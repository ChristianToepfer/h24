using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using ClosedXML.Excel;

namespace h24
{
    public partial class FrmMapExcel : Form
    {
        private List<string> excelColumns = new List<string>();
        private List<string> dbColumns = new List<string>();
        private List<MappingRow> bindingList;
        private string mappingFile = "mapping.json";

        public FrmMapExcel()
        {
            InitializeComponent();
            LoadDbColumns();
            SetupMappingGrid();
            LoadMappingFromJson(); // Try to load saved mappings
        }

    private void LoadExcelColumns(string filePath)
        {
            excelColumns.Clear();

            using (var workbook = new XLWorkbook(filePath))
            {
                var ws = workbook.Worksheets.First();
                var firstRow = ws.FirstRowUsed();

                foreach (var cell in firstRow.Cells())
                {
                    excelColumns.Add(cell.GetString());
                }
            }
        }


    private void LoadDbColumns()
        {
            // Mock DB columns (in real case, fetch from database schema)
            dbColumns = typeof(entries)
                .GetProperties()
                .Select(p => p.Name)
                .ToList();
        }

        private void SetupMappingGrid()
        {
            DataGridView dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoGenerateColumns = false
            };

            // Excel column (read-only)
            var excelCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Excel Column",
                DataPropertyName = "ExcelColumn",
                ReadOnly = true
            };

            // DB column (dropdown)
            var dbCol = new DataGridViewComboBoxColumn
            {
                HeaderText = "DB Column",
                DataPropertyName = "DbColumn",
                DataSource = dbColumns
            };

            dgv.Columns.Add(excelCol);
            dgv.Columns.Add(dbCol);

            // Bind rows
            bindingList = excelColumns
                .Select(c => new MappingRow { ExcelColumn = c })
                .ToList();
            dgv.DataSource = bindingList;

            this.Controls.Add(dgv);

            // Save button
            var btnSave = new Button
            {
                Text = "Save Mapping",
                Dock = DockStyle.Bottom
            };
            btnSave.Click += (s, e) =>
            {
                SaveMappingToJson();
                MessageBox.Show("Mapping saved to JSON!");
            };
            this.Controls.Add(btnSave);
        }

        private void SaveMappingToJson()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(bindingList, options);
            File.WriteAllText(mappingFile, json);
        }

        private void LoadMappingFromJson()
        {
            if (!File.Exists(mappingFile))
                return;

            try
            {
                string json = File.ReadAllText(mappingFile);
                var savedMappings = JsonSerializer.Deserialize<List<MappingRow>>(json);

                // Merge with current Excel columns (in case columns changed)
                foreach (var row in bindingList)
                {
                    var match = savedMappings
                        .FirstOrDefault(m => m.ExcelColumn == row.ExcelColumn);
                    if (match != null && dbColumns.Contains(match.DbColumn))
                    {
                        row.DbColumn = match.DbColumn;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load mapping: " + ex.Message);
            }
        }

        private class MappingRow
        {
            public string ExcelColumn { get; set; }
            public string DbColumn { get; set; }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel Files|*.xlsx;*.xls";
                ofd.Title = "Select Excel File";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = ofd.FileName;
                    LoadExcelColumns(ofd.FileName);
                    SetupMappingGrid();
                }
            }
        }
    }
}


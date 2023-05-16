﻿
namespace h24
{
    partial class frmCourses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgCourses = new System.Windows.Forms.DataGridView();
            this.dgControlCodes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tbCourses = new System.Windows.Forms.TextBox();
            this.btnShowFile = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCourseFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCheckCourses = new System.Windows.Forms.Button();
            this.dgSameCourses = new System.Windows.Forms.DataGridView();
            this.course_name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asofdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursecodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.course_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courselengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseclimbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asofdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursecodesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgControlCodes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSameCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursecodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "*.txt|*.*";
            this.openFileDialog1.Title = "Open Course File";
            // 
            // dgCourses
            // 
            this.dgCourses.AutoGenerateColumns = false;
            this.dgCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.course_id,
            this.coursenameDataGridViewTextBoxColumn,
            this.courselengthDataGridViewTextBoxColumn,
            this.courseclimbDataGridViewTextBoxColumn,
            this.coursetypeDataGridViewTextBoxColumn,
            this.controlcountDataGridViewTextBoxColumn,
            this.asofdateDataGridViewTextBoxColumn,
            this.coursecodesDataGridViewTextBoxColumn,
            this.legsDataGridViewTextBoxColumn});
            this.dgCourses.DataSource = this.coursesBindingSource;
            this.dgCourses.Location = new System.Drawing.Point(29, 35);
            this.dgCourses.Name = "dgCourses";
            this.dgCourses.RowHeadersWidth = 51;
            this.dgCourses.RowTemplate.Height = 24;
            this.dgCourses.Size = new System.Drawing.Size(563, 258);
            this.dgCourses.TabIndex = 6;
            this.dgCourses.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCourses_CellEndEdit);
            this.dgCourses.SelectionChanged += new System.EventHandler(this.dgCourses_SelectionChanged);
            // 
            // dgControlCodes
            // 
            this.dgControlCodes.AutoGenerateColumns = false;
            this.dgControlCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgControlCodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccidDataGridViewTextBoxColumn,
            this.courseidDataGridViewTextBoxColumn1,
            this.controlidDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.ccstatusDataGridViewTextBoxColumn,
            this.asofdateDataGridViewTextBoxColumn1,
            this.controlsDataGridViewTextBoxColumn,
            this.coursesDataGridViewTextBoxColumn});
            this.dgControlCodes.DataSource = this.coursecodesBindingSource;
            this.dgControlCodes.Location = new System.Drawing.Point(863, 35);
            this.dgControlCodes.Name = "dgControlCodes";
            this.dgControlCodes.RowHeadersWidth = 51;
            this.dgControlCodes.RowTemplate.Height = 24;
            this.dgControlCodes.Size = new System.Drawing.Size(528, 258);
            this.dgControlCodes.TabIndex = 7;
            this.dgControlCodes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgControlCodes_CellEndEdit);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.tbCourses);
            this.groupBox1.Controls.Add(this.btnShowFile);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbCourseFile);
            this.groupBox1.Location = new System.Drawing.Point(23, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 405);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upload Courses";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(324, 330);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "Upload Courses";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tbCourses
            // 
            this.tbCourses.Location = new System.Drawing.Point(29, 92);
            this.tbCourses.Multiline = true;
            this.tbCourses.Name = "tbCourses";
            this.tbCourses.Size = new System.Drawing.Size(741, 232);
            this.tbCourses.TabIndex = 10;
            // 
            // btnShowFile
            // 
            this.btnShowFile.Location = new System.Drawing.Point(507, 54);
            this.btnShowFile.Name = "btnShowFile";
            this.btnShowFile.Size = new System.Drawing.Size(129, 23);
            this.btnShowFile.TabIndex = 9;
            this.btnShowFile.Text = "Show file";
            this.btnShowFile.UseVisualStyleBackColor = true;
            this.btnShowFile.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(400, 52);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Course file:";
            // 
            // tbCourseFile
            // 
            this.tbCourseFile.Location = new System.Drawing.Point(113, 54);
            this.tbCourseFile.Name = "tbCourseFile";
            this.tbCourseFile.Size = new System.Drawing.Size(260, 22);
            this.tbCourseFile.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Courses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(860, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Course Codes";
            // 
            // BtnCheckCourses
            // 
            this.BtnCheckCourses.Location = new System.Drawing.Point(1053, 399);
            this.BtnCheckCourses.Name = "BtnCheckCourses";
            this.BtnCheckCourses.Size = new System.Drawing.Size(75, 23);
            this.BtnCheckCourses.TabIndex = 11;
            this.BtnCheckCourses.Text = "Check courses";
            this.BtnCheckCourses.UseVisualStyleBackColor = true;
            this.BtnCheckCourses.Click += new System.EventHandler(this.BtnCheckCourses_Click);
            // 
            // dgSameCourses
            // 
            this.dgSameCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSameCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.course_name1,
            this.course_name});
            this.dgSameCourses.Location = new System.Drawing.Point(863, 437);
            this.dgSameCourses.Name = "dgSameCourses";
            this.dgSameCourses.RowHeadersWidth = 51;
            this.dgSameCourses.RowTemplate.Height = 24;
            this.dgSameCourses.Size = new System.Drawing.Size(528, 150);
            this.dgSameCourses.TabIndex = 12;
            // 
            // course_name1
            // 
            this.course_name1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.course_name1.DataPropertyName = "course_name1";
            this.course_name1.HeaderText = "Course";
            this.course_name1.MinimumWidth = 6;
            this.course_name1.Name = "course_name1";
            this.course_name1.Width = 82;
            // 
            // course_name
            // 
            this.course_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.course_name.DataPropertyName = "course_name";
            this.course_name.HeaderText = "Part of Course";
            this.course_name.MinimumWidth = 6;
            this.course_name.Name = "course_name";
            this.course_name.Width = 128;
            // 
            // ccidDataGridViewTextBoxColumn
            // 
            this.ccidDataGridViewTextBoxColumn.DataPropertyName = "cc_id";
            this.ccidDataGridViewTextBoxColumn.HeaderText = "cc_id";
            this.ccidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ccidDataGridViewTextBoxColumn.Name = "ccidDataGridViewTextBoxColumn";
            this.ccidDataGridViewTextBoxColumn.Visible = false;
            this.ccidDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseidDataGridViewTextBoxColumn1
            // 
            this.courseidDataGridViewTextBoxColumn1.DataPropertyName = "course_id";
            this.courseidDataGridViewTextBoxColumn1.HeaderText = "course_id";
            this.courseidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.courseidDataGridViewTextBoxColumn1.Name = "courseidDataGridViewTextBoxColumn1";
            this.courseidDataGridViewTextBoxColumn1.Visible = false;
            this.courseidDataGridViewTextBoxColumn1.Width = 125;
            // 
            // controlidDataGridViewTextBoxColumn
            // 
            this.controlidDataGridViewTextBoxColumn.DataPropertyName = "control_id";
            this.controlidDataGridViewTextBoxColumn.HeaderText = "Control ID";
            this.controlidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.controlidDataGridViewTextBoxColumn.Name = "controlidDataGridViewTextBoxColumn";
            this.controlidDataGridViewTextBoxColumn.Width = 125;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 125;
            // 
            // ccstatusDataGridViewTextBoxColumn
            // 
            this.ccstatusDataGridViewTextBoxColumn.DataPropertyName = "cc_status";
            this.ccstatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.ccstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ccstatusDataGridViewTextBoxColumn.Name = "ccstatusDataGridViewTextBoxColumn";
            this.ccstatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // asofdateDataGridViewTextBoxColumn1
            // 
            this.asofdateDataGridViewTextBoxColumn1.DataPropertyName = "as_of_date";
            this.asofdateDataGridViewTextBoxColumn1.HeaderText = "as_of_date";
            this.asofdateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.asofdateDataGridViewTextBoxColumn1.Name = "asofdateDataGridViewTextBoxColumn1";
            this.asofdateDataGridViewTextBoxColumn1.Visible = false;
            this.asofdateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // controlsDataGridViewTextBoxColumn
            // 
            this.controlsDataGridViewTextBoxColumn.DataPropertyName = "controls";
            this.controlsDataGridViewTextBoxColumn.HeaderText = "controls";
            this.controlsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.controlsDataGridViewTextBoxColumn.Name = "controlsDataGridViewTextBoxColumn";
            this.controlsDataGridViewTextBoxColumn.Visible = false;
            this.controlsDataGridViewTextBoxColumn.Width = 125;
            // 
            // coursesDataGridViewTextBoxColumn
            // 
            this.coursesDataGridViewTextBoxColumn.DataPropertyName = "courses";
            this.coursesDataGridViewTextBoxColumn.HeaderText = "courses";
            this.coursesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coursesDataGridViewTextBoxColumn.Name = "coursesDataGridViewTextBoxColumn";
            this.coursesDataGridViewTextBoxColumn.Visible = false;
            this.coursesDataGridViewTextBoxColumn.Width = 125;
            // 
            // coursecodesBindingSource
            // 
            this.coursecodesBindingSource.DataSource = typeof(h24.course_codes);
            // 
            // course_id
            // 
            this.course_id.DataPropertyName = "course_id";
            this.course_id.HeaderText = "course_id";
            this.course_id.MinimumWidth = 6;
            this.course_id.Name = "course_id";
            this.course_id.Visible = false;
            this.course_id.Width = 125;
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "course_name";
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.coursenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            this.coursenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // courselengthDataGridViewTextBoxColumn
            // 
            this.courselengthDataGridViewTextBoxColumn.DataPropertyName = "course_length";
            this.courselengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.courselengthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courselengthDataGridViewTextBoxColumn.Name = "courselengthDataGridViewTextBoxColumn";
            this.courselengthDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseclimbDataGridViewTextBoxColumn
            // 
            this.courseclimbDataGridViewTextBoxColumn.DataPropertyName = "course_climb";
            this.courseclimbDataGridViewTextBoxColumn.HeaderText = "Climb";
            this.courseclimbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseclimbDataGridViewTextBoxColumn.Name = "courseclimbDataGridViewTextBoxColumn";
            this.courseclimbDataGridViewTextBoxColumn.Width = 125;
            // 
            // coursetypeDataGridViewTextBoxColumn
            // 
            this.coursetypeDataGridViewTextBoxColumn.DataPropertyName = "course_type";
            this.coursetypeDataGridViewTextBoxColumn.HeaderText = "course_type";
            this.coursetypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coursetypeDataGridViewTextBoxColumn.Name = "coursetypeDataGridViewTextBoxColumn";
            this.coursetypeDataGridViewTextBoxColumn.Visible = false;
            this.coursetypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // controlcountDataGridViewTextBoxColumn
            // 
            this.controlcountDataGridViewTextBoxColumn.DataPropertyName = "control_count";
            this.controlcountDataGridViewTextBoxColumn.HeaderText = "Controls";
            this.controlcountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.controlcountDataGridViewTextBoxColumn.Name = "controlcountDataGridViewTextBoxColumn";
            this.controlcountDataGridViewTextBoxColumn.Width = 125;
            // 
            // asofdateDataGridViewTextBoxColumn
            // 
            this.asofdateDataGridViewTextBoxColumn.DataPropertyName = "as_of_date";
            this.asofdateDataGridViewTextBoxColumn.HeaderText = "as_of_date";
            this.asofdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.asofdateDataGridViewTextBoxColumn.Name = "asofdateDataGridViewTextBoxColumn";
            this.asofdateDataGridViewTextBoxColumn.Visible = false;
            this.asofdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // coursecodesDataGridViewTextBoxColumn
            // 
            this.coursecodesDataGridViewTextBoxColumn.DataPropertyName = "course_codes";
            this.coursecodesDataGridViewTextBoxColumn.HeaderText = "course_codes";
            this.coursecodesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coursecodesDataGridViewTextBoxColumn.Name = "coursecodesDataGridViewTextBoxColumn";
            this.coursecodesDataGridViewTextBoxColumn.Visible = false;
            this.coursecodesDataGridViewTextBoxColumn.Width = 125;
            // 
            // legsDataGridViewTextBoxColumn
            // 
            this.legsDataGridViewTextBoxColumn.DataPropertyName = "legs";
            this.legsDataGridViewTextBoxColumn.HeaderText = "legs";
            this.legsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.legsDataGridViewTextBoxColumn.Name = "legsDataGridViewTextBoxColumn";
            this.legsDataGridViewTextBoxColumn.Visible = false;
            this.legsDataGridViewTextBoxColumn.Width = 125;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataSource = typeof(h24.courses);
            // 
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 768);
            this.Controls.Add(this.dgSameCourses);
            this.Controls.Add(this.BtnCheckCourses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgControlCodes);
            this.Controls.Add(this.dgCourses);
            this.Name = "frmCourses";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.frmCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgControlCodes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSameCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursecodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgCourses;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private System.Windows.Forms.DataGridView dgControlCodes;
        private System.Windows.Forms.BindingSource coursecodesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courselengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseclimbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asofdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursecodesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn legsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asofdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox tbCourses;
        private System.Windows.Forms.Button btnShowFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCourseFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCheckCourses;
        private System.Windows.Forms.DataGridView dgSameCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_name;
    }
}
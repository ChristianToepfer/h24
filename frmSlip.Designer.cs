﻿
namespace h24
{
    partial class frmSlip
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.slipsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slip = new h24.slip();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.slipsTableAdapter = new h24.slipTableAdapters.slipsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.slipsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slip)).BeginInit();
            this.SuspendLayout();
            // 
            // slipsBindingSource
            // 
            this.slipsBindingSource.DataMember = "slips";
            this.slipsBindingSource.DataSource = this.slip;
            // 
            // slip
            // 
            this.slip.DataSetName = "slip";
            this.slip.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsSlip";
            reportDataSource1.Value = this.slipsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "h24.rptSlip1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(141, 55);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(675, 1000);
            this.reportViewer1.TabIndex = 0;
            // 
            // slipsTableAdapter
            // 
            this.slipsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "ReportViewer";
            this.reportViewer2.Size = new System.Drawing.Size(396, 246);
            this.reportViewer2.TabIndex = 0;
            // 
            // frmSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1335, 797);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSlip";
            this.Text = "frmSlip";
            this.Load += new System.EventHandler(this.frmSlip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slipsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource slipsBindingSource;
        private slip slip;
        private slipTableAdapters.slipsTableAdapter slipsTableAdapter;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}
namespace QL_nhansu
{
    partial class frmReportNV
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
            this.DSNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSNV = new QL_nhansu.DSNV();
            this.rpvDSNV = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DSNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // DSNVBindingSource
            // 
            this.DSNVBindingSource.DataMember = "DSNV";
            this.DSNVBindingSource.DataSource = this.DSNV;
            // 
            // DSNV
            // 
            this.DSNV.DataSetName = "DSNV";
            this.DSNV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvDSNV
            // 
            this.rpvDSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RPNV";
            reportDataSource1.Value = this.DSNVBindingSource;
            this.rpvDSNV.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvDSNV.LocalReport.ReportEmbeddedResource = "QL_nhansu.DSNV.rdlc";
            this.rpvDSNV.Location = new System.Drawing.Point(0, 0);
            this.rpvDSNV.Name = "rpvDSNV";
            this.rpvDSNV.Size = new System.Drawing.Size(740, 385);
            this.rpvDSNV.TabIndex = 0;
            // 
            // frmReportNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(740, 385);
            this.Controls.Add(this.rpvDSNV);
            this.Name = "frmReportNV";
            this.Text = "Báo Cáo Nhân Sự";
            this.Load += new System.EventHandler(this.frmReportNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDSNV;
        private System.Windows.Forms.BindingSource DSNVBindingSource;
        private DSNV DSNV;
    }
}
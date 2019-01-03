namespace QL_nhansu
{
    partial class Form2
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
            this.CryView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnLayds = new System.Windows.Forms.Button();
            this.cbDonvi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CryView
            // 
            this.CryView.ActiveViewIndex = -1;
            this.CryView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CryView.DisplayGroupTree = false;
            this.CryView.Location = new System.Drawing.Point(0, 49);
            this.CryView.Name = "CryView";
            this.CryView.SelectionFormula = "";
            this.CryView.Size = new System.Drawing.Size(792, 468);
            this.CryView.TabIndex = 0;
            this.CryView.ViewTimeSelectionFormula = "";
            // 
            // btnLayds
            // 
            this.btnLayds.Location = new System.Drawing.Point(212, 20);
            this.btnLayds.Name = "btnLayds";
            this.btnLayds.Size = new System.Drawing.Size(75, 23);
            this.btnLayds.TabIndex = 1;
            this.btnLayds.Text = "Lấy ds";
            this.btnLayds.UseVisualStyleBackColor = true;
            this.btnLayds.Click += new System.EventHandler(this.btnLayds_Click);
            // 
            // cbDonvi
            // 
            this.cbDonvi.FormattingEnabled = true;
            this.cbDonvi.Location = new System.Drawing.Point(68, 19);
            this.cbDonvi.Name = "cbDonvi";
            this.cbDonvi.Size = new System.Drawing.Size(126, 21);
            this.cbDonvi.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 518);
            this.Controls.Add(this.cbDonvi);
            this.Controls.Add(this.btnLayds);
            this.Controls.Add(this.CryView);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CryView;
        private System.Windows.Forms.Button btnLayds;
        private System.Windows.Forms.ComboBox cbDonvi;
    }
}
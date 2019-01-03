namespace QL_nhansu
{
    partial class Mail
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnattach = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.txtSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBody = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBcc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFrom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(336, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(146, 52);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Gửi Mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Người Gửi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phòng Nhận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tiêu Đề";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nội Dung";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "CC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "BCC";
            // 
            // btnattach
            // 
            this.btnattach.Location = new System.Drawing.Point(838, 159);
            this.btnattach.Name = "btnattach";
            this.btnattach.Size = new System.Drawing.Size(127, 44);
            this.btnattach.TabIndex = 9;
            this.btnattach.Text = "Đính Kèm File";
            this.btnattach.UseVisualStyleBackColor = true;
            this.btnattach.Click += new System.EventHandler(this.btnattach_Click);
            // 
            // btnsend
            // 
            this.btnsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.Location = new System.Drawing.Point(584, 450);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(250, 48);
            this.btnsend.TabIndex = 10;
            this.btnsend.Text = "GỬI";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // txtSubject
            // 
            // 
            // 
            // 
            this.txtSubject.Border.Class = "TextBoxBorder";
            this.txtSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSubject.Location = new System.Drawing.Point(146, 286);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.PreventEnterBeep = true;
            this.txtSubject.Size = new System.Drawing.Size(336, 44);
            this.txtSubject.TabIndex = 11;
            // 
            // txtBody
            // 
            // 
            // 
            // 
            this.txtBody.Border.Class = "TextBoxBorder";
            this.txtBody.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBody.Location = new System.Drawing.Point(146, 351);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.PreventEnterBeep = true;
            this.txtBody.Size = new System.Drawing.Size(336, 147);
            this.txtBody.TabIndex = 12;
            // 
            // txtBcc
            // 
            // 
            // 
            // 
            this.txtBcc.Border.Class = "TextBoxBorder";
            this.txtBcc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBcc.Location = new System.Drawing.Point(146, 247);
            this.txtBcc.Multiline = true;
            this.txtBcc.Name = "txtBcc";
            this.txtBcc.PreventEnterBeep = true;
            this.txtBcc.Size = new System.Drawing.Size(336, 28);
            this.txtBcc.TabIndex = 14;
            // 
            // txtCc
            // 
            // 
            // 
            // 
            this.txtCc.Border.Class = "TextBoxBorder";
            this.txtCc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCc.Location = new System.Drawing.Point(146, 205);
            this.txtCc.Multiline = true;
            this.txtCc.Name = "txtCc";
            this.txtCc.PreventEnterBeep = true;
            this.txtCc.Size = new System.Drawing.Size(336, 28);
            this.txtCc.TabIndex = 15;
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.Border.Class = "TextBoxBorder";
            this.txtPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPass.Location = new System.Drawing.Point(146, 117);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PreventEnterBeep = true;
            this.txtPass.Size = new System.Drawing.Size(336, 28);
            this.txtPass.TabIndex = 17;
            // 
            // txtFrom
            // 
            // 
            // 
            // 
            this.txtFrom.Border.Class = "TextBoxBorder";
            this.txtFrom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFrom.Location = new System.Drawing.Point(146, 75);
            this.txtFrom.Multiline = true;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.PreventEnterBeep = true;
            this.txtFrom.Size = new System.Drawing.Size(336, 28);
            this.txtFrom.TabIndex = 18;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(818, 220);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 121);
            this.listBox1.TabIndex = 20;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Location = new System.Drawing.Point(146, 159);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(336, 20);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 19;
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(988, 594);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBoxEx1);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtCc);
            this.Controls.Add(this.txtBcc);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btnattach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "Mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.Mail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnattach;
        private System.Windows.Forms.Button btnsend;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSubject;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBody;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBcc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPass;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFrom;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
    }
}
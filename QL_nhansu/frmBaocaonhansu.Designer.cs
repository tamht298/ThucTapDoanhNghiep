namespace QL_nhansu
{
    partial class frmBaocaonhansu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaocaonhansu));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rdoPhongban = new System.Windows.Forms.RadioButton();
            this.btnHienthi = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.rdoNghiviec = new System.Windows.Forms.RadioButton();
            this.rdoDotuoi = new System.Windows.Forms.RadioButton();
            this.rdoChucvu = new System.Windows.Forms.RadioButton();
            this.rdoKyluat = new System.Windows.Forms.RadioButton();
            this.rdoKhenthuong = new System.Windows.Forms.RadioButton();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.rdoPhongban);
            this.groupPanel1.Controls.Add(this.btnHienthi);
            this.groupPanel1.Controls.Add(this.btnThoat);
            this.groupPanel1.Controls.Add(this.rdoNghiviec);
            this.groupPanel1.Controls.Add(this.rdoDotuoi);
            this.groupPanel1.Controls.Add(this.rdoChucvu);
            this.groupPanel1.Controls.Add(this.rdoKyluat);
            this.groupPanel1.Controls.Add(this.rdoKhenthuong);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(656, 314);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            // 
            // rdoPhongban
            // 
            this.rdoPhongban.AutoSize = true;
            this.rdoPhongban.BackColor = System.Drawing.Color.Transparent;
            this.rdoPhongban.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rdoPhongban.Location = new System.Drawing.Point(379, 165);
            this.rdoPhongban.Name = "rdoPhongban";
            this.rdoPhongban.Size = new System.Drawing.Size(254, 23);
            this.rdoPhongban.TabIndex = 5;
            this.rdoPhongban.TabStop = true;
            this.rdoPhongban.Text = "Báo cáo nhân viên theo phòng ban";
            this.rdoPhongban.UseVisualStyleBackColor = false;
            this.rdoPhongban.CheckedChanged += new System.EventHandler(this.rdoPhongban_CheckedChanged);
            // 
            // btnHienthi
            // 
            this.btnHienthi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHienthi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHienthi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienthi.Image = ((System.Drawing.Image)(resources.GetObject("btnHienthi.Image")));
            this.btnHienthi.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnHienthi.Location = new System.Drawing.Point(226, 239);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(93, 33);
            this.btnHienthi.TabIndex = 6;
            this.btnHienthi.Text = "Hiển thị";
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(350, 239);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 33);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // rdoNghiviec
            // 
            this.rdoNghiviec.AutoSize = true;
            this.rdoNghiviec.BackColor = System.Drawing.Color.Transparent;
            this.rdoNghiviec.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rdoNghiviec.Location = new System.Drawing.Point(379, 121);
            this.rdoNghiviec.Name = "rdoNghiviec";
            this.rdoNghiviec.Size = new System.Drawing.Size(212, 23);
            this.rdoNghiviec.TabIndex = 4;
            this.rdoNghiviec.TabStop = true;
            this.rdoNghiviec.Text = "Báo cáo nhân viên nghỉ việc";
            this.rdoNghiviec.UseVisualStyleBackColor = false;
            this.rdoNghiviec.CheckedChanged += new System.EventHandler(this.rdoNghiviec_CheckedChanged);
            // 
            // rdoDotuoi
            // 
            this.rdoDotuoi.AutoSize = true;
            this.rdoDotuoi.BackColor = System.Drawing.Color.Transparent;
            this.rdoDotuoi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rdoDotuoi.Location = new System.Drawing.Point(379, 81);
            this.rdoDotuoi.Name = "rdoDotuoi";
            this.rdoDotuoi.Size = new System.Drawing.Size(231, 23);
            this.rdoDotuoi.TabIndex = 3;
            this.rdoDotuoi.TabStop = true;
            this.rdoDotuoi.Text = "Báo cáo nhân viên theo độ tuổi";
            this.rdoDotuoi.UseVisualStyleBackColor = false;
            this.rdoDotuoi.CheckedChanged += new System.EventHandler(this.rdoDotuoi_CheckedChanged);
            // 
            // rdoChucvu
            // 
            this.rdoChucvu.AutoSize = true;
            this.rdoChucvu.BackColor = System.Drawing.Color.Transparent;
            this.rdoChucvu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rdoChucvu.Location = new System.Drawing.Point(33, 165);
            this.rdoChucvu.Name = "rdoChucvu";
            this.rdoChucvu.Size = new System.Drawing.Size(238, 23);
            this.rdoChucvu.TabIndex = 2;
            this.rdoChucvu.TabStop = true;
            this.rdoChucvu.Text = "Báo cáo nhân viên theo chức vụ";
            this.rdoChucvu.UseVisualStyleBackColor = false;
            this.rdoChucvu.CheckedChanged += new System.EventHandler(this.rdoChucvu_CheckedChanged);
            // 
            // rdoKyluat
            // 
            this.rdoKyluat.AutoSize = true;
            this.rdoKyluat.BackColor = System.Drawing.Color.Transparent;
            this.rdoKyluat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rdoKyluat.Location = new System.Drawing.Point(33, 121);
            this.rdoKyluat.Name = "rdoKyluat";
            this.rdoKyluat.Size = new System.Drawing.Size(215, 23);
            this.rdoKyluat.TabIndex = 1;
            this.rdoKyluat.TabStop = true;
            this.rdoKyluat.Text = "Báo cáo nhân viên bị kỷ luật";
            this.rdoKyluat.UseVisualStyleBackColor = false;
            this.rdoKyluat.CheckedChanged += new System.EventHandler(this.rdoKyluat_CheckedChanged);
            // 
            // rdoKhenthuong
            // 
            this.rdoKhenthuong.AutoSize = true;
            this.rdoKhenthuong.BackColor = System.Drawing.Color.Transparent;
            this.rdoKhenthuong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rdoKhenthuong.Location = new System.Drawing.Point(33, 81);
            this.rdoKhenthuong.Name = "rdoKhenthuong";
            this.rdoKhenthuong.Size = new System.Drawing.Size(276, 23);
            this.rdoKhenthuong.TabIndex = 0;
            this.rdoKhenthuong.TabStop = true;
            this.rdoKhenthuong.Text = "Báo cáo nhân viên được khen thưởng";
            this.rdoKhenthuong.UseVisualStyleBackColor = false;
            this.rdoKhenthuong.CheckedChanged += new System.EventHandler(this.rdoKhenthuong_CheckedChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(0, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(656, 38);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "BÁO CÁO NHÂN SỰ";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // frmBaocaonhansu
            // 
            this.ClientSize = new System.Drawing.Size(656, 314);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaocaonhansu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Báo Cáo Nhân Sự";
            this.Load += new System.EventHandler(this.frmBaocaonhansu_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.RadioButton rdoNghiviec;
        private System.Windows.Forms.RadioButton rdoDotuoi;
        private System.Windows.Forms.RadioButton rdoChucvu;
        private System.Windows.Forms.RadioButton rdoKyluat;
        private System.Windows.Forms.RadioButton rdoKhenthuong;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnHienthi;
        private System.Windows.Forms.RadioButton rdoPhongban;
    }
}
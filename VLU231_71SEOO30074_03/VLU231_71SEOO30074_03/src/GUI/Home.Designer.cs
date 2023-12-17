namespace VLU231_71SEOO30074_03.src.GUI
{
    partial class Home
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
            this.navMenu = new System.Windows.Forms.MenuStrip();
            this.dkhpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dkdMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tchpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlKhoaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlNgDMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlmhMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qllhpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qldMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.pnlKhoa = new System.Windows.Forms.Panel();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.navMenu.SuspendLayout();
            this.pnlKhoa.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // navMenu
            // 
            this.navMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.navMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.navMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.navMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dkhpMenuItem,
            this.dkdMenuItem,
            this.tchpMenuItem,
            this.qlKhoaMenuItem,
            this.qlNgDMenuItem,
            this.qlmhMenuItem,
            this.qllhpMenuItem,
            this.qldMenuItem,
            this.logoutMenuItem});
            this.navMenu.Location = new System.Drawing.Point(0, 91);
            this.navMenu.Name = "navMenu";
            this.navMenu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.navMenu.Size = new System.Drawing.Size(134, 396);
            this.navMenu.TabIndex = 0;
            // 
            // dkhpMenuItem
            // 
            this.dkhpMenuItem.Name = "dkhpMenuItem";
            this.dkhpMenuItem.Size = new System.Drawing.Size(125, 19);
            this.dkhpMenuItem.Text = "Đăng Ký Học Phần";
            this.dkhpMenuItem.Visible = false;
            // 
            // dkdMenuItem
            // 
            this.dkdMenuItem.Name = "dkdMenuItem";
            this.dkdMenuItem.Size = new System.Drawing.Size(125, 19);
            this.dkdMenuItem.Text = "Đăng Ký Dạy";
            this.dkdMenuItem.Visible = false;
            // 
            // tchpMenuItem
            // 
            this.tchpMenuItem.Name = "tchpMenuItem";
            this.tchpMenuItem.Size = new System.Drawing.Size(125, 19);
            this.tchpMenuItem.Text = "Tra Cứu Học Phần ";
            this.tchpMenuItem.Visible = false;
            // 
            // qlKhoaMenuItem
            // 
            this.qlKhoaMenuItem.Name = "qlKhoaMenuItem";
            this.qlKhoaMenuItem.Size = new System.Drawing.Size(125, 19);
            this.qlKhoaMenuItem.Text = "Quản Lý Khoa";
            this.qlKhoaMenuItem.Visible = false;
            this.qlKhoaMenuItem.Click += new System.EventHandler(this.qlKhoaMenuItem_Click);
            // 
            // qlNgDMenuItem
            // 
            this.qlNgDMenuItem.Name = "qlNgDMenuItem";
            this.qlNgDMenuItem.Size = new System.Drawing.Size(125, 19);
            this.qlNgDMenuItem.Text = "Quản Lý Người Dùng";
            this.qlNgDMenuItem.Visible = false;
            this.qlNgDMenuItem.Click += new System.EventHandler(this.qlNgDMenuItem_Click);
            // 
            // qlmhMenuItem
            // 
            this.qlmhMenuItem.Name = "qlmhMenuItem";
            this.qlmhMenuItem.Size = new System.Drawing.Size(125, 19);
            this.qlmhMenuItem.Text = "Quản Lý Môn Học";
            this.qlmhMenuItem.Visible = false;
            this.qlmhMenuItem.Click += new System.EventHandler(this.qlmhMenuItem_Click);
            // 
            // qllhpMenuItem
            // 
            this.qllhpMenuItem.Name = "qllhpMenuItem";
            this.qllhpMenuItem.Size = new System.Drawing.Size(125, 19);
            this.qllhpMenuItem.Text = "Quản Lý Lớp HP";
            this.qllhpMenuItem.Visible = false;
            this.qllhpMenuItem.Click += new System.EventHandler(this.qllhpMenuItem_Click);
            // 
            // qldMenuItem
            // 
            this.qldMenuItem.Name = "qldMenuItem";
            this.qldMenuItem.Size = new System.Drawing.Size(125, 19);
            this.qldMenuItem.Text = "Quản lý Điểm";
            this.qldMenuItem.Visible = false;
            // 
            // logoutMenuItem
            // 
            this.logoutMenuItem.ForeColor = System.Drawing.Color.Red;
            this.logoutMenuItem.Name = "logoutMenuItem";
            this.logoutMenuItem.Size = new System.Drawing.Size(125, 19);
            this.logoutMenuItem.Text = "Đăng Xuất";
            this.logoutMenuItem.Click += new System.EventHandler(this.logoutMenuItem_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUser.Location = new System.Drawing.Point(2, 0);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(248, 26);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Thông Tin Người Dùng";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(83, 259);
            this.lblMa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(26, 13);
            this.lblMa.TabIndex = 3;
            this.lblMa.Text = "MÃ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "HỌ TÊN:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(154, 289);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(171, 20);
            this.txtHoTen.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "QUÊ QUÁN:";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(446, 256);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(2);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.ReadOnly = true;
            this.txtQueQuan.Size = new System.Drawing.Size(171, 20);
            this.txtQueQuan.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "GIỚI TÍNH:";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(446, 290);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.ReadOnly = true;
            this.txtGioiTinh.Size = new System.Drawing.Size(171, 20);
            this.txtGioiTinh.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "ĐỊA CHỈ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(154, 326);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(171, 20);
            this.txtDiaChi.TabIndex = 29;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(154, 256);
            this.txtMa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(171, 20);
            this.txtMa.TabIndex = 14;
            // 
            // pnlKhoa
            // 
            this.pnlKhoa.Controls.Add(this.txtKhoa);
            this.pnlKhoa.Controls.Add(this.label7);
            this.pnlKhoa.Location = new System.Drawing.Point(367, 320);
            this.pnlKhoa.Name = "pnlKhoa";
            this.pnlKhoa.Size = new System.Drawing.Size(264, 26);
            this.pnlKhoa.TabIndex = 30;
            this.pnlKhoa.Visible = false;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(79, 6);
            this.txtKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.ReadOnly = true;
            this.txtKhoa.Size = new System.Drawing.Size(171, 20);
            this.txtKhoa.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "KHOA:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlKhoa);
            this.panel1.Controls.Add(this.txtMa);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtGioiTinh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtQueQuan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblMa);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(127, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 396);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VLU231_71SEOO30074_03.Properties.Resources._172626_user_male_icon;
            this.pictureBox1.Location = new System.Drawing.Point(276, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::VLU231_71SEOO30074_03.Properties.Resources.banner_yersin;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(837, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 487);
            this.Controls.Add(this.navMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.navMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.Home_Load);
            this.navMenu.ResumeLayout(false);
            this.navMenu.PerformLayout();
            this.pnlKhoa.ResumeLayout(false);
            this.pnlKhoa.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip navMenu;
        private System.Windows.Forms.ToolStripMenuItem dkhpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qlmhMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qllhpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qlNgDMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qldMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dkdMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tchpMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Panel pnlKhoa;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem qlKhoaMenuItem;
    }
}
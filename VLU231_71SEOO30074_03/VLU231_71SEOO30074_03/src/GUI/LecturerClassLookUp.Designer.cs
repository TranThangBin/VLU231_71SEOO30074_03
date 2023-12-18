namespace VLU231_71SEOO30074_03.src.GUI
{
    partial class LecturerClassLookUp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHp = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSv = new System.Windows.Forms.DataGridView();
            this.sinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopHp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHp
            // 
            this.dgvHp.AllowUserToAddRows = false;
            this.dgvHp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lopHp,
            this.soTc});
            this.dgvHp.Location = new System.Drawing.Point(4, 20);
            this.dgvHp.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHp.Name = "dgvHp";
            this.dgvHp.ReadOnly = true;
            this.dgvHp.RowHeadersWidth = 62;
            this.dgvHp.RowTemplate.Height = 28;
            this.dgvHp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHp.Size = new System.Drawing.Size(893, 181);
            this.dgvHp.TabIndex = 4;
            this.dgvHp.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHp_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.dgvHp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(901, 221);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra Cứu Học Phần:";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.dgvSv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(11, 216);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(901, 318);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // dgvSv
            // 
            this.dgvSv.AllowUserToAddRows = false;
            this.dgvSv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sinhVien,
            this.maSv,
            this.hoTen,
            this.khoa,
            this.ngaySinh,
            this.queQuan,
            this.diaChi});
            this.dgvSv.Location = new System.Drawing.Point(4, 20);
            this.dgvSv.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSv.Name = "dgvSv";
            this.dgvSv.ReadOnly = true;
            this.dgvSv.RowHeadersWidth = 62;
            this.dgvSv.RowTemplate.Height = 28;
            this.dgvSv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSv.Size = new System.Drawing.Size(893, 278);
            this.dgvSv.TabIndex = 4;
            this.dgvSv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSv_RowsAdded);
            // 
            // sinhVien
            // 
            this.sinhVien.HeaderText = "sinhVien";
            this.sinhVien.Name = "sinhVien";
            this.sinhVien.ReadOnly = true;
            this.sinhVien.Visible = false;
            // 
            // maSv
            // 
            this.maSv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maSv.HeaderText = "Mã sinh viên";
            this.maSv.Name = "maSv";
            this.maSv.ReadOnly = true;
            this.maSv.Width = 112;
            // 
            // hoTen
            // 
            this.hoTen.HeaderText = "Họ tên";
            this.hoTen.Name = "hoTen";
            this.hoTen.ReadOnly = true;
            // 
            // khoa
            // 
            this.khoa.HeaderText = "Khoa";
            this.khoa.Name = "khoa";
            this.khoa.ReadOnly = true;
            // 
            // ngaySinh
            // 
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.ReadOnly = true;
            // 
            // queQuan
            // 
            this.queQuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.queQuan.HeaderText = "Quê quán";
            this.queQuan.Name = "queQuan";
            this.queQuan.ReadOnly = true;
            // 
            // diaChi
            // 
            this.diaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            // 
            // lopHp
            // 
            this.lopHp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lopHp.HeaderText = "Lớp học phần";
            this.lopHp.Name = "lopHp";
            this.lopHp.ReadOnly = true;
            // 
            // soTc
            // 
            this.soTc.HeaderText = "Số tín chỉ";
            this.soTc.Name = "soTc";
            this.soTc.ReadOnly = true;
            // 
            // LecturerClassLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LecturerClassLookUp";
            this.Text = "Tra cứu học phần";
            this.Load += new System.EventHandler(this.LecturerClassLookUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopHp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTc;
    }
}
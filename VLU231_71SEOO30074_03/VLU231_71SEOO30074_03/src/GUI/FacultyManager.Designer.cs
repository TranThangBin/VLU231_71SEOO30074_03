namespace VLU231_71SEOO30074_03.src.GUI
{
    partial class FacultyManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenGoi = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtDiaDiemVp = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuyChon = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDiemVp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên gọi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa điểm văn phòng:";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(70, 40);
            this.txtMaKhoa.MaxLength = 20;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(288, 20);
            this.txtMaKhoa.TabIndex = 4;
            this.txtMaKhoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKhoa_KeyPress);
            // 
            // txtTenGoi
            // 
            this.txtTenGoi.Location = new System.Drawing.Point(70, 77);
            this.txtTenGoi.MaxLength = 50;
            this.txtTenGoi.Name = "txtTenGoi";
            this.txtTenGoi.Size = new System.Drawing.Size(288, 20);
            this.txtTenGoi.TabIndex = 5;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(500, 35);
            this.txtSdt.MaxLength = 12;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(288, 20);
            this.txtSdt.TabIndex = 6;
            // 
            // txtDiaDiemVp
            // 
            this.txtDiaDiemVp.Location = new System.Drawing.Point(500, 81);
            this.txtDiaDiemVp.MaxLength = 100;
            this.txtDiaDiemVp.Name = "txtDiaDiemVp";
            this.txtDiaDiemVp.Size = new System.Drawing.Size(288, 20);
            this.txtDiaDiemVp.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(176, 126);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuyChon
            // 
            this.btnHuyChon.Location = new System.Drawing.Point(543, 126);
            this.btnHuyChon.Name = "btnHuyChon";
            this.btnHuyChon.Size = new System.Drawing.Size(75, 23);
            this.btnHuyChon.TabIndex = 11;
            this.btnHuyChon.Text = "Hủy chọn";
            this.btnHuyChon.UseVisualStyleBackColor = true;
            this.btnHuyChon.Click += new System.EventHandler(this.btnHuyChon_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(296, 126);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(416, 126);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.AllowUserToAddRows = false;
            this.dgvKhoa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.khoa,
            this.maKhoa,
            this.tenGoi,
            this.Sdt,
            this.diaDiemVp});
            this.dgvKhoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKhoa.Location = new System.Drawing.Point(0, 173);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.ReadOnly = true;
            this.dgvKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoa.Size = new System.Drawing.Size(800, 277);
            this.dgvKhoa.TabIndex = 8;
            this.dgvKhoa.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellEnter);
            this.dgvKhoa.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvKhoa_RowsAdded);
            // 
            // khoa
            // 
            this.khoa.HeaderText = "Khoa";
            this.khoa.Name = "khoa";
            this.khoa.ReadOnly = true;
            this.khoa.Visible = false;
            // 
            // maKhoa
            // 
            this.maKhoa.HeaderText = "Mã khoa";
            this.maKhoa.Name = "maKhoa";
            this.maKhoa.ReadOnly = true;
            this.maKhoa.Width = 150;
            // 
            // tenGoi
            // 
            this.tenGoi.HeaderText = "Tên gọi";
            this.tenGoi.Name = "tenGoi";
            this.tenGoi.ReadOnly = true;
            this.tenGoi.Width = 150;
            // 
            // Sdt
            // 
            this.Sdt.HeaderText = "Số điện thoại";
            this.Sdt.Name = "Sdt";
            this.Sdt.ReadOnly = true;
            this.Sdt.Width = 150;
            // 
            // diaDiemVp
            // 
            this.diaDiemVp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaDiemVp.HeaderText = "Địa điểm văn phòng";
            this.diaDiemVp.Name = "diaDiemVp";
            this.diaDiemVp.ReadOnly = true;
            // 
            // FacultyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnHuyChon);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvKhoa);
            this.Controls.Add(this.txtDiaDiemVp);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtTenGoi);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FacultyManager";
            this.Text = "Quản lý khoa";
            this.Load += new System.EventHandler(this.FacultyManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtTenGoi;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtDiaDiemVp;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuyChon;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDiemVp;
    }
}
namespace VLU231_71SEOO30074_03.src.GUI
{
    partial class StudentClassLookUp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiemCuoiKy = new System.Windows.Forms.TextBox();
            this.txtDiemGiuaKy = new System.Windows.Forms.TextBox();
            this.txtDiemQuaTrinh = new System.Windows.Forms.TextBox();
            this.dgvHp = new System.Windows.Forms.DataGridView();
            this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopHp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDiemCuoiKy);
            this.groupBox1.Controls.Add(this.txtDiemGiuaKy);
            this.groupBox1.Controls.Add(this.txtDiemQuaTrinh);
            this.groupBox1.Controls.Add(this.dgvHp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(517, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra Cứu Học Phần:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(5, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Điểm Cuối Kỳ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(289, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Điểm Giữa Kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(5, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Điểm Quá Trình";
            // 
            // txtDiemCuoiKy
            // 
            this.txtDiemCuoiKy.Location = new System.Drawing.Point(119, 311);
            this.txtDiemCuoiKy.Name = "txtDiemCuoiKy";
            this.txtDiemCuoiKy.ReadOnly = true;
            this.txtDiemCuoiKy.Size = new System.Drawing.Size(125, 23);
            this.txtDiemCuoiKy.TabIndex = 7;
            // 
            // txtDiemGiuaKy
            // 
            this.txtDiemGiuaKy.Location = new System.Drawing.Point(387, 250);
            this.txtDiemGiuaKy.Name = "txtDiemGiuaKy";
            this.txtDiemGiuaKy.ReadOnly = true;
            this.txtDiemGiuaKy.Size = new System.Drawing.Size(125, 23);
            this.txtDiemGiuaKy.TabIndex = 6;
            // 
            // txtDiemQuaTrinh
            // 
            this.txtDiemQuaTrinh.Location = new System.Drawing.Point(119, 250);
            this.txtDiemQuaTrinh.Name = "txtDiemQuaTrinh";
            this.txtDiemQuaTrinh.ReadOnly = true;
            this.txtDiemQuaTrinh.Size = new System.Drawing.Size(125, 23);
            this.txtDiemQuaTrinh.TabIndex = 5;
            // 
            // dgvHp
            // 
            this.dgvHp.AllowUserToAddRows = false;
            this.dgvHp.AllowUserToDeleteRows = false;
            this.dgvHp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diem,
            this.giangVien,
            this.lopHp,
            this.soTc});
            this.dgvHp.Location = new System.Drawing.Point(7, 20);
            this.dgvHp.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHp.Name = "dgvHp";
            this.dgvHp.ReadOnly = true;
            this.dgvHp.RowHeadersWidth = 62;
            this.dgvHp.RowTemplate.Height = 28;
            this.dgvHp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHp.Size = new System.Drawing.Size(498, 199);
            this.dgvHp.TabIndex = 4;
            this.dgvHp.Enter += new System.EventHandler(this.dgvHp_Enter);
            // 
            // diem
            // 
            this.diem.HeaderText = "diem";
            this.diem.Name = "diem";
            this.diem.ReadOnly = true;
            this.diem.Visible = false;
            // 
            // giangVien
            // 
            this.giangVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giangVien.HeaderText = "Giảng Viên";
            this.giangVien.Name = "giangVien";
            this.giangVien.ReadOnly = true;
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
            // StudentClassLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 392);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentClassLookUp";
            this.Text = "Tra cứu học phần";
            this.Load += new System.EventHandler(this.StudentClassLookUp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiemCuoiKy;
        private System.Windows.Forms.TextBox txtDiemGiuaKy;
        private System.Windows.Forms.TextBox txtDiemQuaTrinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn giangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopHp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTc;
    }
}
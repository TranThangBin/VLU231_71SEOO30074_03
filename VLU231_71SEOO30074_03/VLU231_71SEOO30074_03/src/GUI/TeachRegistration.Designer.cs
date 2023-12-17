namespace VLU231_71SEOO30074_03.src.GUI
{
    partial class TeachingRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDk = new System.Windows.Forms.Button();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.dgvHp = new System.Windows.Forms.DataGridView();
            this.monHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopHp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huyDay = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbLopHp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Ký Dạy Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Môn Học:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // btnDk
            // 
            this.btnDk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDk.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDk.Location = new System.Drawing.Point(91, 179);
            this.btnDk.Margin = new System.Windows.Forms.Padding(2);
            this.btnDk.Name = "btnDk";
            this.btnDk.Size = new System.Drawing.Size(114, 24);
            this.btnDk.TabIndex = 6;
            this.btnDk.Text = "Đăng Ký";
            this.btnDk.UseVisualStyleBackColor = true;
            this.btnDk.Click += new System.EventHandler(this.btnDk_Click);
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(91, 102);
            this.cmbMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(181, 21);
            this.cmbMonHoc.TabIndex = 9;
            this.cmbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbMonHoc_SelectedIndexChanged);
            // 
            // dgvHp
            // 
            this.dgvHp.AllowUserToAddRows = false;
            this.dgvHp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monHoc,
            this.lopHp,
            this.soTc,
            this.huyDay});
            this.dgvHp.Location = new System.Drawing.Point(299, 53);
            this.dgvHp.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHp.Name = "dgvHp";
            this.dgvHp.ReadOnly = true;
            this.dgvHp.RowHeadersWidth = 62;
            this.dgvHp.RowTemplate.Height = 28;
            this.dgvHp.Size = new System.Drawing.Size(504, 228);
            this.dgvHp.TabIndex = 14;
            this.dgvHp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHp_CellContentClick);
            this.dgvHp.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvHp_RowsAdded);
            // 
            // monHoc
            // 
            this.monHoc.HeaderText = "monHoc";
            this.monHoc.Name = "monHoc";
            this.monHoc.ReadOnly = true;
            this.monHoc.Visible = false;
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
            // huyDay
            // 
            this.huyDay.HeaderText = "Hủy";
            this.huyDay.Name = "huyDay";
            this.huyDay.ReadOnly = true;
            this.huyDay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.huyDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cmbLopHp
            // 
            this.cmbLopHp.FormattingEnabled = true;
            this.cmbLopHp.Location = new System.Drawing.Point(91, 140);
            this.cmbLopHp.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLopHp.Name = "cmbLopHp";
            this.cmbLopHp.Size = new System.Drawing.Size(181, 21);
            this.cmbLopHp.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Lớp Học Phần";
            // 
            // TeachingRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 292);
            this.Controls.Add(this.cmbLopHp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvHp);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.btnDk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TeachingRegistration";
            this.Text = "Đăng ký dạy học";
            this.Load += new System.EventHandler(this.TeachingRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDk;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.DataGridView dgvHp;
        private System.Windows.Forms.ComboBox cmbLopHp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn monHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopHp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTc;
        private System.Windows.Forms.DataGridViewButtonColumn huyDay;
    }
}
namespace VLU231_71SEOO30074_03.src.GUI
{
    partial class subject_management
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
            this.groupBoxMH = new System.Windows.Forms.GroupBox();
            this.buttonTìm = new System.Windows.Forms.Button();
            this.buttonXóa = new System.Windows.Forms.Button();
            this.buttonsua = new System.Windows.Forms.Button();
            this.buttonluu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDSMH = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerNT = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMon = new System.Windows.Forms.ComboBox();
            this.comboBoxHP = new System.Windows.Forms.ComboBox();
            this.comboBoxkhoa = new System.Windows.Forms.ComboBox();
            this.textBoxTMH = new System.Windows.Forms.TextBox();
            this.textBoxMMH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMH.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSMH)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMH
            // 
            this.groupBoxMH.Controls.Add(this.buttonTìm);
            this.groupBoxMH.Controls.Add(this.buttonXóa);
            this.groupBoxMH.Controls.Add(this.buttonsua);
            this.groupBoxMH.Controls.Add(this.buttonluu);
            this.groupBoxMH.Controls.Add(this.groupBox1);
            this.groupBoxMH.Controls.Add(this.panel1);
            this.groupBoxMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMH.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxMH.Location = new System.Drawing.Point(32, 33);
            this.groupBoxMH.Name = "groupBoxMH";
            this.groupBoxMH.Size = new System.Drawing.Size(727, 483);
            this.groupBoxMH.TabIndex = 0;
            this.groupBoxMH.TabStop = false;
            this.groupBoxMH.Text = "MÔN HỌC";
            // 
            // buttonTìm
            // 
            this.buttonTìm.Location = new System.Drawing.Point(479, 175);
            this.buttonTìm.Name = "buttonTìm";
            this.buttonTìm.Size = new System.Drawing.Size(103, 34);
            this.buttonTìm.TabIndex = 5;
            this.buttonTìm.Text = "Tìm";
            this.buttonTìm.UseVisualStyleBackColor = true;
            // 
            // buttonXóa
            // 
            this.buttonXóa.Location = new System.Drawing.Point(345, 175);
            this.buttonXóa.Name = "buttonXóa";
            this.buttonXóa.Size = new System.Drawing.Size(103, 34);
            this.buttonXóa.TabIndex = 4;
            this.buttonXóa.Text = "xóa";
            this.buttonXóa.UseVisualStyleBackColor = true;
            // 
            // buttonsua
            // 
            this.buttonsua.Location = new System.Drawing.Point(211, 175);
            this.buttonsua.Name = "buttonsua";
            this.buttonsua.Size = new System.Drawing.Size(103, 34);
            this.buttonsua.TabIndex = 3;
            this.buttonsua.Text = "sữa";
            this.buttonsua.UseVisualStyleBackColor = true;
            // 
            // buttonluu
            // 
            this.buttonluu.Location = new System.Drawing.Point(78, 175);
            this.buttonluu.Name = "buttonluu";
            this.buttonluu.Size = new System.Drawing.Size(103, 34);
            this.buttonluu.TabIndex = 2;
            this.buttonluu.Text = "Lưu";
            this.buttonluu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewDSMH);
            this.groupBox1.Location = new System.Drawing.Point(22, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 262);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Môn Học";
            // 
            // dataGridViewDSMH
            // 
            this.dataGridViewDSMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSMH.Location = new System.Drawing.Point(7, 30);
            this.dataGridViewDSMH.Name = "dataGridViewDSMH";
            this.dataGridViewDSMH.RowHeadersWidth = 62;
            this.dataGridViewDSMH.RowTemplate.Height = 28;
            this.dataGridViewDSMH.Size = new System.Drawing.Size(669, 226);
            this.dataGridViewDSMH.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePickerNT);
            this.panel1.Controls.Add(this.comboBoxMon);
            this.panel1.Controls.Add(this.comboBoxHP);
            this.panel1.Controls.Add(this.comboBoxkhoa);
            this.panel1.Controls.Add(this.textBoxTMH);
            this.panel1.Controls.Add(this.textBoxMMH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(22, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 130);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePickerNT
            // 
            this.dateTimePickerNT.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNT.Location = new System.Drawing.Point(337, 96);
            this.dateTimePickerNT.Name = "dateTimePickerNT";
            this.dateTimePickerNT.Size = new System.Drawing.Size(315, 26);
            this.dateTimePickerNT.TabIndex = 8;
            // 
            // comboBoxMon
            // 
            this.comboBoxMon.FormattingEnabled = true;
            this.comboBoxMon.Items.AddRange(new object[] {
            "Lý Thuyết",
            "Thực Hành"});
            this.comboBoxMon.Location = new System.Drawing.Point(388, 57);
            this.comboBoxMon.Name = "comboBoxMon";
            this.comboBoxMon.Size = new System.Drawing.Size(121, 33);
            this.comboBoxMon.TabIndex = 7;
            // 
            // comboBoxHP
            // 
            this.comboBoxHP.FormattingEnabled = true;
            this.comboBoxHP.Items.AddRange(new object[] {
            "Bắc Buộc",
            "Không Bắc Buộc "});
            this.comboBoxHP.Location = new System.Drawing.Point(388, 9);
            this.comboBoxHP.Name = "comboBoxHP";
            this.comboBoxHP.Size = new System.Drawing.Size(121, 33);
            this.comboBoxHP.TabIndex = 6;
            // 
            // comboBoxkhoa
            // 
            this.comboBoxkhoa.FormattingEnabled = true;
            this.comboBoxkhoa.Location = new System.Drawing.Point(65, 82);
            this.comboBoxkhoa.Name = "comboBoxkhoa";
            this.comboBoxkhoa.Size = new System.Drawing.Size(227, 33);
            this.comboBoxkhoa.TabIndex = 5;
            // 
            // textBoxTMH
            // 
            this.textBoxTMH.Location = new System.Drawing.Point(117, 47);
            this.textBoxTMH.Name = "textBoxTMH";
            this.textBoxTMH.Size = new System.Drawing.Size(175, 30);
            this.textBoxTMH.TabIndex = 4;
            // 
            // textBoxMMH
            // 
            this.textBoxMMH.Location = new System.Drawing.Point(117, 11);
            this.textBoxMMH.Name = "textBoxMMH";
            this.textBoxMMH.Size = new System.Drawing.Size(125, 30);
            this.textBoxMMH.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Môn Học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Môn Học:";
            // 
            // subject_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.groupBoxMH);
            this.Name = "subject_management";
            this.Text = "subject_management";
            this.groupBoxMH.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSMH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxMon;
        private System.Windows.Forms.ComboBox comboBoxHP;
        private System.Windows.Forms.ComboBox comboBoxkhoa;
        private System.Windows.Forms.TextBox textBoxTMH;
        private System.Windows.Forms.TextBox textBoxMMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTìm;
        private System.Windows.Forms.Button buttonXóa;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.Button buttonluu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewDSMH;
        private System.Windows.Forms.DateTimePicker dateTimePickerNT;
    }
}
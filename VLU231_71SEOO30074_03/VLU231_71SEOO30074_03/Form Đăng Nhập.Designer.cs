namespace VLU231_71SEOO30074_03
{
    partial class Form_Đăng_Nhập
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTDN = new System.Windows.Forms.TextBox();
            this.textBoxMK = new System.Windows.Forms.TextBox();
            this.buttonDN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trường Đại Học Văn Lang ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "cổng thông tin đào tạo";
            // 
            // textBoxTDN
            // 
            this.textBoxTDN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxTDN.Location = new System.Drawing.Point(254, 301);
            this.textBoxTDN.Name = "textBoxTDN";
            this.textBoxTDN.Size = new System.Drawing.Size(213, 26);
            this.textBoxTDN.TabIndex = 3;
            this.textBoxTDN.Text = "Tên Đăng Nhập";
            // 
            // textBoxMK
            // 
            this.textBoxMK.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxMK.Location = new System.Drawing.Point(254, 353);
            this.textBoxMK.Name = "textBoxMK";
            this.textBoxMK.Size = new System.Drawing.Size(213, 26);
            this.textBoxMK.TabIndex = 4;
            this.textBoxMK.Text = "Mật Khẩu";
            // 
            // buttonDN
            // 
            this.buttonDN.Location = new System.Drawing.Point(274, 410);
            this.buttonDN.Name = "buttonDN";
            this.buttonDN.Size = new System.Drawing.Size(169, 61);
            this.buttonDN.TabIndex = 5;
            this.buttonDN.Text = "Đăng Nhập";
            this.buttonDN.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(379, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quên mật khẩu ?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VLU231_71SEOO30074_03.Properties.Resources.Ảnh_chụp_màn_hình_2023_12_12_232316;
            this.pictureBox1.Location = new System.Drawing.Point(259, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 199);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Đăng_Nhập
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDN);
            this.Controls.Add(this.textBoxMK);
            this.Controls.Add(this.textBoxTDN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Đăng_Nhập";
            this.Text = "Form_Đăng_Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTDN;
        private System.Windows.Forms.TextBox textBoxMK;
        private System.Windows.Forms.Button buttonDN;
        private System.Windows.Forms.Label label3;
    }
}
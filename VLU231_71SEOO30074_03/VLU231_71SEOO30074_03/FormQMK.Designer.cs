namespace VLU231_71SEOO30074_03
{
    partial class FormQMK
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxMKM = new System.Windows.Forms.TextBox();
            this.textBoxOTP = new System.Windows.Forms.TextBox();
            this.buttonxn = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelkoOTP = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelkoOTP);
            this.panel1.Controls.Add(this.buttonxn);
            this.panel1.Controls.Add(this.textBoxOTP);
            this.panel1.Controls.Add(this.textBoxMKM);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBoxemail);
            this.panel1.Location = new System.Drawing.Point(110, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 317);
            this.panel1.TabIndex = 1;
            // 
            // textBoxemail
            // 
            this.textBoxemail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxemail.Location = new System.Drawing.Point(26, 29);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(233, 26);
            this.textBoxemail.TabIndex = 0;
            this.textBoxemail.Text = "EMAIL";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(26, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Nhập Lại Mật Khẩu";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxMKM
            // 
            this.textBoxMKM.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxMKM.Location = new System.Drawing.Point(26, 139);
            this.textBoxMKM.Name = "textBoxMKM";
            this.textBoxMKM.Size = new System.Drawing.Size(233, 26);
            this.textBoxMKM.TabIndex = 3;
            this.textBoxMKM.Text = "Mật Khẩu Mới";
            // 
            // textBoxOTP
            // 
            this.textBoxOTP.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxOTP.Location = new System.Drawing.Point(26, 85);
            this.textBoxOTP.Name = "textBoxOTP";
            this.textBoxOTP.Size = new System.Drawing.Size(233, 26);
            this.textBoxOTP.TabIndex = 4;
            this.textBoxOTP.Text = "Nhập Mã OTP";
            // 
            // buttonxn
            // 
            this.buttonxn.ForeColor = System.Drawing.Color.Red;
            this.buttonxn.Location = new System.Drawing.Point(77, 253);
            this.buttonxn.Name = "buttonxn";
            this.buttonxn.Size = new System.Drawing.Size(134, 57);
            this.buttonxn.TabIndex = 5;
            this.buttonxn.Text = "xác nhận";
            this.buttonxn.UseVisualStyleBackColor = true;
            // 
            // buttonback
            // 
            this.buttonback.AllowDrop = true;
            this.buttonback.BackgroundImage = global::VLU231_71SEOO30074_03.Properties.Resources._134226_back_arrow_left_icon;
            this.buttonback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonback.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonback.Location = new System.Drawing.Point(12, 12);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(56, 56);
            this.buttonback.TabIndex = 2;
            this.buttonback.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VLU231_71SEOO30074_03.Properties.Resources.Ảnh_chụp_màn_hình_2023_12_12_232316;
            this.pictureBox1.Location = new System.Drawing.Point(208, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelkoOTP
            // 
            this.labelkoOTP.AutoSize = true;
            this.labelkoOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkoOTP.ForeColor = System.Drawing.Color.IndianRed;
            this.labelkoOTP.Location = new System.Drawing.Point(115, 228);
            this.labelkoOTP.Name = "labelkoOTP";
            this.labelkoOTP.Size = new System.Drawing.Size(161, 13);
            this.labelkoOTP.TabIndex = 6;
            this.labelkoOTP.Text = "Bạn Không Nhận được Mã OTP?";
            // 
            // FormQMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 502);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormQMK";
            this.Text = "FormQMK";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonxn;
        private System.Windows.Forms.TextBox textBoxOTP;
        private System.Windows.Forms.TextBox textBoxMKM;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Label labelkoOTP;
    }
}
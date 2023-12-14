namespace VLU231_71SEOO30074_03.src.GUI
{
    partial class Subject
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
            this.buttonQV = new System.Windows.Forms.Button();
            this.buttonDK = new System.Windows.Forms.Button();
            this.dataGridViewLOP = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLOP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonQV);
            this.groupBox1.Controls.Add(this.buttonDK);
            this.groupBox1.Controls.Add(this.dataGridViewLOP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(493, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Môn học";
            // 
            // buttonQV
            // 
            this.buttonQV.Location = new System.Drawing.Point(417, 294);
            this.buttonQV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQV.Name = "buttonQV";
            this.buttonQV.Size = new System.Drawing.Size(61, 31);
            this.buttonQV.TabIndex = 2;
            this.buttonQV.Text = "Trở về";
            this.buttonQV.UseVisualStyleBackColor = true;
            // 
            // buttonDK
            // 
            this.buttonDK.Location = new System.Drawing.Point(339, 294);
            this.buttonDK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDK.Name = "buttonDK";
            this.buttonDK.Size = new System.Drawing.Size(66, 31);
            this.buttonDK.TabIndex = 1;
            this.buttonDK.Text = "Đăng ký";
            this.buttonDK.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLOP
            // 
            this.dataGridViewLOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLOP.Location = new System.Drawing.Point(4, 18);
            this.dataGridViewLOP.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewLOP.Name = "dataGridViewLOP";
            this.dataGridViewLOP.RowHeadersWidth = 62;
            this.dataGridViewLOP.RowTemplate.Height = 28;
            this.dataGridViewLOP.Size = new System.Drawing.Size(474, 266);
            this.dataGridViewLOP.TabIndex = 0;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 374);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Subject";
            this.Text = "Danh sách môn học";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLOP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewLOP;
        private System.Windows.Forms.Button buttonQV;
        private System.Windows.Forms.Button buttonDK;
    }
}
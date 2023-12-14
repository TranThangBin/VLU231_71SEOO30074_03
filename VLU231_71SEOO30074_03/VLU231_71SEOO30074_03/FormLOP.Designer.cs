namespace VLU231_71SEOO30074_03
{
    partial class FormLOP
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
            this.dataGridViewLOP = new System.Windows.Forms.DataGridView();
            this.buttonDK = new System.Windows.Forms.Button();
            this.buttonQV = new System.Windows.Forms.Button();
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
            this.groupBox1.Location = new System.Drawing.Point(23, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 519);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Học phần:";
            // 
            // dataGridViewLOP
            // 
            this.dataGridViewLOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLOP.Location = new System.Drawing.Point(6, 27);
            this.dataGridViewLOP.Name = "dataGridViewLOP";
            this.dataGridViewLOP.RowHeadersWidth = 62;
            this.dataGridViewLOP.RowTemplate.Height = 28;
            this.dataGridViewLOP.Size = new System.Drawing.Size(711, 409);
            this.dataGridViewLOP.TabIndex = 0;
            // 
            // buttonDK
            // 
            this.buttonDK.Location = new System.Drawing.Point(508, 452);
            this.buttonDK.Name = "buttonDK";
            this.buttonDK.Size = new System.Drawing.Size(99, 48);
            this.buttonDK.TabIndex = 1;
            this.buttonDK.Text = "đăng ký";
            this.buttonDK.UseVisualStyleBackColor = true;
            // 
            // buttonQV
            // 
            this.buttonQV.Location = new System.Drawing.Point(625, 452);
            this.buttonQV.Name = "buttonQV";
            this.buttonQV.Size = new System.Drawing.Size(92, 48);
            this.buttonQV.TabIndex = 2;
            this.buttonQV.Text = "quay về";
            this.buttonQV.UseVisualStyleBackColor = true;
            // 
            // FormLOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLOP";
            this.Text = "FormLOP";
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
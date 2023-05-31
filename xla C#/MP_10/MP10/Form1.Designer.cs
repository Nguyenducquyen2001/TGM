namespace MP10
{
    partial class Form1
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
            this.picBoxHinhGoc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBoxY = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picBoxCb = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picBoxCr = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picBoxYCrCb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxYCrCb)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxHinhGoc
            // 
            this.picBoxHinhGoc.Location = new System.Drawing.Point(21, 40);
            this.picBoxHinhGoc.Name = "picBoxHinhGoc";
            this.picBoxHinhGoc.Size = new System.Drawing.Size(300, 300);
            this.picBoxHinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhGoc.TabIndex = 0;
            this.picBoxHinhGoc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hình RGB Gốc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kênh Y:";
            // 
            // picBoxY
            // 
            this.picBoxY.Location = new System.Drawing.Point(18, 380);
            this.picBoxY.Name = "picBoxY";
            this.picBoxY.Size = new System.Drawing.Size(300, 300);
            this.picBoxY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxY.TabIndex = 2;
            this.picBoxY.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(744, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kênh Cb:";
            // 
            // picBoxCb
            // 
            this.picBoxCb.Location = new System.Drawing.Point(744, 380);
            this.picBoxCb.Name = "picBoxCb";
            this.picBoxCb.Size = new System.Drawing.Size(300, 300);
            this.picBoxCb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCb.TabIndex = 4;
            this.picBoxCb.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kênh Cr:";
            // 
            // picBoxCr
            // 
            this.picBoxCr.Location = new System.Drawing.Point(386, 380);
            this.picBoxCr.Name = "picBoxCr";
            this.picBoxCr.Size = new System.Drawing.Size(300, 300);
            this.picBoxCr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCr.TabIndex = 6;
            this.picBoxCr.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1088, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kênh YCrCb:";
            // 
            // picBoxYCrCb
            // 
            this.picBoxYCrCb.Location = new System.Drawing.Point(1088, 380);
            this.picBoxYCrCb.Name = "picBoxYCrCb";
            this.picBoxYCrCb.Size = new System.Drawing.Size(300, 300);
            this.picBoxYCrCb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxYCrCb.TabIndex = 8;
            this.picBoxYCrCb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 1055);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picBoxYCrCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picBoxCr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBoxCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBoxY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxHinhGoc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxYCrCb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxHinhGoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBoxY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBoxCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picBoxCr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBoxYCrCb;
    }
}


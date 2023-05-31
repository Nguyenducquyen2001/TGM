namespace MP_7
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
            this.picBoxH = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picBoxS = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picBoxI = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picBoxHSI = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHSI)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxHinhGoc
            // 
            this.picBoxHinhGoc.Location = new System.Drawing.Point(40, 49);
            this.picBoxHinhGoc.Name = "picBoxHinhGoc";
            this.picBoxHinhGoc.Size = new System.Drawing.Size(300, 300);
            this.picBoxHinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhGoc.TabIndex = 0;
            this.picBoxHinhGoc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hình RGB Gốc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kênh Hue:";
            // 
            // picBoxH
            // 
            this.picBoxH.Location = new System.Drawing.Point(40, 403);
            this.picBoxH.Name = "picBoxH";
            this.picBoxH.Size = new System.Drawing.Size(300, 300);
            this.picBoxH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxH.TabIndex = 2;
            this.picBoxH.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kênh Saturation:";
            // 
            // picBoxS
            // 
            this.picBoxS.Location = new System.Drawing.Point(383, 403);
            this.picBoxS.Name = "picBoxS";
            this.picBoxS.Size = new System.Drawing.Size(300, 300);
            this.picBoxS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxS.TabIndex = 4;
            this.picBoxS.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(723, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kênh Itensity:";
            // 
            // picBoxI
            // 
            this.picBoxI.Location = new System.Drawing.Point(726, 403);
            this.picBoxI.Name = "picBoxI";
            this.picBoxI.Size = new System.Drawing.Size(300, 300);
            this.picBoxI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxI.TabIndex = 6;
            this.picBoxI.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1071, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kênh HSI:";
            // 
            // picBoxHSI
            // 
            this.picBoxHSI.Location = new System.Drawing.Point(1074, 403);
            this.picBoxHSI.Name = "picBoxHSI";
            this.picBoxHSI.Size = new System.Drawing.Size(300, 300);
            this.picBoxHSI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHSI.TabIndex = 8;
            this.picBoxHSI.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picBoxHSI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picBoxI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBoxS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBoxH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxHinhGoc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHSI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxHinhGoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBoxH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBoxS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picBoxI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBoxHSI;
    }
}


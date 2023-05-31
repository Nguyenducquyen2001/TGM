namespace MINI_project08
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
            this.picBox_HinhGoc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBox_H = new System.Windows.Forms.PictureBox();
            this.picBox_S = new System.Windows.Forms.PictureBox();
            this.picBox_V = new System.Windows.Forms.PictureBox();
            this.picBox_HSV = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HSV)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_HinhGoc
            // 
            this.picBox_HinhGoc.Location = new System.Drawing.Point(12, 32);
            this.picBox_HinhGoc.Name = "picBox_HinhGoc";
            this.picBox_HinhGoc.Size = new System.Drawing.Size(350, 350);
            this.picBox_HinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_HinhGoc.TabIndex = 0;
            this.picBox_HinhGoc.TabStop = false;
            this.picBox_HinhGoc.Click += new System.EventHandler(this.picBox_HinhGoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ảnh RGB gốc";
            // 
            // picBox_H
            // 
            this.picBox_H.Location = new System.Drawing.Point(425, 32);
            this.picBox_H.Name = "picBox_H";
            this.picBox_H.Size = new System.Drawing.Size(350, 350);
            this.picBox_H.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_H.TabIndex = 2;
            this.picBox_H.TabStop = false;
            this.picBox_H.Click += new System.EventHandler(this.picBox_H_Click);
            // 
            // picBox_S
            // 
            this.picBox_S.Location = new System.Drawing.Point(807, 32);
            this.picBox_S.Name = "picBox_S";
            this.picBox_S.Size = new System.Drawing.Size(350, 350);
            this.picBox_S.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_S.TabIndex = 3;
            this.picBox_S.TabStop = false;
            // 
            // picBox_V
            // 
            this.picBox_V.Location = new System.Drawing.Point(12, 413);
            this.picBox_V.Name = "picBox_V";
            this.picBox_V.Size = new System.Drawing.Size(350, 350);
            this.picBox_V.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_V.TabIndex = 4;
            this.picBox_V.TabStop = false;
            // 
            // picBox_HSV
            // 
            this.picBox_HSV.Location = new System.Drawing.Point(425, 413);
            this.picBox_HSV.Name = "picBox_HSV";
            this.picBox_HSV.Size = new System.Drawing.Size(350, 350);
            this.picBox_HSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_HSV.TabIndex = 5;
            this.picBox_HSV.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kênh Hue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(815, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kênh Saturasion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kênh Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hình HSV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1055);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBox_HSV);
            this.Controls.Add(this.picBox_V);
            this.Controls.Add(this.picBox_S);
            this.Controls.Add(this.picBox_H);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_HinhGoc);
            this.Name = "Form1";
            this.Text = "Chuyển đổi không gian màu RGB sang không gian màu HSV ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_HinhGoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox_H;
        private System.Windows.Forms.PictureBox picBox_S;
        private System.Windows.Forms.PictureBox picBox_V;
        private System.Windows.Forms.PictureBox picBox_HSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


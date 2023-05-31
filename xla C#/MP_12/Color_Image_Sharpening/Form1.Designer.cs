namespace Color_Image_Sharpening
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
            this.Box_Goc = new System.Windows.Forms.PictureBox();
            this.Box_Sharpening = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Goc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Sharpening)).BeginInit();
            this.SuspendLayout();
            // 
            // Box_Goc
            // 
            this.Box_Goc.Location = new System.Drawing.Point(32, 55);
            this.Box_Goc.Name = "Box_Goc";
            this.Box_Goc.Size = new System.Drawing.Size(350, 350);
            this.Box_Goc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box_Goc.TabIndex = 0;
            this.Box_Goc.TabStop = false;
            // 
            // Box_Sharpening
            // 
            this.Box_Sharpening.Location = new System.Drawing.Point(456, 55);
            this.Box_Sharpening.Name = "Box_Sharpening";
            this.Box_Sharpening.Size = new System.Drawing.Size(350, 350);
            this.Box_Sharpening.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box_Sharpening.TabIndex = 1;
            this.Box_Sharpening.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "HÌNH GỐC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "HÌNH ĐÃ ĐƯỢC LÀM SẮC NÉT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Box_Sharpening);
            this.Controls.Add(this.Box_Goc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Box_Goc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Sharpening)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Box_Goc;
        private System.Windows.Forms.PictureBox Box_Sharpening;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


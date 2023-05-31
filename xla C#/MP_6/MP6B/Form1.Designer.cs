namespace MP6B
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
            this.lblHinhGoc = new System.Windows.Forms.Label();
            this.lblCyan = new System.Windows.Forms.Label();
            this.picBoxC = new System.Windows.Forms.PictureBox();
            this.lblMagenta = new System.Windows.Forms.Label();
            this.picBoxM = new System.Windows.Forms.PictureBox();
            this.lblYellow = new System.Windows.Forms.Label();
            this.picBoxY = new System.Windows.Forms.PictureBox();
            this.lblBlack = new System.Windows.Forms.Label();
            this.picBoxB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxB)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxHinhGoc
            // 
            this.picBoxHinhGoc.Location = new System.Drawing.Point(27, 37);
            this.picBoxHinhGoc.Name = "picBoxHinhGoc";
            this.picBoxHinhGoc.Size = new System.Drawing.Size(256, 256);
            this.picBoxHinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhGoc.TabIndex = 0;
            this.picBoxHinhGoc.TabStop = false;
            // 
            // lblHinhGoc
            // 
            this.lblHinhGoc.AutoSize = true;
            this.lblHinhGoc.Location = new System.Drawing.Point(27, 15);
            this.lblHinhGoc.Name = "lblHinhGoc";
            this.lblHinhGoc.Size = new System.Drawing.Size(98, 16);
            this.lblHinhGoc.TabIndex = 1;
            this.lblHinhGoc.Text = "Hình RGB gốc: ";
            // 
            // lblCyan
            // 
            this.lblCyan.AutoSize = true;
            this.lblCyan.Location = new System.Drawing.Point(27, 314);
            this.lblCyan.Name = "lblCyan";
            this.lblCyan.Size = new System.Drawing.Size(103, 16);
            this.lblCyan.TabIndex = 3;
            this.lblCyan.Text = "Kênh màu Cyan:";
            // 
            // picBoxC
            // 
            this.picBoxC.Location = new System.Drawing.Point(27, 336);
            this.picBoxC.Name = "picBoxC";
            this.picBoxC.Size = new System.Drawing.Size(256, 256);
            this.picBoxC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxC.TabIndex = 2;
            this.picBoxC.TabStop = false;
            // 
            // lblMagenta
            // 
            this.lblMagenta.AutoSize = true;
            this.lblMagenta.Location = new System.Drawing.Point(320, 314);
            this.lblMagenta.Name = "lblMagenta";
            this.lblMagenta.Size = new System.Drawing.Size(125, 16);
            this.lblMagenta.TabIndex = 5;
            this.lblMagenta.Text = "Kênh màu Magenta:";
            // 
            // picBoxM
            // 
            this.picBoxM.Location = new System.Drawing.Point(320, 336);
            this.picBoxM.Name = "picBoxM";
            this.picBoxM.Size = new System.Drawing.Size(256, 256);
            this.picBoxM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxM.TabIndex = 4;
            this.picBoxM.TabStop = false;
            // 
            // lblYellow
            // 
            this.lblYellow.AutoSize = true;
            this.lblYellow.Location = new System.Drawing.Point(614, 314);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(112, 16);
            this.lblYellow.TabIndex = 7;
            this.lblYellow.Text = "Kênh màu Yellow:";
            // 
            // picBoxY
            // 
            this.picBoxY.Location = new System.Drawing.Point(614, 336);
            this.picBoxY.Name = "picBoxY";
            this.picBoxY.Size = new System.Drawing.Size(256, 256);
            this.picBoxY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxY.TabIndex = 6;
            this.picBoxY.TabStop = false;
            // 
            // lblBlack
            // 
            this.lblBlack.AutoSize = true;
            this.lblBlack.Location = new System.Drawing.Point(914, 314);
            this.lblBlack.Name = "lblBlack";
            this.lblBlack.Size = new System.Drawing.Size(106, 16);
            this.lblBlack.TabIndex = 9;
            this.lblBlack.Text = "Kênh màu Black:";
            // 
            // picBoxB
            // 
            this.picBoxB.Location = new System.Drawing.Point(914, 336);
            this.picBoxB.Name = "picBoxB";
            this.picBoxB.Size = new System.Drawing.Size(256, 256);
            this.picBoxB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxB.TabIndex = 8;
            this.picBoxB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1055);
            this.Controls.Add(this.lblBlack);
            this.Controls.Add(this.picBoxB);
            this.Controls.Add(this.lblYellow);
            this.Controls.Add(this.picBoxY);
            this.Controls.Add(this.lblMagenta);
            this.Controls.Add(this.picBoxM);
            this.Controls.Add(this.lblCyan);
            this.Controls.Add(this.picBoxC);
            this.Controls.Add(this.lblHinhGoc);
            this.Controls.Add(this.picBoxHinhGoc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxHinhGoc;
        private System.Windows.Forms.Label lblHinhGoc;
        private System.Windows.Forms.Label lblCyan;
        private System.Windows.Forms.PictureBox picBoxC;
        private System.Windows.Forms.Label lblMagenta;
        private System.Windows.Forms.PictureBox picBoxM;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.PictureBox picBoxY;
        private System.Windows.Forms.Label lblBlack;
        private System.Windows.Forms.PictureBox picBoxB;
    }
}


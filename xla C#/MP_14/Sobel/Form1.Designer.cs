namespace Sobel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Box_Goc = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            Box_Sob = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            trackBar = new TrackBar();
            btnEdge = new Button();
            lbValueNguong = new Label();
            ((System.ComponentModel.ISupportInitialize)Box_Goc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Box_Sob).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            SuspendLayout();
            // 
            // Box_Goc
            // 
            Box_Goc.Location = new Point(54, 51);
            Box_Goc.Name = "Box_Goc";
            Box_Goc.Size = new Size(350, 350);
            Box_Goc.SizeMode = PictureBoxSizeMode.StretchImage;
            Box_Goc.TabIndex = 0;
            Box_Goc.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 33);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "HÌNH GỐC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(560, 33);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 3;
            label2.Text = "HÌNH SOBEL";
            // 
            // Box_Sob
            // 
            Box_Sob.Location = new Point(438, 51);
            Box_Sob.Name = "Box_Sob";
            Box_Sob.Size = new Size(350, 350);
            Box_Sob.SizeMode = PictureBoxSizeMode.StretchImage;
            Box_Sob.TabIndex = 2;
            Box_Sob.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 445);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "NGƯỠNG";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 463);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 5;
            // 
            // trackBar
            // 
            trackBar.Location = new Point(197, 433);
            trackBar.Maximum = 255;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(341, 45);
            trackBar.TabIndex = 6;
            trackBar.Scroll += trackBar_Scroll;
            trackBar.ValueChanged += trackBar_Scroll;
            // 
            // btnEdge
            // 
            btnEdge.Location = new Point(544, 427);
            btnEdge.Name = "btnEdge";
            btnEdge.Size = new Size(130, 51);
            btnEdge.TabIndex = 7;
            btnEdge.Text = "NHẬN DẠNG BIÊN";
            btnEdge.UseVisualStyleBackColor = true;
            btnEdge.Click += btnEdge_Click;
            // 
            // lbValueNguong
            // 
            lbValueNguong.AutoSize = true;
            lbValueNguong.Location = new Point(349, 415);
            lbValueNguong.Name = "lbValueNguong";
            lbValueNguong.Size = new Size(13, 15);
            lbValueNguong.TabIndex = 8;
            lbValueNguong.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 540);
            Controls.Add(lbValueNguong);
            Controls.Add(btnEdge);
            Controls.Add(trackBar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Box_Sob);
            Controls.Add(label1);
            Controls.Add(Box_Goc);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)Box_Goc).EndInit();
            ((System.ComponentModel.ISupportInitialize)Box_Sob).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Box_Goc;
        private Label label1;
        private Label label2;
        private PictureBox Box_Sob;
        private Label label3;
        private Label label4;
        private TrackBar trackBar;
        private Button btnEdge;
        private Label lbValueNguong;
    }
}
namespace Segmentation
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
            Box_Seg = new PictureBox();
            lbValueNguong = new Label();
            txbx1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txby1 = new TextBox();
            label6 = new Label();
            txby2 = new TextBox();
            label7 = new Label();
            txbx2 = new TextBox();
            label8 = new Label();
            btnSeg = new Button();
            label3 = new Label();
            trackBar = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)Box_Goc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Box_Seg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            SuspendLayout();
            // 
            // Box_Goc
            // 
            Box_Goc.Location = new Point(55, 56);
            Box_Goc.Name = "Box_Goc";
            Box_Goc.Size = new Size(350, 350);
            Box_Goc.SizeMode = PictureBoxSizeMode.StretchImage;
            Box_Goc.TabIndex = 0;
            Box_Goc.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 38);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "HÌNH GỐC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(564, 38);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 3;
            label2.Text = "HÌNH SEGMENTATION";
            // 
            // Box_Seg
            // 
            Box_Seg.Location = new Point(445, 56);
            Box_Seg.Name = "Box_Seg";
            Box_Seg.Size = new Size(350, 350);
            Box_Seg.SizeMode = PictureBoxSizeMode.StretchImage;
            Box_Seg.TabIndex = 2;
            Box_Seg.TabStop = false;
            // 
            // lbValueNguong
            // 
            lbValueNguong.AutoSize = true;
            lbValueNguong.Location = new Point(390, 414);
            lbValueNguong.Name = "lbValueNguong";
            lbValueNguong.Size = new Size(0, 15);
            lbValueNguong.TabIndex = 6;
            // 
            // txbx1
            // 
            txbx1.Location = new Point(218, 511);
            txbx1.Name = "txbx1";
            txbx1.Size = new Size(61, 23);
            txbx1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 519);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 8;
            label4.Text = "X1:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(330, 519);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 10;
            label5.Text = "Y1:";
            // 
            // txby1
            // 
            txby1.Location = new Point(356, 511);
            txby1.Name = "txby1";
            txby1.Size = new Size(61, 23);
            txby1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 559);
            label6.Name = "label6";
            label6.Size = new Size(23, 15);
            label6.TabIndex = 12;
            label6.Text = "Y2:";
            // 
            // txby2
            // 
            txby2.Location = new Point(356, 551);
            txby2.Name = "txby2";
            txby2.Size = new Size(61, 23);
            txby2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(192, 559);
            label7.Name = "label7";
            label7.Size = new Size(23, 15);
            label7.TabIndex = 14;
            label7.Text = "X2:";
            // 
            // txbx2
            // 
            txbx2.Location = new Point(218, 551);
            txbx2.Name = "txbx2";
            txbx2.Size = new Size(61, 23);
            txbx2.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(188, 480);
            label8.Name = "label8";
            label8.Size = new Size(303, 15);
            label8.TabIndex = 15;
            label8.Text = "CHỌN VÙNG ẢNH ĐỂ TÍNH VECTOR TRUNG BÌNH MÀU:";
            // 
            // btnSeg
            // 
            btnSeg.Location = new Point(460, 523);
            btnSeg.Name = "btnSeg";
            btnSeg.Size = new Size(120, 51);
            btnSeg.TabIndex = 16;
            btnSeg.Text = "PHÂN ĐOẠN ẢNH";
            btnSeg.UseVisualStyleBackColor = true;
            btnSeg.Click += btnSeg_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 443);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "NGƯỠNG";
            // 
            // trackBar
            // 
            trackBar.Location = new Point(252, 432);
            trackBar.Maximum = 255;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(350, 45);
            trackBar.TabIndex = 4;
            trackBar.Scroll += trackBar_Scroll;
            trackBar.ValueChanged += trackBar_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 621);
            Controls.Add(btnSeg);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txbx2);
            Controls.Add(label6);
            Controls.Add(txby2);
            Controls.Add(label5);
            Controls.Add(txby1);
            Controls.Add(label4);
            Controls.Add(txbx1);
            Controls.Add(lbValueNguong);
            Controls.Add(label3);
            Controls.Add(trackBar);
            Controls.Add(label2);
            Controls.Add(Box_Seg);
            Controls.Add(label1);
            Controls.Add(Box_Goc);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Box_Goc).EndInit();
            ((System.ComponentModel.ISupportInitialize)Box_Seg).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Box_Goc;
        private Label label1;
        private Label label2;
        private PictureBox Box_Seg;
        private Label lbValueNguong;
        private TextBox txbx1;
        private Label label4;
        private Label label5;
        private TextBox txby1;
        private Label label6;
        private TextBox txby2;
        private Label label7;
        private TextBox txbx2;
        private Label label8;
        private Button btnSeg;
        private Label label3;
        private TrackBar trackBar;
    }
}
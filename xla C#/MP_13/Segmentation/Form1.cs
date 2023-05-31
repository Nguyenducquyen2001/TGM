using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Segmentation
{
    public partial class Form1 : Form
    {
        Bitmap HinhGoc;
        byte nguong;
        public Form1()
        {
            InitializeComponent();
            // Them @ de C#.NET hieu day la chuoi unicode de khong bi bao loi
            HinhGoc = new Bitmap(@"E:\hk2_nam3\XLA\XLA c#\lena.jpg");

            //Hiển thị hình gốc trong image_HinhGoc đã tạo
            Box_Goc.Image = HinhGoc;

        }

        //Ham tinh vector mau trung binh a 
        double[] VectorA(Bitmap HinhGoc, int x1, int y1, int x2, int y2)
        {
            double[] a = new double[3];
            a[0] = a[1] = a[2] = 0;
            for (int x = x1; x <= x2; x++)
                for (int y = y1; y <= y2; y++)
                {
                    //Lay thong tin mau RGB tai diem anh trong mat na tiaj vi tri i j
                    Color pixel = HinhGoc.GetPixel(x, y);

                    a[0] += pixel.R; // gia tri kenh RED, moi kenh mau bieu dien boi 8 bit
                    a[1] += pixel.G; // gia tri kenh GREEN
                    a[2] += pixel.B; // gia tri kenh BLUE
                }
            double size = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);
            a[0] /= size;
            a[1] /= size;
            a[2] /= size;
            return a;
        }

        //Hàm phân đoạn ảnh 
        public Bitmap Segmentation(Bitmap HinhGoc, byte nguong)
        {
            //Tao san hinh bitmap chua anh duoc lam muot
            Bitmap Segment_Image = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            //Lấy giá trị của x1,y1,x2,y2 trong textbox
            int x1 = Convert.ToInt32(txbx1.Text);
            int y1 = Convert.ToInt32(txby1.Text);
            int x2 = Convert.ToInt32(txbx2.Text);
            int y2 = Convert.ToInt32(txby2.Text);
            double[] a = new double[3];
            a = VectorA(HinhGoc, x1, y1, x2, y2);
            //Tien hanh quet cac diem anh trong hinh goc RGB
            // Bỏ qua viền ngoài
            for (int x = 0; x < HinhGoc.Width; x++)
                for (int y = 0; y < HinhGoc.Height; y++)
                {
                    //Lay thong tin mau RGB tai diem anh trong mat na tiaj vi tri i j
                    Color pixel = HinhGoc.GetPixel(x, y);

                    int zR = pixel.R; // gia tri kenh RED, moi kenh mau bieu dien boi 8 bit
                    int zG = pixel.G; // gia tri kenh GREEN
                    int zB = pixel.B; // gia tri kenh BLUE

                    double D = Math.Sqrt((zR - a[0]) * (zR - a[0]) + (zG - a[1]) * (zG - a[1]) + (zB - a[2]) * (zB - a[2]));
                    if (D <= nguong)
                    {
                        zR = 255;
                        zG = 255;
                        zB = 255;
                    }
                    Segment_Image.SetPixel(x, y, Color.FromArgb(zR, zG, zB));
                }
            return Segment_Image;
        }


        private void trackBar_Scroll(object sender, EventArgs e)
        {
            //Hàm sự kiện 
            //Lấy giá trị của thanh cuộn 
            // .Value trả về int nên cần ép kiểu về byte
            nguong = (byte)trackBar.Value;
            lbValueNguong.Text = trackBar.Value.ToString();
        }

        private void btnSeg_Click(object sender, EventArgs e)
        {
            // Hiển thị anh phan doan
            Bitmap Segment_Image = Segmentation(HinhGoc, nguong);
            Box_Seg.Image = Segment_Image;
        }
    }
}

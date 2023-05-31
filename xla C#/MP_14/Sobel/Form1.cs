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

namespace Sobel
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

        //Hàm chuyển ảnh mức xám
        public Bitmap ChuyenHinhRGBSangMucXamLuminance(Bitmap hinhgoc)
        {
            Bitmap HinhMucXam = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    //Lấy giá trị của điểm ảnh tại vị trí x,y bằng phương thức .Getpixel 
                    //Color là kiểu dữ liệu đại diện cho các giá trị màu sac
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //Tính giá trị mức xám cho điểm ảnh tại (x,y)
                    byte gray = (byte)(0.2126 * R + 0.7152 * G + 0.0722 * B);

                    //Gán giá trị mức xám vừa tính vào hình mức xám 
                    HinhMucXam.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            return HinhMucXam;
        }

        //Hàm nhận dạng đường biên 
        public Bitmap EdgeDetection(Bitmap HinhGoc, byte nguong)
        {
            Bitmap HinhXam = new Bitmap(ChuyenHinhRGBSangMucXamLuminance(HinhGoc));
            //Tao san hinh bitmap chua anh duoc lam muot
            Bitmap Edge_Image = new Bitmap(HinhXam.Width, HinhXam.Height);

            int[,] Sobelx = { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
            int[,] Sobely = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            //Tien hanh quet cac diem anh trong hinh goc RGB
            // Bỏ qua viền ngoài
            for (int x = 1; x < HinhXam.Width - 1; x++)
                for (int y = 1; y < HinhXam.Height - 1; y++)
                {
                    int gx = 0;
                    int gy = 0;
                    //Tien hanh quet cac diem trong mat na
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            //Lay thong tin mau RGB tai diem anh trong mat na tiaj vi tri i j
                            Color pixel = HinhXam.GetPixel(i, j);

                            int Gray = pixel.R; // gia tri kenh RED, vì màu mức xám nên lấy kênh màu nào cũng được

                            //Nhân tích chập 2 ma trận tìm gx
                            gx += Gray * Sobelx[i - (x - 1), j - (y - 1)];

                            //Nhân tích chập 2 ma trận tìm gy
                            gy += Gray * Sobely[i - (x - 1), j - (y - 1)];


                        }
                    byte edge;
                    double M = Math.Abs(gx) + Math.Abs(gy);
                    if (M < nguong)
                    {
                        edge = 0;
                    }
                    else
                    {
                        edge = 255;
                    }
                    Edge_Image.SetPixel(x, y, Color.FromArgb(edge, edge, edge));
                }
            return Edge_Image;
        }


        private void trackBar_Scroll(object sender, EventArgs e)
        {
            //Hàm sự kiện 
            //Lấy giá trị của thanh cuộn 
            // .Value trả về int nên cần ép kiểu về byte
            nguong = (byte)trackBar.Value;
            lbValueNguong.Text = trackBar.Value.ToString();
        }

        private void btnEdge_Click(object sender, EventArgs e)
        {
            // Hiển thị anh phan doan
            Bitmap Edge_Image = EdgeDetection(HinhGoc, nguong);
            Box_Sob.Image = Edge_Image;
        }
    }
}

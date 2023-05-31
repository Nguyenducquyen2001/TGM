using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Load hình .jpg từ file
            Bitmap HinhGoc = new Bitmap(@"E:\hk2_nam3\XLA\XLA c#\lena.jpg");

            //Cho hiển thị trên pictureBox
            picBoxHinhGoc.Image = HinhGoc;

            //Hiển thị các kênh màu HSI được chuyển đổi từ RGB
            // Gọi hàm chuyển đổi RGB sang HSI 
            List<Bitmap> YCrCb = ChuyenDoiRGBSangYCrCb(HinhGoc);
            Console.WriteLine(YCrCb);

            // Cho hiển thị trên picBox đã tạo
            picBoxY.Image = YCrCb[0];  
            picBoxCr.Image = YCrCb[1];  
            picBoxCb.Image = YCrCb[2];  
            picBoxYCrCb.Image = YCrCb[3]; 
        }
        //YCrCb giúp giảm bớt lượng dữ liệu cần thiết để lưu trữ hoặc truyền
        //tải hình ảnh.Trong đó, kênh Y chứa thông tin về độ sáng, còn kênh
        //Cr và Cb chứa thông tin về màu sắc
        public List<Bitmap> ChuyenDoiRGBSangYCrCb(Bitmap HinhGoc)
        {
            // Tạo mảng đông list để chứa các hình sau chuyển đổi 
            List<Bitmap> YCrCb = new List<Bitmap>();

            // Tạo 3 kênh màu để chứa hình của các kênh H-S-I
            Bitmap YImg = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap CrImg = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap CbImg = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap YCrCbImg = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            for (int x = 0; x < HinhGoc.Width; x++)
                for (int y = 0; y < HinhGoc.Height; y++)
                {
                    // Lấy thông tin điểm ảnh tại ví trí (x,y)
                    Color pixel = HinhGoc.GetPixel(x, y);

                    // Do quá trinh tính các giá trị Y-Cr-Cb kết quả trả về của các công thức đề là kiểu double (số thực)
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    double Y = (16 + 65.738 * R / 256 + 129.057 * G / 256 + 25.064 * B / 256);
                    double Cb = (128 - 37.945 * R / 256 - 74.494 * G / 256 + 112.439 * B / 256);
                    double Cr = (128 + 112.439 * R / 256 - 94.154 * G / 256 - 18.285 * B / 256);

                    // Set giá trị pixel đọc được cho các hình chứa các kênh màu tương ứng 
                    YImg.SetPixel(x, y, Color.FromArgb((byte) Y, (byte) Y, (byte) Y));
                    CbImg.SetPixel(x, y, Color.FromArgb((byte) Cb, (byte) Cb, (byte) Cb));
                    CrImg.SetPixel(x, y, Color.FromArgb((byte) Cr, (byte) Cr, (byte) Cr));
                    YCrCbImg.SetPixel(x, y, Color.FromArgb((byte) Y, (byte) Cb, (byte) Cr));
                }
            // Add các hình tương ứng các kênh màu vào list
            YCrCb.Add(YImg);
            YCrCb.Add(CbImg);
            YCrCb.Add(CrImg);
            YCrCb.Add(YCrCbImg);

            // Hàm trả về là một list 4 ảnh bitmap tương ứng 4 kênh màu
            return YCrCb;
        }
    }
}

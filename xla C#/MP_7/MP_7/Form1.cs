using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_7
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
            List<Bitmap> HSI = ChuyenDoiRGBSangHSI(HinhGoc);

            // Cho hiển thị trên picBox đã tạo
            picBoxH.Image = HSI[0];  //Kenh HUE
            picBoxS.Image = HSI[1];  //Kenh SATURATION
            picBoxI.Image = HSI[2];  //Kenh INTENSITY
            picBoxHSI.Image = HSI[3];  //Kenh HSI
        }
        public List<Bitmap> ChuyenDoiRGBSangHSI(Bitmap HinhGoc)
        {
            // Tạo mảng đông list để chứa các hình sau chuyển đổi 
            List<Bitmap> HSI = new List<Bitmap>();

            // Tạo 3 kênh màu để chứa hình của các kênh H-S-I
            Bitmap Hue = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap Saturation = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap Itensity = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            Bitmap HSIImg = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            for (int x = 0; x < HinhGoc.Width; x++)
                for (int y = 0; y < HinhGoc.Height; y++)
                {
                    // Lấy thông tin điểm ảnh tại ví trí (x,y)
                    Color pixel = HinhGoc.GetPixel(x, y);

                    // Do quá trinh tính các giá trị H-S-I kết quả trả về của các công thức đề là kiểu double (số thực)
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    // t1 là phần tử số của công thức 
                    double t1 = ((R - G) + (R - B)) / 2;

                    // t2 là phần mẫu số của công thức tính góc theta 
                    double t2 = (R - G) * (R - G) + Math.Sqrt((R - B) * (G - B));

                    // Kết quả trả về của hàm tính Acos trong C#.NET là radian
                    double theta = Math.Acos(t1 / t2);

                    // Công thức tính giá trị Hue
                    double H = 0;

                    // Nếu mà Blue <= Green thì Hue = theta 
                    if (B <= G)
                        H = theta;
                    else // Ngươc lại thì Hue tính theo công thức H = 360 - theta  
                        H = 2 * Math.PI - theta; // Do theta là radian tính ở trên nên thay vì dùng 360 thì dùng PI

                    // Chuyển đổi giá trị H từ radian sang degree 
                    H = H * 180 / Math.PI;

                    // Công thức tính giá trị kênh Saturation
                    double S = 1 - 3 * Math.Min(R, Math.Min(G, B)) / (R + G + B);
                    // Do giá trị tính ra của S sẽ nằm trong khoảng [0, 1].
                    // Để bitmap có thể hiển thị được thì mình cần phải chuyển S sang khoảng giá trị [0,255]
                    // Công thức dưới giúp chuyển đổi từ rank [0,1] sang rank [0,255]
                    S = S * 225;

                    // Công thức tính giá trị kênh Itensity
                    double I = (R + G + B) / 3;

                    // Set giá trị pixel đọc được cho các hình chứa các kênh màu tương ứng 
                    Hue.SetPixel(x, y, Color.FromArgb((byte)H, (byte)H, (byte)H));
                    Saturation.SetPixel(x, y, Color.FromArgb((byte)S, (byte)S, (byte)S));
                    Itensity.SetPixel(x, y, Color.FromArgb((byte)I, (byte)I, (byte)I));

                    HSIImg.SetPixel(x, y, Color.FromArgb((byte)H, (byte)S, (byte)I));
                }
            // Add các hình tương ứng các kênh màu vào list
            HSI.Add(Hue);
            HSI.Add(Saturation);
            HSI.Add(Itensity);
            HSI.Add(HSIImg);

            // Hàm trả về là một list 4 ảnh bitmap tương ứng 4 kênh màu
            return HSI;
        }
    }
}

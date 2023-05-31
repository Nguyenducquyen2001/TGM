using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Load hình .jpg từ file hình gốc cô gái Lena từ thư mục
            Bitmap HinhGoc = new Bitmap(@"E:\hk2_nam3\XLA\XLA c#\lena.jpg");

            //Hiển thị hình gốc lên picBox
            picBoxHinhGoc.Image = HinhGoc;

            //Chuyển đổi RGB sang XYZ
            List<Bitmap> XYZ = ChuyenDoiKhongGianMauRGBSangXYZ(HinhGoc);
            Console.WriteLine(XYZ);

            //Hiển thị kết quả
            picBoxX.Image = XYZ[0];
            picBoxY.Image = XYZ[1];
            picBoxZ.Image = XYZ[2];
            picBoxXYZ.Image = XYZ[3];

        }
        //Viết hàm chuyển đổi RGB sang XYZ
        public List<Bitmap> ChuyenDoiKhongGianMauRGBSangXYZ(Bitmap HinhGoc)
        {
            //Tạo mảng động List chứa các hình kết quả sau chuyển đổi
            List<Bitmap> XYZ = new List<Bitmap>();

            //Tạo 3 kênh màu để chứa hình của các kênh X, Y, Z
            Bitmap KX = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap KY = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap KZ = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            Bitmap XYZimg = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            for (int x = 0; x < HinhGoc.Width; x++)
                for (int y = 0; y < HinhGoc.Height; y++)
                {
                    Color pixel = HinhGoc.GetPixel(x, y); //Lấy thông tin điểm ảnh tại vị trí (x, y)

                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;
                    // Ma trận chuyển đổi không gian màu RGB sang XYZ
                    double X = (0.4124564 * R + 0.3575761 * G + 0.1804375 * B);
                    double Y = (0.2126729 * R + 0.7151522 * G + 0.0721750 * B);
                    double Z = (0.0193339 * R + 0.1191920 * G + 0.9503041 * B);

                    //Cho hiển thị các kênh giá trị X-Y-Z tại các picBox
                    KX.SetPixel(x, y, Color.FromArgb((byte)X, (byte)X, (byte)X));
                    KY.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Y, (byte)Y));
                    KZ.SetPixel(x, y, Color.FromArgb((byte)Z, (byte)Z, (byte)Z));
                    XYZimg.SetPixel(x, y, Color.FromArgb((byte)X, (byte)Y, (byte)Z));
                }
            XYZ.Add(KX);
            XYZ.Add(KY);
            XYZ.Add(KZ);
            XYZ.Add(XYZimg);

            //Trả mảng hình kết quả sau chuyển đổi cho hàm
            return XYZ;
        }
    }
}

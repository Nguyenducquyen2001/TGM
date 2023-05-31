using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI_project08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            // Lấy đường dẫn file hình
            Bitmap hinhgoc = new Bitmap(@"E:\hk2_nam3\XLA\XLA c#\lena.jpg");
            // Cho hiển thị trên pictureBox
            picBox_HinhGoc.Image = hinhgoc;


            List<Bitmap> hsv = chuyendoiRGBsangHSV(hinhgoc);
            picBox_H.Image = hsv[0];
            picBox_S.Image = hsv[1];
            picBox_V.Image = hsv[2];
            picBox_HSV.Image = hsv[3];

        }
        // Viết hàm chuyển đổi RGB sang HSV
        public List<Bitmap> chuyendoiRGBsangHSV(Bitmap hinhgoc)
        {
            // Tạo mảng động List chứa các hình kết quả sau chuyển đổi
            List<Bitmap> hsv = new List<Bitmap>();

            // Tạo 3 kênh màu cùng kích thước so với hình gốc để chứa hình các kênh H S V
            Bitmap hue = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap saturation = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap value = new Bitmap(hinhgoc.Width, hinhgoc.Height);


            // Đây là hình HSV kết hợp 3 kênh màu H S V
            Bitmap hsving = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            // Quét các điểm ảnh có trong hình
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    // Lấy các giá trị tại các điểm (x, y)
                    Color pixel = hinhgoc.GetPixel(x, y);

                    // Phần trước thì dùng kiểu cho RGB nhunwgowr phần HSI, HSV thì dùng kiểu double
                    // do quá trình tính toán các giá trị trả về các công thức đều là double(số thực)
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;


                    // t1 là phần tử số của công thức 
                    double t1 = ((R - G) + (R - B)) / 2;


                    // t2 là phần mẫu số của công thức 
                    double t2 = Math.Sqrt((R - B) * (G - B)) + (R - G) * (R - G);
                    // Kết quả trả về của hàm tính Acos: là radian
                    double theta = Math.Acos(t1 / t2);

                    // Công thức tính giá trị hue
                    double H = 0;

                    // Nếu mà Blue <= Green thì Hue = theta
                    if (B <= G)
                        H = theta;
                    else  // ngược lại nếu Blue > Green thih Hue được tính theo công thức sau:
                        H = 2 * Math.PI - theta;     //Do thta là radian tính ở trên nên thay vì dùng 360 độ thì dùng PI
                    // Chuyển đổi giá trị radian sang degre
                        H = (H * 180 / Math.PI);


                    //Ta có công thức tính giá trị Saturation
                    double S = 1 - 3 * Math.Min(R, Math.Min(G, B)) / (R + G + B);
                    S = S * 255;

                    //Do giá trị tính ra của S nằm trong khoảng từ [0;1]
                    //để bitmap có thể hiện thị được thì cần phải thay đổi s sang khoảng giá trị [0; 255]
                    //  S = S * 255;

                    //Công thức tính giá trị kênh Intensity
                    double V = Math.Max(R, Math.Max(G, B));

                    // Ép kiểu của các giá trị HSV vẽ kiểu byte để hình bitmap hiểu và hiển thị 
                    hue.SetPixel(x, y, Color.FromArgb((byte)H, (byte)H, (byte)H));
                    saturation.SetPixel(x, y, Color.FromArgb((byte)S, (byte)S, (byte)S));
                    value.SetPixel(x, y, Color.FromArgb((byte)V, (byte)V, (byte)V));

                    // Còn các giá trị gốc của kênh S chưa nomalized mình có thể dùng để kết hợp các kênh H S V tạo thành HSV
                    hsving.SetPixel(x, y, Color.FromArgb((byte)H, (byte)S, (byte)V));
                }
            // Add các hình vào List
            hsv.Add(hue);
            hsv.Add(saturation);
            hsv.Add(value);
            hsv.Add(hsving);


            // trả về kết quả chuyển đồi cho hàm
            return hsv;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picBox_HinhGoc_Click(object sender, EventArgs e)
        {

        }

        private void picBox_H_Click(object sender, EventArgs e)
        {

        }
    }
}

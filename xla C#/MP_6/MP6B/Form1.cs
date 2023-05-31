using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP6B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Load hình .jpg từ file. Chúng ta sẽ dùng hình màu RGB chuẩn Lena Girl 
            Bitmap HinhGoc = new Bitmap(@"E:\hk2_nam3\XLA\XLA c#\Lena.jpg");

            // Cho hiển thị trên pictureBox 
            picBoxHinhGoc.Image = HinhGoc;

            // Hiển thị các kênh màu CMYK được chuyển đổi từ RGB 
            // Gọi hàm chuyển đổi từ RGB sang CMYK 
            List<Bitmap> CMYK = ChuyenDoiRGBSangCMYK(HinhGoc);

            // Hàm trên trả về 4 màu tương ứng thứ tự từ 0-3 là C-M-Y-K 
            // Bây giờ mình cho hiển thị trên pixtureBox để thấy kết quả 
            picBoxC.Image = CMYK[0]; // Kênh màu Cyan 
            picBoxM.Image = CMYK[1]; // Kênh màu Magenta 
            picBoxY.Image = CMYK[2]; // Kênh màu Yellow 
            picBoxB.Image = CMYK[3]; // Kênh màu Black 
        }

        public List<Bitmap> ChuyenDoiRGBSangCMYK(Bitmap hinhgoc)
        {


            List<Bitmap> CMYK = new List<Bitmap>();

            // Tiếp theo là mình tạo ra 4 hình bitmap, chưa chứa thông tin gì hết 
            // chỉ là kích thước mỗi hình phải bằng với kích thước của hình gốc để sau này 
            // việc tính toán chuyển đổi kênh màu được thực hiện đúng cho từng pixel. 
            // Mỗi kênh trong không gian màu CMYK được hiển thị bởi một hình Bitmap 
            Bitmap Cyan = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Magenta = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Yellow = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Black = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            // Mình tiến hành quét ảnh gốc, 2 vòng for này giúp mình quét các pixel 
            // trong ảnh gốc theo cột, quét hết cột này đến cột tiếp theo, từ trái qua phải 
            // cho đến cột cuối cùng trong ảnh gốc.
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    // Lấy điểm ảnh. Tại mỗi điểm ảnh (pixel) đang được quét mình
                    // tiến hành lấy thông tin tại điểm đó. Do là ảnh gốc RGB nên mỗi pixel 
                    // sẽ chứa thông tin của 3 kênh màu R, G, B tương ứng. 
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R; // Lưu ý mỗi kênh màu được biểu diễn bởi 8 bits
                    byte G = pixel.G; // tương ứng là 1byte. Do đó mình sẽ sử dụng kiểu dữ liệu là byte
                    byte B = pixel.B; // để chứa thông tin của từng kênh màu RGB 

                    // Bây giờ mình sẽ tiến hành trộn các kênh màu R-G-B để cho ra các màu C-M-Y-K 

                    // Màu Cyan (xanh dương) là kết hợp giữa Green và Blue, vậy nên mình set kênh Red = 0
                    Cyan.SetPixel(x, y, Color.FromArgb(0, G, B));

                    // Màu Magenta (tím) là kết hợp giữa Red và Blue, nên set kênh Green = 0
                    Magenta.SetPixel(x, y, Color.FromArgb(R, 0, B));

                    // Màu Yellow (vàng) là kết hợp giữa Red và Green, nên set kênh Blue = 0 
                    Yellow.SetPixel(x, y, Color.FromArgb(R, G, 0));

                    // Màu Black (đen) đơn giản là lấy MIN(R, G, B) 
                    byte K = Math.Min(R, Math.Min(G, B)); // Do hàm Min chỉ có 2 đối số đầu vào nên phải thực hiện 2 lần 
                    Black.SetPixel(x, y, Color.FromArgb(K, K, K));

                }
            // Add các hình tương ứng các kênh màu C-M-Y-K vào List 
            // Do List là kiểu dữ liệu mảng (Array) không cần biết trước kích thước 
            // nên mình có thể Add các element của List vào mà không cần quan tâm nó có 
            // bị tràn kích thước hay không 
            CMYK.Add(Cyan);
            CMYK.Add(Magenta);
            CMYK.Add(Yellow);
            CMYK.Add(Black);

            // Hàm trả về là một list 4 ảnh bitmap tương ứng 4 kênh màu C-M-Y-K 
            return CMYK;

        }
    }
}

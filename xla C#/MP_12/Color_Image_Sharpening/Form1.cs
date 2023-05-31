using System.Drawing;
using System.Windows.Forms;

namespace Color_Image_Sharpening
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Tạo biến chứa hình bitmap load từ file ảnh gốc
            Bitmap hinhgoc = new Bitmap(@"E:\hk2_nam3\XLA\XLA c#\lena.jpg");
            //Hiển thị hình gốc lên Picbox
            Box_Goc.Image = hinhgoc;

            // Hiển thị hình đã làm nét
            Bitmap Image_Sharpening = ColorImageSharpening(hinhgoc);
            Box_Sharpening.Image = Image_Sharpening;

        }

        //Hàm làm nét ảnh RGB
        public Bitmap ColorImageSharpening(Bitmap hinhgoc)
        {
            // tạo 1 hình bit map để chứa ảnh làm nét
            Bitmap Image_Sharpening = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            // tiến hành quét các điểm ảnh trong hình gốc
            //  ta bỏ các viền ngoài để dễ lập trình
            for (int x = 1; x < hinhgoc.Width - 1; x++)
                for (int y = 1; y < hinhgoc.Height - 1; y++)
                {
                    //các biến chứa giá trị cộng dồn của các điểm ảnh. Do vậy ta phải khai báo kiểu int

                    int Rs = 0, Gs = 0, Bs = 0;
                    int Rg = 0, Gg = 0, Bg = 0;
                    int[,] matrix = { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } };

                    // tiến hành quét các điểm trong mặt nạ
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            //Lay thong tin mau RGB tai diem anh trong mat na tai vi tri i j
                            Color pixel = hinhgoc.GetPixel(i, j);

                            byte R = pixel.R; // gia tri kenh RED, moi kenh mau bieu dien boi 8 bit
                            byte G = pixel.G; // gia tri kenh GREEN
                            byte B = pixel.B; // gia tri kenh BLUE

                            //Nhân tích chập 2 ma trận
                            Rs += R * matrix[i - (x - 1), j - (y - 1)];
                            Gs += G * matrix[i - (x - 1), j - (y - 1)];
                            Gs += B * matrix[i - (x - 1), j - (y - 1)];

                        }
                    //Lay thong tin mau RGB tai diem anh trong mat na tiaj vi tri i j
                    Color pixels = hinhgoc.GetPixel(x, y);

                    int Rxy = pixels.R; // gia tri kenh RED, moi kenh mau bieu dien boi 8 bit
                    int Gxy = pixels.G; // gia tri kenh GREEN
                    int Bxy = pixels.B; // gia tri kenh BLUE

                    Rg = Rxy + (1) * Rs;
                    Gg = Gxy + (1) * Gs;
                    Bg = Bxy + (1) * Bs;

                    if (Rg < 0)
                        Rg = 0;
                    else if (Rg > 255)
                        Rg = 255;
                    if (Gg < 0)
                        Gg = 0;
                    else if (Gg > 255)
                        Gg = 255;
                    if (Bg < 0)
                        Bg = 0;
                    else if (Bg > 255)
                        Bg = 255;

                    Image_Sharpening.SetPixel(x, y, Color.FromArgb(Rg, Gg, Bg));
                }
            return Image_Sharpening;
        }


    }
}
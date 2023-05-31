import cv2  # sử dụng thư viện xử lí ảnh OpenCV cho python
import numpy as np
from PIL import Image

#Khai báo đường dẫn file hình
filehinh = r"Lena.jpg"

#Đọc ảnh màu dùng thư viện OpenCV
img= cv2.imread(filehinh, cv2.IMREAD_COLOR)

#Đọc ảnh màu dùng thư viện PIL
# Ảnh PIL dùng để tính toán còn OpenCV chỉ dùng để hiển thị
imgPIL = Image.open(filehinh)

#Hàm làm mượt ảnh với mặt nạ 3x3
def ColorImageSharpening(imgPIL):
    # Lấy kích thước và mode của ảnh
    size = imgPIL.size
    mode = imgPIL.mode

    # Tạo một ảnh có cùng kích thước và mode với ảnh PIL
    SharpeningImage = Image.new(mode, size)

    # Lấy kích thước của ảnh imgPIL
    width = imgPIL.size[0]
    height = imgPIL.size[1]

    for x in range(1,width-1):
        for y in range(1,height-1):
            Rs=0
            Gs=0
            Bs=0
            As=0
            Rg=0
            Gg=0
            Bg=0

            matrix=[[0, -1, 0], [-1, 4, -1], [0, -1, 0]]
            for i in range(x-1,x+2):
                for j in range(y-1,y+2):
                    # Lấy giá trị điểm ảnh tại vị trí (x,y)
                    R, G, B = imgPIL.getpixel((i,j))
                    Rs += R*matrix[i - (x - 1)][ j - (y - 1)]
                    Gs += G*matrix[i - (x - 1)][ j - (y - 1)]
                    Bs += B*matrix[i - (x - 1)][ j - (y - 1)]
            Rxy, Gxy, Bxy = imgPIL.getpixel((x, y))
            Rg = Rxy + (1) * Rs
            Gg = Gxy + (1) * Gs
            Bg = Bxy + (1) * Bs

            # Kết thúc quét và tính trung bình các điểm ảnh xung quanh điểm ảnh đang xét
            # ép kiểu giá trị về kiểu uint8
            if (Rg < 0):
                Rg = 0
            elif (Rg > 255):
                Rg = 255
            if (Gg < 0):
                Gg = 0
            elif (Gg > 255):
                Gg = 255
            if (Bg < 0):
                Bg = 0
            elif (Bg > 255):
                Bg = 255

            # ép kiểu giá trị về kiểu uint8
            Rg = np.uint8(Rg)
            Gg = np.uint8(Gg)
            Bg = np.uint8(Bg)
            # Gán giá trị màu vừa tính cho ảnh Smooth_image
            SharpeningImage.putpixel((x, y), (Rg, Gg, Bg))
    return SharpeningImage

#Hàm làm mượt ảnh với mặt nạ 3x3

#Gọi hàm chuyển đổi ảnh RGB sang HSV
SharpeningImage =ColorImageSharpening(imgPIL)


# Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
SharpeningImage = np.array(SharpeningImage)

# Vì thứ tự các kênh màu trong PIL
# và openCV khác nhau nên cần dùng hàm để chuyển lại đúng thứ tự
SharpeningImage= cv2.cvtColor(np.array(SharpeningImage), cv2.COLOR_RGB2BGR)

#Hiển thị ảnh bằng OpenCV
cv2.imshow('ANH DA LAM NET:', SharpeningImage)
cv2.imshow('HINH GOC:', img)
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()

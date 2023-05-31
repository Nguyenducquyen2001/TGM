import cv2
from PIL import Image
import numpy as np
import math


#Khai báo đường dẫn file hình
filehinh = r"lena.jpg"

#Đọc ảnh màu dùng thư viện OpenCV
img= cv2.imread(filehinh, cv2.IMREAD_COLOR)

#Đọc ảnh màu dùng thư viện PIL
# Ảnh PIL dùng để tính toán còn OpenCV chỉ dùng để hiển thị
imgPIL = Image.open(filehinh)

def RGBToGrayByLuminance():
    # Tạo một ảnh có cùng kích thước và mode với ảnh PIL
    # Ảnh này dùng để chứa kết quả chuyển đổi RGB sang GrayScale
    Luminance = Image.new(imgPIL.mode, imgPIL.size)

    # Lấy kích thước của ảnh imgPIL
    width = Luminance.size[0]
    height = Luminance.size[1]

    # Mỗi ảnh là một ma trận 2 chiều nên sẽ dùng 2 vòng for để
    # đọc hết các điểm ảnh(pixel) có trong ảnh
    for x in range(width):
        for y in range(height):
            # Lấy giá trị điểm ảnh tại vị trí (x,y)
            R, G, B = imgPIL.getpixel((x, y))

            # Công thức chuyển đổi điểm ảnh màu RGB thành
            # Điểm ảnh mức xám dùng phương pháp Average
            gray = np.uint8(0.2126 * R + 0.7152 * G + 0.0722 * B)

            # Gán giá trị mức xám vừa tính cho ảnh xám
            Luminance.putpixel((x, y), (gray, gray, gray))
    return Luminance


#Hàm phân đoạn ảnh với mặt nạ 3x3
def EdgeDetection(imgPIL):
    # Lấy kích thước và mode của ảnh
    size = imgPIL.size
    mode = imgPIL.mode

    # Tạo một ảnh có cùng kích thước và mode với ảnh PIL
    Edge_Image = Image.new(mode, size)

    # Lấy kích thước của ảnh imgPIL
    width = imgPIL.size[0]
    height = imgPIL.size[1]
    nguong=130

    Sobelx = [[-1, -2, -1], [0, 0, 0], [1, 2, 1]]
    Sobely = [[-1, 0, 1], [-2, 0, 2], [-1, 0, 1]]

    for x in range(1,width-1):
        for y in range(1,height-1):
            gx = 0
            gy = 0
            for i in range(x - 1, x + 2):
                for j in range(y - 1, y + 2):
                    # Lấy giá trị điểm ảnh tại vị trí (x,y)
                    Gray,Gray,Gray = imgPIL.getpixel((i,j))

                    gx += Gray * Sobelx[i - (x - 1)][j - (y - 1)]
                    gy += Gray * Sobely[i - (x - 1)][j - (y - 1)]

            M = abs(gx) + abs(gy)
            if M < nguong:
                edge = 0
            else:
                edge = 255
            # ép kiểu giá trị về kiểu uint8
            edge = np.uint8(edge)

            # Gán giá trị màu vừa tính cho ảnh Smooth_image
            Edge_Image.putpixel((x, y), (edge, edge, edge))
    return Edge_Image


#Gọi hàm chuyển đổi ảnh RGB sang HSV
Gray_Image = RGBToGrayByLuminance()

Edge_Image = EdgeDetection(Gray_Image)
Edge_Image= np.array(Edge_Image)

#Hiển thị ảnh bằng OpenCV
cv2.imshow('ANH DA NHAN DIEN BIEN,NGUONG=130):', Edge_Image)
cv2.imshow('HINH GOC:', img)
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()
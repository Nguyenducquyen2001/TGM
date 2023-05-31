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
        gxx = gyy = gxy = gxR = gxG = gxB = gyR = gyG = gyB = 0
        for i in range(x - 1, x + 2):
            for j in range(y - 1, y + 2):
                # Lấy giá trị điểm ảnh tại vị trí (x,y)
                gR, gG, gB = imgPIL.getpixel((i, j))

                gxR += gR * Sobelx[i - (x - 1)][j - (y - 1)]
                gyR += gR * Sobely[i - (x - 1)][j - (y - 1)]
                gxG += gG * Sobelx[i - (x - 1)][j - (y - 1)]
                gyG += gG * Sobely[i - (x - 1)][j - (y - 1)]
                gxB += gB * Sobelx[i - (x - 1)][j - (y - 1)]
                gyB += gB * Sobely[i - (x - 1)][j - (y - 1)]
        gxx = np.abs(gxR) ** 2 + np.abs(gxG) ** 2 + np.abs(gxB) ** 2
        gyy = np.abs(gyR) ** 2 + np.abs(gyG) ** 2 + np.abs(gyB) ** 2
        gxy = (gxR) * (gyR) + (gxG) * (gyG) + (gxB) * (gyB)
        theta = 0.5 * np.arctan2((2 * gxy), (gxx - gyy))
        F0 = np.sqrt(0.5 * ((gxx + gyy) + (gxx - gyy) * (np.cos(2 * theta)) + 2 * gxy * np.sin(2 * theta)))

        if F0 < nguong:
            edge = 0
        else:
            edge = 255
        # ép kiểu giá trị về kiểu uint8
        edge = np.uint8(edge)

        # Gán giá trị màu vừa tính cho ảnh Smooth_image
        Edge_Image.putpixel((x, y), (edge, edge, edge))



#Gọi hàm chuyển đổi ảnh RGB sang HSV

Edge_Image= np.array(Edge_Image)

#Hiển thị ảnh bằng OpenCV
cv2.imshow('ANH DA NHAN DIEN BIEN,NGUONG=130):', Edge_Image)
cv2.imshow('HINH GOC:', img)
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()
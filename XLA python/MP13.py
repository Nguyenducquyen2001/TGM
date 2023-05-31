import cv2  # sử dụng thư viện xử lí ảnh OpenCV cho python
import numpy as np
from PIL import Image
import math

#Khai báo đường dẫn file hình
filehinh = r"Lena.jpg"

#Đọc ảnh màu dùng thư viện OpenCV
img= cv2.imread(filehinh, cv2.IMREAD_COLOR)

#Đọc ảnh màu dùng thư viện PIL
# Ảnh PIL dùng để tính toán còn OpenCV chỉ dùng để hiển thị
imgPIL = Image.open(filehinh)

def VectorA(imgPIL,x1,y1,x2,y2):
    a=[0,0,0]
    for x in range(x1,x2+1):
        for y in range(y1,y2+1):
            # Lấy giá trị điểm ảnh tại vị trí (x,y)
            R, G, B  = imgPIL.getpixel((x, y))
            a[0] += R
            a[1] += G
            a[2] += B
    size = abs(x2-x1)* abs(y2-y1)
    a[0] /= size
    a[1] /= size
    a[2] /= size
    print(a[0])
    return a

#Hàm làm mượt ảnh với mặt nạ 3x3
def Segmentation(imgPIL):
    # Lấy kích thước và mode của ảnh
    size = imgPIL.size
    mode = imgPIL.mode

    # Tạo một ảnh có cùng kích thước và mode với ảnh PIL
    SegmentImage = Image.new(mode, size)

    # Lấy kích thước của ảnh imgPIL
    width = imgPIL.size[0]
    height = imgPIL.size[1]

    nguong=45
    x1=80
    y1=400
    x2=150
    y2=500
    a= VectorA(imgPIL,x1,y1,x2,y2)
    for x in range(0,width):
        for y in range(0,height):
            # Lấy giá trị điểm ảnh tại vị trí (x,y)
            zR, zG, zB = imgPIL.getpixel((x,y))

            D = math.sqrt((zR - a[0])**2 + (zG - a[1])**2 + (zB - a[2])**2)

            if D <= nguong:
                zR = 255
                zG = 255
                zB = 255
            # ép kiểu giá trị về kiểu uint8
            zR = np.uint8(zR)
            zG = np.uint8(zG)
            zB = np.uint8(zB)
            # Gán giá trị màu vừa tính cho ảnh Smooth_image
            SegmentImage.putpixel((x, y), (zR, zG, zB))
    return SegmentImage

#Gọi hàm chuyển đổi ảnh RGB sang HSV
SegmentImage =Segmentation(imgPIL)


# Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
SegmentImage = np.array(SegmentImage)

# Vì thứ tự các kênh màu trong PIL
# và openCV khác nhau nên cần dùng hàm để chuyển lại đúng thứ tự
SegmentImage= cv2.cvtColor(np.array(SegmentImage), cv2.COLOR_RGB2BGR)

#Hiển thị ảnh bằng OpenCV
cv2.imshow('ANH DA PHAN DOAN(X1=80,Y1=400,X2=150,Y2=500,NGUONG=45):', SegmentImage)
cv2.imshow('HINH GOC:', img)
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()
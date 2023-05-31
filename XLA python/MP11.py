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
def Smooth_image_3x3(imgPIL):
    # Lấy kích thước và mode của ảnh
    size = imgPIL.size
    mode = imgPIL.mode

    # Tạo một ảnh có cùng kích thước và mode với ảnh PIL
    Smooth_image = Image.new(mode, size)

    # Lấy kích thước của ảnh imgPIL
    width = imgPIL.size[0]
    height = imgPIL.size[1]

    for x in range(1,width-1):
        for y in range(1,height-1):
            Rs=0
            Gs=0
            Bs=0
            for i in range(x-1,x+2):
                for j in range(y-1,y+2):
                    # Lấy giá trị điểm ảnh tại vị trí (x,y)
                    R, G, B= imgPIL.getpixel((i,j))
                    Rs += R
                    Gs += G
                    Bs += B
            # Kết thúc quét và tính trung bình các điểm ảnh xung quanh điểm ảnh đang xét
            # ép kiểu giá trị về kiểu uint8
            K = 3 * 3;
            Rs = np.uint8(Rs / K)
            Gs = np.uint8(Gs / K)
            Bs = np.uint8(Bs / K)

            # Gán giá trị màu vừa tính cho ảnh Smooth_image
            Smooth_image.putpixel((x, y), (Rs, Gs, Bs))
    return Smooth_image

#Hàm làm mượt ảnh với mặt nạ 3x3
def Smooth_image_5x5(imgPIL):
    # Lấy kích thước và mode của ảnh
    size = imgPIL.size
    mode = imgPIL.mode

    # Tạo một ảnh có cùng kích thước và mode với ảnh PIL
    Smooth_image = Image.new(mode, size)

    # Lấy kích thước của ảnh imgPIL
    width = imgPIL.size[0]
    height = imgPIL.size[1]

    for x in range(2,width-2):
        for y in range(2,height-2):
            Rs=0
            Gs=0
            Bs=0
            for i in range(x-2,x+3):
                for j in range(y-2,y+3):
                    # Lấy giá trị điểm ảnh tại vị trí (x,y)
                    R, G, B = imgPIL.getpixel((i,j))
                    Rs += R
                    Gs += G
                    Bs += B
            # Kết thúc quét và tính trung bình các điểm ảnh xung quanh điểm ảnh đang xét
            # ép kiểu giá trị về kiểu uint8
            K = 5 * 5;
            Rs = np.uint8(Rs / K)
            Gs = np.uint8(Gs / K)
            Bs = np.uint8(Bs / K)

            # Gán giá trị màu vừa tính cho ảnh Smooth_image
            Smooth_image.putpixel((x, y), (Rs, Gs, Bs))
    return Smooth_image

#Hàm làm mượt ảnh với mặt nạ 3x3
def Smooth_image_7x7(imgPIL):
    # Lấy kích thước và mode của ảnh
    size = imgPIL.size
    mode = imgPIL.mode

    # Tạo một ảnh có cùng kích thước và mode với ảnh PIL
    Smooth_image = Image.new(mode, size)

    # Lấy kích thước của ảnh imgPIL
    width = imgPIL.size[0]
    height = imgPIL.size[1]

    for x in range(3,width-3):
        for y in range(3,height-3):
            Rs=0
            Gs=0
            Bs=0
            for i in range(x-3,x+4):
                for j in range(y-3,y+4):
                    # Lấy giá trị điểm ảnh tại vị trí (x,y)
                    R, G, B = imgPIL.getpixel((i,j))
                    Rs += R
                    Gs += G
                    Bs += B
            # Kết thúc quét và tính trung bình các điểm ảnh xung quanh điểm ảnh đang xét
            # ép kiểu giá trị về kiểu uint8
            K = 7 * 7;
            Rs = np.uint8(Rs / K)
            Gs = np.uint8(Gs / K)
            Bs = np.uint8(Bs / K)

            # Gán giá trị màu vừa tính cho ảnh Smooth_image
            Smooth_image.putpixel((x, y), (Rs, Gs, Bs))
    return Smooth_image

#Hàm làm mượt ảnh với mặt nạ 3x3
def Smooth_image_9x9(imgPIL):
    # Lấy kích thước và mode của ảnh
    size = imgPIL.size
    mode = imgPIL.mode

    # Tạo một ảnh có cùng kích thước và mode với ảnh PIL
    Smooth_image = Image.new(mode, size)

    # Lấy kích thước của ảnh imgPIL
    width = imgPIL.size[0]
    height = imgPIL.size[1]

    for x in range(4,width-4):
        for y in range(4,height-4):
            Rs=0
            Gs=0
            Bs=0
            for i in range(x-4,x+5):
                for j in range(y-4,y+5):
                    # Lấy giá trị điểm ảnh tại vị trí (x,y)
                    R, G, B= imgPIL.getpixel((i,j))
                    Rs += R
                    Gs += G
                    Bs += B
            # Kết thúc quét và tính trung bình các điểm ảnh xung quanh điểm ảnh đang xét
            # ép kiểu giá trị về kiểu uint8
            K = 9 * 9;
            Rs = np.uint8(Rs / K)
            Gs = np.uint8(Gs / K)
            Bs = np.uint8(Bs / K)

            # Gán giá trị màu vừa tính cho ảnh Smooth_image
            Smooth_image.putpixel((x, y), (Rs, Gs, Bs))
    return Smooth_image

#Gọi hàm chuyển đổi ảnh RGB sang HSV
Smooth_image3x3 =Smooth_image_3x3(imgPIL)
Smooth_image5x5 =Smooth_image_5x5(imgPIL)
Smooth_image7x7 =Smooth_image_7x7(imgPIL)
Smooth_image9x9 =Smooth_image_9x9(imgPIL)

# Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
Smooth_image3x3 = np.array(Smooth_image3x3)
Smooth_image5x5 = np.array(Smooth_image5x5)
Smooth_image7x7 = np.array(Smooth_image7x7)
Smooth_image9x9 = np.array(Smooth_image9x9)
# Vì thứ tự các kênh màu trong PIL
# và openCV khác nhau nên cần dùng hàm để chuyển lại đúng thứ tự
Smooth_image3x3= cv2.cvtColor(np.array(Smooth_image3x3), cv2.COLOR_RGB2BGR)
Smooth_image5x5= cv2.cvtColor(np.array(Smooth_image5x5), cv2.COLOR_RGB2BGR)
Smooth_image7x7= cv2.cvtColor(np.array(Smooth_image7x7), cv2.COLOR_RGB2BGR)
Smooth_image9x9= cv2.cvtColor(np.array(Smooth_image9x9), cv2.COLOR_RGB2BGR)

#Hiển thị ảnh bằng OpenCV
cv2.imshow('ANH LAM MUOT VOI MAT NA 3x3', Smooth_image3x3)
cv2.imshow('ANH LAM MUOT VOI MAT NA 5x5', Smooth_image5x5)
cv2.imshow('ANH LAM MUOT VOI MAT NA 7x7', Smooth_image7x7)
cv2.imshow('ANH LAM MUOT VOI MAT NA 9x9', Smooth_image9x9)
cv2.imshow('HINH GOC', img)
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()

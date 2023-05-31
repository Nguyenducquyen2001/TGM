import cv2              # Sử dụng thư viện xử lý ảnh OpenCV cho Python
from PIL import Image   # Thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh 
import numpy as np      # Thư viện toán học, đặc biệt là các tính toán ma trận

# Khai báo đường dẫn file hình
filehinh = r'Lena.jpg'
# Đọc ảnh màu dùng thư viện OpenCV
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)

# Đọc ảnh màu dùng thư viện PIL. Ảnh PIL này chúng ta sẽ dùng
# để thực hiện các tác vụ xử lý và tính toán thay vì dùng OpenCV
imgPIL = Image.open(filehinh)

#Tạo một ảnh có cùng kích thước và mode với ảnh imgPIL
#Ảnh này dùng để chứa kết quả chuyển đổi RGB sang grayScale
Cyan = Image.new(imgPIL.mode, imgPIL.size)
Magenta = Image.new(imgPIL.mode, imgPIL.size)
Yellow = Image.new(imgPIL.mode, imgPIL.size)
Black = Image.new(imgPIL.mode, imgPIL.size)

# Lấy kích thước ảnh
w = imgPIL.size[0]
h = imgPIL.size[1]

for x in range (w):
    for y in range(h):
    # Lấy giá trị điểm ảnh tại vị trí (x,y)
        R, G, B = imgPIL.getpixel((x, y))
        
        #Bây giờ sẽ tiến hành trộn các kênh màu cho ra các màu C-M-Y-K
        #Màu Cyan (xanh dương) là sự kết hợp giữa Green và Blue, nên set kênh Red = 0
        Cyan.putpixel((x,y),(B,G,0))
        #Màu Magenta (tím) là sự kết hợp giữa Red và Blue, nên set kênh Green = 0
        Magenta.putpixel((x,y),(B,0,R))
        #Màu Yellow (vàng) là sự kết hợp giữa Red và Green, nên set kênh Blue = 0
        Yellow.putpixel((x,y),(0,G,R))
        #Màu Black (đen) là lấy Min (R,G,B)
        Min = min(R,G,B) # do hàm Min chỉ có hai số đối đầu vào nên phải thực hiện hai lần
        K = Min
        Black.putpixel((x,y),(K,K,K))
    
    
# Để hiển thị ảnh OpenCV ở đâu cũng hiển thị chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
anhC = np.array(Cyan)
anhM = np.array(Magenta)
anhY = np.array(Yellow)
anhB = np.array(Black)

#Hiển thị ảnh dùng thư viện OpenCV
cv2.imshow('Anh mau RGB goc co gai Lena', img)
cv2.imshow('Kenh Cyan', anhC)
cv2.imshow('Kenh Magenta', anhM)
cv2.imshow('Kenh Yellow', anhY)
cv2.imshow('Kenh Black', anhB)

# Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv2.waitKey(0)

#Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()
import streamlit as st
import cv2
import numpy as np
import keras
import matplotlib.pyplot as plt
from PIL import Image

def main():
    # Thêm CSS để tùy chỉnh màu nền
    st.markdown(
        """
        <style>
        
        .title-wrapper {
            display: flex;
            justify-content: center;
        }
        
        </style>
        """,
        unsafe_allow_html=True
    )

    # Chèn ảnh trong cùng một cột
    col1, col2, col3 = st.columns([1, 1, 5])

    with col1:
        # Điều chỉnh kích thước và căn chỉnh ảnh
        st.image("hcmute.png", width=100, use_column_width=False)

    with col2:
        st.image("khoa_ckm.png", width=80, use_column_width=False)

    with col3:
        
        # Thêm chữ vào cột thứ 3
        st.markdown("<p style='font-size: 24px'><b>TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT TP.HCM</b></p>", unsafe_allow_html=True)
        st.markdown("<p style='font-size: 24px'>KHOA CƠ KHÍ CHẾ TẠO MÁY </p>", unsafe_allow_html=True)
    st.divider()
    # Tiêu đề của ứng dụng
    st.markdown("<div class='title-wrapper'><h1>Nhận dạng bệnh ở heo</h1></div>", unsafe_allow_html=True)
   
    #load model file h5
    model = keras.models.load_model('best_model.h5')
    
    encode = {
        0: "bệnh đóng dấu ở lợn",
        1: "bệnh tai xanh ở heo",
        2: "heo khỏe mạnh",
        3: "lmlm",
        4: "tử huyết trùng",
        5: "viêm da tiết dịch"
    }
    
    # Upload file ảnh
    uploaded_file = st.file_uploader("Tải lên file ảnh", type=["jpg", "jpeg", "png"])

    # Kiểm tra xem người dùng đã tải lên file chưa
    if uploaded_file is not None:
        # Đọc ảnh đầu vào
        input_image = Image.open(uploaded_file).convert("L")

        # Resize ảnh
        img_size = 150
        input_image = input_image.resize((img_size, img_size))

        # Chuyển đổi thành mảng numpy và mở rộng số chiều
        input_image = np.array(input_image) / 255.0
        input_image = np.expand_dims(input_image, axis=-1)
        input_image = np.expand_dims(input_image, axis=0)

        # Đánh giá bệnh của ảnh
        predictions = model.predict(input_image)
        predicted_labels = np.argmax(predictions, axis=1)

        probabilities = predictions[0] * 100  # Chuyển đổi thành tỉ lệ phần trăm
        predicted_labels = predicted_labels[0]

        # Hiển thị ảnh trong Streamlit
        st.image(input_image.squeeze(), caption="Input Image", use_column_width=True)

        # In kết quả trong Streamlit
        st.subheader("Kết quả đánh giá bệnh")
        for label, probability in zip(encode.values(), probabilities):
            st.write(f"{label}: {probability:.2f}%")

    
    st.markdown("<div style='background-color: #f2f2f2; padding: 10px;'>"
                "<h2>GVHD:NGUYỄN VĂN THÁI</h2>"               
                "</div>", unsafe_allow_html=True) 
    st.markdown("<div style='background-color: #f2f2f2; padding: 10px;'>"
                "<h2>SINH VIÊN THỰC HIỆN</h2>"
                "<ul>"
                "<li>Nguyễn Đức Quyền-20146148</li>"
                "<li>Nguyễn Chí Lộc-20146504</li>"
                "<li>PHẠM THÀNH TOÀN </li>"
                "</ul>"
                "</div>", unsafe_allow_html=True)   
    st.markdown("""
        <div style='background-color: #f2f2f2; padding: 10px;'>
            <h2>THÔNG TIN PROJECT</h2>
            <ul>
                <li>drive: <a href='https://drive.google.com/drive/folders/11qjLydYeJjYra126YgaRkUMZSCd3wOld?usp=sharing' style='text-decoration: none; color: blue;'>tại đây</a></li>
                <li>github: <a href='https://github.com/Nguyenducquyen2001/TGM' style='text-decoration: none; color: blue;'>tại đây</a></li>
            </ul>
        </div>
    """, unsafe_allow_html=True) 
    
if __name__ == "__main__":
    main()


## 1. Thành Viên
| MSSV | Họ Tên |
| ------ | ------ |
| 2001215939 | Nguyễn Thành Luân|
| 2001215770 | Cao Hoàng Minh Hiếu |
| 2001215852 | Nguyễn Trí Khang |
## 2. Công nghệ sử dụng
- Dotnet
- SQL server
- Visual studio 2022
- LinQ
- JQuery
## 3. Chi tiết đề tài
#### 3.1. Sơ đồ tổng quan đề tài 
##### Sơ đồ tổng quan:
![image](https://github.com/user-attachments/assets/6215b218-b9c6-4b4a-83f5-b776173e6c4e)

##### Giao diện người dùng (Frontend):
- Trang chủ
- Danh mục sản phẩm
- Trang chi tiết sản phẩm
- Giỏ hàng
- Trang thanh toán
- Trang quản lý tài khoản người dùng
##### Hệ thống máy chủ (Backend):
- Quản lý cơ sở dữ liệu sản phẩm
- Quản lý đơn hàng
- Xử lý thanh toán
- Quản lý người dùng và quyền truy cập
- Giao diện lập trình ứng dụng (API)
##### Cơ sở dữ liệu:
- Thông tin sản phẩm
- Thông tin người dùng
- Lịch sử đơn hàng
- Thông tin thanh toán
## 4. Triển khai dự án 
#### 4.1. Mô tả tổng quan
Dự án xây dựng một hệ thống bán hàng trực tuyến cho thiết bị điện tử nhằm cung cấp một nền tảng hiệu quả để khách hàng có thể tìm kiếm, lựa chọn và mua sắm các sản phẩm điện tử. Hệ thống sẽ bao gồm một giao diện người dùng dễ sử dụng, cho phép người dùng duyệt các danh mục sản phẩm, xem chi tiết sản phẩm, thêm sản phẩm vào giỏ hàng và thực hiện thanh toán một cách an toàn. Phần backend của hệ thống sẽ xử lý các yêu cầu từ giao diện người dùng, quản lý cơ sở dữ liệu và đảm bảo tính bảo mật của thông tin người dùng.
#### 4.2 Yêu cầu chức năng, thành phần
##### 4.2.1 Yêu cầu chức năng
###### Website
- Đăng ký và đăng nhập người
- Xem, tím kiếm sản phẩm
- Đặt hàng, huỷ đặt hàng
- Thanh toán
- Đánh giá, nhận xét sản phẩm
###### Application
- Quản lý đơn hàng
- Quản lý sản phẩm
- Quản lý danh mục sản phẩm và thông tin chi tiết sản phẩm.
- Quản ký người dùng
- Quản lý nhà cung cấp
- Quản lý thanh toán
###### AI: phân cụm khách hàng theo tuổi và loại hàng mua (kmean).
##### 4.2.2 Yêu cầu thành phần
###### Giao diện người dùng (Frontend):
Trang web tương thích với các trình duyệt phổ biến (Chrome, Firefox, Safari).
Thiết kế responsive để hoạt động trên các thiết bị di động và máy tính bảng.
Winform để quản lý tiện lợi
###### Hệ thống máy chủ (Backend):
Server xử lý yêu cầu từ frontend và giao tiếp với cơ sở dữ liệu.
###### Cơ sở dữ liệu:
Cơ sở dữ liệu quan hệ để lưu trữ thông tin sản phẩm, người dùng và đơn hàng.

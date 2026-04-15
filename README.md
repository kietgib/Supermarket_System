# 🛒 Supermarket Management System (WinForms)

Dự án quản lý siêu thị được xây dựng trên nền tảng **C# Windows Forms**, sử dụng kiến trúc **3 lớp (3-Layer Architecture)** để đảm bảo tính module hóa và dễ bảo trì.

---

## 🏗️ Kiến trúc Dự án (Architecture)

Dự án được tổ chức thành các tầng riêng biệt để tách lời logic nghiệp vụ khỏi giao diện và dữ liệu:

* **DataLayer (DAL):** Quản lý kết nối SQL Server thông qua class `DataAccessLayer`, thực thi các truy vấn SQL trực tiếp.
* **BussinessLogicLayer (BLL):** Chứa các logic kiểm tra dữ liệu và kết nối các bảng. Sử dụng một lớp `BaseBusinessLogic<T>` làm khung xương cho các thực thể.
* **Entities:** Định nghĩa các lớp đối tượng như `Employee`, `Customer`, `Product`, `Order`.
* **GUI (Presentation Layer):** Giao diện người dùng với các Form chức năng riêng biệt.

```

GUI
│   AdminForm.cs
│   CustomerForm.cs
│   LogInForm.cs
│   MainForm.cs
│
└───ManagementForms
│        CustomersForm.cs
│        OrderDetailsForm.cs
│        OrdersForm.cs
│        ProductsForm.cs
│        StaffForm.cs
│
BussinessLogicLayer
│   BaseBusinessLayer.cs
│
├───BLL
│       CustomersBLL.cs
│       OrderBLL.cs
│       OrderDetailsBLL.cs
│       ProductBLL.cs
│       StaffBLL.cs
│
└───Entities
│       Customers.cs
│       Order.cs
│       OrderDetails.cs
│       Product.cs
│       Staff.cs
│
DataLayer
│   DataAccessLayer.cs
│
Images
│   porsche_911_turbo_03_by_uptownzombie31_dj84k3y.png
│
SQLdata
│   SupermarketDB.bak
```
---

## ✨ Chức năng chính

1.  **Quản lý Nhân viên (Staff):** Theo dõi thông tin cá nhân và vị trí công tác.
2.  **Quản lý Khách hàng (Customer):** Lưu trữ thông tin liên lạc và địa chỉ khách hàng.
3.  **Quản lý Sản phẩm (Product):** Cập nhật giá cả, danh mục và số lượng tồn kho.
4.  **Hệ thống Hóa đơn (Orders):**
    * Lập hóa đơn mới và lưu trữ lịch sử giao dịch.
    * **Tự động hóa:** Khi thêm chi tiết hóa đơn, hệ thống tự động trừ số lượng tồn kho trong bảng Sản phẩm.

---

## 🛠️ Công nghệ & Công cụ

* **Ngôn ngữ:** C# (.NET Framework).
* **IDE:** Visual Studio 2022.
* **Cơ sở dữ liệu:** SQL Server (sử dụng thư viện `System.Data.SqlClient`).
* **Quản lý mã nguồn:** Git/GitHub.

---

## 🚀 Hướng dẫn Cài đặt

1. ## 🗄️ Database Setup
   * Để sử dụng cơ sở dữ liệu của dự án này, vui lòng thực hiện:
   * Mở file `SupermarketDB.sql` đính kèm trong thư mục `SQLData`.
   * Mở **SQL Server Management Studio**.
   * Copy toàn bộ nội dung file và chạy lệnh **Execute** (F5).
2.  **Thiết lập Kết nối:**
    * Mở file `DataAccessLayer.cs`.
    * Sửa đổi chuỗi `ConnStr` để khớp với Server của bạn:
    ```csharp
    string ConnStr = "Data Source=YOUR_SERVER_NAME;Initial Catalog=SupermarketDB;Integrated Security=True";
    ```
3.  **Chạy ứng dụng:** Nhấn `F5` trong Visual Studio để bắt đầu.
4.  **Username và Password để login tạm thời:** username: admin, password: 123

---

## 👤 Thông tin Tác giả

* **Sinh viên thực hiện:** Tran Gia Kiet, Mai Viet Thanh
* **Đơn vị:** Đại học Công nghệ Kỹ thuật TP.HCM (HCMUTE).
* **Chuyên ngành:** Công nghệ thông tin.

---

Tình trạng hiện tại đã code xong tương tác GUI với các button trong Customer và 1 phần của Orderdetails, các nội dung khi thêm sửa sẽ ảnh hưởng đến bảng khác, ngoài ra các chức năng setting cũng đã hoàn chỉnh setting màu cho panel... 

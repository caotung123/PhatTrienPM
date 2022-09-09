DROP DATABASE [QL_THIETBITH]
CREATE DATABASE [QL_THIETBITH]
go
USE [QL_THIETBITH]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 6/3/2022 11:46:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [int] IDENTITY(1,1) NOT NULL,
	[TENNV] [nvarchar](50) NULL,
	[NGAYSINH] [date] NULL,
	[GIOITINH] [nvarchar](4) NULL,
	[SDT] [nvarchar](15) NULL,
	[DIACHI] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 6/3/2022 11:46:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [int] IDENTITY(1,1) NOT NULL,
	[TENKH] [nvarchar](50) NULL,
	[NGAYSINH] [date] NULL,
	[GIOITINH] [nvarchar](4) NULL,
	[SDT] [nvarchar](15) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[TaiKhoan] [nvarchar](100) null,
	[MatKhau] [nvarchar](100) null,
PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAITB]    Script Date: 6/3/2022 11:46:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAITB](
	[MALOAI] [int] IDENTITY(1,1) NOT NULL,
	[TENLOAI] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THIETBI]    Script Date: 6/3/2022 11:46:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THIETBI](
	[MATB] [int] IDENTITY(1,1) NOT NULL,
	[TENTB] [nvarchar](1000) NULL,
	[HINHANH] [nvarchar](150) NULL,
	[GIA] [int] NULL,
	[SOLUONG] [int] NULL,
	[MOTA] [nvarchar](1000) NULL,
	[MALOAI] [int] NULL,
	[MANCC] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MATB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COSO]    Script Date: 6/3/2022 11:46:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COSO](
	[MACS] [int] IDENTITY(1,1) NOT NULL,
	[TENCS] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](150) NULL,
 CONSTRAINT [PK_COSO] PRIMARY KEY CLUSTERED 
(
	[MACS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACC]    Script Date: 6/3/2022 11:46:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACC](
	[MANCC] [int] IDENTITY(1,1) NOT NULL,
	[TENNCC] [nvarchar](100) NULL,
	[SDT] [nvarchar](15) NULL,
	[DIACHI] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DONNHAP]    Script Date: 6/3/2022 11:46:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONNHAP](
	[MADN] [int] IDENTITY(1,1) NOT NULL,
	[MANV] [int] NULL,
	[MANCC] [int] NULL,
	[NGAYLAP] [date] NULL,
	[TONGTIEN] [money] NULL,
	[MACS] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MADN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTDONHAP]    Script Date: 6/3/2022 11:46:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDONHAP](
	[MADN] [int] NOT NULL,
	[MATB] [int] NOT NULL,
	[SOLUONG] [int] NULL,
	[GIANHAP] [money] NULL,
	[THANHTIEN] [money] NULL,
 CONSTRAINT [PK_CHITIETDN] PRIMARY KEY CLUSTERED 
(
	[MADN] ASC,
	[MATB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[DONHANG]    Script Date: 6/3/2022 11:46:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONHANG](
	[MADH] [int] IDENTITY(1,1) NOT NULL,
	[MAKH] [int] NULL,
	[MANV] [int] NULL,
	[NGAYLAP] [date] NULL,
	[TONGTIEN] [money] NULL,
	[HINHTHUCTT] [nvarchar](50) NULL,
	[TINHTRANG] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MADH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTDONHANG]    Script Date: 6/3/2022 11:46:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDONHANG](
	[MADH] [int] NOT NULL,
	[MATB] [int] NOT NULL,
	[SOLUONG] [int] NULL,
	[GIABAN] [money] NULL,
	[THANHTIEN] [money] NULL,
 CONSTRAINT [PK_CHITIETDH] PRIMARY KEY CLUSTERED 
(
	[MADH] ASC,
	[MATB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOANG]    Script Date: 6/3/2022 11:46:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOANG](
	[TENTK] nchar(36) ,
	[MATKHAU] nchar(36),
	[MANV] int
	CONSTRAINT PK_TAIKHOANG PRIMARY KEY (TENTK)	
) 
GO

CREATE TABLE DMMANGHINH
(
	MADM INT IDENTITY (1,1) ,
	TENMH NVARCHAR(30),	
	CHON BIT,
	MANV INT
	CONSTRAINT PK_DMMANGHINH PRIMARY KEY (MADM)	,
	CONSTRAINT FK_DMMANGHINH_TAIKHOANG FOREIGN KEY (MANV)
	REFERENCES NHANVIEN (MANV)
)
--THÊM ĐỮ LIỆU
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [GIOITINH], [SDT], [DIACHI]) VALUES (1, N'Văn Hường', CAST(N'2001-01-16' AS Date), N'Nam', N'0999999999', N'Tây Ninh')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [GIOITINH], [SDT], [DIACHI]) VALUES (2, N'Nguyên Khang', CAST(N'2000-04-22' AS Date), N'Nữ', N'0911911911', N'Bến Tre')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [GIOITINH], [SDT], [DIACHI]) VALUES (3, N'Trần Cao Tùng', CAST(N'2001-10-15' AS Date), N'Nam', N'0368686868', N'Quảng Ngãi')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [GIOITINH], [SDT], [DIACHI]) VALUES (4, N'Nguyễn Đắc Đạt', CAST(N'2001-06-26' AS Date), N'Nam', N'039696969', N'Phú Yên')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [GIOITINH], [SDT], [DIACHI]) VALUES (5, N'Nguyễn Cao Gà', CAST(N'2001-06-26' AS Date), N'Nam', N'feưefdwe', N'ưdfwf')
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
GO
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [NGAYSINH], [GIOITINH], [SDT], [DIACHI],[TaiKhoan],[MatKhau]) VALUES (1, N'Nguyễn Nguyên Bảo', CAST(N'2001-02-22' AS Date), N'Nam', N'08329023', N'TPHCM','nguyendacdat','123')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [NGAYSINH], [GIOITINH], [SDT], [DIACHI],[TaiKhoan],[MatKhau]) VALUES (2, N'Nguyễn Thanh Loan', CAST(N'2001-02-22' AS Date), N'Nữ', N'083294533', N'Hà Nội','tung','123')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [NGAYSINH], [GIOITINH], [SDT], [DIACHI],[TaiKhoan],[MatKhau]) VALUES (3, N'Nguyễn Thanh Bình', CAST(N'2001-02-22' AS Date), N'Nữ', N'083294533', N'Hà Nội','dacdat','123')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [NGAYSINH], [GIOITINH], [SDT], [DIACHI],[TaiKhoan],[MatKhau]) VALUES (4, N'Trần Cao Tùng', CAST(N'2001-02-22' AS Date), N'Nam', N'083294533', N'Hà Nội','dacdat','123')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [NGAYSINH], [GIOITINH], [SDT], [DIACHI],[TaiKhoan],[MatKhau]) VALUES (5, N'Nguyễn Đắc Đạt', CAST(N'2001-02-22' AS Date), N'Nữ', N'083294533', N'Hà Nội','dacdat','123')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [NGAYSINH], [GIOITINH], [SDT], [DIACHI],[TaiKhoan],[MatKhau]) VALUES (6, N'Lý Thị Hồng Thương', CAST(N'2001-02-22' AS Date), N'Nữ', N'083294533', N'Hà Nội','dacdat','123')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [NGAYSINH], [GIOITINH], [SDT], [DIACHI],[TaiKhoan],[MatKhau]) VALUES (7, N'Nguyễn Hùng Cường', CAST(N'2001-02-22' AS Date), N'Nam', N'083294533', N'Hà Nội','dacdat','123')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [NGAYSINH], [GIOITINH], [SDT], [DIACHI],[TaiKhoan],[MatKhau]) VALUES (8, N'Nguyễn Tuấn Đạt', CAST(N'2001-02-22' AS Date), N'Nam', N'083294533', N'Hà Nội','dacdat','123')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [NGAYSINH], [GIOITINH], [SDT], [DIACHI],[TaiKhoan],[MatKhau]) VALUES (9, N'Bùi Thị Ái Ly', CAST(N'2001-02-22' AS Date), N'Nữ', N'083294533', N'Hà Nội','dacdat','123')
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
GO
SET IDENTITY_INSERT [dbo].[LOAITB] ON 

INSERT [dbo].[LOAITB] ([MALOAI], [TENLOAI]) VALUES (1, N'ÐIỆN THOẠI')
INSERT [dbo].[LOAITB] ([MALOAI], [TENLOAI]) VALUES (2, N'LAPTOP')
INSERT [dbo].[LOAITB] ([MALOAI], [TENLOAI]) VALUES (3, N'TIVI')
INSERT [dbo].[LOAITB] ([MALOAI], [TENLOAI]) VALUES (4, N'MÁY GIẶT')
INSERT [dbo].[LOAITB] ([MALOAI], [TENLOAI]) VALUES (5, N'TỦ LẠNH')
INSERT [dbo].[LOAITB] ([MALOAI], [TENLOAI]) VALUES (6, N'PHỤ KIỆN')
SET IDENTITY_INSERT [dbo].[LOAITB] OFF
SET IDENTITY_INSERT [dbo].[COSO] ON 

INSERT [dbo].[COSO] ([MACS], [TENCS], [SDT], [DIACHI]) VALUES (1, N'SHOWROOM TÂN BÌNH', N'0899 000 001', N'384/8 Cộng Hòa, P.13, Q Tân Bình, TP.HCM')
INSERT [dbo].[COSO] ([MACS], [TENCS], [SDT], [DIACHI]) VALUES (2, N'SHOWROOM QUẬN 11', N'0899 000 002', N' 344 Lãnh Binh Thăng, P.11, Q.11, TP.HCM')
INSERT [dbo].[COSO] ([MACS], [TENCS], [SDT], [DIACHI]) VALUES (3, N'SHOWROOM QUẬN 9', N'0899 000 003', N'180 Lê Văn Việt, P. Tăng Nhơn Phú B, Q. 9, TP.HCM')
INSERT [dbo].[COSO] ([MACS], [TENCS], [SDT], [DIACHI]) VALUES (4, N'SHOWROOM QUẬN BÌNH THẠNH', N'0899 000 004', N'474 Điện Biên Phủ, P. 17, Q. Bình Thạnh, TP.HCM')
SET IDENTITY_INSERT [dbo].[COSO] OFF
GO
SET IDENTITY_INSERT [dbo].[THIETBI] ON 

INSERT [dbo].[THIETBI] ([MATB], [TENTB], [HINHANH], [GIA], [SOLUONG], [MOTA], [MALOAI], [MANCC]) VALUES (1, N'Samsung Galaxy A52', N'hinh1.jpg', 9990000, 32, N'Chiếc điện thoại sở hữu màn hình Infinity-O đầy hiện đại, 
 4 máy ảnh mặt sau được sắp xếp gọn gàng bên trong mô-đun hình chữ nhật thân thuộc và
  các cạnh viền bo cong nhẹ nhàng, uyển chuyển quanh thân máy, tạo cảm giác dễ chịu khi cầm nắm sử dụng.', 1, 1)
INSERT [dbo].[THIETBI] ([MATB], [TENTB], [HINHANH], [GIA], [SOLUONG], [MOTA], [MALOAI], [MANCC]) VALUES (2, N'Laptop Acer Nitro 5 Gaming AN515 57 727J i7 11800H/8GB/512GB/4GB RTX3050Ti/144Hz/Win10 (NH.QD9SV.005.)', N'hinh2.jpg', 26990000, 31, N'Acer Nitro 
  Gaming được trang bị bộ vi xử lý Intel Core i7 Tiger Lake với cấu trúc 8 nhân 16 luồng có tốc độ đạt tối đa đến 4.6 GHz nhờ Turbo Boost cho máy
   hiệu năng mạnh mẽ chạy tốt các tựa game cấu hình cao, xử lý các tác vụ đồ họa chuyên nghiệp một cách trơn tru.
RAM 8 GB chuẩn DDR4 2 khe (1 khe 8 GB + 1 khe rời) cùng khả năng nâng cấp tối đa lên đến 32 GB xử lý đa nhiệm cùng 
lúc nhiều tác vụ, việc di chuyển qua lại giữa các phần mềm, chạy đồng thời các ứng dụng đồ họa mà không lo 
 tượng giật, lag.', 2, 1)
INSERT [dbo].[THIETBI] ([MATB], [TENTB], [HINHANH], [GIA], [SOLUONG], [MOTA], [MALOAI], [MANCC]) VALUES (3, N'Vsmart Star 3', N'hinh3.jpg', 1990000, 12, N'Chiếc điện thoại Vsmart Star 3 được trang bị bộ đôi camera kép ở mặt lưng bao gồm một 
 camera chính độ phân giải 8 MP và một camera góc siêu rộng 5 MP.', 1, 3)
INSERT [dbo].[THIETBI] ([MATB], [TENTB], [HINHANH], [GIA], [SOLUONG], [MOTA], [MALOAI], [MANCC]) VALUES (4, N'Ðiện thoại Vsmart Aris', N'hinh4.jpg', 3990000, 12, N'CPhần thiết kế của Vsmart Aris có độ hoàn thiện cao với phần khung
  viền kim loại và mặt lưng là một lớp kính phủ nhám tốt giúp chống bám mồ hôi, dấu vân tay hiệu quả.Mặt kính Corning Gorilla Glass 5 phủ hoàn 
  toàn trên bề mặt của thiết bị mang lại sự an toàn bền bỉ lẫn nét sang trọng, cao cấp cho máy.', 1, 3)
  INSERT [dbo].[THIETBI] ([MATB], [TENTB], [HINHANH], [GIA], [SOLUONG], [MOTA], [MALOAI], [MANCC]) VALUES (5, N'Ðiện thoại SamSung note 8', N'hinh5.jpg', 5990000, 12, N'Chiếc điện thoại Samsung trang bị cấu hình khung.', 1, 1)
  INSERT [dbo].[THIETBI] ([MATB], [TENTB], [HINHANH], [GIA], [SOLUONG], [MOTA], [MALOAI], [MANCC]) VALUES (6, N'DELL XPS 9575', N'hinh6.jpg', 9990000, 12, N'Laptop hiện đại nhất.', 2, 2)
  INSERT [dbo].[THIETBI] ([MATB], [TENTB], [HINHANH], [GIA], [SOLUONG], [MOTA], [MALOAI], [MANCC]) VALUES (7, N'Điên Thoại Xiaomi note 7', N'hinh7.jpg', 3990000, 12, N'Thiết kế tối ưu của xiaomi.', 1, 6)
  INSERT [dbo].[THIETBI] ([MATB], [TENTB], [HINHANH], [GIA], [SOLUONG], [MOTA], [MALOAI], [MANCC]) VALUES (8, N'Iphone 13', N'hinh8.jpg', 33990000, 12, N'Trang bị hệ sinh thái tốt nhất.', 1, 4)
  INSERT [dbo].[THIETBI] ([MATB], [TENTB], [HINHANH], [GIA], [SOLUONG], [MOTA], [MALOAI], [MANCC]) VALUES (9, N'Iphone 14', N'hinh9.jpg', 3990000, 12, N'Đang nằm trong dự kiến', 1, 4)
SET IDENTITY_INSERT [dbo].[THIETBI] OFF
GO
SET IDENTITY_INSERT [dbo].[NHACC] ON 

INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [SDT], [DIACHI]) VALUES (1, N'SAMSUNG', N'090987293', N'TPHCM')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [SDT], [DIACHI]) VALUES (2, N'ACER', N'0909879879', N'TPHCM')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [SDT], [DIACHI]) VALUES (3, N'VINSMART', N'09067879', N'Hà Nội')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [SDT], [DIACHI]) VALUES (4, N'IPHONE', N'09067879', N'TPHCM')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [SDT], [DIACHI]) VALUES (5, N'NOKIA', N'09067879', N'Bình Dương')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [SDT], [DIACHI]) VALUES (6, N'Xiaomi', N'09067879', N'Hà Nội')
SET IDENTITY_INSERT [dbo].[NHACC] OFF
GO
SET IDENTITY_INSERT [dbo].[DONNHAP] ON 
INSERT [dbo].[DONNHAP] ([MADN], [MANV], [MANCC], [NGAYLAP], [TONGTIEN], [MACS]) VALUES (1, 1, 5, CAST(N'2022-10-17' AS Date), 3000000.0000, NULL)
INSERT [dbo].[DONNHAP] ([MADN], [MANV], [MANCC], [NGAYLAP], [TONGTIEN], [MACS]) VALUES (2, 1, 6, CAST(N'2022-01-11' AS Date), 400000.0000, NULL)
INSERT [dbo].[DONNHAP] ([MADN], [MANV], [MANCC], [NGAYLAP], [TONGTIEN], [MACS]) VALUES (3, 2, 5, CAST(N'2022-09-26' AS Date), 3000000.0000, NULL)
INSERT [dbo].[DONNHAP] ([MADN], [MANV], [MANCC], [NGAYLAP], [TONGTIEN], [MACS]) VALUES (4, 1, 4, CAST(N'2022-08-27' AS Date), 3000000.0000, NULL)
INSERT [dbo].[DONNHAP] ([MADN], [MANV], [MANCC], [NGAYLAP], [TONGTIEN], [MACS]) VALUES (5, 2, 2, CAST(N'2022-04-15' AS Date), 400000.0000, NULL)
INSERT [dbo].[DONNHAP] ([MADN], [MANV], [MANCC], [NGAYLAP], [TONGTIEN], [MACS]) VALUES (6, 1, 5, CAST(N'2022-12-12' AS Date), 3000000.0000, NULL)
INSERT [dbo].[DONNHAP] ([MADN], [MANV], [MANCC], [NGAYLAP], [TONGTIEN], [MACS]) VALUES (7, 2, 7, CAST(N'2022-06-01' AS Date), 3000000.0000, NULL)
INSERT [dbo].[DONNHAP] ([MADN], [MANV], [MANCC], [NGAYLAP], [TONGTIEN], [MACS]) VALUES (8, 2, 7, CAST(N'2022-06-01' AS Date), 3000000.0000, NULL)
SET IDENTITY_INSERT [dbo].[DONNHAP] OFF
GO
GO	
INSERT [dbo].[CTDONHAP] ([MADN], [MATB], [SOLUONG], [GIANHAP], [THANHTIEN]) VALUES (1, 5, 15, 140000.0000, 3*140000.0000)
INSERT [dbo].[CTDONHAP] ([MADN], [MATB], [SOLUONG], [GIANHAP], [THANHTIEN]) VALUES (2, 3, 2, 110000.0000, 2*110000.0000)
INSERT [dbo].[CTDONHAP] ([MADN], [MATB], [SOLUONG], [GIANHAP], [THANHTIEN]) VALUES (3, 1, 7, 550000.0000, 7*550000.0000)
INSERT [dbo].[CTDONHAP] ([MADN], [MATB], [SOLUONG], [GIANHAP], [THANHTIEN]) VALUES (7, 2, 15, 150000.0000, 15*150000.0000)
INSERT [dbo].[CTDONHAP] ([MADN], [MATB], [SOLUONG], [GIANHAP], [THANHTIEN]) VALUES (6, 4, 5, 100000.0000, 5*100000.0000)
INSERT [dbo].[CTDONHAP] ([MADN], [MATB], [SOLUONG], [GIANHAP], [THANHTIEN]) VALUES (4, 6, 1, 2100000.0000, 1*2100000.0000)
INSERT [dbo].[CTDONHAP] ([MADN], [MATB], [SOLUONG], [GIANHAP], [THANHTIEN]) VALUES (8, 7, 5, 300000.0000, 5*300000.0000)
INSERT [dbo].[CTDONHAP] ([MADN], [MATB], [SOLUONG], [GIANHAP], [THANHTIEN]) VALUES (4, 8, 11, 750000.0000, 11*750000.0000)
GO
SET IDENTITY_INSERT [dbo].[DONHANG] ON 
INSERT [dbo].[DONHANG] ([MADH], [MAKH], [MANV], [NGAYLAP], [TONGTIEN], [HINHTHUCTT], [TINHTRANG]) VALUES (1, 1, 1, CAST(N'2022-04-01' AS Date), 12300000.0000, N'TRẢ GÓP', N'HOÀN THÀNH')
INSERT [dbo].[DONHANG] ([MADH], [MAKH], [MANV], [NGAYLAP], [TONGTIEN], [HINHTHUCTT], [TINHTRANG]) VALUES (2, 5, 3, CAST(N'2022-04-14' AS Date), 12300000.0000, N'ĐÃ THANH TOÁN', N'HOÀN THÀNH')
INSERT [dbo].[DONHANG] ([MADH], [MAKH], [MANV], [NGAYLAP], [TONGTIEN], [HINHTHUCTT], [TINHTRANG]) VALUES (3, 1, 2, CAST(N'2022-05-15' AS Date), 1200000.0000, N'ĐÃ THANH TOÁN', N'HOÀN THÀNH')
INSERT [dbo].[DONHANG] ([MADH], [MAKH], [MANV], [NGAYLAP], [TONGTIEN], [HINHTHUCTT], [TINHTRANG]) VALUES (4, 7, 1, CAST(N'2022-06-03' AS Date), 1200000.0000, N'ĐÃ THANH TOÁN', N'HOÀN THÀNH')
INSERT [dbo].[DONHANG] ([MADH], [MAKH], [MANV], [NGAYLAP], [TONGTIEN], [HINHTHUCTT], [TINHTRANG]) VALUES (5, 9, 5, CAST(N'2022-06-08' AS Date), 1200000.0000, N'ĐÃ THANH TOÁN', N'HOÀN THÀNH')
INSERT [dbo].[DONHANG] ([MADH], [MAKH], [MANV], [NGAYLAP], [TONGTIEN], [HINHTHUCTT], [TINHTRANG]) VALUES (6, 3, 1, CAST(N'2022-09-13' AS Date), 1200000.0000, N'ĐÃ THANH TOÁN', N'HOÀN THÀNH')
INSERT [dbo].[DONHANG] ([MADH], [MAKH], [MANV], [NGAYLAP], [TONGTIEN], [HINHTHUCTT], [TINHTRANG]) VALUES (7, 8, 4, CAST(N'2022-06-14' AS Date), 1200000.0000, N'ĐÃ THANH TOÁN', N'HOÀN THÀNH')
INSERT [dbo].[DONHANG] ([MADH], [MAKH], [MANV], [NGAYLAP], [TONGTIEN], [HINHTHUCTT], [TINHTRANG]) VALUES (8, 3, 1, CAST(N'2022-03-14' AS Date), 1200000.0000, N'ĐÃ THANH TOÁN', N'HOÀN THÀNH')
INSERT [dbo].[DONHANG] ([MADH], [MAKH], [MANV], [NGAYLAP], [TONGTIEN], [HINHTHUCTT], [TINHTRANG]) VALUES (9, 7, 3, CAST(N'2022-05-29' AS Date), 1200000.0000, N'ĐÃ THANH TOÁN', N'HOÀN THÀNH')
SET IDENTITY_INSERT [dbo].[DONHANG] OFF
GO	
INSERT [dbo].[CTDONHANG] ([MADH], [MATB], [SOLUONG], [GIABAN], [THANHTIEN]) VALUES (1, 5, 2, 100000.0000, 2*100000.0000)
INSERT [dbo].[CTDONHANG] ([MADH], [MATB], [SOLUONG], [GIABAN], [THANHTIEN]) VALUES (2, 1, 1, 200000.0000, 1*200000.0000)
INSERT [dbo].[CTDONHANG] ([MADH], [MATB], [SOLUONG], [GIABAN], [THANHTIEN]) VALUES (2, 2, 2, 300000.0000,2*300000.0000)
INSERT [dbo].[CTDONHANG] ([MADH], [MATB], [SOLUONG], [GIABAN], [THANHTIEN]) VALUES (2, 3, 2, 560000.0000, 2*560000.0000)
INSERT [dbo].[CTDONHANG] ([MADH], [MATB], [SOLUONG], [GIABAN], [THANHTIEN]) VALUES (3, 9, 1, 400000.0000, 1*400000.0000)
INSERT [dbo].[CTDONHANG] ([MADH], [MATB], [SOLUONG], [GIABAN], [THANHTIEN]) VALUES (4, 8, 2, 500000.0000, 2*500000.0000)
INSERT [dbo].[CTDONHANG] ([MADH], [MATB], [SOLUONG], [GIABAN], [THANHTIEN]) VALUES (5, 4, 3, 200000.0000, 3*200000.0000)
INSERT [dbo].[CTDONHANG] ([MADH], [MATB], [SOLUONG], [GIABAN], [THANHTIEN]) VALUES (6, 6, 4, 500000.0000, 4*500000.0000)
INSERT [dbo].[CTDONHANG] ([MADH], [MATB], [SOLUONG], [GIABAN], [THANHTIEN]) VALUES (6, 2, 1, 400000.0000, 1*400000.0000)
INSERT [dbo].[CTDONHANG] ([MADH], [MATB], [SOLUONG], [GIABAN], [THANHTIEN]) VALUES (7, 7, 2, 300000.0000, 2*300000.0000)
INSERT [dbo].[CTDONHANG] ([MADH], [MATB], [SOLUONG], [GIABAN], [THANHTIEN]) VALUES (7, 5, 5, 300000.0000, 5*300000.0000)
INSERT [dbo].[CTDONHANG] ([MADH], [MATB], [SOLUONG], [GIABAN], [THANHTIEN]) VALUES (8, 7, 2, 100000.0000, 2*100000.0000)
INSERT [dbo].[CTDONHANG] ([MADH], [MATB], [SOLUONG], [GIABAN], [THANHTIEN]) VALUES (9, 9, 3, 560000.0000, 3*560000.0000)
GO
INSERT [dbo].[TAIKHOANG] ([TENTK], [MATKHAU], [MANV]) VALUES (N'admin', N'123', 1)
INSERT [dbo].[TAIKHOANG] ([TENTK], [MATKHAU], [MANV]) VALUES (N'tung', N'123', 3)
INSERT [dbo].[TAIKHOANG] ([TENTK], [MATKHAU], [MANV]) VALUES (N'dat', N'123', 4)
GO
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Bán Hàng',1,1)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Nhân Viên',1,1)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Khách Hàng',1,1)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Thiết Bị',1,1)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Loại Thiết Bị',1,1)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Cơ Sở',1,1)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Đơn Nhập',1,1)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Phân Quyền',1,1)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Báo Cáo',1,1)

INSERT INTO DMMANGHINH VALUES (N'Màng Hình Bán Hàng',1,3)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Nhân Viên',1,3)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Khách Hàng',1,3)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Thiết Bị',1,3)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Loại Thiết Bị',1,3)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Cơ Sở',1,3)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Đơn Nhập',1,3)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Phân Quyền',1,3)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Báo Cáo',1,3)


INSERT INTO DMMANGHINH VALUES (N'Màng Hình Bán Hàng',1,4)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Nhân Viên',1,4)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Khách Hàng',1,4)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Thiết Bị',1,4)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Loại Thiết Bị',1,4)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Cơ Sở',1,4)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Đơn Nhập',1,4)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Phân Quyền',1,4)
INSERT INTO DMMANGHINH VALUES (N'Màng Hình Báo Cáo',1,4)
GO
---KHACH HANG
INSERT KHACHHANG VALUES (N'Trần Cao Tùng','2001-02-15','Nam','036310298','TPHCM','tung','123')
INSERT KHACHHANG VALUES (N'Lê Thanh Thương','2000-01-15','Nam','094534876','Quảng Ngãi',null,null)
INSERT KHACHHANG VALUES (N'Huỳnh Thanh Hằng','2001-04-06','Nữ','098648136','Đà Nẵng',null,null)
INSERT KHACHHANG VALUES (N'Nguyễn Thị Trà My','1999-09-09','Nữ','098648136','Đà Nẵng',null,null)
INSERT KHACHHANG VALUES (N'Huỳnh Thị Bích Trang','2002-02-20','Nữ','026846314','Đà Nẵng',null,null)
INSERT KHACHHANG VALUES (N'Trần Kim Khôi','2001-03-16','Nam','098648136','Đà Nẵng',null,null)
GO
ALTER TABLE [dbo].[CTDONHANG]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETDH_DONHANG] FOREIGN KEY([MADH])
REFERENCES [dbo].[DONHANG] ([MADH])
GO
ALTER TABLE [dbo].[CTDONHANG] CHECK CONSTRAINT [FK_CHITIETDH_DONHANG]
GO
ALTER TABLE [dbo].[CTDONHANG]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETDH_THIETBI] FOREIGN KEY([MATB])
REFERENCES [dbo].[THIETBI] ([MATB])
GO
ALTER TABLE [dbo].[CTDONHANG] CHECK CONSTRAINT [FK_CHITIETDH_THIETBI]
GO
ALTER TABLE [dbo].[CTDONHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETDN_DONNHAP] FOREIGN KEY([MADN])
REFERENCES [dbo].[DONNHAP] ([MADN])
GO
ALTER TABLE [dbo].[CTDONHAP] CHECK CONSTRAINT [FK_CHITIETDN_DONNHAP]
GO
ALTER TABLE [dbo].[CTDONHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETDN_THIETBI] FOREIGN KEY([MATB])
REFERENCES [dbo].[THIETBI] ([MATB])
GO
ALTER TABLE [dbo].[CTDONHAP] CHECK CONSTRAINT [FK_CHITIETDN_THIETBI]
GO
ALTER TABLE [dbo].[DONHANG]  WITH CHECK ADD  CONSTRAINT [FK_DONHANG_KHACHHANG] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[DONHANG] CHECK CONSTRAINT [FK_DONHANG_KHACHHANG]
GO
ALTER TABLE [dbo].[DONHANG]  WITH CHECK ADD  CONSTRAINT [FK_DONHANG_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[DONHANG] CHECK CONSTRAINT [FK_DONHANG_NHANVIEN]
GO
ALTER TABLE [dbo].[DONNHAP]  WITH CHECK ADD  CONSTRAINT [FK_DONNHAP_COSO] FOREIGN KEY([MACS])
REFERENCES [dbo].[COSO] ([MACS])
GO
ALTER TABLE [dbo].[DONNHAP] CHECK CONSTRAINT [FK_DONNHAP_COSO]
GO
ALTER TABLE [dbo].[DONNHAP]  WITH CHECK ADD  CONSTRAINT [FK_DONNHAP_NHACC] FOREIGN KEY([MANCC])
REFERENCES [dbo].[NHACC] ([MANCC])
GO
ALTER TABLE [dbo].[DONNHAP] CHECK CONSTRAINT [FK_DONNHAP_NHACC]
GO
ALTER TABLE [dbo].[DONNHAP]  WITH CHECK ADD  CONSTRAINT [FK_DONNHAP_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[DONNHAP] CHECK CONSTRAINT [FK_DONNHAP_NHANVIEN]
GO
ALTER TABLE [dbo].[TAIKHOANG]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOANG_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[TAIKHOANG] CHECK CONSTRAINT [FK_TAIKHOANG_NHANVIEN]
GO
ALTER TABLE [dbo].[THIETBI]  WITH CHECK ADD  CONSTRAINT [FK_THIETBI_LOAITB] FOREIGN KEY([MALOAI])
REFERENCES [dbo].[LOAITB] ([MALOAI])
GO
ALTER TABLE [dbo].[THIETBI] CHECK CONSTRAINT [FK_THIETBI_LOAITB]
GO
ALTER TABLE [dbo].[THIETBI]  WITH CHECK ADD  CONSTRAINT [FK_THIETBI_NHACC] FOREIGN KEY([MANCC])
REFERENCES [dbo].[NHACC] ([MANCC])
GO
ALTER TABLE [dbo].[THIETBI] CHECK CONSTRAINT [FK_THIETBI_NHACC]
GO
--sap xep tang view nhap
GO
CREATE VIEW View_Nhap as
select DONNHAP.MADN,TENNV , c.TENNCC,NGAYLAP,TONGTIEN
from DONNHAP , NHANVIEN, NHACC c
where DONNHAP.MANV = NHANVIEN.MANV and DONNHAP.MANCC = c.MANCC
order by NgayLap desc
OFFSET 0 ROWS
--View DOnNhap
GO
CREATE VIEW View_DonNhap as
select *
from DONNHAP
--View CTNhap
GO
create view View_CTNhap as
select CTDONHAP.MADN,CTDONHAP.MATB, THIETBI.TENTB,HINHANH,CTDONHAP.SOLUONG,GIANHAP,THANHTIEN
from THIETBI,CTDONHAP,DONNHAP
where THIETBI.MATB = CTDONHAP.MATB and CTDONHAP.MADN = DONNHAP.MADN

--VIEW Gio hang
GO
CREATE VIEW VIEW_GIOHANG AS
SELECT dbo.CTDONHANG.MADH, dbo.CTDONHANG.MATB, dbo.THIETBI.TENTB, dbo.CTDONHANG.SOLUONG, dbo.CTDONHANG.GIABAN, dbo.CTDONHANG.THANHTIEN, dbo.THIETBI.HINHANH
FROM     dbo.THIETBI INNER JOIN
                  dbo.CTDONHANG ON dbo.THIETBI.MATB = dbo.CTDONHANG.MATB
-----------------------------------------------------
---Mỗi khi thêm, xóa, sửa vào bảng CHITIETDH sẽ cập nhật thành tiền ở CHITIETDH , tổng tiền ở DONHANG

--GO
--CREATE TRIGGER TINHTHANHTIEN ON CTDONHANG
--FOR INSERT,DELETE,UPDATE
--AS
--	DECLARE @madh int,@matb int	,@thanhtien money,@tongtien money
--	if(select count(*) from inserted)>0
--		BEGIN
--		set @madh=(select MADH FROM inserted)
--		set @matb=(select MATB FROM inserted)
		
--		END
--	ELSE
--		BEGIN
--		set @madh=(select MADH FROM deleted)
--		set @matb=(select MATB FROM deleted)
		
--		END

--	SET @tongtien=(select sum(GIABAN*SOLUONG) FROM DONHANG,CTDONHANG WHERE DONHANG.MADH=CTDONHANG.MADH AND DONHANG.MADH=@madh GROUP BY DONHANG.MADH)
--	set @thanhtien=(select GIABAN*SOLUONG FROM CTDONHANG WHERE  MADH=@madh and MATB=@matb)
	
--	update CTDONHANG
--	set THANHTIEN=@thanhtien
--	where MADH=@madh and MATB=@matb

--	update DONHANG
--	set TONGTIEN=@tongtien
--	where MADH=@madh
--INSERT INTO CTDONHANG(MADH ,MATB ,SOLUONG ,GIABAN )
--VALUES(2,4,2,500000)
--DELETE FROM CTDONHANG WHERE MADH=2 and MATB =2
--select * from LOAITB
---Mỗi khi thêm, xóa, sửa vào bảng CHITIETDN sẽ cập nhật thành tiền ở CHITIETDH , tổng tiền ở DONNHAP
--GO
--CREATE TRIGGER TINHTIENNHAP ON CTDONHAP
--FOR INSERT,DELETE,UPDATE
--AS
--	DECLARE @madh int,@matb int	,@thanhtien money,@tongtien money
--	if(select count(*) from inserted)>0
--		BEGIN
--		set @madh=(select MADN FROM inserted)
--		set @matb=(select MATB FROM inserted)
		
--		END
--	ELSE
--		BEGIN
--		set @madh=(select MADN FROM deleted)
--		set @matb=(select MATB FROM deleted)
		
--		END

--	SET @tongtien=(select sum(GIANHAP*SOLUONG) FROM DONNHAP,CTDONHAP WHERE DONNHAP.MADN=CTDONHAP.MADN AND DONNHAP.MADN=@madh GROUP BY DONNHAP.MADN)
--	set @thanhtien=(select GIANHAP*SOLUONG FROM CTDONHAP WHERE  MADN=@madh and MATB=@matb)
	
--	update CTDONHAP
--	set THANHTIEN=@thanhtien
--	where MADN=@madh and MATB=@matb

--	update DONNHAP
--	set TONGTIEN=@tongtien
--	where MADN=@madh

--select * from CTDONHAP
--select * from DONNHAP

--delete from CTDONHAP where MADN=6


----API
--select * from DONHANG
--select *from CTDONHANG
--select * from KHACHHANG

--Trigger khi thêm Chitiet, số lượng tự động cập nhật vào thiết bị
--CREATE TRIGGER CAPNHATSL ON CTDONHAP
--FOR INSERT,DELETE,UPDATE
--AS
--	DECLARE @manl int, @sl int
--	if(select count(*) from inserted)>0
--		BEGIN
--			set @manl=(select MATB FROM inserted)
--			set @sl=(select SOLUONG FROM inserted)
--			update THIETBI
--			set SOLUONG=SOLUONG+@sl
--			where MATB=@manl
--		END
--	ELSE
--		BEGIN
--			set @manl=(select MATB FROM deleted)
--			set @sl=(select SOLUONG FROM deleted)
--			update THIETBI
--			set SOLUONG=SOLUONG-@sl
--			where MATB=@manl
--		END

--Trigger khi thêm Chitietdonhang, số lượng tự động trừ vào thiết bị
--CREATE TRIGGER CAPNHATSLBAN ON CTDONHANG
--FOR INSERT,DELETE,UPDATE
--AS
--	DECLARE @manl nvarchar(10), @sl float
--	if(select count(*) from inserted)>0
--		BEGIN
--			set @manl=(select MATB FROM inserted)
--			set @sl=(select SOLUONG FROM inserted)
--			update THIETBI
--			set SOLUONG=SOLUONG-@sl
--			where MATB=@manl
--		END
--	ELSE
--		BEGIN
--			set @manl=(select MATB FROM deleted)
--			set @sl=(select SOLUONG FROM deleted)
--			update THIETBI
--			set SOLUONG=SOLUONG+@sl
--			where MATB=@manl
--		END
--produce báo cáo theo ngay
create proc show_DB @ngay date
as
	begin
		--set dateformat DMY
		select s.TENTB, ncc.tenNCC as TENNCC, SUM(ctb.soLuong) as TongSoLuong, AVG(s.GIA) as TrungBinhGiaBan,
					 AVG(ctn.giaNhap) TrungBinhGiaNhap, (AVG(s.GIA) - AVG(ctn.giaNhap)) as DoanhThu
		from THIETBI s, CTDONHAP ctn, CTDONHANG ctb, DONHANG dbh, DONNHAP dnh, NHACC ncc
		where s.MATB = ctn.MATB and dnh.MADN = ctn.MADN and dnh.maNCC = ncc.maNCC
		and s.MATB = ctb.MATB and ctb.MADH = dbh.MADH and dbh.NGAYLAP = @ngay
		group by s.TENTB, ncc.tenNCC
	end
go
set dateformat DMY
exec show_DB '22/02/2022'
--chuan
exec show_DB '2022/06/14'

select * from DONHANG where NGAYLAP='22/02/2021'
select * from CTDONHANG where MADH=1 or MADH = 2
select * from THIETBI
select * from CTDONHANG
select * from DONHANG
--BÁO CÁO THEO THÁNG
create proc show_DB_Thang @thang int
as
	begin
		set dateformat DMY
		select s.TENTB, ncc.tenNCC, SUM(ctb.soLuong) as tongSLBan, AVG(s.GIA) as trungBinhGiaBan,
					 AVG(ctn.giaNhap) trungBinhGiaNhap, (AVG(s.GIA) - AVG(ctn.giaNhap)) as doanhThu
		from THIETBI s, CTDONHAP ctn, CTDONHANG ctb, DONHANG dbh, DONNHAP dnh, NHACC ncc
		where s.MATB = ctn.MATB and dnh.MADN = ctn.MADN and dnh.maNCC = ncc.maNCC
		and s.MATB = ctb.MATB and ctb.MADH = dbh.MADH and MONTH(dbh.NGAYLAP) = @thang
		group by s.TENTB, ncc.tenNCC
	end
go
exec show_DB_Thang 4
select * from THIETBI
select * from DONHANG
select * from DONNHAP
select * from CTDONHANG
--BÁO CÁO THEO QUÝ 1
create proc show_DB_Quy_1
as
	begin
		set dateformat DMY
		select s.TENTB, ncc.tenNCC, SUM(ctb.soLuong) as tongSLBan, AVG(s.GIA) as trungBinhGiaBan,
					 AVG(ctn.giaNhap) trungBinhGiaNhap, (AVG(s.GIA) - AVG(ctn.giaNhap)) as doanhThu
		from THIETBI s, CTDONHAP ctn, CTDONHANG ctb, DONHANG dbh, DONNHAP dnh, NHACC ncc
		where s.MATB = ctn.MATB and dnh.MADN = ctn.MADN and dnh.maNCC = ncc.maNCC
		and s.MATB = ctb.MATB and ctb.MADH = dbh.MADH and (MONTH(dbh.NGAYLAP) between 1 and 6)
		group by s.TENTB, ncc.tenNCC
	end
go
exec show_DB_Quy_1
----BÁO CÁO THEO QUÝ 2
create proc show_DB_Quy_2
as
	begin
		set dateformat DMY
		select s.TENTB, ncc.tenNCC, SUM(ctb.soLuong) as tongSLBan, AVG(s.GIA) as trungBinhGiaBan,
					 AVG(ctn.giaNhap) trungBinhGiaNhap, (AVG(s.GIA) - AVG(ctn.giaNhap)) as doanhThu
		from THIETBI s, CTDONHAP ctn, CTDONHANG ctb, DONHANG dbh, DONNHAP dnh, NHACC ncc
		where s.MATB = ctn.MATB and dnh.MADN = ctn.MADN and dnh.maNCC = ncc.maNCC
		and s.MATB = ctb.MATB and ctb.MADH = dbh.MADH and (MONTH(dbh.NGAYLAP) between 7 and 12)
		group by  s.TENTB, ncc.tenNCC
	end
go
exec show_DB_Quy_2
--15/6**********************************************
select * from DMMANGHINH
select * from NHANVIEN
select * from NHANVIEN
select * from TAIKHOANG


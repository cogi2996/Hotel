create database quanlikhachsan5
go

use quanlikhachsan5
go

CREATE TABLE KhachHang(
    MaKH INT PRIMARY KEY IDENTITY(1,1),
    TenKH NVARCHAR(50) NOT NULL,
    NgaySinh DATE NOT NULL,
    CCCD NVARCHAR(12) UNIQUE CHECK (LEN(CCCD) = 12),
    SDT NVARCHAR(10) UNIQUE CHECK (LEN(SDT) = 10),
    LoaiKH NVARCHAR(1) NOT NULL
);
go

CREATE TABLE BangGiaPhong (
    LoaiPhong NVARCHAR(1), 
    SucChua INT,
    TienGioDau INT CHECK (TienGioDau > 0),
    TienQuaDem INT CHECK (TienQuaDem > 0),
    TienGioTiepTheo INT CHECK (TienGioTiepTheo > 0),
    PRIMARY KEY (LoaiPhong, SucChua)
);
go

CREATE TABLE Phong (
    SoPhong INT PRIMARY KEY ,
    LoaiPhong NVARCHAR(1) NOT NULL,
    SucChua INT NOT NULL,
    TinhTrang NVARCHAR(10) NOT NULL,
    FOREIGN KEY (LoaiPhong,SucChua) REFERENCES BangGiaPhong(LoaiPhong,SucChua),
);
go


CREATE TABLE DatPhong 
(
    SoPhong INT PRIMARY KEY ,
    MaKH INT NOT NULL,
    CheckIn DATETIME NOT NULL,
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    FOREIGN KEY (SoPhong) REFERENCES Phong(SoPhong)
);
go
 
CREATE TABLE HoaDon (
    MaKH INT NOT NULL,
    MaHD INT PRIMARY KEY IDENTITY(1,1),
    NgayThanhToan DATE NOT NULL,
    TongTienThanhToan INT CHECK (TongTienThanhToan >= 0),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);
go

CREATE TABLE DichVu (
    MaDV INT PRIMARY KEY IDENTITY(100,1),
    TenDV NVARCHAR(50) NOT NULL,
    DonGia INT CHECK (DonGia > 0)
);
go

CREATE TABLE DanhSachSuDungDichVu (
    MaKH INT,
    MaDV INT,
    SoLuong INT CHECK (SoLuong > 0),
    ThoiDiem DATETIME NOT NULL,
    PRIMARY KEY (MaKH, MaDV),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV)
);
go

/* Đổ dữ liệu*/
INSERT INTO KhachHang (TenKH, NgaySinh, CCCD, SDT, LoaiKH)
VALUES
    (N'Nguyễn Văn A', '1990-01-01', '123456789012', '0987654321', N'T'),
	('Trần Thị B', '1991-02-02', '987654321098', '0123456789', N'V'),
	('Nguyễn Văn C', '1992-03-03', '098765432101', '0908765432', N'V'),
	('Trần Thị D', '1993-04-04', '123456789014', '0123456790', N'T'),
	('Nguyễn Văn E', '1994-05-05', '098765432102', '0908765433', N'T');
go

INSERT INTO BangGiaPhong (LoaiPhong, SucChua, TienGioDau, TienQuaDem, TienGioTiepTheo)
VALUES	
    (N'T', 2, 100000, 80000, 50000),
    (N'V', 3, 120000, 90000, 60000),
    (N'T', 4, 150000, 100000, 70000);
go

INSERT INTO Phong (SoPhong, LoaiPhong, SucChua, TinhTrang)
VALUES
    (101, N'T', 2, N'Trống'),
    (102, N'T', 4, N'Trống'),
	(103, N'V', 3, N'Trống'),
    (104, N'T', 4, N'Trống'),
	(105, N'T', 2, N'Trống'),
    (106, N'V', 3, N'Trống');
go

INSERT INTO DatPhong (SoPhong, MaKH, CheckIn)
VALUES
    (101, 1, '2023-10-10 12:00:00'),
	(102, 2, '2023-10-11 11:00:00'),
	(103, 3, '2023-10-9 19:00:00')
go

INSERT INTO DichVu (TenDV, DonGia)
VALUES
    (N'Đồ uống', 50000),
    (N'Ăn sáng', 80000),
    (N'Dịch vụ phòng', 100000);
go

INSERT INTO DanhSachSuDungDichVu (MaKH, MaDV, SoLuong, ThoiDiem)
VALUES
    (1, 100, 2, '2023-10-15 08:30:00'),
    (1, 102, 3, '2023-11-07 07:45:00'),
    (1, 101, 4, '2023-12-24 20:15:00');
go

INSERT INTO HoaDon(MaKH, NgayThanhToan, TongTienThanhToan)
VALUES
	(1,'2023-10-25', 1000000),
	(2,'2023-10-26', 2000000),
	(3,'2023-10-27', 3000000),
	(4,'2023-10-28', 4000000),
	(5,'2023-10-29', 5000000);


/*1.------------------------------------------procedure trên Table DichVu------------------------------------*/

/*1.1-------Procedure thêm 1 dịch vụ mới trong Table DichVu------*/

CREATE PROCEDURE ThemDichVu
  @TenDV NVARCHAR(50),
  @DonGia INT
AS
BEGIN

  -- Kiểm tra giá dịch vụ phải lớn hơn 0
  IF @DonGia <= 0
  BEGIN
    RAISERROR(N'Giá dịch vụ phải lớn hơn 0.', 16, 1);/*16 là mã lỗi của số ko hợp lệ*/
    RETURN;
  END;

  -- Thêm bản ghi mới vào bảng DichVu
  INSERT INTO DichVu(TenDV, DonGia)
  VALUES(@TenDV, @DonGia);

  -- Thông báo đã thêm thành công
  PRINT N'Thêm thành công 1 bản ghi vào bảng DichVu.';

END;

/*----test Procedure ThemDichVu------*/
EXEC ThemDichVu @TenDV = 'Ăn sáng', @DonGia = 100000;


/*1.2-------Procedure sửa 1 dịch vụ mới trong Table DichVu------*/
CREATE PROCEDURE SuaDichVu
  @MaDV INT,
  @TenDV NVARCHAR(50),
  @DonGia INT
AS
BEGIN
  -- Kiểm tra mã dịch vụ tồn tại
  IF NOT EXISTS(SELECT * FROM DichVu WHERE MaDV = @MaDV)
  BEGIN
    RAISERROR(N'Mã dịch vụ không tồn tại.', 16, 1);
    RETURN;
  END;

  -- Cập nhật bản ghi trong bảng DichVu
  UPDATE DichVu
  SET TenDV = @TenDV,
      DonGia = @DonGia
  WHERE MaDV = @MaDV;

  -- Thông báo đã sửa thành công
  PRINT N'Sửa thành công 1 dịch vụ trong bảng DichVu.';
END;

/*----test Procedure SuaDichVu------*/
EXEC SuaDichVu 100, 'Ăn trưa', 200000;


/*2.------------------------------------------procedure trên Table DatPhong------------------------------------*/
/*2.1-------Procedure xóa 1 yêu cầu đặt phòng trong Table DatPhong------*/
CREATE PROCEDURE XoaDatPhong
  @SoPhong INT
AS
BEGIN
  -- Kiểm tra xem yêu cầu xóa phòng có tồn tại hay không
  IF NOT EXISTS(SELECT * FROM DatPhong WHERE SoPhong = @SoPhong)
  BEGIN
    RAISERROR(N'Yêu cầu xóa phòng không tồn tại.', 16, 1);
    RETURN;
  END;

  -- Xóa yêu cầu đặt phòng
  DELETE FROM DatPhong WHERE SoPhong = @SoPhong;

  -- Thông báo đã xóa thành công
  PRINT N'Xóa thành công phòng';
END;

/*----test Procedure XoaDatPhong------*/
EXEC XoaDatPhong 102;


/*3.------------------------------------------procedure trên Table SuDungDichVu------------------------------------*/
/*3.1-------Procedure hủy 1 dịch vụ được sử dụng trong Table SuDungDichVu------*/
CREATE PROCEDURE HuySuDungDichVu
  @MaKH INT,
  @MaDV INT
AS
BEGIN
  -- Kiểm tra xem yêu cầu hủy sử dụng dịch vụ có tồn tại hay không
  IF NOT EXISTS(SELECT * FROM DanhSachSuDungDichVu WHERE MaKH = @MaKH AND MaDV = @MaDV)
  BEGIN
    RAISERROR(N'Yêu cầu hủy sử dụng dịch vụ không thành công.', 16, 1);
    RETURN;
  END;

  -- Xóa yêu cầu đặt phòng
  DELETE FROM DanhSachSuDungDichVu WHERE MaKH = @MaKH AND MaDV = @MaDV;

  -- Thông báo đã thành công
  PRINT N'Yêu cầu hủy sử dụng dịch vụ thành công.';
END;

/*----test Procedure HuySuDungDichVu------*/
EXEC HuySuDungDichVu 1, 102;



/*4.------------------------------------------VIEWS------------------------------------*/


/*3.1-------View hiện BangGiaPhong cố định------*/
CREATE VIEW v_BangGiaPhong 
AS
SELECT * FROM BangGiaPhong;


/*3.2-------View hiện DichVu cố định------*/
CREATE VIEW v_DichVu 
AS
SELECT * FROM DichVu;

/*3.2-------View hiện DanhSachSuDungDichVu------*/
CREATE VIEW v_DanhSachSuDungDichVu
AS
SELECT * FROM DanhSachSuDungDichVu;




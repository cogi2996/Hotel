create database QuanLyKhachSan
go

use QuanLyKhachSan
go


--------------------------------------------------------------------------
---------------------------  CÁC BẢNG   ----------------------------------
--------------------------------------------------------------------------

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
-- Loại phòng được tham 
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
	-- tham chiếu theo bộ
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

--------------------------------------------------------------------------
---------------------------      VIEW       ------------------------------
--------------------------------------------------------------------------
-- 1. VIEW danh sách khách hàng
CREATE VIEW v_DanhSachKhachHang 
AS
	SELECT *
	FROM KhachHang;
go

-- 2. VIEW danh sách khách hàng VIP
CREATE VIEW v_DanhSachKhachHangVIP 
AS
	SELECT *
	FROM KhachHang
	WHERE LoaiKH = 'V';
go

-- 3. VIEW danh sách khách hàng thường
CREATE VIEW v_DanhSachKhachHangThuong 
AS
	SELECT *
	FROM KhachHang
	WHERE LoaiKH = 'T';
go

-- 4. VIEW bảng giá phòng
create view v_BangGia
as
select * from BangGiaPhong;
go

-- 5. VIEW các phòng
create view v_Phong
	as 
	select * from Phong
go

-- 6. VIEW các phòng đã đặt
create view v_PhongDaDat
as
	select * from Phong
	where Phong.TinhTrang = N'Đã đặt';
go

-- 7. VIEW các phòng trống
create view v_PhongTrong
as
	select * from Phong
	where Phong.TinhTrang = N'Trống';
go

-- 8. VIEW dịch vụ
CREATE VIEW v_DichVu 
AS
	SELECT * FROM DichVu;
go

 -- 9. VIEW danh sách sử dụng dịch vụ
CREATE VIEW v_DanhSachSuDungDichVu
AS
	SELECT * FROM DanhSachSuDungDichVu;
go

-- 10. VIEW hiển thị danh sách hoá đơn
create view v_DanhSachHoaDon
as 
	select MaKH, MaHD
	from HoaDon;
go

-- 11. VIEW thông tin phòng được khách hàng đặt
create view v_ThongTinPhongDuocDat
as
	select KhachHang.MaKH,Phong.SoPhong,CheckIn,
		   TienGioDau,TienQuaDem,TienGioTiepTheo 
	from KhachHang
	inner join DatPhong on KhachHang.MaKH = DatPhong.MaKH
	inner join Phong on DatPhong.SoPhong = Phong.SoPhong 
	inner join BangGiaPhong on Phong.LoaiPhong = BangGiaPhong.LoaiPhong 
	                           and Phong.SucChua = BangGiaPhong.SucChua;
go

--------------------------------------------------------------------------
---------------------------      FUCNTION      ---------------------------
--------------------------------------------------------------------------

-- 1. FUNCTION tính tuổi. Khách sạn chỉ cho khách >= 18 tuổi đặt phòng.
CREATE FUNCTION f_TinhTuoi
(
    @NamSinh DATE
)
RETURNS INT
AS
	BEGIN
		DECLARE @Tuoi INT;
		SET @Tuoi = YEAR(GETDATE()) - YEAR(@NamSinh);
		RETURN @Tuoi;
	END;
go

-- 2. FUNCTION kiểm tra phòng trống. 
-- Kết quả trả về là 1 số nguyên đại diện cho: 1 trống , -1 đặt
create function f_KiemTraPhongTrong(@SoPhong int)
returns int
begin
	declare @tinhtrang nvarchar(20);
	select @tinhtrang =  Phong.TinhTrang  from Phong
	where SoPhong = @SoPhong;
	if @tinhtrang = N'Đã đặt'
		return -1;
	else if @tinhtrang = N'Trống'
		return 1;
	return 0;
end;
go

--- 3. FUNCTION tính số đêm khách đã ở
CREATE FUNCTION f_TinhSoDem
(
    @checkin_str NVARCHAR(50),
    @checkout_str NVARCHAR(50)
)
RETURNS INT
AS
BEGIN
    DECLARE @checkin DATETIME;
    DECLARE @checkout DATETIME;
    DECLARE @so_gio INT;
    DECLARE @so_dem INT;

    SET @checkin = CONVERT(DATETIME, @checkin_str, 120);
    SET @checkout = CONVERT(DATETIME, @checkout_str, 120);

    -- Tính số giờ giữa check-in và check-out
    SET @so_gio = DATEDIFF(HOUR, @checkin, @checkout);

	-- so gio ở trong ngày check in 
	declare @so_gio_ngay_checkin int;
	set @so_gio_ngay_checkin = 24 -DATEPART(HOUR, @checkin);

	-- số giờ ở trong ngày check out 
	declare @so_gio_ngay_checkout int;
	set @so_gio_ngay_checkout = DATEPART(HOUR, @checkout);

    -- Tính số đêm giữa check-in và check-out
    SET @so_dem = ( @so_gio - @so_gio_ngay_checkin - @so_gio_ngay_checkout ) / 24;

    -- Kiểm tra nếu check-in trước 22:00 và check-out sau 06:00, thêm 1 đêm
    IF DATEPART(HOUR, @checkin) <= 22 AND DATEPART(HOUR, @checkout) >= 6
    BEGIN
        SET @so_dem = @so_dem + 1;
    END

    RETURN @so_dem;
END;
go

-- 4. FUNCTION tính giá phòng
create function f_TinhGiaPhong
(
	@TienGioDau int,
	@TienQuaDem int,
	@TienGioTiepTheo int,
	@checkin DateTime
)
returns INT
AS 
BEGIN
-- nếu khách trả phòng >=1 giờ 
	if DATEDIFF(HOUR,@checkin,GETDATE()) >1
	begin
		declare @LoGio int;
		-- Nếu bị lố sang giờ tiếp theo vài phút thì tính là dùng thêm 1 giờ
		set @LoGio = 0;
		if DATEDIFF(MINUTE,@checkin,GETDATE()) >0 
			begin 
				set @LoGio = 1;
			end
		return @TienGioDau+(DATEDIFF(HOUR,@checkin,GETDATE()) + @LoGio -dbo.f_TinhSoDem(@checkin,GETDATE())*8-1)*@TienGioTiepTheo + dbo.f_TinhSoDem(@checkin,GETDATE())*@TienQuaDem ;
	end
	return  @TienGioDau;
END;
go

-- 5. FUNCTION tính tổng tiền dịch vụ 
create function f_TongTienDichVu
	(@MaKH int)
returns int
as
	begin
		declare @TongTien int;
		select @TongTien = sum(DonGia*SoLuong)
		from DichVu,DanhSachSuDungDichVu
		where DanhSachSuDungDichVu.MaKH = @MaKH and DichVu.MaDV = DanhSachSuDungDichVu.MaDV
		return @TongTien;
	end

go

-- 6.FUNCTION tính tổng tiền hoá đơn
CREATE FUNCTION f_TongTienHoaDon
(@MaKH int)
RETURNS int
AS
BEGIN
    -- Create a temporary table to store information about room prices for all booked rooms
    DECLARE @Phong TABLE (SoPhong int, CheckIn datetime, TienGioDau int, TienQuaDem int, TienGioTiepTheo int)

    -- Insert data into the temporary table
    INSERT INTO @Phong (SoPhong, CheckIn, TienGioDau, TienQuaDem, TienGioTiepTheo)
    SELECT SoPhong, CheckIn, TienGioDau, TienQuaDem, TienGioTiepTheo
    FROM v_ThongTinPhongDuocDat

    -- Calculate the total price for each room
    DECLARE @TongTienPhong int;
    SET @TongTienPhong = 0;

    WHILE EXISTS (SELECT 1 FROM @Phong)
    BEGIN
        DECLARE @SoPhong int, @TienGioDau int, @TienQuaDem int, @TienGioTiepTheo int, @checkin datetime

        -- Select the first room
        SELECT TOP 1 @SoPhong = SoPhong, @TienGioDau = TienGioDau, @TienQuaDem = TienQuaDem, @TienGioTiepTheo = TienGioTiepTheo, @checkin = CheckIn
        FROM @Phong

        -- Calculate the price for the selected room
        SET @TongTienPhong = @TongTienPhong + dbo.f_TinhGiaPhong(@TienGioDau, @TienQuaDem, @TienGioTiepTheo, @checkin)

        -- Delete the processed room
        DELETE FROM @Phong
        WHERE SoPhong = @SoPhong
    END

    RETURN @TongTienPhong;
END
go

-- 7. FUNCTION xem danh sách khách hàng
CREATE FUNCTION f_XemDanhSachKhachHang()
RETURNS TABLE
AS
RETURN 
(
    SELECT * FROM v_DanhSachKhachHang
);
go

-- 8. FUNCTION xem danh sách khách hàng VIP
CREATE FUNCTION f_XemDanhSachKhachHangVIP()
RETURNS TABLE
AS
RETURN 
(
    SELECT * FROM v_DanhSachKhachHangVIP
);
go

-- 9. FUNCTION xem danh sách khách hàng thường
CREATE FUNCTION f_XemDanhSachKhachHangThuong()
RETURNS TABLE
AS
RETURN 
(
    SELECT * FROM v_DanhSachKhachHangThuong
);
go

--------------------------------------------------------------------------
---------------------------      PROCEDURE      --------------------------
--------------------------------------------------------------------------

-- 1. PROCEDURE thêm khách hàng mới vào bảng KhachHang
CREATE PROCEDURE proc_ThemKhachHang
    @TenKH NVARCHAR(50),
    @NgaySinh DATE,
    @CCCD NVARCHAR(12),
    @SDT NVARCHAR(10),
    @LoaiKH NVARCHAR(1)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        -- Bắt lỗi các ràng buộc
        IF @TenKH = ''  OR @NgaySinh = '' OR @CCCD = '' OR @SDT = ''  OR @LoaiKH = ''
        BEGIN
            RAISERROR ('Tên khách hàng, ngày sinh, CCCD, số điện thoại hoặc loại khách hàng không được để trống. Vui lòng kiểm tra lại!', 16, 1);
            ROLLBACK TRANSACTION;
			RETURN;
        END
        IF LEN(@CCCD) != 12
        BEGIN
            RAISERROR ('Độ dài CCCD không hợp lệ!', 16, 1);
			ROLLBACK TRANSACTION;
            RETURN;
        END
        IF LEN(@SDT) != 10
        BEGIN
            RAISERROR ('Độ dài SĐT không hợp lệ!', 16, 1);
            ROLLBACK TRANSACTION;
			RETURN;
        END
        IF EXISTS (SELECT * FROM KhachHang WHERE CCCD = @CCCD)
        BEGIN
            RAISERROR ('CCCD đã tồn tại!', 16, 1);
            ROLLBACK TRANSACTION;
			RETURN;
        END
        IF EXISTS (SELECT * FROM KhachHang WHERE SDT = @SDT)
        BEGIN
            RAISERROR ('SĐT đã tồn tại!', 16, 1);
            ROLLBACK TRANSACTION;
			RETURN;
        END
        -- Thực hiện thao tác INSERT
        INSERT INTO KhachHang (TenKH, NgaySinh, CCCD, SDT, LoaiKH)
        VALUES (@TenKH, @NgaySinh, @CCCD, @SDT, @LoaiKH);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
		-- Có thể là lỗi cú pháp, lỗi khóa ngoại, lỗi quyền truy cập,  lỗi thực thi
        DECLARE @ErrMsg nvarchar(4000), @ErrSeverity int;
        SELECT @ErrMsg = ERROR_MESSAGE(),
               @ErrSeverity = ERROR_SEVERITY();
        RAISERROR(@ErrMsg, @ErrSeverity, 1);
    END CATCH
END;
go

-- 2. PROCEDURE tìm kiếm thông tin 1 khách hàng dựa vào MaKH
CREATE PROCEDURE proc_ThongTinKhachHang
    @MaKH INT
AS
BEGIN
    SELECT * FROM KhachHang
    WHERE MaKH = @MaKH;
END;
go

-- 3. PROCEDURE xóa khách hàng khỏi bảng KhachHang
CREATE PROCEDURE proc_XoaKhachHang
    @MaKH INT
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM DatPhong WHERE MaKH = @MaKH)
        BEGIN
            RAISERROR('Khách hàng đang có đơn đặt phòng, không thể xóa.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END;
        DELETE FROM KhachHang
        WHERE MaKH = @MaKH;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        DECLARE @ErrMsg NVARCHAR(4000), @ErrSeverity INT;
        SELECT @ErrMsg = ERROR_MESSAGE(),
               @ErrSeverity = ERROR_SEVERITY();
        RAISERROR(@ErrMsg, @ErrSeverity, 1);
    END CATCH;
END;
go

-- 4. PROCEDURE sửa thông tin khách hàng trong bảng KhachHang
CREATE PROCEDURE proc_SuaThongTinKhachHang
    @MaKH INT,
    @TenKH NVARCHAR(50),
    @NgaySinh DATE,
    @CCCD NVARCHAR(12),
    @SDT NVARCHAR(10),
    @LoaiKH NVARCHAR(1)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
		-- Bắt lỗi các ràng buộc
        IF @TenKH = ''  OR @NgaySinh = '' OR @CCCD = '' OR @SDT = ''  OR @LoaiKH = ''
        BEGIN
            RAISERROR ('Tên khách hàng, ngày sinh, CCCD, số điện thoại hoặc loại khách hàng không được để trống. Vui lòng kiểm tra lại!', 16, 1);
            ROLLBACK TRANSACTION;
			RETURN;
        END
        IF LEN(@CCCD) != 12
        BEGIN
            RAISERROR ('Độ dài CCCD không hợp lệ!', 16, 1);
            ROLLBACK TRANSACTION;
			RETURN;
        END
        IF LEN(@SDT) != 10
        BEGIN
            RAISERROR ('Độ dài SĐT không hợp lệ!', 16, 1);
            ROLLBACK TRANSACTION;
			RETURN;
        END
        -- Thực hiện thao tác UPDATE
        UPDATE KhachHang
        SET TenKH = @TenKH,
            NgaySinh = @NgaySinh,
            CCCD = @CCCD,
            SDT = @SDT,
            LoaiKH = @LoaiKH
        WHERE MaKH = @MaKH;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
		-- Có thể là lỗi cú pháp, lỗi khóa ngoại, lỗi quyền truy cập,  lỗi thực thi
        DECLARE @ErrMsg nvarchar(4000), @ErrSeverity int;
        SELECT @ErrMsg = ERROR_MESSAGE(),
               @ErrSeverity = ERROR_SEVERITY();
        RAISERROR(@ErrMsg, @ErrSeverity, 1);
    END CATCH
END;
go

-- 5. PROCEDURE thêm phòng mới vào bảng Phong
CREATE PROCEDURE proc_ThemPhong
    @SoPhong INT,
    @Loai NVARCHAR(5),
    @SucChua INT,
    @TinhTrang NVARCHAR(10)
AS
BEGIN
    -- Kiểm tra điều kiện trước khi thêm phòng
	IF @SoPhong = ''OR @Loai = '' OR @SucChua = '' OR @TinhTrang = ''
    BEGIN
        RAISERROR('Các giá trị không được để trống.', 16, 1)
        RETURN
    END
	IF EXISTS (SELECT 1 FROM Phong WHERE SoPhong = @SoPhong)
    BEGIN
        RAISERROR('Số phòng đã tồn tại.', 16, 1)
        RETURN
    END
    IF NOT EXISTS (SELECT 1 FROM BangGiaPhong WHERE LoaiPhong = @Loai AND SucChua = @SucChua)
    BEGIN
        RAISERROR('Loại phòng và sức chứa không hợp lệ.', 16, 1)
        RETURN
    END
    -- Thực hiện thêm phòng nếu không có lỗi
    INSERT INTO Phong (SoPhong, LoaiPhong, SucChua, TinhTrang)
    VALUES (@SoPhong, @Loai, @SucChua, @TinhTrang)
END
GO

-- 6. PROCEDURE xóa phòng khỏi bảng Phong
create proc proc_XoaPhong
	@SoPhong int
as
begin
	IF EXISTS (SELECT 1 FROM DatPhong WHERE SoPhong = @SoPhong)
        BEGIN
            RAISERROR('Phòng đang có khách sử dụng, không thể xóa.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END;
	delete from Phong where SoPhong = @SoPhong
end
go

-- 7. PROCEDURE xóa phòng đã đặt khỏi bảng DatPhong
-- Phục vụ cho việc hủy phòng
create proc proc_XoaPhongDaDat
	@Sophong int
as
begin
	delete from DatPhong where SoPhong = @Sophong
end
go

-- 8. PROCEDURE sửa thông tin của phòng trong bảng Phong
create proc proc_SuaPhong
	@SoPhong int,
	@Loai nvarchar(5),
	@SucChua int,
	@TinhTrang nvarchar(10)
as
begin
	update Phong set LoaiPhong=@Loai,SucChua = @SucChua,TinhTrang = @TinhTrang where SoPhong = @SoPhong
end
go

-- 9. PROCEDURE đặt phòng
create proc proc_DatPhongKH
	@SoPhong int,
	@MaKH int,
	@checkin datetime
as
	if dbo.f_KiemTraPhongTrong(@SoPhong) = 1
		insert into DatPhong values (@SoPhong,@MaKH,@checkin)
	else
		begin
			print('loi')
		end
go

-- 10. Procedure thêm 1 dịch vụ mới trong Table DichVu
CREATE PROCEDURE proc_ThemDichVu
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
go

-- 11. Procedure sửa thông tin 1 dịch vụ trong Table DichVu
CREATE PROCEDURE proc_SuaDichVu
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
go

-- 12. Procedure xóa 1 yêu cầu đặt phòng trong Table DatPhong
CREATE PROCEDURE proc_XoaDatPhong
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
go

-- 13. Procedure hủy 1 dịch vụ được sử dụng trong Table SuDungDichVu
CREATE PROCEDURE proc_HuySuDungDichVu
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
go
drop procedure proc_ThemDichVuSuDung
-- 14. Procedure thêm 1 dịch vụ được sử dụng trong Table SuDungDichVu
create PROCEDURE proc_ThemDichVuSuDung
@MaKH INT,
@MaDV INT,
@SoLuong INT
AS
BEGIN
	IF NOT EXISTS(SELECT * FROM KhachHang WHERE MaKH = @MaKH)
	BEGIN
		RAISERROR(N'Khách hàng không tồn tại.', 16, 1);
		RETURN;
	END;

	IF NOT EXISTS(SELECT * FROM DichVu WHERE MaDV = @MaDV)
	BEGIN
		RAISERROR(N'Dịch vụ không tồn tại.', 16, 1);
		RETURN;
	END;

	IF @SoLuong <= 0
	BEGIN
		RAISERROR(N'Số lượng phải lớn hơn 0.', 16, 1);
		RETURN;
	END;

	INSERT INTO DanhSachSuDungDichVu (MaKH, MaDV, SoLuong, ThoiDiem)
	VALUES (@MaKH, @MaDV, @SoLuong, GETDATE());

END;
go
	
-- 15. Procedure lấy về danh sách hoá đơn ( makh, madh)
create procedure proc_DanhSachHoaDon
as 
	begin
		select *
		from view_DanhSachHoaDon
	end
go

-- 16. Procedure lấy các dịch vụ dược sử dụng bới khách hàng 
create procedure proc_DanhSachSuDungDichVu
	@MaKH int
as 
begin	
	select v_DichVu.MaDV,SoLuong,DonGia,ThoiDiem
	from v_DanhSachSuDungDichVu 
	inner join v_DichVu on v_DanhSachSuDungDichVu.MaDV = v_DichVu.MaDV
	where v_DanhSachSuDungDichVu.MaKH = @MaKH
end
go

-- 17. Procedure lấy danh sách các phòng của khác hàng đã đặt
create procedure proc_DanhSachPhongDaDat
	@MaKH int
as
	select Phong.SoPhong,phong.LoaiPhong
	from v_ThongTinPhongDuocDat 
	inner join Phong on v_ThongTinPhongDuocDat.SoPhong = Phong.SoPhong
	where v_ThongTinPhongDuocDat.MaKH = @MaKH
go

--------------------------------------------------------------------------
---------------------------      TRIGGER      ----------------------------
--------------------------------------------------------------------------

-- 1. Trigger báo lỗi khi thêm khách hàng chưa đủ 18 tuổi vào bảng KhachHang
CREATE TRIGGER trg_KiemTraTuoiKhachHangTruocKhiThem
ON KhachHang
FOR INSERT
AS
BEGIN
    IF dbo.f_TinhTuoi((SELECT NgaySinh FROM INSERTED)) < 18
    BEGIN
        RAISERROR('Khách hàng chưa đủ 18 tuổi.', 16, 1);
        ROLLBACK;
    END;
END;
go

-- 2. Trigger cập nhật khi xóa 1 record trên bảng DatPhong
create trigger trg_CapNhatKhiXoa on DatPhong
after delete
as
begin
	declare @Sophong int;
	Select @Sophong= de.SoPhong
	from deleted de, Phong
	where de.SoPhong = Phong.SoPhong
	update Phong set TinhTrang = N'Trống' where Phong.SoPhong = @Sophong
end
go

-- 3. Trigger cập nhật khi thêm 1 record trên bảng DatPhong
create trigger trg_CapNhatKhiThem on DatPhong
after insert
as
	begin
		declare @Sophong int;
		Select @Sophong= te.SoPhong
		from inserted te, Phong
		where te.SoPhong = Phong.SoPhong
		if dbo.f_KiemTraPhongTrong(@SoPhong) =-1
		begin
			print('Phòng đã đặt')
			rollback;
		end
		update Phong set TinhTrang = N'Đã đặt' where Phong.SoPhong = @Sophong
end
go
drop trigger trg_CapNhatSuDungDichVu
-- 4. Trigger cập nhật khi thêm 1 record trên bảng DanhSachSuDungDichVu
CREATE TRIGGER trg_CapNhatSuDungDichVu
ON DanhSachSuDungDichVu
INSTEAD OF INSERT
AS
BEGIN
    -- Kiểm tra xem các bộ (MaKH, MaDV) mới được thêm đã tồn tại hay chưa
    IF EXISTS (
    SELECT 1
    FROM inserted i
    JOIN DanhSachSuDungDichVu d
    ON i.MaKH = d.MaKH AND i.MaDV = d.MaDV
	)
    BEGIN
        -- Nếu tồn tại, thực hiện cập nhật thay vì thêm mới
        UPDATE d
        SET d.SoLuong = i.SoLuong
        FROM DanhSachSuDungDichVu d
        INNER JOIN inserted i ON d.MaKH = i.MaKH AND d.MaDV = i.MaDV;
    END
    ELSE
    BEGIN
        -- Nếu không tồn tại, thực hiện việc thêm mới
        INSERT INTO DanhSachSuDungDichVu (MaKH, MaDV, SoLuong, ThoiDiem)
        SELECT MaKH, MaDV, SoLuong, GETDATE()
        FROM inserted;
    END
END;

/* Đổ dữ liệu*/
INSERT INTO KhachHang (TenKH, NgaySinh, CCCD, SDT, LoaiKH)
VALUES
	(N'Nguyễn Văn E', '1994-05-05', '098765432102', '0908765433', N'T'),
	(N'Trần Thị B', '1991-02-02', '987654321098', '0123456789', N'V'),
	(N'Trần Thị D', '1993-04-04', '123456789014', '0123456790', N'T'),
	(N'Nguyễn Văn C', '1992-03-03', '098765432101', '0908765432', N'V'),
    (N'Nguyễn Văn A', '1990-01-01', '123456789012', '0987654321', N'T');
go

INSERT INTO BangGiaPhong (LoaiPhong, SucChua, TienGioDau, TienQuaDem, TienGioTiepTheo)
VALUES	
    (N'T', 2, 100000, 80000, 50000),
    (N'V', 3, 120000, 90000, 60000),
    (N'T', 4, 150000, 100000, 70000);
go
delete phong
where 1=1
INSERT INTO Phong (SoPhong, LoaiPhong, SucChua, TinhTrang)
VALUES
    (101, N'T', 2, N'Trống'),
    (102, N'T', 4, N'Trống'),
	(103, N'V', 3, N'Trống'),
    (104, N'T', 4, N'Trống'),
	(105, N'T', 2, N'Trống'),
    (106, N'V', 3, N'Trống');
go


delete DatPhong
where 1=1
delete datphong 
where 1=1
INSERT INTO DatPhong (SoPhong, MaKH, CheckIn)
VALUES
	(103, 1, '2023-10-9 19:00:00'),
	(102, 2, '2023-10-11 11:00:00'),
    (101, 3, '2023-10-10 12:00:00');
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
    (2, 102, 3, '2023-11-07 07:45:00'),
    (3, 101, 4, '2023-12-24 20:15:00');
go

INSERT INTO HoaDon(MaKH, NgayThanhToan, TongTienThanhToan)
VALUES
	(21,'2023-10-25', 1000000),
	(26,'2023-10-26', 2000000),
	(27,'2023-10-27', 3000000),
	(4,'2023-10-28', 4000000),
	(5,'2023-10-29', 5000000);
go
select d.SoPhong,d.CheckIn 
from DatPhong d,KhachHang k
where d.MaKH = k.MaKH and k.MaKH = 2;

use QuanLyKhachSan
go
EXEC sp_help 'HoaDonChiTiet';
create table HoaDonChiTiet(
	MaKH nvarchar(50) primary key,
	TenKH nvarchar(50),
	SoPhong nvarchar(50),
	SoDem nvarchar(50),
	TenDV nvarchar(50),
	TienDV nvarchar(50),
	TienPhong nvarchar(50),
	NgaySinh nvarchar(50),
	NgayDi nvarchar(50),
	CheckIn nvarchar(50),
	TongTien nvarchar(50))
SELECT @@VERSION;


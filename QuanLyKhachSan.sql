create database QuanLyKhachSan
go

use QuanLyKhachSan
go

select * from KhachHang

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

-- 4. VIEW danh sách khách hàng đang đặt phòng
CREATE VIEW v_DanhSachKhachHangDangDatPhong 
AS
	SELECT KhachHang.MaKH, KhachHang.TenKH, KhachHang.NgaySinh, 
		   KhachHang.CCCD, KhachHang.SDT, KhachHang.LoaiKH, 
		   DatPhong.SoPhong, DatPhong.CheckIn
	FROM KhachHang
	INNER JOIN DatPhong ON KhachHang.MaKH = DatPhong.MaKH;
go

-- 5. VIEW bảng giá phòng
create view v_BangGia
as
select * from BangGiaPhong;
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

-- 10. VIEW hiển thị dánh sách hoá đơn
create view view_DanhSachHoaDon
as 
	select makh,mahd
	from hoadon;
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

--------------------------------------------------------------------------
---------------------------      PROCEDURE      --------------------------
--------------------------------------------------------------------------

-- 1. PROCEDURE xem danh sách khách hàng
CREATE PROCEDURE proc_XemDanhSachKhachHang
AS
BEGIN
    SELECT * FROM v_DanhSachKhachHang;
END;
go

-- 2. PROCEDURE xem danh sách khách hàng VIP
CREATE PROCEDURE proc_XemDanhSachKhachHangVIP
AS
BEGIN
    SELECT * FROM v_DanhSachKhachHangVIP;
END;
go

-- 3. PROCEDURE xem danh sách khách hàng thuờng
CREATE PROCEDURE proc_XemDanhSachKhachHangThuong
AS
BEGIN
    SELECT * FROM v_DanhSachKhachHangThuong;
END;
go

-- 3. PROCEDURE xem danh sách khách hàng đang đặt phòng
CREATE PROCEDURE proc_XemDanhSachKhachHangDangDatPhong
AS
BEGIN
    SELECT * FROM v_DanhSachKhachHangDangDatPhong;
END;
go

-- 4. PROCEDURE thêm khách hàng mới vào bảng KhachHang
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
        END
        IF LEN(@CCCD) != 12
        BEGIN
            RAISERROR ('Độ dài CCCD không hợp lệ!', 16, 1);
            RETURN;
        END
        IF LEN(@SDT) != 10
        BEGIN
            RAISERROR ('Độ dài SĐT không hợp lệ!', 16, 1);
            ROLLBACK TRANSACTION;
        END
        IF EXISTS (SELECT * FROM KhachHang WHERE CCCD = @CCCD)
        BEGIN
            RAISERROR ('CCCD đã tồn tại!', 16, 1);
            ROLLBACK TRANSACTION;
        END
        IF EXISTS (SELECT * FROM KhachHang WHERE SDT = @SDT)
        BEGIN
            RAISERROR ('SĐT đã tồn tại!', 16, 1);
            ROLLBACK TRANSACTION;
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

-- 5. PROCEDURE tìm kiếm thông tin 1 khách hàng dựa vào CCCD
CREATE PROCEDURE proc_TimKhachHang
    @CCCD NVARCHAR(12)
AS
BEGIN
    SELECT * FROM KhachHang
    WHERE CCCD = @CCCD;
END;
go

-- 5.1 PROCEDURE tìm kiếm thông tin 1 khách hàng dựa vào MaKH
CREATE PROCEDURE proc_ThongTinKhachHang
    @MaKH INT
AS
BEGIN
    SELECT * FROM KhachHang
    WHERE MaKH = @MaKH;
END;
go

-- 6. PROCEDURE xóa khách hàng khỏi bảng KhachHang
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
        END
        IF LEN(@CCCD) != 12
        BEGIN
            RAISERROR ('Độ dài CCCD không hợp lệ!', 16, 1);
            RETURN;
        END
        IF LEN(@SDT) != 10
        BEGIN
            RAISERROR ('Độ dài SĐT không hợp lệ!', 16, 1);
            ROLLBACK TRANSACTION;
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
create proc proc_ThemPhong
	@SoPhong int,
	@Loai nvarchar(5),
	@SucChua int,
	@TinhTrang nvarchar(10)
as
begin
	insert into Phong values (@SoPhong,@Loai,@SucChua,@TinhTrang)
end
go

-- 6. PROCEDURE xóa phòng khỏi bảng Phong
create proc proc_XoaPhong
	@SoPhong int
as
begin
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

-- 14. Procedure lấy về danh sách hoá đơn ( makh, madh)
create proc proc_DanhSachHoaDon
as 
	begin
		select *
		from view_DanhSachHoaDon
	end
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
			print('phong da dat')
			rollback;
		end
		update Phong set TinhTrang = N'Đã đặt' where Phong.SoPhong = @Sophong
end
go

INSERT INTO KhachHang (TenKH, NgaySinh, CCCD, SDT, LoaiKH)
VALUES
	('Nguyễn Văn C', '1992-03-03', '098765432101', '0908765432', N'V'),
	('Trần Thị D', '1993-04-04', '123456789014', '0123456790', N'T'),
    (N'Nguyễn Văn A', '1990-01-01', '123456789012', '0987654321', N'T'),
	('Trần Thị B', '1991-02-02', '987654321098', '0123456789', N'V'),
	('Nguyễn Văn E', '1994-05-05', '098765432102', '0908765433', N'T');
go

exec proc_ThemKhachHang 'hehe', '1990-01-01', '123456789010', '0987654329', N'T';
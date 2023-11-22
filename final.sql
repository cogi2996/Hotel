use QuanLyKhachSan

create role Staff
grant Select, insert, delete, update,REFERENCES on KhachHang to Staff
grant Select,REFERENCES on BangGiaPhong to Staff
grant Select,REFERENCES on Phong to Staff
grant Select, insert, delete, update,REFERENCES on DatPhong to Staff
grant Select,REFERENCES on HoaDon to Staff
grant Select,REFERENCES on DichVu to Staff
grant Select, insert, delete, update,REFERENCES on DanhSachSuDungDichVu to Staff

GRANT EXECUTE TO Staff
Grant select to staff
DENY EXECUTE ON proc_ThemPhong to Staff;
DENY EXECUTE ON proc_XoaPhong to Staff;
DENY EXECUTE ON proc_SuaPhong to Staff;
DENY EXECUTE ON proc_ThemDichVu to Staff;
DENY EXECUTE ON proc_SuaDichVu to Staff;
DENY EXECUTE ON proc_DanhSachHoaDon to Staff;
DENY EXECUTE ON proc_XoaDichVu to Staff;
go
create table DangNhap (
	username nvarchar(100) primary key,
	password nvarchar(100),
	role nvarchar(10),
)

insert into DangNhap values ('sa','29092003','admin')


--TRIGGER khi tạo tài khoản mới
create trigger createAccount on DangNhap
after insert
as
begin 
	-- lấy ra username, password , role vừa được insert vào DangNhap
	declare @username nvarchar(100),@password nvarchar(100),@role nvarchar(10)
	select @username = new.username ,@password = new.password , @role = new.role
	from inserted new
	-- tạo login
	declare @sql nvarchar(2000)
	set @sql = 'CREATE LOGIN [' + @username+']  WITH PASSWORD ='''+@password +''', DEFAULT_DATABASE = [QuanLyKhachSan],CHECK_EXPIRATION=OFF,
CHECK_POLICY=OFF'
	EXEC (@sql)
	-- tạo user
	set @sql = 'CREATE USER '+@username+' FOR LOGIN ' + @username
	exec (@sql)
	if(@role ='admin')
		set @sql = 'ALTER SERVER ROLE sysadmin' + ' ADD MEMBER '+  @username
	else
		set @sql = 'ALTER ROLE Staff ADD MEMBER ' + @username;
	EXEC (@sql)
end

insert DangNhap values ('sa2','29092003','admin')


-- kiểm tra đăng nhập 
drop function dbo.checkLogin
create function checkLogin (@username NVARCHAR(100), @password NVARCHAR(100))
returns int
as
begin 
	declare @role INT,@check nvarchar(100);
	SET @role = 0;
	SELECT @check = DangNhap.role
	FROM DangNhap
	WHERE username = @username and password = @password
	if @check = N'admin'  -- Sử dụng N để chỉ ra chuỗi Unicode
		set @role = 2;
	else if @check = N'user'  -- Sử dụng N để chỉ ra chuỗi Unicode
		set @role = 1;
	return @role;
end


--print(dbo.checkLogin('sda','29092003'))
SELECT dbo.checkLogin('nhanvien1', '29092003')


-- thêm tài khoản

CREATE procedure proc_ThemTaiKhoan 
@tk NVARCHAR(100), @mk NVARCHAR(100), @role NCHAR(10)
As
BEGIN
INSERT INTO DangNhap VALUES (@tk, @mk, @role)
END
--- tin
-- trigger xóa tài khoản
CREATE TRIGGER deleteAccount
ON DangNhap
AFTER DELETE
AS
BEGIN
    -- Lấy ra username vừa bị xóa
    DECLARE @username NVARCHAR(100)
    SELECT @username = username
    FROM deleted

    -- Xóa đăng nhập (LOGIN) tương ứng
    DECLARE @sqlLogin NVARCHAR(2000)
    SET @sqlLogin = 'DROP LOGIN [' + @username + ']'
    EXEC (@sqlLogin)

    -- Xóa người dùng (USER) tương ứng
    DECLARE @sqlUser NVARCHAR(2000)
    SET @sqlUser = 'DROP USER [' + @username + ']'
    EXEC (@sqlUser)
END

--procedure xoá tài khoản
CREATE PROCEDURE proc_XoaTaiKhoan
@username nvarchar(100)
AS
BEGIN
    DELETE FROM DangNhap
    WHERE username = @username;
END;

-- sửa procedure thêm tài khoản của tuấn 
CREATE PROCEDURE proc_ThemTaiKhoan 
@username nvarchar(100),
@password nvarchar(100),
@role nvarchar(10)
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM DangNhap
        WHERE username = @username
    )
    BEGIN
        RAISERROR('Username đã tồn tại.', 16, 1);
        RETURN;
    END

    INSERT INTO DangNhap (username, password, role)
    VALUES (@username, @password, @role);
END;

--> THIẾU TRIGGER BẮT LỖI INSERT TRÙNG USERNAME



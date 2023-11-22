use QuanLyKhachSan_21_11
go
drop procedure proc_DanhSachKH
go
-- danh sách khách hàng thanh toán---
create procedure proc_DanhSachKH ( @MaKH int)
as
begin
	Select * from KhachHang where MaKH=@MaKH
end
go
-- lấy số phòng,thời gian checkin của khách hàng---
create procedure proc_ChiTietPhong (@MaKH int)
as
begin
	select d.SoPhong,d.CheckIn from DatPhong d,KhachHang k where d.MaKH = k.MaKH and k.MaKH = @MaKH
end
go
--lấy dịch vụ mà khách hàng đã sử dụng---
create procedure proc_DichVuSuDung(@MaKH int)
as
begin
	  select d.TenDV,ds.SoLuong,ds.ThoiDiem,dbo.f_TongTienDichVu(k.MaKH) as tongtien from DanhSachSuDungDichVu ds,DichVu d,KhachHang k where ds.MaDV = d.MaDV and k.MaKH = ds.MaKH and k.MaKH = @MaKH;

end
go
-- lấy tổng tiền--
create procedure proc_TongTien(@MaKH int)
as 
begin
	  select sum(v.tongtien) as tongtiendv from (select d.TenDV,ds.SoLuong,ds.ThoiDiem,dbo.f_TongTienDichVu(@MaKH) as tongtien from DanhSachSuDungDichVu ds,DichVu d,KhachHang k where ds.MaDV = d.MaDV and k.MaKH = ds.MaKH and k.MaKH = @MaKH) v

end
go
-- cập nhật hóa đơn---
create procedure proc_LuuTruHoaDon(@MaKH int,@TongTien nvarchar(50))
as
begin
	insert into HoaDon
	values (@MaKH,GETDATE(),@TongTien)
end

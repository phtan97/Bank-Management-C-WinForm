create database BankManagement
go
use BankManagement
go
create table KhachHang(
	MaKH varchar(10),
	HoKH nvarchar(20),
	TenKH nvarchar(20),
	NgaySinh date,
	GioiTinh nvarchar(3),
	DanToc nvarchar(20),
	CMND varchar(12),
	NgayCap date,
	DiaChi nvarchar(20),
	Email varchar(50)
	primary key (MaKH)
)

create table NhanVien(
	MaNV varchar(10),
	HoNV nvarchar(20),
	TenNV nvarchar(20),
	ChucVu nvarchar(20)
	primary key (MaNV)
)

create table HopDong(
	MaHD varchar(10),
	LoaiHD nvarchar(50)
	primary key (MaHD)
)

create table HopDongChoVay(
	MaHD varchar(10),
	MaKH varchar(10),
	SoTienVay decimal(28,0),
	LaiSuat float,
	NgayVay date,
	NgayTra date,
	MucDichVay nvarchar(500),
	TheChap bit
	primary key (MaHD,MaKH)
)

create table HopDongTheChapTaiSan(
	MaHD varchar(10),
	MaKH varchar(10),
	LoaiTaiSan nvarchar(50),
	GiaTriTaiSan decimal(28,0)
	primary key (MaHD,MaKH)
)

create table HopDongGuiTietKiem(
	MaHD varchar(10),
	MaKH varchar(10),
	SoTienGui decimal(28,0),
	NgayGui date,
	NgayDenHan date,
	LaiSuat float
	primary key (MaHD,MaKH)
)

create table TaiKhoanNhanVien(
	TenDangNhap varchar(50),
	MatKhau varchar(MAX),
	MaNV varchar(10),
	ChucVu varchar(10)
	primary key (TenDangNhap)
)

create table ChucVuNhanVien(
	IDChucVu varchar(10),
	TenChucVu nvarchar(50)
	primary key (IDChucVu)
)

alter table HopDongChoVay
add constraint fk01_MaKH foreign key (MaKH) references KhachHang(MaKH)
alter table HopDongChoVay
add constraint fk02_MaHD foreign key (MaHD) references HopDong(MaHD)

alter table HopDongTheChapTaiSan
add constraint fk03_MaHD foreign key (MaHD) references HopDong(MaHD)
alter table HopDongTheChapTaiSan
add constraint fk04_MaKH foreign key (MaKH) references KhachHang(MaKH)

alter table HopDongGuiTietKiem
add constraint fk05_MaHD foreign key (MaHD) references HopDong(MaHD)
alter table HopDongGuiTietKiem
add constraint fk06_MaKH foreign key(MaKH) references KhachHang(MaKH)

alter table TaiKhoanNhanVien
add constraint fk02_MaNV foreign key (MaNV) references NhanVien(MaNV)
alter table TaiKhoanNhanVien
add constraint fk01_ChucVu_IDChucVu foreign key (ChucVu) references ChucVuNhanVien(IDChucVu)

insert into ChucVuNhanVien
values ('1',N'Nhân Viên')
insert into ChucVuNhanVien
values ('2',N'Quản Lý')

insert into NhanVien
values ('NV001',N'Nguyễn Văn',N'Khang',N'Quản Lý')
insert into NhanVien
values ('NV002',N'Trần',N'Nam',N'Nhân Viên')
insert into NhanVien
values ('NV003',N'Nguyễn Như',N'Quỳnh','Nhân Viên')
insert into NhanVien
values ('NV004',N'Cao Lê Tuấn',N'Tú',N'Nhân Viên')
insert into NhanVien
values ('NV005',N'Dương Thị',N'Diễm',N'Quản Lý')


insert into TaiKhoanNhanVien(TenDangNhap,MatKhau,MaNV,ChucVu)
values ('NV001','123','NV002','1')
insert into TaiKhoanNhanVien(TenDangNhap,MatKhau,MaNV,ChucVu)
values ('NV002','123','NV001','2')
insert into TaiKhoanNhanVien(TenDangNhap,MatKhau,MaNV,ChucVu)
values ('admin','admin','NV001','2')
insert into TaiKhoanNhanVien(TenDangNhap,MatKhau,MaNV,ChucVu)
values ('NV003','NV003','NV003','1')
insert into TaiKhoanNhanVien(TenDangNhap,MatKhau,MaNV,ChucVu)
values ('NV004','NV004','NV004','1')
insert into TaiKhoanNhanVien(TenDangNhap,MatKhau,MaNV,ChucVu)
values ('NV005','NV005','NV005','2')


insert into HopDong
values ('HD001',N'hợp đồng cho vay')
insert into HopDong
values ('HD002',N'hợp đồng thế chấp')
insert into HopDong
values ('HD003',N'hợp đồng tiết kiệm')
insert into HopDong
values ('HD004',N'hợp đồng cho vay')
insert into HopDong
values ('HD005',N'hợp đồng tiết kiệm')
insert into HopDong
values ('HD006',N'hợp đồng thế chấp')

set dateformat dmy
insert into KhachHang
values ('KH001',N'Trần Trung',N'Kiên','23/7/1998','Nam','Kinh','874950672','12/3/2012',N'Quận 2','trantrungkien@gmail.com')
insert into KhachHang
values ('KH002',N'Nguyễn Như',N'Ngọc','16/2/1995',N'Nữ',N'Tày','086397652','8/1/2010',N'Quận 9','nguyennhungoc@gmail.com')
insert into KhachHang
values ('KH003',N'Lê Văn',N'Hậu','14/5/1992',N'Nam','Kinh','398490871','30/8/2008',N'Tân Bình','levanhau@gmail.com')
insert into KhachHang
values ('KH004',N'Diệp Hoàng Trúc',N'Mai','12/12/1994',N'Nữ','Kinh','874090182','28/3/2008',N'Thủ Đức','diephoangtrucmai@gmail.com')
insert into KhachHang
values ('KH005',N'Phan Văn',N'Cao','5/1/1992',N'Nam','Kinh','874950672','12/3/2012',N'Quận 2','trantrungkien@gmail.com')
insert into KhachHang
values ('KH006',N'Nguyễn Kỳ',N'Duyên','18/2/1994',N'Nữ','Kinh','874950672','12/3/2012',N'Quận 2','trantrungkien@gmail.com')
insert into KhachHang
values ('KH007',N'Lê Thị',N'Nữ','23/7/1998',N'Nữ','Khome','874950672','12/3/2012',N'Quận 5','trantrungkien@gmail.com')
insert into KhachHang
values ('KH008',N'Lê Khương Yến',N'Vy','23/7/1998',N'Nữ','Kinh','874950672','12/3/2012',N'Quận 8','trantrungkien@gmail.com')
insert into KhachHang
values ('KH009',N'Nguyễn Văn',N'Chương','23/7/1998','Nam','Kinh','874950672','12/3/2012',N'Bình Thạnh','trantrungkien@gmail.com')
insert into KhachHang
values ('KH010',N'Lê Văn',N'Sĩ','23/7/1998','Nam','Kinh','874950672','12/3/2012',N'Nhà Bè','trantrungkien@gmail.com')

insert into HopDongChoVay
values ('HD001','KH001','280000','0.8','25/12/2020','25/6/2021',N'Tiêu dùng','0')


go
create proc SP_ThongTinTaiKhoanNV(@tendangnhap varchar(50),@matkhau varchar(50))
as
	select * from TaiKhoanNhanVien
	where TenDangNhap = @tendangnhap and MatKhau = @matkhau
	
go
create proc SP_LayDB
as
	select * from sys.databases
	
go
create proc SP_TimKiemNhanVien(@timkiem varchar(50))
as
	select * from NhanVien
	where MaNV=@timkiem or HoNV=@timkiem or TenNV=@timkiem or ChucVu=@timkiem
go
create proc SP_ThongTinNhanVien
as
	select * from NhanVien

go
create proc SP_ThemNhanVien(@manv varchar(10), @honv nvarchar(20), @tennv nvarchar(20), @chucvu nvarchar(20))
as
	insert into NhanVien(MaNV,HoNV,TenNV,ChucVu)
	values (@manv,@honv,@tennv,@chucvu)

go
create proc SP_XoaNhanVien(@manv varchar(10))
as
	delete from TaiKhoanNhanVien
	where MaNV=@manv	
	
go
create proc SP_SuaNhanVien(@manv varchar(10),@honv nvarchar(20),@tennv nvarchar(20),@chucvu nvarchar(20))
as
	update NhanVien set HoNV=@honv,TenNV=@tennv,ChucVu=@chucvu
	where MaNV=@manv
go
create proc SP_ThongTinTaiKhoanNhanVien
as
	select * from TaiKhoanNhanVien
go
create proc SP_ThemTaiKhoanNhanVien(@manv varchar(10), @taikhoan varchar(50), @matkhau varchar(MAX), @chucvu varchar(10))
as
	insert into TaiKhoanNhanVien(MaNV,TenDangNhap,MatKhau,ChucVu)
	values (@manv,@taikhoan,@matkhau,@chucvu)
go
create proc SP_XoaTaiKhoanNhanVien(@tendangnhap varchar(50))
as
	delete from TaiKhoanNhanVien
	where TenDangNhap=@tendangnhap
go
create proc SP_SuaTaiKhoanNhanVien(@manv varchar(10), @taikhoan varchar(50), @matkhau varchar(MAX), @chucvu varchar(10))
as
	update TaiKhoanNhanVien set TenDangNhap=@taikhoan, MatKhau=@matkhau, ChucVu=@chucvu
	where MaNV=@manv
go
create proc SP_TimKiemTaiKhoanNhanVien(@timkiem varchar(50))
as
	select * from TaiKhoanNhanVien
	where TenDangNhap = @timkiem or MaNV = @timkiem or MaNV = @timkiem or ChucVu = @timkiem
go
create proc LayDsMaNV
as
	select MaNV from NhanVien
go
create proc SP_ChucVuNV(@tendangnhap varchar(50))
as
	select * from NhanVien,ChucVuNhanVien,TaiKhoanNhanVien
	where NhanVien.MaNV = TaiKhoanNhanVien.MaNV and ChucVuNhanVien.IDChucVu = TaiKhoanNhanVien.ChucVu and TaiKhoanNhanVien.TenDangNhap = @tendangnhap
	
go
create proc SP_TimKiemKhachHang(@timkiem varchar(50))
as
	select * from KhachHang
	where MaKH=@timkiem or HoKH=@timkiem or TenKH=@timkiem or DiaChi=@timkiem or Email=@timkiem or CAST(NgaySinh as varchar(50))=@timkiem or GioiTinh =@timkiem or DanToc=@timkiem or CMND=@timkiem or CAST(NgaySinh as varchar(50))=@timkiem
go
create proc SP_ThongTinKhachHang
as
	select  * from KhachHang
go
create proc SP_ThemKhachHang(@makh varchar(10),@hokh nvarchar(20),@tenkh nvarchar(20),@ngaysinh date,@gioitinh nvarchar(3),@dantoc nvarchar(20),@cmnd varchar(12),@ngaycap date,@diachi nvarchar(20),@email varchar(50))
as
	insert into KhachHang
	values(@makh,@hokh,@tenkh,@ngaysinh,@gioitinh,@dantoc,@cmnd,@ngaycap,@diachi,@email)
go
create proc SP_XoaKhachHang(@makh varchar(10))
as
	delete from KhachHang
	where MaKH=@makh
go
create proc SP_SuaKhachHang(@makh varchar(10),@hokh nvarchar(20),@tenkh nvarchar(20),@ngaysinh date,@gioitinh nvarchar(3),@dantoc nvarchar(20),@cmnd varchar(12),@ngaycap date,@diachi nvarchar(20),@email varchar(50))
as
	update KhachHang set HoKH=@hokh,TenKH=@tenkh,NgaySinh=@ngaysinh,GioiTinh=@gioitinh,DanToc=@dantoc,CMND=@cmnd,NgayCap=@ngaycap,DiaChi=@diachi,Email=@email
	where MaKH=@makh
go
create proc SP_ThongTinHopDong
as
	select * from HopDong
go
create proc SP_ThemHopDong(@mahd varchar(10),@loaihd nvarchar(20))
as
	insert into HopDong
	values (@mahd,@loaihd)
go
create proc SP_XoaHopDong(@mahd varchar(10))
as
	delete from HopDong
	where MaHD=@mahd
go
create proc SP_SuaHopDong(@mahd varchar(10),@loaihd nvarchar(20))
as
	update HopDong set LoaiHD=@loaihd
	where MaHD=@mahd
go
create proc SP_DanhSachHopDongVay
as
	select * from HopDongChoVay
go
create proc SP_ThemHopDongVay(@mahd varchar(10),@makh varchar(10),@sotienvay money,@laisuat float,@ngayvay date,@ngaytra date,@mucdichvay nvarchar(500),@thechap bit)
as
	insert into HopDongChoVay
	values (@mahd,@makh,@sotienvay,@laisuat,@ngayvay,@ngaytra,@mucdichvay,@thechap)
go
create proc SP_XoaHopDongVay(@mahd varchar(10))
as
	delete from HopDongChoVay
	where MaHD=@mahd
go
create proc SP_SuaHopDongVay(@mahd varchar(10),@makh varchar(10),@sotienvay money,@laisuat float,@ngayvay date,@ngaytra date,@mucdichvay nvarchar(500),@thechap bit)
as
	update HopDongChoVay set MaKH=@makh,SoTienVay=@sotienvay,LaiSuat=@laisuat,NgayVay=@ngayvay,NgayTra=@ngaytra,MucDichVay=@mucdichvay,TheChap=@thechap
	where MaHD=@mahd
go
create proc SP_DanhSachHDTheChap
as
	select * from HopDongTheChapTaiSan
go
create proc SP_ThemHDTheChap(@mahd varchar(10),@makh varchar(10),@loaits nvarchar(50),@giatrits decimal(28,0))
as
	insert into HopDongTheChapTaiSan
	values (@mahd,@makh,@loaits,@giatrits)
go
create proc SP_XoaHDTheChap(@mahd varchar(10))
as
	delete from HopDongTheChapTaiSan
	where MaHD=@mahd
go
create proc SP_SuaHDTheChap(@mahd varchar(10),@makh varchar(10),@loaits nvarchar(50),@giatrits decimal(28,0))
as
	update HopDongTheChapTaiSan set MaHD=@mahd,MaKH=@makh,LoaiTaiSan=@loaits,GiaTriTaiSan=@giatrits
	where MaHD=@mahd
go
create proc SP_DanhSachHDTietKiem
as
	select * from HopDongGuiTietKiem
go
create proc SP_ThemHDTietKiem(@mahd varchar(10),@makh varchar(10),@sotiengui decimal(28,0),@ngaygui date,@kyhan date, @laisuat float)
as
	insert into HopDongGuiTietKiem
	values (@mahd,@makh,@sotiengui,@ngaygui,@kyhan,@laisuat)
go
create proc SP_XoaHDTietKiem(@mahd varchar(10))
as
	delete from HopDongGuiTietKiem
	where MaHD=@mahd
go
create proc SP_SuaHDTietKiem(@mahd varchar(10),@makh varchar(10),@sotiengui decimal(28,0),@ngaygui date,@kyhan date, @laisuat float)
as
	update HopDongGuiTietKiem set MaKH=@makh,SoTienGui=@sotiengui,NgayGui=@ngaygui,NgayDenHan=@kyhan,LaiSuat=@laisuat
	where MaHD=@mahd
	
go
create proc SP_LayMaHD
as
	select * from HopDong
go
create proc SP_LayMaKH
as
	select MaKH from KhachHang
go
create proc SP_TimKiemHDVay(@timkiem varchar(50))
as
	select * from HopDongChoVay
	where MaHD=@timkiem or MaKH=@timkiem or cast(SoTienVay as varchar(50))=@timkiem or cast(LaiSuat as varchar(50))=@timkiem or cast(NgayVay as varchar(50))=@timkiem or cast(NgayTra as varchar(50))=@timkiem or MucDichVay=@timkiem
go
create proc SP_ReportHopDongVay(@mahd varchar(10))
as
	select * from HopDong a, KhachHang b, HopDongChoVay c
	where a.MaHD=c.MaHD and b.MaKH=c.MaKH and c.MaHD=@mahd
go
create proc SP_TimKiemHDTheChap(@timkiem varchar(50))
as
	select * from HopDongTheChapTaiSan
	where MaHD=@timkiem or MaKH=@timkiem or LoaiTaiSan=@timkiem or CAST(GiaTriTaiSan as varchar(50))=@timkiem
go
create proc SP_ReportHopDongTheChap(@mahd varchar(10))
as
	select * from HopDong a, KhachHang b, HopDongTheChapTaiSan c
	where a.MaHD=c.MaHD and b.MaKH=c.MaKH and c.MaHD=@mahd
go
create proc SP_TimKiemHDTietKiem(@timkiem varchar(50))
as
	select * from HopDongGuiTietKiem
	where MaHD=@timkiem or MaKH=@timkiem or CAST(SoTienGui as varchar(50))=@timkiem or CAST(NgayGui as varchar(50))=@timkiem or CAST(NgayDenHan as varchar(50))=@timkiem or CAST(LaiSuat as varchar(50))=@timkiem
go
create proc SP_ReportHDTietKiem(@mahd varchar(10))
as
	select * from HopDong a, KhachHang b, HopDongGuiTietKiem c
	where a.MaHD=c.MaHD and b.MaKH=c.MaKH and c.MaHD=@mahd
go

create proc SP_ThongTinKhachHangVay(@makh varchar(10))
as
	select *
	from KhachHang a, HopDongChoVay b
	where a.MaKH=b.MaKH and b.MaKH=@makh
go
create proc SP_DanhSachKhachHangVay
as
	select * from HopDongChoVay
go
create proc SP_ThongTinKhachHangGui(@makh varchar(10))
as
	select *
	from KhachHang a, HopDongGuiTietKiem b
	where a.MaKH=b.MaKH and b.MaKH=@makh
go
create proc SP_DanhSachKhachHangGuiTietKiem
as
	select * from HopDongGuiTietKiem
go
create proc SP_DsHDTheoLoaiHD(@loaihd nvarchar(50))
as
	select * from HopDong
	where LoaiHD=@loaihd
go
create proc SP_ThongKeHDVay
as
	select * from KhachHang a, HopDongChoVay b
	where a.MaKH=b.MaKH 
go
create proc SP_ThongKeHDTheChap
as
	select * from KhachHang a, HopDongTheChapTaiSan b
	where a.MaKH=b.MaKH 
go
create proc SP_ThongKeHDTietKiem
as
	select * from KhachHang a, HopDongGuiTietKiem b
	where a.MaKH=b.MaKH 
go
create proc SP_ThongTinDangNhap(@taikhoan varchar(50))
as
	select a.TenDangNhap,a.MatKhau,b.HoNV,b.TenNV,b.ChucVu from TaiKhoanNhanVien a, NhanVien b
	where  a.MaNV=b.MaNV and TenDangNhap = @taikhoan
go
create proc SP_DoiMatKhau(@matkhau varchar(50),@taikhoan varchar(50))
as
	update TaiKhoanNhanVien set MatKhau=@matkhau
	where TenDangNhap = @taikhoan
go
create proc TimKiemHopDong(@timkiem varchar(50))
as
	select * from HopDong
	where MaHD = @timkiem
go
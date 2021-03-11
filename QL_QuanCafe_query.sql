create database QL_QuanCafe
use QL_QuanCafe

/* tạo bảng nhân viên */

alter table tblNhanvien (
	iMaNV int identity(1,1) NOT NULL,
	sHoten nvarchar (50) not null,
	sGioitinh nvarchar (10) not null,
	iSDT int not null,
	sDiachi nvarchar (50) not null,
	dNgaysinh date,
	sTrangthai nvarchar (20) null,
	isAdmin bit NOT NULL,
	sMatkhau varchar (10) not null
);

/* tạo bảng hóa đơn */

create table tblHoadon (
	iSoHD int identity(1,1) NOT NULL,
	iMaNV int NOT NULL,
	iMaban int NOT NULL,
	dNgaylap datetime,
	sTrangthai nvarchar (20) null,
	fTongtien real
);


/* tạo bảng chi tiết hóa đơn */

create table tblCT_Hoadon (
	iSoHD int NOT NULL,
	iMaSP int NOT NULL,
	iSoluong int null,
	fDongia real
);

/* tạo bảng bàn */

create table tblBan (
	iMaban int identity(1,1) NOT NULL,
	iTenban int NOT NULL,
	iSoluongkhach int NULL
);


/* tạo bảng sản phẩm */

create table tblSanpham (
	iMaSP int identity(1,1) NOT NULL,
	sTenSP nvarchar (20) not null,
	iMaloaiSP int not NULL,
	iSoluong int not null,
	fDongia real
);

/* tạo bảng danh mục sản phẩm */

create table tblLoaisanpham (
	iMaloaiSP int identity(1,1) NOT NULL,
	sTenloaiSP nvarchar (20) not null,
);


/*tạo proc kiểm tra đăng nhập */
alter proc LoginCheck 
@username varchar(10),
@password varchar(10)
as
select sHoten, sSDT, isAdmin, sMatkhau
from tblNhanvien 
where sSDT = @username and sMatkhau = @password

exec LoginCheck '0987654321', 123456

ALTER TABLE tblNhanvien
  DROP COLUMN iMaCV ;

/*insert fake data */
INSERT INTO tblNhanvien(sHoten, sGioitinh, sSDT, sDiachi, dNgaysinh, iMaCV, sTrangthai, isAdmin, sMatkhau)
VALUES ( 'phuong', 'nam', '0912345677', 'dinh cong', '02-11-1998', 2, 'dang lam',0, 'admin100');

/*tạo proc thêm nhân viên */
alter proc addNV
@sHoten varchar (50),
@sGioitinh nvarchar (10),
@sSDT varchar(10),
@sDiachi varchar(50),
@dNgaysinh date,
@status nvarchar (20),
@isAdmin bit,
@password varchar (20)
as
	BEGIN
		insert into tblNhanvien
		values (@sHoten,@sGioitinh,@sSDT,@sDiachi,@dNgaysinh, @status, @isAdmin, @password);
	END

	drop proc addNV
	
/*check nhân viên tồn tại*/
create proc checkEmployeeExist
@sSDT varchar(10)
as
select sSDT
from tblNhanvien 
where sSDT = @sSDT

exec checkEmployeeExist '0912345670'


/*tạo proc trả dữ liệu của bảng nhân viên */
alter proc returnNV
as 
select iMaNV, sHoten, sGioitinh,sSDT, sDiachi, dNgaysinh, sTrangthai, isAdmin
from tblNhanvien

exec returnNV

/*tạo proc đổi mật khẩu */
create proc ChangePW 
@username varchar(10),
@newPW varchar (10)
as
update tblNhanvien
set sMatkhau = @newPW 
where @username = sSDT


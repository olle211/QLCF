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

/*check loại đồ uống tồn tại*/
create proc checkCategoryExist
@categoryNm varchar(20)
as
select sTenloaidouong
from tblLoaidouong
where sTenloaidouong = @categoryNm

exec checkCategoryExist '0912345670'

/* thêm mới loại đồ uống */
create proc addCategory
@sTenloaidouong varchar (20)
as
	BEGIN
		insert into tblLoaidouong
		values (@sTenloaidouong);
	END

	/*tạo proc trả dữ liệu của bảng loại đồ uống */
create proc returnCategory
as 
select *
from tblLoaidouong

exec returnCategory

/* thêm mới  đồ uống */
create proc addBeverage
@sTendouong varchar (20),
@fDongia float,
@iSoluong int,
@iMaloaidouong int
as
	BEGIN
		insert into tblDouong
		values (@sTendouong,@fDongia,@iSoluong, @iMaloaidouong);
	END
exec addBeverage N'Phin đen đá', 35000, 30, 1
sp_help tblLoaidouong

		/*tạo proc trả dữ liệu của bảng đồ uống */
alter proc returnBeverage
as 
select tblDouong.iMadouong, tblDouong.sTendouong, tblDouong.iSoluong, tblDouong.fDongia, tblDouong.iMaloaidouong, tblLoaidouong.sTenloaidouong
from tblDouong, tblLoaidouong
where tblDouong.iMaloaidouong = tblLoaidouong.iMaloaidouong
exec returnBeverage

/*check loại đồ uống tồn tại*/
create proc checkBeverageExist
@beverageNm varchar(20)
as
select sTendouong
from tblDouong
where sTendouong = @beverageNm

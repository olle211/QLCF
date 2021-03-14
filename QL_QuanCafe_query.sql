create database QL_QuanCafe
GO
use QL_QuanCafe
GO
/* tạo bảng nhân viên */

CREATE table tblNhanvien (
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
GO
ALTER TABLE dbo.tblNhanvien ADD CONSTRAINT pk_iMaNV PRIMARY KEY(iMaNV);

/* tạo bảng hóa đơn */

create table tblHoadon (
	iSoHD int identity(1,1) NOT NULL,
	iMaNV int NOT NULL,
	iMaban int NOT NULL,
	dNgaylap datetime,
	sTrangthai nvarchar (20) null,
	fTongtien real
);
GO

/* tạo bảng chi tiết hóa đơn */

create table tblCT_Hoadon (
	iSoHD int NOT NULL,
	iMaSP int NOT NULL,
	iSoluong int null,
	fDongia real
);
GO
/* tạo bảng bàn */

create table tblBan (
	iMaban int identity(1,1) NOT NULL,
	iTenban int NOT NULL,
	iSoluongkhach int NULL
);

GO
/* tạo bảng sản phẩm */

create table tblSanpham (
	iMaSP int identity(1,1) NOT NULL,
	sTenSP nvarchar (20) not null,
	iMaloaiSP int not NULL,
	iSoluong int not null,
	fDongia real
);
GO
/* tạo bảng danh mục sản phẩm */

create table tblLoaisanpham (
	iMaloaiSP int identity(1,1) NOT NULL,
	sTenloaiSP nvarchar (20) not null,
);
GO


/*Tạo khóa*/
ALTER TABLE dbo.tblHoadon ADD CONSTRAINT pk_iSoHD PRIMARY KEY(iSoHD);
ALTER TABLE dbo.tblHoadon ADD CONSTRAINT fk_tblHoaDon_iMaNV FOREIGN KEY(iMaNV) REFERENCES dbo.tblNhanvien(iMaNV);
ALTER TABLE dbo.tblHoadon ADD CONSTRAINT fk_tblHoaDon_iMaBan FOREIGN KEY(iMaban) REFERENCES dbo.tblBan(iMaban);

GO
ALTER TABLE dbo.tblCT_Hoadon ADD CONSTRAINT pk_tblCT_Hoadon PRIMARY KEY(iSoHD,iMaSP);
ALTER TABLE dbo.tblCT_Hoadon ADD CONSTRAINT fk_tblCT_Hoadon_iSoHD FOREIGN KEY(iSoHD) REFERENCES dbo.tblHoadon(iSoHD);
ALTER TABLE dbo.tblCT_Hoadon ADD CONSTRAINT fk_tblCT_Hoadon_iMaSP FOREIGN KEY(iMaSP) REFERENCES dbo.tblSanpham(iMaSP);
GO
ALTER TABLE dbo.tblSanpham ADD CONSTRAINT pk_tblSanpham PRIMARY KEY(iMaSP);
ALTER TABLE dbo.tblSanpham ADD CONSTRAINT fk_tblSanpham FOREIGN KEY(iMaloaiSP) REFERENCES dbo.tblLoaisanpham(iMaloaiSP);
GO
ALTER TABLE dbo.tblLoaisanpham ADD CONSTRAINT pk_tblLoaisanpham PRIMARY KEY(iMaloaiSP);
GO
ALTER TABLE dbo.tblBan ADD CONSTRAINT pk_tblBan PRIMARY KEY(iMaban);
GO

SELECT * FROM dbo.tblHoadon
/*Tao proc thanh toan hoa don*/
ALTER PROC thanh_toan_HD
@iSoHD INT,
@sTrangthai NVARCHAR(100)
AS
BEGIN
	
	UPDATE dbo.tblHoadon SET sTrangthai=@sTrangthai WHERE iSoHD=@iSoHD;
	
END


ALTER PROC TongTienHD
@iSoHD INT
AS
BEGIN
	DECLARE @TongTien FLOAT;
	SET @TongTien= (SELECT SUM(ct.iSoluong*ct.fDongia) FROM dbo.tblCT_Hoadon AS ct WHERE iSoHD=@iSoHD);
	UPDATE dbo.tblHoadon SET fTongtien=@TongTien WHERE iSoHD=@iSoHD;
END

EXEC TongTienHD @iSoHD= 1007

/*Proc Huy hoa don*/
ALTER PROC HuyBill
@iSoHD INT
AS
BEGIN
	DELETE dbo.tblHoadon WHERE iSoHD= @iSoHD
END

EXEC HuyBill @iSoHD= 1006

DELETE dbo.tblHoadon  
SELECT * FROM dbo.tblHoadon
SELECT * FROM dbo.tblCT_Hoadon

SELECT ct.iMaSP,sp.sTenSP,ct.iSoluong,ct.fDongia FROM dbo.tblCT_Hoadon AS ct, dbo.tblSanpham AS sp WHERE ct.iMaSP=sp.iMaSP AND ct.iSoHD=10
EXEC thanh_toan_HD @iSoHD , @sTrangthai;

SELECT * FROM dbo.tblCT_Hoadon;










/*tạo proc kiểm tra đăng nhập */

CREATE proc LoginCheck 
@username varchar(10),
@password varchar(10)
as
select sHoten, sSDT, isAdmin, sMatkhau
from tblNhanvien 
<<<<<<< HEAD
where iSDT = @username and sMatkhau = @password
=======
where sSDT = @username and sMatkhau = @password

exec LoginCheck '0987654321', 123456
>>>>>>> 6694b717d2d073eafc76df2e4fa23e1acea80135

--exec LoginCheck '0912345677', admin100
GO
ALTER TABLE tblNhanvien
  ADD  iMaCV INT ;
  GO
/*insert fake data */
INSERT INTO tblNhanvien(sHoten, sGioitinh, iSDT, sDiachi, dNgaysinh, iMaCV, sTrangthai, isAdmin, sMatkhau)
VALUES ( 'phuong', 'nam', '0912345677', 'dinh cong', '02-11-1998', 2, 'dang lam',0, 'admin100');
INSERT INTO tblNhanvien(sHoten, sGioitinh, iSDT, sDiachi, dNgaysinh, iMaCV, sTrangthai, isAdmin, sMatkhau)
VALUES ( 'Đồng Duy Phương', 'nam', '0123', 'dinh cong', '02-11-1998', 2, 'dang lam',0, 'a');
GO
/*tạo proc thêm nhân viên */
<<<<<<< HEAD
CREATE proc addNV
@sHoten varchar (50),
@sGioitinh nvarchar (10),
@iSDT INT,
=======
alter proc addNV
@sHoten varchar (50),
@sGioitinh nvarchar (10),
@sSDT varchar(10),
>>>>>>> 6694b717d2d073eafc76df2e4fa23e1acea80135
@sDiachi varchar(50),
@dNgaysinh date,
@status nvarchar (20),
@iMaCV INT,
@isAdmin bit,
@password varchar (20)
as
	BEGIN
		insert into tblNhanvien
<<<<<<< HEAD
		values (@sHoten,@sGioitinh,@iSDT,@sDiachi,@dNgaysinh,@iMaCV, @status, @isAdmin, @password);
	END

--drop proc addNV
GO
=======
		values (@sHoten,@sGioitinh,@sSDT,@sDiachi,@dNgaysinh, @status, @isAdmin, @password);
	END

	drop proc addNV
	
>>>>>>> 6694b717d2d073eafc76df2e4fa23e1acea80135
/*check nhân viên tồn tại*/
create proc checkEmployeeExist
@sSDT varchar(10)
as
<<<<<<< HEAD
select iSDT
from tblNhanvien 
where iSDT = @sSDT
GO
exec checkEmployeeExist '912345677'

GO
/*tạo proc trả dữ liệu của bảng nhân viên */
create proc returnNV
as 
select iMaNV, sHoten, sGioitinh,iSDT, sDiachi, dNgaysinh, sTrangthai, isAdmin
=======
select sSDT
from tblNhanvien 
where sSDT = @sSDT

exec checkEmployeeExist '0912345670'


/*tạo proc trả dữ liệu của bảng nhân viên */
alter proc returnNV
as 
select iMaNV, sHoten, sGioitinh,sSDT, sDiachi, dNgaysinh, sTrangthai, isAdmin
>>>>>>> 6694b717d2d073eafc76df2e4fa23e1acea80135
from tblNhanvien

exec returnNV

<<<<<<< HEAD
INSERT dbo.tblLoaisanpham
        ( sTenloaiSP )
VALUES  ( N'Cafe đen đá'  -- sTenloaiSP - nvarchar(20)
          )
=======
/*proc sửa nhân viên*/
alter proc editNV 
@iMaNV int,
@sHoten varchar (50),
@sGioitinh nvarchar (10),
@sDiachi varchar(50),
@dNgaysinh date,
@status nvarchar (20),
@isAdmin bit
as 
update tblNhanvien
set sHoten = @sHoten, sGioitinh = @sGioitinh, sDiachi = @sDiachi, dNgaysinh = @dNgaysinh, sTrangthai = @status, isAdmin = @isAdmin
WHERE iMaNV = @iMaNV

/*proc xóa nhân viên*/
create proc deleteNV 
@iMaNV int
as 
DELETE
from tblNhanvien
WHERE iMaNV = @iMaNV 

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

/*proc sửa loại đồ uống*/
alter proc editCategory 
@iMaloaidouong int,
@sTenloaidouong nvarchar (20)
as 
update tblLoaidouong
set sTenloaidouong = @sTenloaidouong
WHERE iMaloaidouong = @iMaloaidouong

/*proc xóa loại đồ uống*/
create proc deleteCategory 
@iMaloaidouong int
as 
DELETE
from tblLoaidouong
WHERE iMaloaidouong = @iMaloaidouong 

alter view vvSolgDouongtheoLoai (maLoaidouong, tenLoaidouong, soluongdouong)
as
select tblLoaidouong.iMaloaidouong, tblLoaidouong.sTenloaidouong, count(tblDouong.iMadouong)
from tblLoaidouong join tblDouong 
on tblDouong.iMaloaidouong = tblLoaidouong.iMaloaidouong
group by tblLoaidouong.iMaloaidouong, tblLoaidouong.sTenloaidouong

select * from vvSolgDouongtheoLoai

/* kiểm tra ràng buộc loại đồ uống - đồ uống trước khi xóa */
create proc checkContraintCateBeverage
as
select 

/*tạo proc trả dữ liệu của bảng loại đồ uống */
create proc returnCategory
as 
select *
from tblLoaidouong

exec returnCategory

/* thêm mới  đồ uống */
alter proc addBeverage
@sTendouong nvarchar (20),
@fDongia float,
@iSoluong int,
@iMaloaidouong int
as
	BEGIN
		insert into tblDouong
		values (@sTendouong,@iMaloaidouong,@iSoluong, @fDongia);
	END

exec addBeverage N'Phin đen đá', 1, 30, 35000

/*proc sửa đồ uống*/
create proc editBeverage 
@iMadouong int,
@sTendouong nvarchar (20),
@fDongia float,
@iSoluong int,
@iMaloaidouong int
as 
update tblDouong
set sTendouong = @sTendouong, fDongia = @fDongia,iSoluong = @iSoluong, iMaloaidouong = @iMaloaidouong
WHERE iMadouong = @iMadouong

/*proc xóa đồ uống*/
create proc deleteBeverage
@iMadouong int
as 
DELETE
from tblDouong
WHERE iMadouong = @iMadouong

/*tạo proc trả dữ liệu của bảng đồ uống */
alter proc returnBeverage
as 
select tblDouong.iMadouong, tblDouong.sTendouong, tblDouong.iSoluong, tblDouong.fDongia, tblLoaidouong.sTenloaidouong, tblDouong.iMaloaidouong
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
>>>>>>> 6694b717d2d073eafc76df2e4fa23e1acea80135

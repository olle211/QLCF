create database QL_QuanCafe
GO
use QL_QuanCafe
GO
/* tạo bảng nhân viên */

CREATE table tblNhanvien (
	iMaNV int identity(1,1) NOT NULL,
	sHoten nvarchar (50) not null,
	sGioitinh nvarchar (10) not null,
	sSDT varchar (10) not null,
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
CREATE PROC thanh_toan_HD
@iSoHD INT,
@sTrangthai NVARCHAR(100)
AS
BEGIN
	
	UPDATE dbo.tblHoadon SET sTrangthai=@sTrangthai WHERE iSoHD=@iSoHD;
	
END
GO
CREATE PROC TongTienHD
@iSoHD INT
AS
BEGIN
	DECLARE @TongTien FLOAT;
	SET @TongTien= (SELECT SUM(ct.iSoluong*ct.fDongia) FROM dbo.tblCT_Hoadon AS ct WHERE iSoHD=@iSoHD);
	UPDATE dbo.tblHoadon SET fTongtien=@TongTien WHERE iSoHD=@iSoHD;
END

EXEC TongTienHD @iSoHD= 1007

/*Proc Huy hoa don*/
CREATE PROC HuyBill
@iSoHD INT
AS
BEGIN
	DELETE dbo.tblHoadon WHERE iSoHD= @iSoHD
END
GO
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
AS
BEGIN
	select sHoten, sSDT, isAdmin, sMatkhau, iMaNV
	FROM tblNhanvien 
	WHERE sSDT = @username and sMatkhau = @password
END


exec LoginCheck '0987654321', 123456


--exec LoginCheck '0912345677', admin100
GO
ALTER TABLE tblNhanvien
  ADD  iMaCV INT ;
  GO
/*insert fake data */
INSERT INTO tblNhanvien(sHoten, sGioitinh, sSDT, sDiachi, dNgaysinh, sTrangthai, isAdmin, sMatkhau)
VALUES ( N'Tài', 'Nam', '0987654321', N'Định Công', '02-11-1998', 'Đang làm',0, 'admin100');
INSERT INTO tblNhanvien(sHoten, sGioitinh, sSDT, sDiachi, dNgaysinh, iMaCV, sTrangthai, isAdmin, sMatkhau)
VALUES ( 'Đồng Duy Phương', 'nam', '0123', 'dinh cong', '02-11-1998', 2, 'dang lam',0, 'a');
GO
/*tạo proc thêm nhân viên */
create proc addNV
@sHoten nvarchar (50),
@sGioitinh nvarchar (10),
@sSDT varchar(10),
@sDiachi nvarchar(50),
@dNgaysinh date,
@status nvarchar (20),
@isAdmin bit,
@password VARCHAR(20),
@IMaCV INT
as
	BEGIN
		insert into tblNhanvien
		values (@sHoten,@sGioitinh,@sSDT,@sDiachi,@dNgaysinh, @status, @isAdmin, @password,@IMaCV);
	END
	drop proc addNV
	
/*check nhân viên tồn tại*/
create proc checkEmployeeExist
@sSDT varchar(10)
as
select sSDT
from tblNhanvien 
where sSDT = @sSDT
GO
exec checkEmployeeExist '912345677'

GO
/*tạo proc trả dữ liệu của bảng nhân viên 
create proc returnNV
as 
select iMaNV, sHoten, sGioitinh,sSDT, sDiachi, dNgaysinh, sTrangthai, isAdmin
select sSDT
from tblNhanvien 
where sSDT = @sSDT
*/
exec checkEmployeeExist '0912345670'


/*tạo proc trả dữ liệu của bảng nhân viên */
CREATE proc returnNV
as 
select iMaNV, sHoten, sGioitinh,sSDT, sDiachi, dNgaysinh, sTrangthai, isAdmin

from tblNhanvien

exec returnNV

INSERT dbo.tblLoaisanpham
        ( sTenloaiSP )
VALUES  ( N'Cafe đen đá'  -- sTenloaiSP - nvarchar(20)
          )
/*proc sửa nhân viên*/
CREATE proc editNV 
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
select sTenloaiSP
from dbo.tblLoaisanpham
where sTenloaiSP = @categoryNm

exec checkCategoryExist '0912345670'

/* thêm mới loại đồ uống */
create proc addCategory
@sTenloaidouong varchar (20)
as
	BEGIN
		insert into dbo.tblLoaisanpham
		        ( sTenloaiSP )
		values (@sTenloaidouong);
	END

/*proc sửa loại đồ uống*/
CREATE proc editCategory 
@iMaloaidouong int,
@sTenloaidouong nvarchar (20)
as 
update dbo.tblLoaisanpham
set sTenloaiSP = @sTenloaidouong
WHERE iMaloaiSP = @iMaloaidouong

/*proc xóa loại đồ uống*/
create proc deleteCategory 
@iMaloaidouong int
as 
DELETE
from dbo.tblLoaisanpham
WHERE iMaloaiSP = @iMaloaidouong 

exec deleteCategory 6

CREATE view vvSolgDouongtheoLoai (maLoaidouong, tenLoaidouong, soluongdouong)
as
select tblLoaisanpham.iMaloaiSP, dbo.tblLoaisanpham.sTenloaiSP, count(dbo.tblSanpham.iMaSP)
from dbo.tblLoaisanpham join dbo.tblSanpham 
on dbo.tblSanpham.iMaloaiSP = dbo.tblLoaisanpham.iMaloaiSP
group by dbo.tblLoaisanpham.iMaloaiSP, dbo.tblLoaisanpham.sTenloaiSP

select * from vvSolgDouongtheoLoai

/* kiểm tra ràng buộc loại đồ uống - đồ uống trước khi xóa */
DECLARE @returnvalue int;
EXEC @returnvalue = checkContraintCateBeverage @iMaloaidouong = 1
select @returnvalue

create proc checkContraintCateBeverage
@iMaloaidouong int
as
IF EXISTS (SELECT top(1) * FROM dbo.tblSanpham WHERE iMaloaiSP = @iMaloaidouong) 
--true
BEGIN
   return 1 
END
--false
ELSE
BEGIN
    return 0
END 
exec checkContraintCateBeverage 1

/*tạo proc trả dữ liệu của bảng loại đồ uống */
create proc returnCategory
as 
select *
from dbo.tblLoaisanpham

exec returnCategory

/* thêm mới  đồ uống */
CREATE proc addBeverage
@sTendouong nvarchar (20),
@fDongia float,
@iSoluong int,
@iMaloaidouong int
as
	BEGIN
		insert into tblSanpham
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
update tblSanpham
set sTenSP = @sTendouong, fDongia = @fDongia,iSoluong = @iSoluong, iMaloaiSP = @iMaloaidouong
WHERE iMaSP = @iMadouong

/*proc xóa đồ uống*/
create proc deleteBeverage
@iMadouong int
as 
DELETE
from dbo.tblSanpham
WHERE iMaSP = @iMadouong

exec deleteBeverage 16

/*tạo proc trả dữ liệu của bảng đồ uống */
CREATE proc returnBeverage
as 
select dbo.tblSanpham.iMaSP, dbo.tblSanpham.sTenSP, dbo.tblSanpham.iSoluong, dbo.tblSanpham.fDongia, dbo.tblLoaisanpham.sTenloaiSP, dbo.tblSanpham.iMaloaiSP
from dbo.tblSanpham, dbo.tblLoaisanpham
where dbo.tblSanpham.iMaloaiSP = dbo.tblLoaisanpham.iMaloaiSP
exec returnBeverage

/*check loại đồ uống tồn tại*/
create proc checkBeverageExist
@beverageNm varchar(20)
as
select sTenSP
from dbo.tblSanpham
where sTenSP = @beverageNm


CREATE PROC add_bill
@iMaNV INT, @iMaBan INT, @sTrangthai NVARCHAR(30)
AS
BEGIN
	INSERT dbo.tblHoadon
	        ( iMaNV ,
	          iMaban ,
	          dNgaylap ,
	          sTrangthai 
	          
	        )
	VALUES  ( @iMaNV , -- iMaNV - int
	          @iMaBan , -- iMaban - int
	          GETDATE() , -- dNgaylap - datetime
	          @sTrangthai  -- sTrangthai - nvarchar(20)
	          
	        )
END
EXECUTE addBillinfor @iSoHD , @iMaSP , @iSoluong , @fDongia

CREATE PROC addBillinfor
@iSoHD INT, @iMaSP INT, @iSoluong INT, @fDongia Float
AS
BEGIN
	INSERT dbo.tblCT_Hoadon
	        ( iSoHD, iMaSP, iSoluong, fDongia )
	VALUES  ( @iSoHD, -- iSoHD - int
	          @iMaSP, -- iMaSP - int
	          @iSoluong, -- iSoluong - int
	          @fDongia  -- fDongia - real
	          )
END

EXEC dbo.layNVtheoma @iMaNV

CREATE PROC layNVtheoma
@iMaNV INT
AS
BEGIN
	SELECT * FROM dbo.tblNhanvien WHERE iMaNV=@iMaNV
END

ALTER TABLE dbo.tblHoadon ALTER COLUMN fTongtien FLOAT

Select * from tblHoaDon
DELETE dbo.tblHoadon WHERE iSoHD=1
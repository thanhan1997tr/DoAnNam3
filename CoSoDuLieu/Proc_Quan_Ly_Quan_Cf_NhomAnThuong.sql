﻿-- Stored Procedures
GO
USE QuanLyQuanCf

--====>>>ĐĂNG NHẬP
--Load form đăng nhập
GO
CREATE PROC SP_DANGNHAP
@taikhoan nvarchar(100), @matkhau nvarchar(100)
AS
BEGIN
	SELECT *
	FROM NHANVIEN
	WHERE MANV = @taikhoan AND MATKHAU = @matkhau
END

--====>>>NHÂN VIÊN
--Load nhân viên
GO
CREATE PROC SP_NHANVIEN_LOAD
AS
BEGIN
	SELECT *
	FROM NHANVIEN
END

--Load Combobox theo tên nhân viên
GO
CREATE PROC SP_NHANVIEN_LOADCOMBOBOX
AS
BEGIN
	SELECT TENNV
	FROM NHANVIEN
	GROUP BY TENNV
END

--Lấy số lớn nhất của mã nhân viên
GO
CREATE PROC SP_GETMANV
AS
BEGIN
	SELECT TOP (1) CAST(RIGHT(MANV, 4) AS INTEGER) + 1 AS MASONV
	FROM NHANVIEN
	ORDER BY MANV DESC
END


--Thêm nhân viên
GO
CREATE PROC SP_NHANVIEN_THEM
	@MANV NVARCHAR(10),
	@TENNV NVARCHAR(100),
	@NGAYSINH DATE,
	@GIOITINH NVARCHAR(5),
	@DIACHI NVARCHAR(100),
	@DIENTHOAI VARCHAR(11),
	@MATKHAU NVARCHAR(100),
	@QUYEN NVARCHAR(100) ,
	@LUONGCOBAN MONEY
AS
BEGIN
	INSERT INTO NHANVIEN(MANV, TENNV, NGAYSINH, GIOITINH, DIACHI, DIENTHOAI, MATKHAU, QUYEN, LUONGCOBAN)
	VALUES(@MANV, @TENNV, @NGAYSINH, @GIOITINH, @DIACHI, @DIENTHOAI, @MATKHAU, @QUYEN, @LUONGCOBAN)
END


--Xóa nhân viên
GO
CREATE PROC SP_NHANVIEN_XOA
	@MANV NVARCHAR(10)
AS
BEGIN
	DELETE FROM NHANVIEN WHERE @MANV = MANV AND QUYEN != 'Admin' 
END

--Sửa nhân viên
GO
CREATE PROC SP_NHANVIEN_SUA
	@MANV NVARCHAR(10),
	@TENNV NVARCHAR(100),
	@NGAYSINH DATE,
	@GIOITINH NVARCHAR(5),
	@DIACHI NVARCHAR(100),
	@DIENTHOAI VARCHAR(11),
	@QUYEN NVARCHAR(100) ,
	@LUONGCOBAN MONEY
AS
BEGIN
	UPDATE NHANVIEN SET TENNV = @TENNV, NGAYSINH = @NGAYSINH, GIOITINH = @GIOITINH, DIACHI = @DIACHI, DIENTHOAI = @DIENTHOAI, QUYEN = @QUYEN, LUONGCOBAN = @LUONGCOBAN
	WHERE MANV = @MANV
END

--Sửa mật khẩu nhân viên
GO
CREATE PROC SP_NHANVIEN_SUA_MATKHAU
	@MANV NVARCHAR(10),
	@MATKHAU NVARCHAR(100)
AS
BEGIN
	UPDATE NHANVIEN SET MATKHAU = @MATKHAU
	WHERE MANV = @MANV
END

--Load Thông tin tài khoản
GO
CREATE PROC SP_NHANVIEN_LOADTAIKHOAN
	@MANV NVARCHAR(10)
AS
BEGIN
	SELECT *
	FROM NHANVIEN
	WHERE MANV = @MANV
END

--====>>>CHẤM CÔNG
GO
CREATE PROC SP_CHAMCONG
	@THANG VARCHAR(2),
	@NAM VARCHAR(4)
AS
BEGIN
	SELECT *
	FROM CHAMCONGCHITIET
	WHERE MACHAMCONG IN (SELECT MACHAMCONG FROM CHAMCONG WHERE NAM = @NAM AND THANG = @THANG) AND MANV IN (SELECT MANV FROM CHAMCONG WHERE NAM = @NAM AND THANG = @THANG)
END

GO
CREATE PROC SP_CHAMCONG_THEM
	@MANV VARCHAR(10),
	@THANG VARCHAR(2),
	@NAM VARCHAR(4)
AS
BEGIN
	INSERT INTO CHAMCONG(MANV, THANG, NAM)
	VALUES(@MANV, @THANG, @NAM)
END

GO
CREATE PROC SP_CHAMCONG_CHECKTHANGNAM
	@THANG VARCHAR(2),
	@NAM VARCHAR(4)
AS
BEGIN
	SELECT COUNT(*)
	FROM CHAMCONG
	WHERE THANG = @THANG AND NAM = @NAM
END

GO
CREATE TRIGGER TG_CHAMCONG
ON NHANVIEN FOR INSERT
AS
BEGIN
	DECLARE @MANV VARCHAR(10)
	SELECT @MANV = MANV FROM inserted
	DECLARE @time DATETIME
	SELECT @time = getdate()
	INSERT INTO CHAMCONG(MANV, THANG, NAM) VALUES(@MANV, MONTH(@time), YEAR(@time))
END


GO
CREATE TRIGGER TG_CHAMCONGCHITIET
ON CHAMCONG FOR INSERT
AS
BEGIN
	DECLARE @MACHAMCONG INT
	DECLARE @MANV VARCHAR(10)
	SELECT @MACHAMCONG = MACHAMCONG, @MANV = MANV FROM inserted
	DECLARE @TENNV NVARCHAR(50)
	SELECT @TENNV = TENNV FROM NHANVIEN WHERE MANV = @MANV
	INSERT INTO CHAMCONGCHITIET(MACHAMCONG, MANV, TENNV)
	VALUES(@MACHAMCONG, @MANV, @TENNV)
END

--====>>>BÀN
--Load danh sách bàn
GO
CREATE PROC SP_TABLE_LOAD
AS
BEGIN
	SELECT *
	FROM BAN
END

--Thêm bàn
GO
CREATE PROC SP_TABLE_THEM
AS
BEGIN
	DECLARE @MA INT
	DECLARE @TEN NVARCHAR(10)
	SELECT  @MA = MAX(MABAN)
	FROM BAN
	SET @MA = @MA + 1
	SET @TEN = N'BÀN ' + CAST(@MA AS nvarchar(5))
	INSERT INTO BAN(MABAN, TENBAN)
	VALUES(@MA, @TEN)
END

--Xóa bàn
GO
CREATE PROC SP_TABLE_XOA
AS
BEGIN
	DECLARE @MA INT
	SELECT  @MA = MAX(MABAN)
	FROM BAN
	DELETE FROM BAN WHERE MABAN = @MA AND TRANGTHAI <> N'CÓ'
END

--====>>>SẢN PHẨM
--Load danh sách sản phẩm
GO
CREATE PROC SP_SANPHAM_LOAD
AS
BEGIN
	SELECT *
	FROM SANPHAM
END

--Kiểm tra tên sản phẩm có tồn tại hay không
GO
CREATE PROC SP_SANPHAM_KTRATENSP
	@TENSP NVARCHAR(100)
AS
BEGIN
	SELECT *
	FROM SANPHAM
	WHERE TENSP = @TENSP
END

--Thêm sản phẩm
GO
CREATE PROC SP_SANPHAM_THEM
	@MASP VARCHAR(10),
	@TENSP VARCHAR(100),
	@DONGIABAN MONEY
AS
BEGIN
	INSERT INTO SANPHAM(MASP, TENSP, DONGIABAN)
	VALUES(@MASP, @TENSP, @DONGIABAN)
END

--Sửa sản phẩm
GO
CREATE PROC SP_SANPHAM_SUA
	@MASP VARCHAR(10),
	@TENSP VARCHAR(100),
	@DONGIABAN MONEY
AS
BEGIN
	UPDATE SANPHAM SET TENSP = @TENSP, DONGIABAN = @DONGIABAN WHERE MASP = @MASP
END

--====>>NHÀ CUNG CẤP
--Load Nhà cung cấp
GO
CREATE PROC SP_NHACUNGCAP_DS
AS
BEGIN
	SELECT * FROM NHACUNGCAP
END
--Thêm nhà cung cấp
GO
CREATE PROC SP_NHACUNGCAP_THEM
	@MANCC VARCHAR(10),
	@TENNCC NVARCHAR(100),
	@DIACHINCC NVARCHAR(100),
	@DIENTHOAINCC VARCHAR(11)
AS
BEGIN
	INSERT INTO NHACUNGCAP
	VALUES(@MANCC, @TENNCC, @DIACHINCC, @DIENTHOAINCC)
END
--Sửa nhà cung cấp
GO
CREATE PROC SP_NHACUNGCAP_SUA
	@MANCC VARCHAR(10),
	@TENNCC NVARCHAR(100),
	@DIACHINCC NVARCHAR(100),
	@DIENTHOAINCC VARCHAR(11)
AS
BEGIN
	UPDATE NHACUNGCAP
	SET TENNCC = @TENNCC, DIACHINCC = @DIACHINCC, DIENTHOAINCC = @DIENTHOAINCC
	WHERE MANCC = @MANCC
END
--Xóa nhà cung cấp
GO
CREATE PROC SP_NHACUNGCAP_XOA
	@MANCC VARCHAR(10)
AS
BEGIN
	DELETE NHACUNGCAP WHERE MANCC = @MANCC
END
--====>>>HÓA ĐƠN
--Load danh sách hóa đơn
GO
CREATE PROC SP_HOADON_DS
AS
BEGIN
	SELECT *
	FROM HOADON
	WHERE GHICHU <> N'CHƯA THANH TOÁN'
END


--Tìm hóa đơn theo ngày
GO
CREATE PROC SP_HOADON_TIM
	@TUNGAY DATE,
	@DENNGAY DATE
AS
BEGIN
	SELECT *
	FROM HOADON
	WHERE GHICHU <> N'CHƯA THANH TOÁN' AND CAST(NGAYXUAT AS DATE) >= @TUNGAY AND CAST(NGAYXUAT AS DATE) <= @DENNGAY
END


--Xem hóa đơn chi tiết
GO
CREATE PROC SP_HOADONCHITIET_DS
	@MAHOADON NVARCHAR(20)
AS
BEGIN
	SELECT *
	FROM HOADON HD JOIN HOADONCHITIET HDCT ON HD.MAHOADON = HDCT.MAHOADON JOIN SANPHAM SP ON SP.MASP = HDCT.MASP JOIN NHANVIEN NV ON NV.MANV = HD.MANV JOIN BAN B ON B.MABAN = HD.MABAN
	WHERE HD.MAHOADON = @MAHOADON
END

--Load hóa đơn thanh toán
GO
CREATE PROC SP_HOADONTHANHTOAN_LOAD
	@MABAN VARCHAR(10)
AS
BEGIN
	SELECT SP.TENSP, HDCT.SOLUONG, SP.DONGIABAN, (SP.DONGIABAN * HDCT.SOLUONG) THANHTIEN, HD.NGAYNHAP, NV.TENNV, HD.GIAMGIA, HD.VAT, HD.GHICHU
	FROM HOADON HD JOIN HOADONCHITIET HDCT ON HD.MAHOADON = HDCT.MAHOADON JOIN BAN B ON HD.MABAN = B.MABAN JOIN SANPHAM SP ON SP.MASP = HDCT.MASP JOIN NHANVIEN NV ON NV.MANV = HD.MANV
	WHERE (B.MABAN = @MABAN AND HD.GHICHU <> N'ĐÃ THU')
END
--Load doanh thu
GO
CREATE PROC SP_DOANHTHU_DS
AS
BEGIN
	SELECT SP.MASP, SP.TENSP, SP.DONGIABAN, SUM(CT.SOLUONG) SOLUONG, SUM(CT.SOLUONG*SP.DONGIABAN) THANHTIEN
	FROM HOADON HD JOIN HOADONCHITIET CT ON HD.MAHOADON = CT.MAHOADON JOIN SANPHAM SP ON SP.MASP = CT.MASP
	WHERE HD.GHICHU = N'ĐÃ THU'
	GROUP BY SP.MASP, SP.TENSP, SP.DONGIABAN
END

--Tìm doanh thu
GO
CREATE PROC SP_DOANHTHU_TIM
	@TUNGAY DATE,
	@DENNGAY DATE
AS
BEGIN
	SELECT SP.MASP, SP.TENSP, SP.DONGIABAN, SUM(CT.SOLUONG) SOLUONG, SUM(CT.SOLUONG*SP.DONGIABAN) THANHTIEN
	FROM HOADON HD JOIN HOADONCHITIET CT ON HD.MAHOADON = CT.MAHOADON JOIN SANPHAM SP ON SP.MASP = CT.MASP
	WHERE HD.GHICHU = N'ĐÃ THU' AND CAST(HD.NGAYXUAT AS DATE) >= @TUNGAY AND CAST(HD.NGAYXUAT AS DATE) <= @DENNGAY
	GROUP BY SP.MASP, SP.TENSP, SP.DONGIABAN
END

--THÊM MÓN
GO
CREATE PROC SP_HOADON_TONTAIHD
	@MABAN VARCHAR(5)
AS
BEGIN
	SELECT *
	FROM HOADON
	WHERE MABAN = @MABAN AND GHICHU <> N'ĐÃ THU'
END


--THANH TOÁN
GO
CREATE PROC SP_THANHTOANHOADON
	@MAHOADON VARCHAR(20),
	@THANHTOAN MONEY,
	@GIAMGIA FLOAT,
	@VAT FLOAT
AS
BEGIN
	UPDATE HOADON SET NGAYXUAT = GETDATE(), GIAMGIA = @GIAMGIA, VAT = @VAT, THANHTOAN = @THANHTOAN, GHICHU = N'ĐÃ THU'
	WHERE MAHOADON = @MAHOADON
END


GO
CREATE PROC SP_THEMHOADON
	@mahoadon varchar(20),
	@manv varchar(10),
	@maban varchar(10), 
	@giamgia float,
	@vat float
AS
BEGIN
	INSERT INTO HOADON(MAHOADON, NGAYNHAP, MANV, MABAN, GIAMGIA, VAT, GHICHU)	
	VALUES(@mahoadon, GETDATE(), @manv, @maban, @giamgia, @vat, N'CHƯA THANH TOÁN')
END

GO
CREATE PROC SP_THEMHOADONCHITIET
	@mahoadon varchar(20), @masp varchar(10), @soluong int
AS
BEGIN
	DECLARE @KTRA INT
	DECLARE @SOSP INT = 1
	SELECT @KTRA = COUNT(*),  @SOSP = SOLUONG
	FROM HOADONCHITIET
	WHERE @mahoadon = MAHOADON AND @masp = MASP
	GROUP BY MAHOADON, SOLUONG

	IF (@KTRA>0)
	BEGIN
		IF(@soluong>0)
			UPDATE HOADONCHITIET SET SOLUONG = @soluong WHERE @mahoadon = MAHOADON AND @masp = MASP
		IF(@soluong=0)
		BEGIN
			DELETE HOADONCHITIET WHERE @mahoadon = MAHOADON AND @masp = MASP

			--Delete
			
			--DECLARE @mahdDel NVARCHAR(20)
			--SELECT @mahdDel = MAHOADON FROM HOADONCHITIET

			DECLARE @countDel INT
			SELECT @countDel = COUNT(*) FROM HOADONCHITIET WHERE MAHOADON = @mahoadon
			DECLARE @mabanDel NVARCHAR(10)
			SELECT @mabanDel = MABAN FROM HOADON WHERE MAHOADON = @mahoadon AND GHICHU = N'CHƯA THANH TOÁN'
			IF (@countDel = 0)
			BEGIN
				UPDATE BAN SET TRANGTHAI = N'TRỐNG' WHERE MABAN = @mabanDel
				DELETE FROM HOADON WHERE MAHOADON = @mahoadon
			END

		END
	END

	ELSE
	BEGIN
		IF (@soluong>0)
		BEGIN
			INSERT HOADONCHITIET(MAHOADON, MASP, SOLUONG)
			VALUES(@mahoadon, @masp, @soluong)
		END
	END
END


GO
CREATE TRIGGER TG_CapNhatHoaDonChiTiet
ON HOADONCHITIET FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @mahd NVARCHAR(20)
	
	SELECT @mahd = MAHOADON FROM Inserted
	
	DECLARE @maban NVARCHAR(10)
	SELECT @maban = MABAN FROM HOADON WHERE MAHOADON = @mahd AND GHICHU = N'CHƯA THANH TOÁN'

	DECLARE @count INT
	SELECT @count = COUNT(*) FROM HOADONCHITIET WHERE MAHOADON = @mahd
	

	IF (@count > 0)
	BEGIN
		UPDATE BAN SET TRANGTHAI = N'CÓ' WHERE MABAN = @maban
	END
	ELSE
	BEGIN
		UPDATE BAN SET TRANGTHAI = N'TRỐNG' WHERE MABAN = @maban
	END
END

GO
CREATE TRIGGER TG_CAPNHATHOADON
ON HOADON FOR UPDATE
AS
BEGIN
	DECLARE @mahd NVARCHAR(20)
	
	SELECT @mahd = MAHOADON FROM Inserted	
	
	DECLARE @maban NVARCHAR(10)
	
	SELECT @maban = MABAN FROM HOADON WHERE MAHOADON = @mahd
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM HOADON WHERE MABAN = @maban AND GHICHU = N'CHƯA THANH TOÁN'
	
	IF (@count = 0)
		UPDATE BAN SET TRANGTHAI = N'TRỐNG' WHERE MABAN = @maban
END

GO
CREATE PROC SP_GIAMGIA_VAT
	@mahoadon varchar(20),
	@giamgia float,
	@vat float
AS
BEGIN
	UPDATE HOADON SET GIAMGIA = @giamgia, VAT = @vat WHERE MAHOADON = @mahoadon
END

--Chuyển bàn
GO
CREATE PROC SP_CHUYENBAN
@idTable1 NVARCHAR(10), @idTable2 NVARCHAR(10), @mahoadon varchar(20), @manv varchar(10)
AS BEGIN

	DECLARE @idFirstBill NVARCHAR(20)
	DECLARE @idSeconrdBill NVARCHAR(20)
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = MAHOADON FROM HOADON WHERE MABAN = @idTable2 AND GHICHU = N'CHƯA THANH TOÁN'
	SELECT @idFirstBill = MAHOADON FROM HOADON WHERE MABAN = @idTable1 AND GHICHU = N'CHƯA THANH TOÁN'
	IF (@idFirstBill IS NULL AND @idSeconrdBill IS NULL)
		BEGIN
			RETURN
		END
	ELSE
	BEGIN
		IF (@idFirstBill IS NULL)
		BEGIN
			INSERT INTO HOADON(MAHOADON, NGAYNHAP, MANV, MABAN, GHICHU)
			VALUES(@mahoadon, GETDATE(), @manv, @idTable1, N'CHƯA THANH TOÁN')
		        
			SELECT @idFirstBill = @mahoadon--MAHOADON FROM HOADON WHERE MABAN = @idTable1 AND GHICHU = N'CHƯA THANH TOÁN'
		END
	
		SELECT @isFirstTablEmty = COUNT(*) FROM HOADONCHITIET WHERE MAHOADON = @idFirstBill

		IF (@idSeconrdBill IS NULL)
		BEGIN
			INSERT INTO HOADON(MAHOADON, NGAYNHAP, MANV, MABAN, GHICHU)
			VALUES(@mahoadon, GETDATE(), @manv, @idTable2, N'CHƯA THANH TOÁN')

			SELECT @idSeconrdBill = @mahoadon-- MAHOADON FROM HOADON WHERE MABAN = @idTable2 AND GHICHU = N'CHƯA THANH TOÁN'
		
		END
	
		SELECT @isSecondTablEmty = COUNT(*) FROM HOADONCHITIET WHERE MAHOADON = @idSeconrdBill

		SELECT MAHOADON, MASP INTO IDBillInfoTable FROM HOADONCHITIET WHERE MAHOADON = @idSeconrdBill
	

		DECLARE @DEM INT = 0
		SELECT @DEM = COUNT(*) FROM HOADONCHITIET WHERE MAHOADON IN (SELECT MAHOADON FROM IDBillInfoTable) AND MASP IN (SELECT MASP FROM IDBillInfoTable)
		IF (@DEM > 0)
		BEGIN
			INSERT INTO HOADON(MAHOADON, NGAYNHAP, MANV, MABAN, GHICHU)
			VALUES(@mahoadon, GETDATE(), @manv, @idTable2, N'CHƯA THANH TOÁN')

			UPDATE HOADONCHITIET SET MAHOADON = @mahoadon WHERE MAHOADON = @idFirstBill
			UPDATE HOADONCHITIET SET MAHOADON = @idFirstBill WHERE MAHOADON IN (SELECT MAHOADON FROM IDBillInfoTable) AND MASP IN (SELECT MASP FROM IDBillInfoTable)
			UPDATE HOADONCHITIET SET MAHOADON = @idSeconrdBill WHERE MAHOADON = @mahoadon
			
			DELETE FROM HOADONCHITIET WHERE MAHOADON = @mahoadon
			DELETE FROM HOADON WHERE MAHOADON = @mahoadon

			
		END
		ELSE
		BEGIN
			UPDATE HOADONCHITIET SET MAHOADON = @idSeconrdBill WHERE MAHOADON = @idFirstBill
			UPDATE HOADONCHITIET SET MAHOADON = @idFirstBill WHERE MAHOADON IN (SELECT MAHOADON FROM IDBillInfoTable) AND MASP IN (SELECT MASP FROM IDBillInfoTable)
		END
		DROP TABLE IDBillInfoTable
	
		IF (@isFirstTablEmty = 0)
		BEGIN
			UPDATE BAN SET TRANGTHAI = N'TRỐNG' WHERE MABAN = @idTable2
			DELETE FROM HOADON WHERE MABAN = @idTable2 AND GHICHU = N'CHƯA THANH TOÁN'
		END
			
		IF (@isSecondTablEmty= 0)
		BEGIN
			UPDATE BAN SET TRANGTHAI = N'TRỐNG' WHERE MABAN = @idTable1
			DELETE FROM HOADON WHERE MABAN = @idTable1 AND GHICHU = N'CHƯA THANH TOÁN'
		END
	END
END

--Gộp bàn
GO
CREATE PROC SP_GOPBAN
@idTable1 NVARCHAR(10), @idTable2 NVARCHAR(10)
AS
BEGIN

	DECLARE @idFirstBill NVARCHAR(20)
	DECLARE @idSeconrdBill NVARCHAR(20)
	
	SELECT @idSeconrdBill = MAHOADON FROM HOADON WHERE MABAN = @idTable2 AND GHICHU = N'CHƯA THANH TOÁN'
	SELECT @idFirstBill = MAHOADON FROM HOADON WHERE MABAN = @idTable1 AND GHICHU = N'CHƯA THANH TOÁN'

	IF (@idFirstBill IS NOT NULL AND @idSeconrdBill IS NOT NULL)
	BEGIN
		SELECT MAHOADON, MASP, SOLUONG  INTO IDBillInfoTable FROM HOADONCHITIET WHERE MAHOADON = @idFirstBill

		UPDATE HOADONCHITIET SET MASP = (SELECT MASP FROM IDBillInfoTable b where b.MASP = HDCT.MASP), SOLUONG = SOLUONG +  (SELECT SOLUONG FROM IDBillInfoTable b where b.MASP = HDCT.MASP) from HOADONCHITIET as HDCT  WHERE MAHOADON = @idSeconrdBill AND MASP IN (SELECT MASP FROM IDBillInfoTable)

		delete from HOADONCHITIET where MAHOADON = @idFirstBill and MASP in (select MASP from HOADONCHITIET where MAHOADON = @idSeconrdBill)

		UPDATE HOADONCHITIET SET MAHOADON = @idSeconrdBill WHERE MAHOADON = @idFirstBill

		DELETE FROM HOADONCHITIET WHERE MAHOADON = @idFirstBill
		DELETE FROM HOADON WHERE MAHOADON = @idFirstBill
		
		DROP TABLE IDBillInfoTable

		UPDATE BAN SET TRANGTHAI = N'TRỐNG' WHERE MABAN = @idTable1
		DELETE FROM HOADON WHERE MABAN = @idTable1 AND GHICHU = N'CHƯA THANH TOÁN'
	END
END
CREATE DATABASE QuanLySinhVienKhoaCNTT
go

USE QuanLySinhVienKhoaCNTT
GO

CREATE TABLE KHOA(
    MAKHOA VARCHAR(10) PRIMARY KEY,
    TENKHOA NVARCHAR(50) NOT NULL, 
)
GO

CREATE TABLE CHUYENNGANH(
    MACHUYENNGANHNGANH VARCHAR(10) PRIMARY KEY,
    TENCHUYENNGANH NVARCHAR(50) DEFAULT 'Công Nghệ Web',
    MAKHOA VARCHAR(10) DEFAULT 'KCNTT',
    FOREIGN KEY(MAKHOA) REFERENCES KHOA(MAKHOA)
)
GO

CREATE TABLE LOP(
    MALOP VARCHAR(10) PRIMARY KEY,
    TENLOP NVARCHAR(50) NOT NULL DEFAULT '12522W.2',
    MACHUYENNGANHNGANH VARCHAR(10) DEFAULT 'CNWeb',
    FOREIGN KEY(MACHUYENNGANHNGANH) REFERENCES CHUYENNGANH(MACHUYENNGANHNGANH)
)
GO

CREATE TABLE SinhVien(
    MASV VARCHAR(10) PRIMARY KEY,
    HOTEN NVARCHAR(50) NOT NULL,
    GIOITINH NVARCHAR(10)  ,
    DANTOC NVARCHAR(10) DEFAULT 'Kinh',
    NGAYSINH DATETIME,
    DIACHI NVARCHAR(100) NOT NULL,
    SODIENTHOAI VARCHAR(20),
    CCCD VARCHAR(20) UNIQUE,
    MALOP VARCHAR(10),
    FOREIGN KEY(MALOP) REFERENCES LOP(MALOP)
)
GO

CREATE TABLE NGUOITHAN(
    ID INT IDENTITY PRIMARY KEY,
    HOTEN NVARCHAR(50),
    QUANHE NVARCHAR(50),
    NGAYSINH DATETIME,
    SODIENTHOAI VARCHAR(20),
    MASV VARCHAR(10),
    FOREIGN KEY(MASV) REFERENCES SINHVIEN(MASV)
)
GO

CREATE TABLE HOCPHAN(
    MAHOCPHAN VARCHAR(10) PRIMARY KEY,
    TENHOCPHAN NVARCHAR(50) NOT NULL,
    SOTC INT,
    MAKHOA VARCHAR(10) DEFAULT 'KCNTT',
    FOREIGN KEY(MAKHOA) REFERENCES KHOA(MAKHOA)
)
GO
DBCC CHECKIDENT ('DIEMTHI', RESEED, 0);
select * from DIEMTHI

CREATE TABLE DIEMTHI(
    ID INT IDENTITY PRIMARY KEY,
    DIEM FLOAT NOT NULL DEFAULT 0 CHECK(DIEM >= 0 AND DIEM <= 10),
    HOCKY INT,
    MASV VARCHAR(10),
    MAHOCPHAN VARCHAR(10),
    FOREIGN KEY(MASV) REFERENCES SINHVIEN(MASV),
    FOREIGN KEY(MAHOCPHAN) REFERENCES HOCPHAN(MAHOCPHAN)
)
GO 


CREATE TABLE GIANGVIEN(
    MAGIANGVIEN VARCHAR(10),
    TENGIANGVIEN NVARCHAR(50),
    GIOITINH NVARCHAR(10),
    NGAYSINH DATETIME,
    DIACHI NVARCHAR(50),
    CCCD VARCHAR(20) UNIQUE,
    SODIENTHOAI VARCHAR(20),
    MAKHOA VARCHAR(10),
    FOREIGN KEY(MAKHOA) REFERENCES KHOA(MAKHOA)
)
GO

CREATE TABLE THONGTINCHITIET(
    ID INT IDENTITY PRIMARY KEY,
    NIENKHOA NVARCHAR(20) DEFAULT 'K20',
    HEDAOTAO NVARCHAR(20) DEFAULT 'Chính Quy',
    NAMNHAPHOC VARCHAR(10) DEFAULT '2022',
    MASV VARCHAR(10),
    FOREIGN KEY(MASV) REFERENCES SINHVIEN(MASV)
)
GO


CREATE TABLE TAIKHOAN(
    ID INT IDENTITY PRIMARY KEY,
    USERNAME NVARCHAR(50),
    PASSWORD NVARCHAR(50),
    SODIENTHOAI VARCHAR(20)
)
GO

-- Chèn dữ liệu vào bảng TAIKHOAN
INSERT INTO TAIKHOAN (USERNAME, PASSWORD, SODIENTHOAI) VALUES
('DoDangThang01', '12345', '0911122331'),
('DoDangThang02', '12345', '0911122332'),
('DoDangThang03', '12345', '0911122333'),
('DoDangThang04', '12345', '0911122334'),
('DoDangThang05', '12345', '0911122335'),
('DoDangThang06', '12345', '0911122336'),
('DoDangThang07', '12345', '0911122337'),
('DoDangThang08', '12345', '0911122338'),
('DoDangThang09', '12345', '0911122339'),
('DoDangThang10', '12345', '0911122340'),
('DoDangThang11', '12345', '0911122341'),
('DoDangThang12', '12345', '0911122342'),
('DoDangThang13', '12345', '0911122343'),
('DoDangThang14', '12345', '0911122344'),
('DoDangThang15', '12345', '0911122345'),
('DoDangThang16', '12345', '0911122346'),
('DoDangThang17', '12345', '0911122347'),
('DoDangThang18', '12345', '0911122348'),
('DoDangThang19', '12345', '0911122349'),
('DoDangThang20', '12345', '0911122350');




SELECT * FROM KHOA
INSERT INTO KHOA VALUES('KCNTT', N'Khoa Công Nghệ Thông Tin')

SELECT * FROM CHUYENNGANH
INSERT INTO CHUYENNGANH(MACHUYENNGANHNGANH, TENCHUYENNGANH) VALUES('CNW', N'Công Nghệ Web' )
INSERT INTO CHUYENNGANH(MACHUYENNGANHNGANH, TENCHUYENNGANH) VALUES('CNDD', N'Công Nghệ Di Động' )
INSERT INTO CHUYENNGANH(MACHUYENNGANHNGANH, TENCHUYENNGANH) VALUES('KT', N'Kiểm Thử' )
INSERT INTO CHUYENNGANH(MACHUYENNGANHNGANH, TENCHUYENNGANH) VALUES('TKDH', N'Thiết Kế Đồ Họa' )
INSERT INTO CHUYENNGANH(MACHUYENNGANHNGANH, TENCHUYENNGANH) VALUES('IOT', N'Internet of Things' )
INSERT INTO CHUYENNGANH(MACHUYENNGANHNGANH, TENCHUYENNGANH) VALUES('KHMT', N'Khoa Học Máy Tính' )


INSERT INTO CHUYENNGANH VALUES()

select * from LOP
INSERT INTO LOP(MALOP, TENLOP, MACHUYENNGANHNGANH) VALUES('12522W.1','Web1','CNW')
INSERT INTO LOP(MALOP, TENLOP, MACHUYENNGANHNGANH) VALUES('12522W.2','Web2','CNW')
INSERT INTO LOP(MALOP, TENLOP, MACHUYENNGANHNGANH) VALUES('12522W.3','Web3','CNW')
INSERT INTO LOP(MALOP, TENLOP, MACHUYENNGANHNGANH) VALUES('12522W.4','Web4','CNW')
INSERT INTO LOP(MALOP, TENLOP, MACHUYENNGANHNGANH) VALUES('10122O.1','IOT1','IOT')
INSERT INTO LOP(MALOP, TENLOP, MACHUYENNGANHNGANH) VALUES('10122O.2','IOT2','IOT')
INSERT INTO LOP(MALOP, TENLOP, MACHUYENNGANHNGANH) VALUES('10122G.1','Đồ Họa 1','TKDH')
INSERT INTO LOP(MALOP, TENLOP, MACHUYENNGANHNGANH) VALUES('10122G.2','Đồ Họa 2','TKDH')
INSERT INTO LOP(MALOP, TENLOP, MACHUYENNGANHNGANH) VALUES('10122G.3','Đồ Họa 3','TKDH')
INSERT INTO LOP(MALOP, TENLOP, MACHUYENNGANHNGANH) VALUES('12522T.1','Kiểm Thử 1','KT')
INSERT INTO LOP(MALOP, TENLOP, MACHUYENNGANHNGANH) VALUES('12522T.2','Kiểm Thử 2','KT')
INSERT INTO LOP(MALOP, TENLOP, MACHUYENNGANHNGANH) VALUES('12522T.3','Kiểm Thử 3','KT')

select * from SinhVien
-- Chèn dữ liệu vào bảng SinhVien
INSERT INTO SinhVien (MASV, HOTEN, GIOITINH, DANTOC, NGAYSINH, DIACHI, SODIENTHOAI, CCCD, MALOP)
VALUES
('SV001', N'Nguyễn Văn Anh', 'Nam', N'Kinh', '2000-01-01', N'Hà Nội', '0123456789', '0332040052001', '12522W.1'),
('SV002', N'Trần Thị Bích', 'Nữ', N'Kinh', '2004-05-15', N'Hồ Chí Minh', '0987654321', '0332040052002', '12522W.2'),
('SV003', N'Phạm Văn Cao', 'Nam', N'Kinh', '2004-08-20', N'Đà Nẵng', '0369852147', '0332040052003', '12522W.3'),
('SV004', N'Nguyễn Thị Dinh', 'Nữ', N'Mường', '2003-12-05', N'Hà Nội', '0123456780', '0332040052004', '12522T.1'),
('SV005', N'Lê Văn Em', 'Nam', N'Tày', '2001-06-30', N'Hồ Chí Minh', '0987654312', '0332040052005', '12522T.2'),
('SV006', N'Hoàng Thị Lan', 'Nữ', N'Nùng', '2002-11-25', N'Đà Nẵng', '0369852165', '0332040052006', '12522T.3'),
('SV007', N'Trần Văn Gíap', 'Nam', N'Kinh', '2000-03-10', N'Hà Nội', '0123456798', '0332040052007', '10122O.1'),
('SV008', N'Phạm Thị Hồng', 'Nữ', N'Muờng', '2001-07-12', N'Hồ Chí Minh', '0987654323', '0332040052008', '10122O.2'),
('SV009', N'Lê Văn Ích', 'Nam', N'Tày', '2005-09-15', N'Đà Nẵng', '0369852178', '0332040052009', '10122G.1'),
('SV010', N'Nguyễn Thị Kim', 'Nữ', N'Nùng', '2003-04-22', N'Hà Nội', '0123456765', '0332040052010', '10122G.2'),
('SV011', N'Hoàng Văn Long', 'Nam', N'Kinh', '2000-06-17', N'Hồ Chí Minh', '0987654310', '0332040052011', '10122G.3'),
('SV012', N'Trần Thị Trang', 'Nữ', N'Mường', '2002-10-05', N'Đà Nẵng', '0369852198', '0332040052012', '10122O.1'),
('SV013', N'Lê Văn Nam', 'Nam', N'Tày', '2001-02-28', N'Hà Nội', '0123456709', '0332040052013', '10122O.2'),
('SV014', N'Phạm Thị Tâm', 'Nữ', N'Muong', '2004-11-15', N'Hồ Chí Minh', '0987654387', '0332040052014', '10122G.1'),
('SV015', N'Nguyễn Văn Quang', 'Nam', N'Kinh', '2003-08-20', N'Đà Nẵng', '0369852132', '0332040052015', '10122G.2'),
('SV016', N'Hoàng Thị Thi', 'Nữ', N'Mường', '2000-12-05', N'Hà Nội', '0123456743', '0332040052016', '10122G.3'),
('SV017', N'Trần Văn Sinh', 'Nam', N'Tày', '2002-07-30', N'Hồ Chí Minh', '0987654326', '0332040052017', '12522W.1'),
('SV018', N'Phạm Thị Trinh', 'Nữ', N'Nùng', '2001-09-22', N'Đà Nẵng', '0369852146', '0332040052018', '12522W.2'),
('SV019', N'Lê Văn Hải', 'Nam', N'Kinh', '2005-04-17', N'Hà Nội', '0123456791', '0332040052019', '12522W.3'),
('SV020', N'Nguyễn Thị Vân', 'Nữ', N'Mường', '2004-02-10', N'Hồ Chí Minh', '0987654311', '0332040052020', '10122O.1'),
('SV021', N'Nguyễn Thị Lan', 'Nữ', N'Mường', '2001-03-22', N'Hồ Chí Minh', '0987654322', '0332040052021', '12522W.1'),
('SV022', N'Vũ Văn Khánh', 'Nam', N'Kinh', '2002-08-15', N'Hà Nội', '0123456781', '0332040052022', '12522W.2'),
('SV023', N'Lê Thị Ngọc', 'Nữ', N'Tày', '2003-05-10', N'Đà Nẵng', '0369852148', '0332040052023', '12522W.3'),
('SV024', N'Hoàng Văn Hùng', 'Nam', N'Mường', '2000-11-18', N'Hà Nội', '0123456782', '0332040052024', '12522T.1'),
('SV025', N'Trần Thị Hà', 'Nữ', N'Tày', '2004-02-28', N'Hồ Chí Minh', '0987654313', '0332040052025', '12522T.2'),
('SV026', N'Nguyễn Văn Thắng', 'Nam', N'Nùng', '2002-09-15', N'Đà Nẵng', '0369852166', '0332040052026', '12522T.3'),
('SV027', N'Phạm Thị Ngân', 'Nữ', N'Kinh', '2001-07-05', N'Hà Nội', '0123456799', '0332040052027', '10122O.1'),
('SV028', N'Đỗ Văn Hải', 'Nam', N'Muờng', '2000-05-12', N'Hồ Chí Minh', '0987654324', '0332040052028', '10122O.2'),
('SV029', N'Trần Thị Nga', 'Nữ', N'Tày', '2005-10-20', N'Đà Nẵng', '0369852179', '0332040052029', '10122G.1'),
('SV030', N'Nguyễn Văn Hòa', 'Nam', N'Mường', '2003-04-02', N'Hà Nội', '0123456766', '0332040052030', '10122G.2'),
('SV031', N'Vũ Thị Hoài', 'Nữ', N'Nùng', '2000-06-14', N'Hồ Chí Minh', '0987654314', '0332040052031', '10122G.3'),
('SV032', N'Lê Văn Phương', 'Nam', N'Kinh', '2002-12-05', N'Đà Nẵng', '0369852199', '0332040052032', '10122O.1'),
('SV033', N'Phạm Văn Tuấn', 'Nam', N'Tày', '2001-01-28', N'Hà Nội', '0123456710', '0332040052033', '10122O.2'),
('SV034', N'Lê Thị Mai', 'Nữ', N'Muong', '2004-09-15', N'Hồ Chí Minh', '0987654388', '0332040052034', '10122G.1'),
('SV035', N'Nguyễn Văn Tú', 'Nam', N'Kinh', '2003-08-02', N'Đà Nẵng', '0369852133', '0332040052035', '10122G.2'),
('SV036', N'Hoàng Thị Hương', 'Nữ', N'Mường', '2001-12-15', N'Hà Nội', '0123456744', '0332040052036', '10122G.3'),
('SV037', N'Trần Văn Bình', 'Nam', N'Tày', '2002-10-30', N'Hồ Chí Minh', '0987654327', '0332040052037', '12522W.1'),
('SV038', N'Phạm Thị Lệ', 'Nữ', N'Nùng', '2001-08-22', N'Đà Nẵng', '0369852147', '0332040052038', '12522W.2'),
('SV039', N'Lê Văn Minh', 'Nam', N'Kinh', '2005-05-17', N'Hưng Yên', '0123456792', '0332040052039', '12522W.3'),
('SV040', N'Nguyễn Thị Huệ', 'Nữ', N'Mường', '2004-03-10', N'Hưng Yên', '0987654315', '0332040052040', '10122O.1'),
('SV041', N'Đỗ Văn Nam', 'Nam', N'Tày', '2000-07-20', N'Hưng Yên', '0369852147', '0332040052041', '10122O.2'),
('SV042', N'Vũ Thị Thảo', 'Nữ', N'Mường', '2003-11-25', N'Hưng Yên', '0987654389', '0332040052042', '10122G.1'),
('SV043', N'Lê Văn Quốc', 'Nam', N'Kinh', '2002-02-28', N'Hưng Yên', '0369852134', '0332040052043', '10122G.2'),
('SV044', N'Nguyễn Thị Loan', 'Nữ', N'Mường', '2001-09-05', N'Hưng Yên', '0123456745', '0332040052044', '10122G.3'),
('SV045', N'Vũ Văn Hiệp', 'Nam', N'Tày', '2005-04-17', N'Hưng Yên', '0987654328', '0332040052045', '12522W.1'),
('SV046', N'Phạm Thị Thủy', 'Nữ', N'Nùng', '2004-02-10', N'Đà Nẵng', '0369852148', '0332040052046', '12522W.2'),
('SV047', N'Nguyễn Văn Quân', 'Nam', N'Kinh', '2000-10-12', N'Hưng Yên', '0123456793', '0332040052047', '12522W.3'),
('SV048', N'Trần Thị Thu', 'Nữ', N'Mường', '2003-06-28', N'Hưng Yên', '0987654316', '0332040052048', '12522T.1'),
('SV049', N'Hoàng Văn Tú', 'Nam', N'Tày', '2001-04-22', N'Hưng Yên', '0369852167', '0332040052049', '12522T.2'),
('SV050', N'Trần Thị Linh', 'Nữ', N'Nùng', '2002-11-12', N'Hưng Yên', '0123456767', '0332040052050', '12522T.3'),
('SV051', N'Nguyễn Văn Tân', 'Nam', N'Thái', '2000-01-25', N'Hưng Yên', '0987654329', '0332040052051', '10122O.1'),
('SV052', N'Lê Thị Thắm', 'Nữ', N'Thái', '2004-07-12', N'Hưng Yên', '0369852149', '0332040052052', '10122O.2'),
('SV053', N'Trần Văn Tiến', 'Nam', N'Thái', '2003-04-18', N'Hưng Yên', '0987654390', '0332040052053', '10122G.1'),
('SV054', N'Phạm Thị Hoa', 'Nữ', N'Thái', '2001-11-30', N'Hưng Yên', '0123456746', '0332040052054', '10122G.2'),
('SV055', N'Đỗ Văn Tuyến', 'Nam', N'Thái', '2000-08-22', N'Hưng Yên', '0987654320', '0332040052055', '10122G.3'),
('SV056', N'Lê Thị Hương', 'Nữ', N'Thái', '2005-03-05', N'Hưng Yên', '0369852135', '0332040052056', '12522W.1'),
('SV057', N'Nguyễn Văn Trường', 'Nam', N'Thái', '2004-02-18', N'Hưng Yên', '0987654317', '0332040052057', '12522W.2'),
('SV058', N'Trần Thị Mai', 'Nữ', N'Thái', '2000-10-02', N'Hưng Yên', '0123456794', '0332040052058', '12522W.3'),
('SV059', N'Phạm Văn Bình', 'Nam', N'Thái', '2003-07-15', N'Hưng Yên', '0987654321', '0332040052059', '12522T.1'),
('SV060', N'Lê Thị Huệ', 'Nữ', N'Thái', '2002-12-10', N'Hưng Yên', '0369852168', '0332040052060', '12522T.2'),
('12522091', N'Đỗ Đặng Thắng', 'Nam', N'Kinh', '2004-08-19', N'Hưng Yên', '0363969923', '033204005287', '12522W.2'),
('1013234', N'Nguyễn Đức Phi', 'Nam', N'Kinh', '2004-12-10', N'Hưng Yên', '0369852168', '0332040052095', '12522W.2'),
('11322138', N'Đặng Thị Thu Huyền', 'Nữ', N'Kinh', '2004-12-06', N'Hưng Yên', '0866677519', '0332040052099', '12522W.2');


select * from NGUOITHAN
INSERT INTO NGUOITHAN (HOTEN, QUANHE, NGAYSINH, SODIENTHOAI, MASV)
VALUES
(N'Nguyễn Thị Hài', N'Mẹ của Anh', '1975-03-15', '0123456789', 'SV001'),
(N'Trần Văn Chiến', N'Bố của Bích', '1972-06-20', '0987654321', 'SV002'),
(N'Phạm Văn Anh', N'Bố của Cao', '1998-09-10', '0369852147', 'SV003'),
(N'Lê Thị Ánh', N'Mẹ của Dinh', '1985-12-05', '0123456780', 'SV004'),
(N'Lê Văn Lương', N'Mẹ của Em', '1999-04-22', '0987654312', 'SV005'),
(N'Hoàng Thị Dương', N'Bố của Lan', '1985-11-25', '0369852165', 'SV006'),
(N'Trần Văn Dũng', N'Bố của Giáp', '1980-03-10', '0123456798', 'SV007'),
(N'Phạm Thị Dịu', N'Mẹ của Hồng', '1978-07-12', '0987654323', 'SV008'),
(N'Lê Văn Thể', N'Bố của Ích', '1988-09-15', '0369852178', 'SV009'),
(N'Nguyễn Thị Kim', N'Mẹ của Kim', '1997-04-22', '0123456765', 'SV010'),
(N'Trần Văn Bính', N'Mẹ của Long', '1970-06-17', '0987654310', 'SV011'),
(N'Trần Thị Nhàn', N'Mẹ của Trang', '1979-10-05', '0369852198', 'SV012'),
(N'Lê Văn Vinh', N'Bố của Nam', '1995-02-28', '0123456709', 'SV013'),
(N'Phạm Thị Ngọc', N'Mẹ của Tâm', '1977-11-15', '0987654387', 'SV014'),
(N'Nguyễn Văn Tuấn', N'Bố của Quang', '1992-08-20', '0369852132', 'SV015'),
(N'Trần Thị Phương', N'Mẹ của Thi', '1988-12-05', '0123456743', 'SV016'),
(N'Trần Văn Thái', N'Bố của Sinh', '1992-07-30', '0987654326', 'SV017'),
(N'Phạm Thị Tâm', N'Mẹ của Trinh', '1991-09-22', '0369852146', 'SV018'),
(N'Lê Văn Hùng', N'Bố của Hải', '1980-04-17', '0123456791', 'SV019'),
(N'Nguyễn Thị Linh', N'Mẹ của Vân', '1969-02-10', '0987654311', 'SV020'),
(N'Nguyễn Thị Hồng', N'Mẹ của Lan', '1968-02-22', '0987654322', 'SV021'),
(N'Vũ Văn Kiên', N'Bố của Khánh', '1965-05-15', '0123456781', 'SV022'),
(N'Lê Thị Anh', N'Mẹ của Ngọc', '1960-04-10', '0369852148', 'SV023'),
(N'Hoàng Văn Hoàng', N'Bố của Hùng', '1965-08-18', '0123456782', 'SV024'),
(N'Trần Thị Thắm,', N'Mẹ của Hà', '1970-02-28', '0987654313', 'SV025'),
(N'Nguyễn Văn Quân', N'Bố của Thắng', '1968-09-15', '0369852166', 'SV026'),
(N'Phạm Thị Huyền', N'Mẹ của Ngân', '1969-07-05', '0123456799', 'SV027'),
(N'Đỗ Văn Quang', N'Bố của Hải', '1970-05-12', '0987654324', 'SV028'),
(N'Trần Thị Hường', N'Mẹ của Nga', '1975-10-20', '0369852179', 'SV029'),
(N'Nguyễn Văn Hảo', N'Bố của Hòa', '1972-04-02', '0123456766', 'SV030'),
(N'Vũ Thị Thu', N'Mẹ của Hoài', '1968-06-14', '0987654314', 'SV031'),
(N'Lê Văn Đạt', N'Bố của Phương', '1965-12-05', '0369852199', 'SV032'),
(N'Phạm Văn Đông', N'Bố của Tuấn', '1969-01-28', '0123456710', 'SV033'),
(N'Lê Thị Bích', N'Mẹ của Mai', '1974-09-15', '0987654388', 'SV034'),
(N'Nguyễn Văn Khải', N'Bố của Tú', '1972-08-02', '0369852133', 'SV035'),
(N'Hoàng Thị Oanh', N'Mẹ của Hương', '1969-12-15', '0123456744', 'SV036'),
(N'Trần Văn Phương', N'Bố của Bình', '1968-10-30', '0987654327', 'SV037'),
(N'Phạm Thị Lệ Thu', N'Mẹ của Lệ', '1972-08-22', '0369852147', 'SV038'),
(N'Lê Văn Thành', N'Bố của Minh', '1975-05-17', '0123456792', 'SV039'),
(N'Nguyễn Thị Mơ', N'Mẹ của Huệ', '1970-03-10', '0987654315', 'SV040'),
(N'Đỗ Văn Mấu', N'Bố của Nam', '1968-07-20', '0369852147', 'SV041'),
(N'Vũ Thị Hà', N'Mẹ của Thảo', '1973-11-25', '0987654389', 'SV042'),
(N'Lê Văn Tập', N'Bố của Quốc', '1965-02-28', '0369852134', 'SV043'),
(N'Nguyễn Thị Yến', N'Mẹ của Loan', '1969-09-05', '0123456745', 'SV044'),
(N'Vũ Văn Phượng', N'Bố của Hiệp', '1975-04-17', '0987654328', 'SV045'),
(N'Phạm Thị Mây', N'Mẹ của Thủy', '1970-02-10', '0369852148', 'SV046'),
(N'Nguyễn Văn Sĩ', N'Bố của Quân', '1968-10-12', '0123456793', 'SV047'),
(N'Trần Thị Thúy', N'Mẹ của Thu', '1973-06-28', '0987654316', 'SV048'),
(N'Hoàng Văn Chiến', N'Bố của Tú', '1969-04-22', '0369852167', 'SV049'),
(N'Trần Thị Lan Anh', N'Mẹ của Linh', '1972-11-12', '0123456767', 'SV050'),
(N'Nguyễn Văn Vương', N'Bố của Tân', '1965-01-25', '0987654329', 'SV051'),
(N'Lê Thị Nhung', N'Mẹ của Thắm', '1972-07-12', '0369852149', 'SV052'),
(N'Trần Văn Thành', N'Bố của Tiến', '1968-04-18', '0987654390', 'SV053'),
(N'Phạm Thị Huyên', N'Mẹ của Hoa', '1971-11-30', '0123456746', 'SV054'),
(N'Đỗ Văn Quân', N'Bố của Tuyến', '1968-08-22', '0987654320', 'SV055'),
(N'Lê Thị Thu', N'Mẹ của Hương', '1975-03-05', '0369852135', 'SV056'),
(N'Nguyễn Văn Quân', N'Bố của Trường', '1974-02-18', '0987654317', 'SV057'),
(N'Trần Thị Trang', N'Mẹ của Mai', '1970-10-02', '0123456794', 'SV058'),
(N'Phạm Văn Kiên', N'Bố của Bình', '1973-07-15', '0987654321', 'SV059'),
(N'Lê Thị Thoa', N'Mẹ của Huệ', '1968-12-10', '0369852168', 'SV060');


select * from SinhVien


select * from HOCPHAN
insert into hocphan(mahocphan, tenhocphan, SOTC) values
('CDS','Công Dân Số',2),
('PT','Lập Trình Python',2),
('CSDL','Cơ Sở Dữ Liệu',2),
('CSKTLT','Cơ Sở Kỹ Thuật Lập Trình',2),
('KTMT','Kiến Trúc Máy Tính',3),
('CTDLGT','Cấu Trúc Dữ Liệu Và Giải Thuật',3),
('HDH','Hệ Điều Hành',3),
('HQT','Hệ Quản Trị CSDL',3),
('OOP','Lập Trình Hướng Đối Tượng',3),
('WF','Lập Trình Window Form',3)

delete from DIEMTHI
INSERT into DIEMTHI(DIEM, HOCKY, MASV,MAHOCPHAN) values
    (8.8,1,'12522091','CDS'),
    (8.2,1,'12522091','PT'),
    (8.9,1,'12522091','CSDL'),
    (9.8,2,'12522091','CSKTLT'),
    (9.9,2,'12522091','CTDLGT'),
    (8.9,3,'12522091','HDH'),
    (8.5,3,'12522091','HQT'),
    (9.2,3,'12522091','OOP'),
    (8.7,3,'12522091','WF'),
    (8.2,1,'11322138','CDS'),
    (8.8,1,'12522091','PT'),
    (9.2,1,'12522091','CSDL'),
    (9.5,2,'12522091','CSKTLT'),
    (9.8,2,'12522091','CTDLGT'),
    (8.3,3,'12522091','HDH'),
    (7.7,3,'12522091','HQT'),
    (9.6,3,'12522091','OOP'),
    (8.1,3,'12522091','WF'),

    -- Sinh viên SV001
    (8.8, 1, 'SV001', 'CDS'),
    (8.2, 1, 'SV001', 'PT'),
    (8.9, 1, 'SV001', 'CSDL'),
    (9.8, 2, 'SV001', 'CSKTLT'),
    (9.9, 2, 'SV001', 'CTDLGT'),
    (8.9, 3, 'SV001', 'HDH'),
    (8.5, 3, 'SV001', 'HQT'),
    (9.2, 3, 'SV001', 'OOP'),
    (8.7, 3, 'SV001', 'WF'),

    -- Sinh viên SV002
    (8.5, 1, 'SV002', 'CDS'),
    (7.8, 1, 'SV002', 'PT'),
    (8.3, 1, 'SV002', 'CSDL'),
    (9.0, 2, 'SV002', 'CSKTLT'),
    (8.7, 2, 'SV002', 'CTDLGT'),
    (9.5, 3, 'SV002', 'HDH'),
    (8.9, 3, 'SV002', 'HQT'),
    (9.3, 3, 'SV002', 'OOP'),
    (8.1, 3, 'SV002', 'WF'),

    -- Sinh viên SV003
    (7.5, 1, 'SV003', 'CDS'),
    (8.0, 1, 'SV003', 'PT'),
    (7.2, 1, 'SV003', 'CSDL'),
    (8.9, 2, 'SV003', 'CSKTLT'),
    (7.8, 2, 'SV003', 'CTDLGT'),
    (8.5, 3, 'SV003', 'HDH'),
    (9.1, 3, 'SV003', 'HQT'),
    (8.3, 3, 'SV003', 'OOP'),
    (8.7, 3, 'SV003', 'WF'),
    -- Sinh viên SV004
    (7.2, 1, 'SV004', 'CDS'),
    (8.4, 1, 'SV004', 'PT'),
    (7.9, 1, 'SV004', 'CSDL'),
    (9.2, 2, 'SV004', 'CSKTLT'),
    (8.6, 2, 'SV004', 'CTDLGT'),
    (7.8, 3, 'SV004', 'HDH'),
    (9.0, 3, 'SV004', 'HQT'),
    (8.3, 3, 'SV004', 'OOP'),
    (8.9, 3, 'SV004', 'WF'),

    -- Sinh viên SV005
    (8.0, 1, 'SV005', 'CDS'),
    (8.6, 1, 'SV005', 'PT'),
    (7.5, 1, 'SV005', 'CSDL'),
    (9.1, 2, 'SV005', 'CSKTLT'),
    (8.3, 2, 'SV005', 'CTDLGT'),
    (7.9, 3, 'SV005', 'HDH'),
    (8.7, 3, 'SV005', 'HQT'),
    (9.5, 3, 'SV005', 'OOP'),
    (8.1, 3, 'SV005', 'WF'),

    -- Sinh viên SV006
    (7.8, 1, 'SV006', 'CDS'),
    (8.3, 1, 'SV006', 'PT'),
    (7.2, 1, 'SV006', 'CSDL'),
    (9.0, 2, 'SV006', 'CSKTLT'),
    (8.5, 2, 'SV006', 'CTDLGT'),
    (9.2, 3, 'SV006', 'HDH'),
    (8.7, 3, 'SV006', 'HQT'),
    (8.9, 3, 'SV006', 'OOP'),
    (9.1, 3, 'SV006', 'WF'),

    -- Sinh viên SV007
    (8.5, 1, 'SV007', 'CDS'),
    (9.0, 1, 'SV007', 'PT'),
    (7.8, 1, 'SV007', 'CSDL'),
    (8.3, 2, 'SV007', 'CSKTLT'),
    (7.9, 2, 'SV007', 'CTDLGT'),
    (8.2, 3, 'SV007', 'HDH'),
    (8.6, 3, 'SV007', 'HQT'),
    (9.2, 3, 'SV007', 'OOP'),
    (8.7, 3, 'SV007', 'WF'),

    -- Sinh viên SV008
    (8.1, 1, 'SV008', 'CDS'),
    (9.2, 1, 'SV008', 'PT'),
    (8.0, 1, 'SV008', 'CSDL'),
    (8.8, 2, 'SV008', 'CSKTLT'),
    (9.5, 2, 'SV008', 'CTDLGT'),
    (8.4, 3, 'SV008', 'HDH'),
    (9.1, 3, 'SV008', 'HQT'),
    (8.7, 3, 'SV008', 'OOP'),
    (8.9, 3, 'SV008', 'WF'),

    -- Sinh viên SV009
    (8.2, 1, 'SV009', 'CDS'),
    (8.9, 1, 'SV009', 'PT'),
    (7.5, 1, 'SV009', 'CSDL'),
    (8.4, 2, 'SV009', 'CSKTLT'),
    (9.0, 2, 'SV009', 'CTDLGT'),
    (8.3, 3, 'SV009', 'HDH'),
    (8.7, 3, 'SV009', 'HQT'),
    (9.1, 3, 'SV009', 'OOP'),
    (8.5, 3, 'SV009', 'WF'),
    -- Sinh viên SV010
    (7.5, 1, 'SV010', 'CDS'),
    (8.0, 1, 'SV010', 'PT'),
    (7.2, 1, 'SV010', 'CSDL'),
    (8.9, 2, 'SV010', 'CSKTLT'),
    (7.8, 2, 'SV010', 'CTDLGT'),
    (8.5, 3, 'SV010', 'HDH'),
    (9.1, 3, 'SV010', 'HQT'),
    (8.3, 3, 'SV010', 'OOP'),
    (8.7, 3, 'SV010', 'WF');

delete from DIEMTHI
go
CREATE PROCEDURE InsertRandomScores
    @MASV VARCHAR(10),
    @DIEM_MIN FLOAT = 0,
    @DIEM_MAX FLOAT = 10
AS
BEGIN
    DECLARE @MAHOCPHAN NVARCHAR(10)

    -- Tạo điểm ngẫu nhiên cho từng môn học và chèn vào bảng DIEMTHI
    DECLARE InsertCursor CURSOR FOR
    SELECT MAHOCPHAN
    FROM HOCPHAN;

    OPEN InsertCursor;
    
    FETCH NEXT FROM InsertCursor INTO @MAHOCPHAN;
    WHILE @@FETCH_STATUS = 0
    BEGIN
        DECLARE @DIEM FLOAT = ROUND(RAND() * (@DIEM_MAX - @DIEM_MIN) + @DIEM_MIN, 2)

        INSERT INTO DIEMTHI (DIEM, HOCKY, MASV, MAHOCPHAN)
        VALUES (@DIEM, CAST(RAND() * 2 + 1 AS INT), @MASV, @MAHOCPHAN);

        FETCH NEXT FROM InsertCursor INTO @MAHOCPHAN;
    END

    CLOSE InsertCursor;
    DEALLOCATE InsertCursor;
END;

DECLARE @dem INT = 20;
WHILE (@dem < 50)
BEGIN
    declare @msv VARCHAR(10)
    SET @msv = CONCAT('sv0', FORMAT(@dem, '00'));
    EXEC InsertRandomScores @msv, 3, 10;
    SET @dem += 1;
END


select * from DIEMTHI



select * from GIANGVIEN
-- Thêm 20 bản ghi vào bảng GIANGVIEN
INSERT INTO GIANGVIEN (MAGIANGVIEN, TENGIANGVIEN, GIOITINH, NGAYSINH, DIACHI, CCCD, SODIENTHOAI, MAKHOA)
VALUES
    ('GV001', N'Nguyễn Văn Anh', N'Nam', '1980-05-15', N'Hà Nội', '033200000001', '0987654321', 'KCNTT'),
    ('GV002', N'Trần Thị Bình', N'Nữ', '1985-09-20', N'Hồ Chí Minh', '033200000002', '0123456789', 'KCNTT'),
    ('GV003', N'Lê Văn Cần', N'Nam', '1978-12-10', N'Thái Bình', '033200000003', '0369852147', 'KCNTT'),
    ('GV004', N'Phạm Thị Dung', N'Nữ', '1982-07-05', N'Hải Phòng', '033200000004', '0123456780', 'KCNTT'),
    ('GV005', N'Hồ Văn Hùng', N'Nam', '1987-03-22', N'Bắc Giang', '033200000005', '0987654312', 'KCNTT'),
    ('GV006', N'Đỗ Thị Loan', N'Nữ', '1989-06-28', N'Nam Định', '033200000006', '0369852165', 'KCNTT'),
    ('GV007', N'Mai Văn Giang', N'Nam', '1983-11-25', N'Hà Nam', '033200000007', '0123456798', 'KCNTT'),
    ('GV008', N'Vũ Thị Hồng', N'Nữ', '1986-04-10', N'Thái Nguyên', '033200000008', '0987654323', 'KCNTT'),
    ('GV009', N'Nguyễn Văn Kiên', N'Nam', '1981-07-12', N'Quảng Ninh', '033200000009', '0369852178', 'KCNTT'),
    ('GV010', N'Lê Thị Kiều', N'Nữ', '1984-04-22', N'Hải Dương', '033200000010', '0123456765', 'KCNTT'),
    ('GV011', N'Trần Văn Lâm', N'Nam', '1988-06-17', N'Thái Bình', '033200000011', '0987654310', 'KCNTT'),
    ('GV012', N'Hoàng Văn Mạnh', N'Nam', '1975-10-05', N'Hà Nội', '033200000012', '0369852198', 'KCNTT'),
    ('GV013', N'Phạm Thị Nhung', N'Nữ', '1980-02-28', N'Hồ Chí Minh', '033200000013', '0123456709', 'KCNTT'),
    ('GV014', N'Lê Văn Phong', N'Nam', '1986-11-15', N'Bắc Ninh', '033200000014', '0987654387', 'KCNTT'),
    ('GV015', N'Nguyễn Thị Quỳnh', N'Nữ', '1989-08-20', N'Hải Phòng', '033200000015', '0369852132', 'KCNTT'),
    ('GV016', N'Trần Văn Sơn', N'Nam', '1982-12-05', N'Nam Định', '033200000016', '0123456743', 'KCNTT'),
    ('GV017', N'Vũ Thị Thảo', N'Nữ', '1987-07-30', N'Thái Nguyên', '033200000017', '0987654326', 'KCNTT'),
    ('GV018', N'Đỗ Văn Thắng', N'Nam', '1984-09-22', N'Quảng Ninh', '033200000018', '0369852146', 'KCNTT'),
    ('GV019', N'Mai Thị Vân', N'Nữ', '1979-04-17', N'Hà Nam', '033200000019', '0123456791', 'KCNTT'),
    ('GV020', N'Nguyễn Văn Xuân', N'Nam', '1988-02-10', N'Hải Dương', '033200000020', '0987654311', 'KCNTT');

    INSERT INTO GIANGVIEN (MAGIANGVIEN, HOTEN, GIOITINH, NGAYSINH, DIACHI, CCCD, SODIENTHOAI, MAKHOA)
VALUES
    ('GV021', N'Trần Thị Bình', N'Nữ', '1985-08-22', N'Hồ Chí Minh', '033266001222', '0901234567', 'KCNTT'),
    ('GV022', N'Lê Văn Hùng', N'Nam', '1982-02-10', N'Đà Nẵng', '033266021225', '0976543210', 'KCNTT'),
    ('GV023', N'Phạm Thị Mai', N'Nữ', '1987-12-05', N'Hải Phòng', '03326603166', '0912345678', 'KCNTT'),
    ('GV024', N'Nguyễn Minh Trí', N'Nam', '1983-06-30', N'Bắc Ninh', '0332559001213', '0923456789', 'KCNTT'),
    ('GV025', N'Lê Thị Hương', N'Nữ', '1986-09-17', N'Thái Nguyên', '0332559001214', '0934567890', 'KCNTT'),
    ('GV026', N'Đỗ Văn Quang', N'Nam', '1989-03-25', N'Nam Định', '0332559001215', '0945678901', 'KCNTT'),
    ('GV027', N'Trần Thị Thảo', N'Nữ', '1984-08-12', N'Hà Nam', '0332559001216', '0956789012', 'KCNTT'),
    ('GV028', N'Hoàng Văn Hải', N'Nam', '1981-01-09', N'Thừa Thiên Huế', '0332559001217', '0967890123', 'KCNTT'),
    ('GV029', N'Phan Thị Thanh', N'Nữ', '1988-04-14', N'Quảng Ninh', '0332559001218', '0978901234', 'KCNTT'),
    ('GV030', N'Lê Văn Nam', N'Nam', '1980-07-21', N'Bình Định', '0332559001219', '0989012345', 'KCNTT'),
    ('GV031', N'Nguyễn Thị Hoa', N'Nữ', '1983-10-28', N'Vĩnh Phúc', '0332559001220', '0990123456', 'KCNTT'),
    ('GV032', N'Vũ Minh Khôi', N'Nam', '1986-05-02', N'Đồng Nai', '0332559001221', '0901122334', 'KCNTT'),
    ('GV033', N'Lê Thị Ngọc Anh', N'Nữ', '1982-08-15', N'Cà Mau', '0332559001222', '0912233445', 'KCNTT'),
    ('GV034', N'Trần Đình Hưng', N'Nam', '1985-11-28', N'Tiền Giang', '0332559001223', '0923344556', 'KCNTT'),
    ('GV035', N'Nguyễn Thị Thu Hà', N'Nữ', '1984-04-10', N'Long An', '0332559001224', '0934455667', 'KCNTT'),
    ('GV036', N'Phạm Văn Tâm', N'Nam', '1981-07-23', N'Vĩnh Long', '0332559001225', '0945566778', 'KCNTT'),
    ('GV037', N'Hoàng Minh Tuấn', N'Nam', '1988-12-16', N'Bến Tre', '0332559001226', '0956677889', 'KCNTT'),
    ('GV038', N'Đỗ Thị Lan', N'Nữ', '1983-03-29', N'Bà Rịa - Vũng Tàu', '0332559001227', '0967788990', 'KCNTT'),
    ('GV039', N'Nguyễn Văn Dũng', N'Nam', '1980-06-01', N'An Giang', '0332559001228', '0978899001', 'KCNTT'),
    ('GV040', N'Lê Thị Mỹ Linh', N'Nữ', '1987-09-14', N'Bình Thuận', '0332559001229', '0989900112', 'KCNTT'),
    ('GV041', N'Trần Văn Toàn', N'Nam', '1984-02-27', N'Cần Thơ', '0332559001230', '0990011223', 'KCNTT'),
    ('GV042', N'Nguyễn Thị Hồng', N'Nữ', '1982-05-10', N'Tây Ninh', '0332559001231', '0981122334', 'KCNTT'),
    ('GV043', N'Phan Văn Hùng', N'Nam', '1985-08-23', N'Đồng Tháp', '0332559001232', '0972233445', 'KCNTT'),
    ('GV044', N'Trần Thị Linh', N'Nữ', '1984-11-05', N'Bắc Giang', '0332559001233', '0963344556', 'KCNTT'),
    ('GV045', N'Hoàng Văn Hiệp', N'Nam', '1981-02-18', N'Sóc Trăng', '0332559001234', '0954455667', 'KCNTT'),
    ('GV046', N'Lê Thị Ngọc Trâm', N'Nữ', '1988-05-31', N'Kiên Giang', '0332559001235', '0945566778', 'KCNTT'),
    ('GV047', N'Phạm Văn Hòa', N'Nam', '1983-09-13', N'Vĩnh Phúc', '0332559001236', '0936677889', 'KCNTT'),
    ('GV048', N'Nguyễn Thị Ngọc Ánh', N'Nữ', '1980-12-26', N'Lâm Đồng', '0332559001237', '0927788990', 'KCNTT'),
    ('GV049', N'Đỗ Văn Đạt', N'Nam', '1987-03-09', N'Tuyên Quang', '0332559001238', '0918899001', 'KCNTT'),
    ('GV050', N'Lê Thị Kim Ngân', N'Nữ', '1984-06-22', N'Đắk Nông', '0332559001239', '0909900112', 'KCNTT'),
    ('GV051', N'Nguyễn Thị Ánh', N'Nữ', '1983-02-14', N'Quảng Bình', '0332559001240', '0901122334', 'KCNTT'),
    ('GV052', N'Lê Văn Dũng', N'Nam', '1981-05-27', N'Ninh Bình', '0332559001241', '0912233445', 'KCNTT'),
    ('GV053', N'Trần Thị Tâm', N'Nữ', '1984-08-10', N'Thái Bình', '0332559001242', '0923344556', 'KCNTT'),
    ('GV054', N'Hoàng Minh Tuấn', N'Nam', '1989-11-23', N'Lào Cai', '0332559001243', '0934455667', 'KCNTT'),
    ('GV055', N'Phạm Thị Lan', N'Nữ', '1982-04-05', N'Sơn La', '0332559001244', '0945566778', 'KCNTT'),
    ('GV056', N'Đỗ Văn Hoàng', N'Nam', '1985-07-18', N'Thanh Hóa', '0332559001245', '0956677889', 'KCNTT'),
    ('GV057', N'Lê Thị Mai', N'Nữ', '1988-10-31', N'Yên Bái', '0332559001246', '0967788990', 'KCNTT'),
    ('GV058', N'Nguyễn Văn Long', N'Nam', '1980-01-13', N'Hòa Bình', '0332559001247', '0978899001', 'KCNTT'),
    ('GV059', N'Trần Thị Thu', N'Nữ', '1987-04-26', N'Đắk Lắk', '0332559001248', '0989900112', 'KCNTT'),
    ('GV060', N'Phan Văn Hòa', N'Nam', '1984-09-08', N'Bình Dương', '0332559001249', '0990011223', 'KCNTT');
    -- ... Tiếp tục thêm 9 bản ghi khác tương tự



select * from DIEMTHI



select * from THONGTINCHITIET
INSERT into THONGTINCHITIET(MASV) VALUEs
('12522091'),
('11322138')
DECLARE @i INT = 1;

WHILE @i <= 50
BEGIN
    DECLARE @MASV VARCHAR(10) = 'sv' + RIGHT('00' + CAST(@i AS VARCHAR(2)), 3);

    INSERT INTO THONGTINCHITIET (MASV) VALUES (@MASV);

    SET @i = @i + 1;
END;


SELECT * from TAIKHOAN
insert into TAIKHOAN(USERNAME, [PASSWORD], SODIENTHOAI) values
('admin', 'admin', 0363969923)
GO


SELECT * FROM SINHVIEN
SELECT * FROM NGUOITHAN
select * from THONGTINCHITIET
GO
ALTER proc USP_ThongTinSinhVien
AS
BEGIN
    SELECT SinhVien.MASV AS [Mã SV], SINHVIEN.HOTEN [Họ Tên], GIOITINH [Giới Tính], DANTOC [Dân Tộc], 
    format(CAST(SinhVien.NGAYSINH AS DATE),'dd/MM/yyyy') [Ngày Sinh], DIACHI [Địa Chỉ], SINHVIEN.SODIENTHOAI [Số Điện Thoại], 
    CCCD [Số CCCD], MALOP [Lớp], NGUOITHAN.HOTEN [Họ Tên Người Thân], QUANHE [Quan Hệ], format(CAST(NGUOITHAN.NGAYSINH AS DATE), 'dd/MM/yyyy') [Ngày Sinh],
    NGUOITHAN.SODIENTHOAI [Số Điện Thoại], NIENKHOA [Niên Khóa], HEDAOTAO [Hệ Đào Tạo], NAMNHAPHOC [Năm Nhập Học]
    FROM SinhVien
    INNER JOIN THONGTINCHITIET ON SinhVien.MASV = THONGTINCHITIET.MASV
    LEFT JOIN NGUOITHAN ON SinhVien.MASV = NGUOITHAN.MASV
END

EXEC USP_ThongTinSinhVien
select * from NGUOITHAN

SELECT * FROM SinhVien

select * from GIANGVIEN
go
ALTER proc testproc(
    @msv CHAR(10),
    @hoten NVARCHAR(50),
    @NgaySinh DATE,
    @Gioitinh NVARCHAR(50),
    @noisinh NVARCHAR(50),
    @malop VARCHAR(10),

    @mamonhoc CHAR(10),
    @tenmh varchar(50),
    @stc int
)
AS
BEGIN
    INSERT INTO MONHOC(MAMONHOC, TENMONHOC, SOTC) VALUES
    (@mamonhoc, @tenmh, @stc)
    INSERT into SinhVien(MASV, HOTEN, NGAYSINH, GIOITINH, NOISINH, MALOP) values
    (@msv, @hoten, @NgaySinh, @Gioitinh, @noisinh, @malop)

END

SELECT * FROM SinhVien
GO

CREATE PROC USP_AddHoSoSinhVien(
    @MASV VARCHAR(10),
    @HOTEN NVARCHAR(50),
    @GIOITINH NVARCHAR(10),
    @DANTOC NVARCHAR(10),
    @NGAYSINH DATE,
    @DIACHI NVARCHAR(100),
    @SDT VARCHAR(120),
    @SOCCCD VARCHAR(20),

    @HOTENNT NVARCHAR(50),
    @QUANHE NVARCHAR(50),
    @NGAYSINHNT DATE,
    @SDTNT VARCHAR(20),

    @MALOP VARCHAR(10),
    @NIENKHOA NVARCHAR(20),
    @HDT NVARCHAR(20),
    @NAMNHAPHOC VARCHAR(10)
)
AS
BEGIN
    INSERT INTO SinhVien (MASV, HOTEN, GIOITINH, DANTOC, NGAYSINH, DIACHI, SODIENTHOAI, CCCD, MALOP) VALUES
    (@MASV, @HOTEN,@GIOITINH, @DANTOC, @NGAYSINH, @DIACHI, @SDT, @SOCCCD, @MALOP)
    INSERT INTO NGUOITHAN (HOTEN, QUANHE, NGAYSINH, SODIENTHOAI, MASV) VALUEs
    (@HOTENNT, @QUANHE, @NGAYSINHNT, @SDTNT, @MASV)
    INSERT INTO THONGTINCHITIET(NIENKHOA, HEDAOTAO, NAMNHAPHOC, MASV) VALUES
    (@NIENKHOA, @HDT, @NAMNHAPHOC, @MASV)
END
GO

EXEC USP_AddHoSoSinhVien
    @MASV = 'SVTEST1',
    @HOTEN = N'Nguyen Van A',
    @GIOITINH = N'Nam',
    @DANTOC = N'Kinh',
    @NGAYSINH = '1990-01-01',
    @DIACHI = N'123 Đường ABC, Quận XYZ',
    @SDT = '0123456789',
    @SOCCCD = 'CCCD1234516',

    @HOTENNT = N'Nguyen Thi B',
    @QUANHE = N'Me',
    @NGAYSINHNT = '1970-01-01',
    @SDTNT = '0987654321',

    @MALOP = '12522W.2',
    @NIENKHOA = N'K20',
    @HDT = N'Chính Quy',
    @NAMNHAPHOC = '2022';
GO

select * from SinhVien

GO
CREATE PROC USP_UPDATESTUDENT(
    @MASV VARCHAR(10),
    @HOTEN NVARCHAR(50),
    @GIOITINH NVARCHAR(10),
    @DANTOC NVARCHAR(10),
    @NGAYSINH DATE,
    @DIACHI NVARCHAR(100),
    @SDT VARCHAR(120),
    @SOCCCD VARCHAR(20),

    @HOTENNT NVARCHAR(50),
    @QUANHE NVARCHAR(50),
    @NGAYSINHNT DATE,
    @SDTNT VARCHAR(20),

    @MALOP VARCHAR(10),
    @NIENKHOA NVARCHAR(20),
    @HDT NVARCHAR(20),
    @NAMNHAPHOC VARCHAR(10)
)
AS
BEGIN
    UPDATE SinhVien
    SET HOTEN = @HOTEN, GIOITINH = @GIOITINH, DANTOC = @DANTOC, NGAYSINH = @NGAYSINH, DIACHI = @DIACHI, SODIENTHOAI = @SDT, CCCD = @SOCCCD, MALOP = @MALOP
    WHERE MASV = @MASV
    UPDATE NGUOITHAN 
    SET HOTEN = @HOTENNT, QUANHE = @QUANHE, NGAYSINH = @NGAYSINHNT, SODIENTHOAI = @SDTNT
    WHERE MASV = @MASV
    UPDATE THONGTINCHITIET 
    SET NIENKHOA = @NIENKHOA, HEDAOTAO = @HDT, NAMNHAPHOC = @NAMNHAPHOC
    WHERE MASV = @MASV
END
GO

EXEC USP_UPDATESTUDENT
    @MASV = 'SVTEST',
    @HOTEN = N'Nguyen Van B',
    @GIOITINH = N'Nam',
    @DANTOC = N'Kinh',
    @NGAYSINH = '1990-01-01',
    @DIACHI = N'123 Đường ABC, Quận XYZ',
    @SDT = '0123456789',
    @SOCCCD = 'CCCD123456',

    @HOTENNT = N'Nguyen Thi B',
    @QUANHE = N'Me',
    @NGAYSINHNT = '1970-01-01',
    @SDTNT = '0987654321',

    @MALOP = '12522W.2',
    @NIENKHOA = N'K20',
    @HDT = N'Chính Quy',
    @NAMNHAPHOC = '2022';
GO


CREATE PROCEDURE USP_DELETESTUDENT(
    @MASV VARCHAR(10)
)
AS
BEGIN
    DELETE FROM SinhVien
    WHERE MASV = @MASV
END

USP_DELETESTUDENT 'SVTEST'

ALTER TABLE THONGTINCHITIET
ADD CONSTRAINT CONSTRAINT_CascadeTTCT
FOREIGN KEY (masv)
REFERENCES sinhvien (masv)
ON DELETE CASCADE ON UPDATE CASCADE

GO
ALTER PROCEDURE USP_SEARCH_STUDENT
    @SearchColumn NVARCHAR(50),
    @SearchValue NVARCHAR(50)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    IF (@SearchColumn = 'masv')
    BEGIN
        select * from v_sinhvien where  MaSV = @SearchValue
    END
    ELSE
    BEGIN
    SET @sql = 'SELECT * FROM v_sinhvien WHERE ' + @SearchColumn + ' LIKE ''%'' + @SearchValue + ''%''';
    EXEC sp_executesql @sql,
        N'@SearchValue NVARCHAR(50)',
        @SearchValue;
    END
END


EXEC USP_SEARCH_STUDENT 'HOTEN', N'thắng';
EXEC USP_SEARCH_STUDENT 'masv', 12522091;
select * from SinhVien 
where hoten  like N'%Thang%'

select * from v_sinhvien

go
ALTER view v_SinhVien AS
SELECT
    SinhVien.MASV AS MaSV,
    SINHVIEN.HOTEN AS HoTen,
    GIOITINH,
    DANTOC,
    CAST(SinhVien.NGAYSINH AS DATE) AS NgaySinh,
    DIACHI,
    SINHVIEN.SODIENTHOAI AS SoDienThoai,
    CCCD AS SoCCCD,
    MALOP AS Lop,
    NGUOITHAN.HOTEN AS HoTenNguoiThan,
    QUANHE AS QuanHe,
    CAST(NGUOITHAN.NGAYSINH AS DATE) AS NgaySinhNguoiThan,
    NGUOITHAN.SODIENTHOAI AS SoDienThoaiNguoiThan,
    NIENKHOA AS NienKhoa,
    HEDAOTAO AS HeDaoTao,
    NAMNHAPHOC AS NamNhapHoc
FROM
    SinhVien
LEFT JOIN
    THONGTINCHITIET ON SinhVien.MASV = THONGTINCHITIET.MASV
LEFT JOIN
    NGUOITHAN ON SinhVien.MASV = NGUOITHAN.MASV;
go

select * from v_SinhVien

go
CREATE PROCEDURE USP_GetAccountsLogin
    @Username NVARCHAR(50),
    @Password NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM TaiKhoan
    WHERE Username = @Username AND Password = @Password;
END;

insert into TAIKHOAN(USERNAME, [PASSWORD], SODIENTHOAI) values('admin', 'admin',35465)

ALTER TABLE TaiKhoan
ADD CONSTRAINT UQ_username UNIQUE (Username);

DECLARE @pra nvarchar(50) = 'admsin'
select count(*) from TaiKhoan
where USERNAME = @pra

select * from taikhoan

USP_GetAccountsLogin 'admin', 'admin'
go
CREATE PROCEDURE USP_ForgotPassword
    @Username NVARCHAR(50),
    @PhoneNumber NVARCHAR(20)
AS
BEGIN
    SELECT *
    FROM TAIKHOAN
    WHERE USERNAME = @Username
      AND SODIENTHOAI = @PhoneNumber;
END;

USP_ForgotPassword 'admin','0363969923'


select * from GIANGVIEN
go
CREATE PROCEDURE USP_INSERT_GIANGVIEN
    @MAGV VARCHAR(10),
    @HOTEN NVARCHAR(50),
    @GIOITINH NVARCHAR(10),
    @NGAYSINH DATE,
    @DIACHI NVARCHAR(100),
    @SOCCCD VARCHAR(20),
    @SODIENTHOAI VARCHAR(20),
    @MAKHOA VARCHAR(10)
AS
BEGIN
    INSERT INTO GiangVien (MAGIANGVIEN, HOTEN, GIOITINH, NGAYSINH, DIACHI, CCCD, SODIENTHOAI, MAKHOA)
    VALUES (@MAGV, @HOTEN, @GIOITINH, @NGAYSINH,  @DIACHI, @SOCCCD, @SODIENTHOAI, @MAKHOA);
END

EXEC sp_rename 'giangvien.hoten',  'HOTEN', 'COLUMN';
select * from GIANGVIEN

go
create proc USP_GetAllGiangVien
AS
BEGIN
    select MAGIANGVIEN [Mã Giảng Viên], hoten [Họ Tên], GIOITINH [Giới Tính], NGAYSINH [Ngày Sinh], DIACHI [Địa Chỉ], CCCD [SỐ CCCD], SODIENTHOAI [Số Điện Thoại], MAKHOA [Mã Khoa]
    from GIANGVIEN
END 

USP_GetAllGiangVien

go
CREATE PROCEDURE USP_UPDATE_GIANGVIEN
    @MAGV VARCHAR(10),
    @HOTEN NVARCHAR(50),
    @GIOITINH NVARCHAR(10),
    @NGAYSINH DATE,
    @DIACHI NVARCHAR(100),
    @SOCCCD VARCHAR(20),
    @SODIENTHOAI VARCHAR(20),
    @MAKHOA VARCHAR(10)
AS
BEGIN
    UPDATE GiangVien
    SET 
        HOTEN = @HOTEN,
        GIOITINH = @GIOITINH,
        NGAYSINH = @NGAYSINH,
        DIACHI = @DIACHI,
        CCCD = @SOCCCD,
        SODIENTHOAI = @SODIENTHOAI,
        MAKHOA = @MAKHOA
    WHERE MAGIANGVIEN = @MAGV;
END

go
create proc USP_DeleteGiangVien(
    @magv varchar(10)
)
AS
BEGIN
    DELETE from GIANGVIEN where MAGIANGVIEN = @magv
END 

alter table sinhvien
drop CONSTRAINT UQ__SinhVien__A955A0AA0894D3E0

select * from GIANGVIEN

select * from hocphan

go
CREATE PROCEDURE USP_SearchLecture
    @SearchColumn NVARCHAR(50),
    @SearchValue NVARCHAR(50)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    IF (@SearchColumn = 'magv')
    BEGIN
        select * from v_GiangVien where  magiangvien = @SearchValue
    END
    ELSE
    BEGIN
    SET @sql = 'SELECT * FROM v_GiangVien WHERE ' + @SearchColumn + ' LIKE ''%'' + @SearchValue + ''%''';
    EXEC sp_executesql @sql,
        N'@SearchValue NVARCHAR(50)',
        @SearchValue;
    END
END

go
create view v_GiangVien AS
    select MAGIANGVIEN, HOTEN , GIOITINH, NGAYSINH, DIACHI, CCCD, SODIENTHOAI , MAKHOA 
    from GIANGVIEN
go
    select * from v_GiangVien

    USP_SearchLecture magiangvien, gv001

go
alter proc USP_GetAllScore
AS
BEGIN
    select DIEMTHI.ID as STT, DIEMTHI.MASV [Mã Sinh Viên], SinhVien.HOTEN [Họ Tên], HOCPHAN.TENHOCPHAN [Học Phần], HOCKY,DIEMthi.DIEM [Điểm Thi]
    from DIEMTHI
    INNER JOIN HOCPHAN on DIEMTHI.MAHOCPHAN = HOCPHAN.MAHOCPHAN
    INNER join SinhVien on SinhVien.MASV = DIEMTHI.MASV
END

select * from diemthi

go
create proc GetAllLopHoc
AS
BEGIN
    select MALOP [Mã Lớp], TENLOP [Tên Lớp], CHUYENNGANH.TENCHUYENNGANH [Tên Chuyên Ngành], MAKHOA [Mã Khoa]
    from LOP
    inner join CHUYENNGANH on LOP.MACHUYENNGANHNGANH = CHUYENNGANH.MACHUYENNGANHNGANH
END

select * from HOCPHAN
create proc GetAllHocPhan

select * from DIEMTHI
go
Create PROCEDURE USP_InsertScore
    @DIEMTHI FLOAT,
    @HOCKY NVARCHAR(20),
    @MASINHVIEN VARCHAR(10),
    @MAHOCPHAN VARCHAR(10)
AS
BEGIN
    INSERT INTO DiemThi (DIEM, HocKy, MASV, MaHocPhan)
    VALUES (@DIEMTHI, @HOCKY, @MASINHVIEN, @MAHOCPHAN);
END

select * 
from DIEMTHI
where MAHOCPHAN = 'CDS' and masv = 'sv001'

go
Create PROCEDURE USP_UpdateScore
    @DIEM FLOAT,
    @HOCKY NVARCHAR(20),
    @MASINHVIEN VARCHAR(10),
    @MAHOCPHAN VARCHAR(10)
AS
BEGIN
    UPDATE DiemThi
    SET DIEM = @DIEM
    WHERE HocKy = @HOCKY
        AND MASV = @MASINHVIEN
        AND MaHocPhan = @MAHOCPHAN;
END

GO
ALTER PROCEDURE USP_SearchScore
    @SearchColumn NVARCHAR(50),
    @SearchValue NVARCHAR(50)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    IF (@SearchColumn = 'malop')
    BEGIN
        select * from v_DiemByLop where  malop = @SearchValue
    END
    else IF (@SearchColumn = 'masv')
    BEGIN
        select * from v_DiemByLop where  masv = @SearchValue
    END
    ELSE
    BEGIN
    SET @sql = 'SELECT * FROM v_SearchByMonHoc WHERE ' + @SearchColumn + ' LIKE ''%'' + @SearchValue + ''%''';
    EXEC sp_executesql @sql,
       N'@SearchValue NVARCHAR(50)',
       @SearchValue;
    END
END

USP_SearchScore 'malop' , '12522W.2'


USP_GetAllScore
go
create view v_DiemByLop as
select DIEMTHI.MASV, HOTEN, TENHOCPHAN, HOCKY, DIEM, MALOP from DIEMTHI
inner join SinhVien on SinhVien.MASV = DIEMTHI.MaSV
INNER join HOCPHAN on DIEMTHI.MAHOCPHAN = HOCPHAN.MAHOCPHAN

go
Create view v_SearchByMonHoc as
    select DIEMTHI.ID as STT, DIEMTHI.MASV , SinhVien.HOTEN , HOCPHAN.TENHOCPHAN , HOCKY,DIEMthi.DIEM 
    from DIEMTHI
    INNER JOIN HOCPHAN on DIEMTHI.MAHOCPHAN = HOCPHAN.MAHOCPHAN
    INNER join SinhVien on SinhVien.MASV = DIEMTHI.MASV

    go
select * from HOCPHAN

select * from v_SearchByMonHoc
order by diem DESC

SELECT * FROM LOP

go
CREATE proc USP_GetAllClass
AS
BEGIN
SELECT MALOP [Mã Lớp], TENLOP [Tên Lớp], TENCHUYENNGANH [Tên Chuyên Ngành], CHUYENNGANH.MACHUYENNGANHNGANH [Mã Chuyên Ngành], MAKHOA [Mã Khoa] FROM LOP INNER JOIN CHUYENNGANH ON LOP.MACHUYENNGANHNGANH = CHUYENNGANH.MACHUYENNGANHNGANH
END
SELECT * FROM LOP 
INNER JOIN CHUYENNGANH ON LOP.MACHUYENNGANHNGANH = CHUYENNGANH.MACHUYENNGANHNGANH

go
CREATE PROCEDURE USP_InsertClass
    @MALOP VARCHAR(10),
    @TENLOP NVARCHAR(50),
    @MACHUYENNGANH VARCHAR(10)
AS
BEGIN
    INSERT INTO LOP (MaLop, TenLop, MACHUYENNGANHNGANH)
    VALUES (@MALOP, @TENLOP, @MACHUYENNGANH);
END


go
CREATE PROCEDURE USP_UpdateClass
    @MALOP VARCHAR(10),
    @TENLOP NVARCHAR(50),
    @MACHUYENNGANH VARCHAR(10)
AS
BEGIN
    UPDATE LOP
    SET TenLop = @TENLOP,
        MACHUYENNGANHNGANH = @MACHUYENNGANH
    WHERE MaLop = @MALOP;
END

go
create PROCEDURE USP_SearchClass
    @SearchColumn NVARCHAR(50),
    @SearchValue NVARCHAR(50)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    IF (@SearchColumn = 'malop')
    BEGIN
        select * from v_LopHoc where  malop = @SearchValue
    END
    ELSE
    BEGIN
    SET @sql = 'SELECT * FROM v_LopHoc WHERE ' + @SearchColumn + ' LIKE ''%'' + @SearchValue + ''%''';
    EXEC sp_executesql @sql,
       N'@SearchValue NVARCHAR(50)',
       @SearchValue;
    END
END

USP_SearchClass TENCHUYENNGANH, N'công nghệ web'


go
CREATE view v_LopHoc AS
SELECT MALOP, TENLOP , TENCHUYENNGANH, CHUYENNGANH.MACHUYENNGANHNGANH, MAKHOA
FROM LOP 
INNER JOIN CHUYENNGANH ON LOP.MACHUYENNGANHNGANH = CHUYENNGANH.MACHUYENNGANHNGANH

select * from v_LopHoc

select MAHOCPHAN
from HOCPHAN
where TENHOCPHAN = N'Công Dân Số'

select * from HOCPHAN
select * from CHUYENNGANH

select MACHUYENNGANHNGANH
from CHUYENNGANH
where TENCHUYENNGANH = N'Công nghệ di động'

select MACHUYENNGANHNGANH as [Mã Chuyên Ngành], TENCHUYENNGANH [Tên Chuyên Ngành], MAKHOA  [Mã Khoa] from CHUYENNGANH
go
CREATE PROCEDURE USP_INSERT_CHUYENNGANH
    @MACHUYENNGANH VARCHAR(10),
    @TENCHUYENNGANH NVARCHAR(50),
    @MAKHOA VARCHAR(10) = 'KCNTT'
AS
BEGIN
    INSERT INTO ChuyenNganh (MACHUYENNGANHNGANH, TenChuyenNganh, MaKhoa)
    VALUES (@MACHUYENNGANH, @TENCHUYENNGANH, @MAKHOA);
END

USP_INSERT_CHUYENNGANH 'cntest', testname
select * from CHUYENNGANH

go
ALTER PROCEDURE USP_UPDATE_CHUYENNGANH
    @MACHUYENNGANH VARCHAR(10),
    @TENCHUYENNGANH NVARCHAR(50),
    @MAKHOA VARCHAR(10) = 'KCNTT'
AS
BEGIN
    UPDATE ChuyenNganh
    SET TenChuyenNganh = @TENCHUYENNGANH,
        MaKhoa = @MAKHOA
    WHERE MACHUYENNGANHNGANH = @MACHUYENNGANH;
END

delete CHUYENNGANH
where MACHUYENNGANHNGANH = @mcn

select * from CHUYENNGANH

go
create PROCEDURE USP_SearchBranch
    @SearchColumn NVARCHAR(50),
    @SearchValue NVARCHAR(50)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    IF (@SearchColumn = 'MACHUYENNGANHNGANH')
    BEGIN
        select * from CHUYENNGANH where  MACHUYENNGANHNGANH = @SearchValue
    END
    ELSE
    BEGIN
    SET @sql = 'SELECT * FROM CHUYENNGANH WHERE ' + @SearchColumn + ' LIKE ''%'' + @SearchValue + ''%''';
    EXEC sp_executesql @sql,
       N'@SearchValue NVARCHAR(50)',
       @SearchValue;
    END
END

select * from HOCPHAN
go
create proc USP_GetAllHocPhan
as
BEGIN
    select MAHOCPHAN as [Mã Học Phần],  TENHOCPHAN [Tên Học Phần], SOTC [Số Tín Chỉ], khoa.MAKHOA [Mã Khoa], TENKHOA [Tên Khoa]
    from HOCPHAN 
    inner join KHOA on HOCPHAN.MAKHOA = KHOA.MAKHOA
end

go
CREATE PROCEDURE USP_INSERT_HOCPHAN
    @MAHOCPHAN VARCHAR(10),
    @TENHOCPHAN NVARCHAR(50),
    @SOTINCHI INT,
    @MAKHOA VARCHAR(10) = 'KCNTT'
AS
BEGIN
    INSERT INTO HocPhan (MaHocPhan, TenHocPhan, SOTC, MaKhoa)
    VALUES (@MAHOCPHAN, @TENHOCPHAN, @SOTINCHI, @MAKHOA);
END

go
CREATE PROCEDURE USP_UPDATE_HOCPHAN
    @MAHOCPHAN VARCHAR(10),
    @TENHOCPHAN NVARCHAR(50),
    @SOTINCHI INT,
    @MAKHOA VARCHAR(10) = 'KCNTT'
AS
BEGIN
    UPDATE HocPhan
    SET TenHocPhan = @TENHOCPHAN,
        SOTC = @SOTINCHI,
        MaKhoa = @MAKHOA
    WHERE MaHocPhan = @MAHOCPHAN;
END

go
CREATE proc USP_DeleteHocPhan(
    @mahp VARCHAR(10)
)
AS
BEGIN
    DELETE HOCPHAN
    where MAHOCPHAN = @mahp
END

select * from HOCPHAN
go
create PROCEDURE USP_SearchSubject
    @SearchColumn NVARCHAR(50),
    @SearchValue NVARCHAR(50)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    IF (@SearchColumn = 'mahocphan')
    BEGIN
        select * from v_HocPhan where  mahocphan = @SearchValue
    END
    ELSE
    BEGIN
    SET @sql = 'SELECT * FROM v_HocPhan WHERE ' + @SearchColumn + ' LIKE ''%'' + @SearchValue + ''%''';
    EXEC sp_executesql @sql,
       N'@SearchValue NVARCHAR(50)',
       @SearchValue;
    END
END

go
create view v_HocPhan AS    
select MAHOCPHAN,  TENHOCPHAN , SOTC , khoa.MAKHOA, TENKHOA
    from HOCPHAN 
    inner join KHOA on HOCPHAN.MAKHOA = KHOA.MAKHOA

    SELECT TENHOCPHAN FROM HOCPHAN

    select * from sinhvien



create view v_DiemTheoKhoa

select * from TAIKHOAN

USP_ThongTinSinhVien

select USERNAME
from TAIKHOAN
where username = 'admin'

update TAIKHOAN
set [PASSWORD] = 'newpass' ,
SoDienThoai = '012345'
where USERNAME = 'dodangthang20'

delete TAIKHOAN
where USERname = @US
GO
go
CREATE PROCEDURE CapNhatThongTinTaiKhoan
    @Username NVARCHAR(50),
    @Password NVARCHAR(50),
    @Sodienthoai VARCHAR(20)
AS
BEGIN
    UPDATE TAIKHOAN
    SET
        PASSWORD = @Password,
        SODIENTHOAI = @Sodienthoai
    WHERE
        USERNAME = @Username;
END;

select * from TAIKHOAN

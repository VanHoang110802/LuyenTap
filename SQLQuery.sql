-- Tạo cơ sở dữ liệu
CREATE DATABASE SOF2052_FINAL_TEST;
GO

-- Sử dụng cơ sở dữ liệu vừa tạo
USE SOF2052_FINAL_TEST;
GO

-- Tạo bảng Hãng
CREATE TABLE Hang (
    MaHang INT PRIMARY KEY IDENTITY(1,1),
    TenHang NVARCHAR(100) NOT NULL
);
GO

-- Tạo bảng Sản phẩm, có khóa ngoại liên kết đến bảng Hãng
CREATE TABLE SanPham (
    MaSP INT PRIMARY KEY IDENTITY(1,1),
    TenSP NVARCHAR(100) NOT NULL,
    Gia FLOAT NOT NULL,
    MaHang INT NOT NULL,
    FOREIGN KEY (MaHang) REFERENCES Hang(MaHang),
	TinhTrang BIT NOT NULL
);
GO

-- Dữ liệu mẫu cho bảng Hang
INSERT INTO Hang (TenHang)
VALUES 
(N'Apple'),
(N'Samsung'),
(N'Xiaomi'),
(N'Oppo'),
(N'Nokia');
GO
-- Dữ liệu mẫu cho bảng SanPham
INSERT INTO SanPham (TenSP, Gia, MaHang, TinhTrang)
VALUES 
(N'iPhone 15', 29990, 1, 1),
(N'MacBook Air M2', 26990, 1, 0),
(N'Galaxy S24', 23990, 2, 0),
(N'Galaxy Tab S9', 15990, 2, 1),
(N'Redmi Note 13', 5990, 3, 1),
(N'Xiaomi 14 Ultra', 20990, 3, 1),
(N'Oppo Reno11', 10990, 4, 0),
(N'Oppo A78', 5990, 4, 0),
(N'Nokia G60', 4990, 5, 1),
(N'Nokia C32', 3990, 5, 0);

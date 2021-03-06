USE [master]
GO
/****** Object:  Database [Quanlynhansu]    Script Date: 1/2/2019 8:09:19 PM ******/
CREATE DATABASE [Quanlynhansu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Quanlynhansu', FILENAME = N'D:\ChiuThu2\csdl1\Quanlynhansu.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Quanlynhansu_log', FILENAME = N'D:\ChiuThu2\csdl1\Quanlynhansu_log.ldf' , SIZE = 52416KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Quanlynhansu] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Quanlynhansu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Quanlynhansu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Quanlynhansu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Quanlynhansu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Quanlynhansu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Quanlynhansu] SET ARITHABORT OFF 
GO
ALTER DATABASE [Quanlynhansu] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Quanlynhansu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Quanlynhansu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Quanlynhansu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Quanlynhansu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Quanlynhansu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Quanlynhansu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Quanlynhansu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Quanlynhansu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Quanlynhansu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Quanlynhansu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Quanlynhansu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Quanlynhansu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Quanlynhansu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Quanlynhansu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Quanlynhansu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Quanlynhansu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Quanlynhansu] SET RECOVERY FULL 
GO
ALTER DATABASE [Quanlynhansu] SET  MULTI_USER 
GO
ALTER DATABASE [Quanlynhansu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Quanlynhansu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Quanlynhansu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Quanlynhansu] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Quanlynhansu] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Quanlynhansu] SET QUERY_STORE = OFF
GO
USE [Quanlynhansu]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Quanlynhansu]
GO
/****** Object:  Table [dbo].[tblNhanvien]    Script Date: 1/2/2019 8:09:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanvien](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[CMND] [varchar](20) NOT NULL,
	[Ngaycap] [datetime] NULL,
	[Tinhthanh] [nvarchar](50) NULL,
	[Ngaysinh] [datetime] NULL,
	[Gioitinh] [nvarchar](10) NULL,
	[Nguyenquan] [nvarchar](50) NULL,
	[Dctamtru] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[SDTrieng] [varchar](15) NULL,
	[SDTnha] [varchar](15) NULL,
	[Tinhtranghonnhan] [nvarchar](50) NULL,
	[Tinhtranglamviec] [nvarchar](50) NULL,
	[Maphongban] [varchar](10) NULL,
	[Machucvu] [varchar](10) NULL,
	[Ngayvaolam] [datetime] NULL,
	[Thamnien] [int] NULL,
	[Heso] [float] NULL,
	[Matinhoc] [varchar](10) NOT NULL,
	[Mangoaingu] [varchar](10) NOT NULL,
	[Mabangcap] [varchar](10) NOT NULL,
	[SoBHXH] [varchar](20) NULL,
	[SoBHYT] [varchar](20) NULL,
	[Cannang] [nvarchar](50) NULL,
	[Cao] [nvarchar](50) NULL,
	[Nhommau] [nvarchar](10) NULL,
	[Tinhtrangsuckhoe] [nvarchar](50) NULL,
	[TaikhoanNH] [varchar](20) NULL,
	[Madantoc] [varchar](10) NOT NULL,
	[Matongiao] [varchar](10) NOT NULL,
	[Anh] [binary](6000) NULL,
 CONSTRAINT [PK_tblNhanvien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChucvu]    Script Date: 1/2/2019 8:09:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChucvu](
	[Machucvu] [varchar](10) NOT NULL,
	[Tenchucvu] [nvarchar](50) NULL,
	[Hesochucvu] [real] NULL,
	[Ghichu] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblChucvu] PRIMARY KEY CLUSTERED 
(
	[Machucvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[BC_chiluong]    Script Date: 1/2/2019 8:09:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[BC_chiluong]
AS
SELECT     dbo.tblNhanvien.TenNV, dbo.tblChucvu.Tenchucvu, dbo.tblBangchiluong.Ngaylamviec, dbo.tblChucvu.Hesochucvu, dbo.tblBangchiluong.Luongthang, 
                      dbo.tblBangchiluong.PhucapCV, dbo.tblBangchiluong.Phucapdochai, dbo.tblBangchiluong.Trocaptrachnhiem, dbo.tblBangchiluong.Trocapantrua, 
                      dbo.tblBangchiluong.Trocapxanha, dbo.tblBangchiluong.TrocapQLDN, dbo.tblBangchiluong.Tongluong, dbo.tblBangchiluong.BHXH, 
                      dbo.tblBangchiluong.BHYT, dbo.tblBangchiluong.Doanphi, dbo.tblBangchiluong.Thuclinh, dbo.tblBangchiluong.Thangchi
FROM         dbo.tblNhanvien INNER JOIN
                      dbo.tblChucvu ON dbo.tblNhanvien.Machucvu = dbo.tblChucvu.Machucvu INNER JOIN
                      dbo.tblBangchiluong ON dbo.tblNhanvien.MaNV = dbo.tblBangchiluong.MaNV
GO
/****** Object:  Table [dbo].[tblBangchamcong]    Script Date: 1/2/2019 8:09:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBangchamcong](
	[Machamcong] [varchar](10) NOT NULL,
	[Thangchamcong] [datetime] NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[Ngay1] [varchar](2) NULL,
	[Ngay2] [varchar](2) NULL,
	[Ngay3] [varchar](2) NULL,
	[Ngay4] [varchar](2) NULL,
	[Ngay5] [varchar](2) NULL,
	[Ngay6] [varchar](2) NULL,
	[Ngay7] [varchar](2) NULL,
	[Ngay8] [varchar](2) NULL,
	[Ngay9] [varchar](2) NULL,
	[Ngay10] [varchar](2) NULL,
	[Ngay11] [varchar](2) NULL,
	[Ngay12] [varchar](2) NULL,
	[Ngay13] [varchar](2) NULL,
	[Ngay14] [varchar](2) NULL,
	[Ngay15] [varchar](2) NULL,
	[Ngay16] [varchar](2) NULL,
	[Ngay17] [varchar](2) NULL,
	[Ngay18] [varchar](2) NULL,
	[Ngay19] [varchar](2) NULL,
	[Ngay20] [varchar](2) NULL,
	[Ngay21] [varchar](2) NULL,
	[Ngay22] [varchar](2) NULL,
	[Ngay23] [varchar](2) NULL,
	[Ngay24] [varchar](2) NULL,
	[Ngay25] [varchar](2) NULL,
	[Ngay26] [varchar](2) NULL,
	[Ngay27] [varchar](2) NULL,
	[Ngay28] [varchar](2) NULL,
	[Ngay29] [varchar](2) NULL,
	[Ngay30] [varchar](2) NULL,
	[Ngay31] [varchar](2) NULL,
	[Tongsongay] [int] NULL,
	[Ngaydilam] [int] NULL,
	[Ngayvang] [int] NULL,
 CONSTRAINT [PK_tblBangchamcong] PRIMARY KEY CLUSTERED 
(
	[Machamcong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhongban]    Script Date: 1/2/2019 8:09:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhongban](
	[Maphongban] [varchar](10) NOT NULL,
	[Tenphongban] [nvarchar](50) NULL,
	[Ghichu] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblPhongban] PRIMARY KEY CLUSTERED 
(
	[Maphongban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_BC_chamcong]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_BC_chamcong]
AS
SELECT     dbo.tblBangchamcong.Machamcong, dbo.tblBangchamcong.Thangchamcong, dbo.tblNhanvien.TenNV, dbo.tblBangchamcong.Ngay1, 
                      dbo.tblBangchamcong.Ngay2, dbo.tblBangchamcong.Ngay3, dbo.tblBangchamcong.Ngay4, dbo.tblBangchamcong.Ngay5, 
                      dbo.tblBangchamcong.Ngay6, dbo.tblBangchamcong.Ngay7, dbo.tblBangchamcong.Ngay8, dbo.tblBangchamcong.Ngay9, 
                      dbo.tblBangchamcong.Ngay10, dbo.tblBangchamcong.Ngay11, dbo.tblBangchamcong.Ngay12, dbo.tblBangchamcong.Ngay13, 
                      dbo.tblBangchamcong.Ngay14, dbo.tblBangchamcong.Ngay15, dbo.tblBangchamcong.Ngay16, dbo.tblBangchamcong.Ngay17, 
                      dbo.tblBangchamcong.Ngay18, dbo.tblBangchamcong.Ngay19, dbo.tblBangchamcong.Ngay20, dbo.tblBangchamcong.Ngay21, 
                      dbo.tblBangchamcong.Ngay22, dbo.tblBangchamcong.Ngay23, dbo.tblBangchamcong.Ngay24, dbo.tblBangchamcong.Ngay25, 
                      dbo.tblBangchamcong.Ngay26, dbo.tblBangchamcong.Ngay27, dbo.tblBangchamcong.Ngay28, dbo.tblBangchamcong.Ngay29, 
                      dbo.tblBangchamcong.Ngay30, dbo.tblBangchamcong.Ngay31, dbo.tblBangchamcong.Tongsongay, dbo.tblBangchamcong.Ngaydilam, 
                      dbo.tblBangchamcong.Ngayvang, dbo.tblPhongban.Maphongban, dbo.tblPhongban.Tenphongban
FROM         dbo.tblBangchamcong INNER JOIN
                      dbo.tblNhanvien ON dbo.tblBangchamcong.MaNV = dbo.tblNhanvien.MaNV INNER JOIN
                      dbo.tblPhongban ON dbo.tblNhanvien.MaNV = dbo.tblPhongban.MaNV AND dbo.tblNhanvien.Maphongban = dbo.tblPhongban.Maphongban
GO
/****** Object:  View [dbo].[View_BC_Chiluongtheophong]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_BC_Chiluongtheophong]
AS
SELECT     dbo.tblBangchiluong.Maluong, dbo.tblBangchiluong.Thangchi, dbo.tblNhanvien.TenNV, dbo.tblBangchiluong.Ngaylamviec, 
                      dbo.tblBangchiluong.Luongthang, dbo.tblBangchiluong.Truluong, dbo.tblBangchiluong.PhucapCV, dbo.tblBangchiluong.Phucapdochai, 
                      dbo.tblBangchiluong.Trocaptrachnhiem, dbo.tblBangchiluong.Trocapantrua, dbo.tblBangchiluong.Trocapxanha, dbo.tblBangchiluong.TrocapQLDN, 
                      dbo.tblBangchiluong.Tongluong, dbo.tblBangchiluong.BHXH, dbo.tblBangchiluong.Doanphi, dbo.tblBangchiluong.BHYT, dbo.tblBangchiluong.Thuclinh, 
                      dbo.tblPhongban.Tenphongban, dbo.tblPhongban.Maphongban
FROM         dbo.tblBangchiluong INNER JOIN
                      dbo.tblNhanvien ON dbo.tblBangchiluong.MaNV = dbo.tblNhanvien.MaNV INNER JOIN
                      dbo.tblPhongban ON dbo.tblNhanvien.Maphongban = dbo.tblPhongban.Maphongban AND dbo.tblNhanvien.MaNV = dbo.tblPhongban.MaNV
GO
/****** Object:  View [dbo].[View_Chiluongtheochucvu]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Chiluongtheochucvu]
AS
SELECT     dbo.tblNhanvien.MaNV, dbo.tblBangchiluong.Maluong, dbo.tblBangchiluong.Thangchi, dbo.tblNhanvien.Machucvu
FROM         dbo.tblNhanvien INNER JOIN
                      dbo.tblBangchiluong ON dbo.tblNhanvien.MaNV = dbo.tblBangchiluong.MaNV
GO
/****** Object:  View [dbo].[View_Chamcongchucvu]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Chamcongchucvu]
AS
SELECT     dbo.tblNhanvien.MaNV, dbo.tblNhanvien.Machucvu, dbo.tblBangchamcong.Thangchamcong, dbo.tblBangchamcong.Machamcong
FROM         dbo.tblNhanvien INNER JOIN
                      dbo.tblBangchamcong ON dbo.tblNhanvien.MaNV = dbo.tblBangchamcong.MaNV
GO
/****** Object:  Table [dbo].[tblBangcap]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBangcap](
	[Mabangcap] [varchar](10) NOT NULL,
	[Tenbangcap] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblBangcap] PRIMARY KEY CLUSTERED 
(
	[Mabangcap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDantoc]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDantoc](
	[Madantoc] [varchar](10) NOT NULL,
	[Tendantoc] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblDantoc] PRIMARY KEY CLUSTERED 
(
	[Madantoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDotphongvan]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDotphongvan](
	[Madotphongvan] [varchar](10) NOT NULL,
	[Tendotphongvan] [nvarchar](50) NULL,
	[Manguoiphongvan] [varchar](10) NULL,
	[Ngaybatdau] [datetime] NULL,
	[Ngayketthuc] [datetime] NULL,
	[Chude] [nvarchar](50) NULL,
 CONSTRAINT [PK_Dotphongvan] PRIMARY KEY CLUSTERED 
(
	[Madotphongvan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhenthuong]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhenthuong](
	[Makhenthuong] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[Lydo] [nvarchar](max) NULL,
	[Hinhthuc] [nvarchar](50) NULL,
	[Ngaykhen] [datetime] NULL,
	[Ghichu] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblKhenthuong] PRIMARY KEY CLUSTERED 
(
	[Makhenthuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKyluatphat]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKyluatphat](
	[Makyluat] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[Lydo] [nvarchar](50) NULL,
	[Hinhthuc] [nvarchar](50) NULL,
	[Ngaykyluat] [datetime] NULL,
	[Ghichu] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblKyluatphat] PRIMARY KEY CLUSTERED 
(
	[Makyluat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLLuong]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLLuong](
	[MaLuong] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[Heso] [float] NULL,
	[Luongcoban] [float] NULL,
	[Thang] [datetime] NULL,
	[Ngaylamviec] [int] NULL,
	[Phucap] [float] NULL,
	[BHXH] [float] NULL,
	[BHYT] [float] NULL,
	[TongLuong] [float] NULL,
	[ThucLinh] [float] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_Luong] PRIMARY KEY CLUSTERED 
(
	[MaLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNgoaingu]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNgoaingu](
	[Mangoaingu] [varchar](10) NOT NULL,
	[Tenngoaingu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblNgoaingu] PRIMARY KEY CLUSTERED 
(
	[Mangoaingu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNguoidung]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNguoidung](
	[Usename] [varchar](10) NOT NULL,
	[Pass] [varchar](20) NULL,
	[Chophepthaotac] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblNguoidung] PRIMARY KEY CLUSTERED 
(
	[Usename] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTinhoc]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTinhoc](
	[Matinhoc] [varchar](10) NOT NULL,
	[Tentinhoc] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblTinhoc] PRIMARY KEY CLUSTERED 
(
	[Matinhoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTongiao]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTongiao](
	[Matongiao] [varchar](10) NOT NULL,
	[Tentongiao] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblTongiao] PRIMARY KEY CLUSTERED 
(
	[Matongiao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUngvien]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUngvien](
	[Maungvien] [varchar](10) NOT NULL,
	[Tenungvien] [nvarchar](50) NULL,
	[CMND] [varchar](20) NULL,
	[Ngaycap] [datetime] NULL,
	[Tinhthanh] [nvarchar](50) NULL,
	[Ngaysinh] [datetime] NULL,
	[Gioitinh] [nvarchar](10) NULL,
	[Diachi] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[SDTrieng] [varchar](20) NULL,
	[SDTnha] [varchar](20) NULL,
	[Tinhtranghonnhan] [nvarchar](50) NULL,
	[Mabangcap] [varchar](10) NULL,
	[Mangoaingu] [varchar](10) NULL,
	[Matinhoc] [varchar](10) NULL,
	[Namkinhnghiem] [int] NULL,
	[Ngaynophoso] [datetime] NULL,
	[Trangthai] [nvarchar](20) NULL,
	[Ghichu] [varchar](max) NULL,
	[Madantoc] [varchar](10) NULL,
	[Matongiao] [varchar](10) NULL,
	[Madotphongvan] [varchar](10) NULL,
 CONSTRAINT [PK_tblUngvien] PRIMARY KEY CLUSTERED 
(
	[Maungvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[tblBangcap] ([Mabangcap], [Tenbangcap]) VALUES (N'BC01', N'Tốt nghiệp trung hoc phổ thông')
INSERT [dbo].[tblBangcap] ([Mabangcap], [Tenbangcap]) VALUES (N'BC02', N'Tốt nghiệp trung cấp CN')
INSERT [dbo].[tblBangcap] ([Mabangcap], [Tenbangcap]) VALUES (N'BC03', N'Tốt nghiệp trường dạy nghề')
INSERT [dbo].[tblBangcap] ([Mabangcap], [Tenbangcap]) VALUES (N'BC04', N'Tốt nghiệp cao đẳng')
INSERT [dbo].[tblBangcap] ([Mabangcap], [Tenbangcap]) VALUES (N'BC05', N'Tốt nghiệp đại học')
INSERT [dbo].[tblBangcap] ([Mabangcap], [Tenbangcap]) VALUES (N'BC06', N'Cử nhân đại học')
INSERT [dbo].[tblBangchamcong] ([Machamcong], [Thangchamcong], [MaNV], [Ngay1], [Ngay2], [Ngay3], [Ngay4], [Ngay5], [Ngay6], [Ngay7], [Ngay8], [Ngay9], [Ngay10], [Ngay11], [Ngay12], [Ngay13], [Ngay14], [Ngay15], [Ngay16], [Ngay17], [Ngay18], [Ngay19], [Ngay20], [Ngay21], [Ngay22], [Ngay23], [Ngay24], [Ngay25], [Ngay26], [Ngay27], [Ngay28], [Ngay29], [Ngay30], [Ngay31], [Tongsongay], [Ngaydilam], [Ngayvang]) VALUES (N'CC06120004', CAST(N'2012-01-01T00:00:00.000' AS DateTime), N'NV004', N'CN', N'x', N'x', N'x', N'x', N'x', N'x', N'CN', N'x', N'x', N'x', N'x', N'x', N'x', N'CN', N'P', N'x', N'x', N'x', N'x', N'x', N'CN', N'x', N'x', N'x', N'x', N'x', N'x', N'CN', N'x', N'x', 26, 25, 1)
INSERT [dbo].[tblBangchamcong] ([Machamcong], [Thangchamcong], [MaNV], [Ngay1], [Ngay2], [Ngay3], [Ngay4], [Ngay5], [Ngay6], [Ngay7], [Ngay8], [Ngay9], [Ngay10], [Ngay11], [Ngay12], [Ngay13], [Ngay14], [Ngay15], [Ngay16], [Ngay17], [Ngay18], [Ngay19], [Ngay20], [Ngay21], [Ngay22], [Ngay23], [Ngay24], [Ngay25], [Ngay26], [Ngay27], [Ngay28], [Ngay29], [Ngay30], [Ngay31], [Tongsongay], [Ngaydilam], [Ngayvang]) VALUES (N'CC11180001', CAST(N'2018-08-01T00:00:00.000' AS DateTime), N'NV001', N'x', N'x', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 2, 2, 0)
INSERT [dbo].[tblBangchamcong] ([Machamcong], [Thangchamcong], [MaNV], [Ngay1], [Ngay2], [Ngay3], [Ngay4], [Ngay5], [Ngay6], [Ngay7], [Ngay8], [Ngay9], [Ngay10], [Ngay11], [Ngay12], [Ngay13], [Ngay14], [Ngay15], [Ngay16], [Ngay17], [Ngay18], [Ngay19], [Ngay20], [Ngay21], [Ngay22], [Ngay23], [Ngay24], [Ngay25], [Ngay26], [Ngay27], [Ngay28], [Ngay29], [Ngay30], [Ngay31], [Tongsongay], [Ngaydilam], [Ngayvang]) VALUES (N'CC11180002', CAST(N'2018-08-01T00:00:00.000' AS DateTime), N'NV002', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 0, 0, 0)
INSERT [dbo].[tblBangchamcong] ([Machamcong], [Thangchamcong], [MaNV], [Ngay1], [Ngay2], [Ngay3], [Ngay4], [Ngay5], [Ngay6], [Ngay7], [Ngay8], [Ngay9], [Ngay10], [Ngay11], [Ngay12], [Ngay13], [Ngay14], [Ngay15], [Ngay16], [Ngay17], [Ngay18], [Ngay19], [Ngay20], [Ngay21], [Ngay22], [Ngay23], [Ngay24], [Ngay25], [Ngay26], [Ngay27], [Ngay28], [Ngay29], [Ngay30], [Ngay31], [Tongsongay], [Ngaydilam], [Ngayvang]) VALUES (N'CC11180003', CAST(N'2018-08-01T00:00:00.000' AS DateTime), N'NV003', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 0, 0, 0)
INSERT [dbo].[tblBangchamcong] ([Machamcong], [Thangchamcong], [MaNV], [Ngay1], [Ngay2], [Ngay3], [Ngay4], [Ngay5], [Ngay6], [Ngay7], [Ngay8], [Ngay9], [Ngay10], [Ngay11], [Ngay12], [Ngay13], [Ngay14], [Ngay15], [Ngay16], [Ngay17], [Ngay18], [Ngay19], [Ngay20], [Ngay21], [Ngay22], [Ngay23], [Ngay24], [Ngay25], [Ngay26], [Ngay27], [Ngay28], [Ngay29], [Ngay30], [Ngay31], [Tongsongay], [Ngaydilam], [Ngayvang]) VALUES (N'CC11180004', CAST(N'2018-10-01T00:00:00.000' AS DateTime), N'NV001', N'x', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 1, 1, 0)
INSERT [dbo].[tblBangchamcong] ([Machamcong], [Thangchamcong], [MaNV], [Ngay1], [Ngay2], [Ngay3], [Ngay4], [Ngay5], [Ngay6], [Ngay7], [Ngay8], [Ngay9], [Ngay10], [Ngay11], [Ngay12], [Ngay13], [Ngay14], [Ngay15], [Ngay16], [Ngay17], [Ngay18], [Ngay19], [Ngay20], [Ngay21], [Ngay22], [Ngay23], [Ngay24], [Ngay25], [Ngay26], [Ngay27], [Ngay28], [Ngay29], [Ngay30], [Ngay31], [Tongsongay], [Ngaydilam], [Ngayvang]) VALUES (N'CC11180005', CAST(N'2018-10-01T00:00:00.000' AS DateTime), N'NV002', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 0, 0, 0)
INSERT [dbo].[tblBangchamcong] ([Machamcong], [Thangchamcong], [MaNV], [Ngay1], [Ngay2], [Ngay3], [Ngay4], [Ngay5], [Ngay6], [Ngay7], [Ngay8], [Ngay9], [Ngay10], [Ngay11], [Ngay12], [Ngay13], [Ngay14], [Ngay15], [Ngay16], [Ngay17], [Ngay18], [Ngay19], [Ngay20], [Ngay21], [Ngay22], [Ngay23], [Ngay24], [Ngay25], [Ngay26], [Ngay27], [Ngay28], [Ngay29], [Ngay30], [Ngay31], [Tongsongay], [Ngaydilam], [Ngayvang]) VALUES (N'CC11180006', CAST(N'2018-10-01T00:00:00.000' AS DateTime), N'NV003', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 0, 0, 0)
INSERT [dbo].[tblChucvu] ([Machucvu], [Tenchucvu], [Hesochucvu], [Ghichu]) VALUES (N'CV01', N'Giám đốc', 2, NULL)
INSERT [dbo].[tblChucvu] ([Machucvu], [Tenchucvu], [Hesochucvu], [Ghichu]) VALUES (N'CV02', N'Phó giám đốc', 1.5, NULL)
INSERT [dbo].[tblChucvu] ([Machucvu], [Tenchucvu], [Hesochucvu], [Ghichu]) VALUES (N'CV03', N'Thư ký', 0.7, NULL)
INSERT [dbo].[tblChucvu] ([Machucvu], [Tenchucvu], [Hesochucvu], [Ghichu]) VALUES (N'CV04', N'Trưởng phòng', 1.2, NULL)
INSERT [dbo].[tblChucvu] ([Machucvu], [Tenchucvu], [Hesochucvu], [Ghichu]) VALUES (N'CV05', N'Phó trưởng phòng', 1, NULL)
INSERT [dbo].[tblChucvu] ([Machucvu], [Tenchucvu], [Hesochucvu], [Ghichu]) VALUES (N'CV06', N'Nhân viên', 0.6, NULL)
INSERT [dbo].[tblDantoc] ([Madantoc], [Tendantoc]) VALUES (N'DT01', N'Kinh')
INSERT [dbo].[tblDantoc] ([Madantoc], [Tendantoc]) VALUES (N'DT02', N'Tày')
INSERT [dbo].[tblDantoc] ([Madantoc], [Tendantoc]) VALUES (N'DT03', N'Thái')
INSERT [dbo].[tblDantoc] ([Madantoc], [Tendantoc]) VALUES (N'DT04', N'Mường')
INSERT [dbo].[tblDantoc] ([Madantoc], [Tendantoc]) VALUES (N'DT05', N'Hoa')
INSERT [dbo].[tblDantoc] ([Madantoc], [Tendantoc]) VALUES (N'DT06', N'Khơ-me')
INSERT [dbo].[tblDantoc] ([Madantoc], [Tendantoc]) VALUES (N'DT07', N'Nùng')
INSERT [dbo].[tblDantoc] ([Madantoc], [Tendantoc]) VALUES (N'DT08', N'Hơmông')
INSERT [dbo].[tblDantoc] ([Madantoc], [Tendantoc]) VALUES (N'DT09', N'Dao')
INSERT [dbo].[tblDantoc] ([Madantoc], [Tendantoc]) VALUES (N'DT10', N'Gia-rai')
INSERT [dbo].[tblDantoc] ([Madantoc], [Tendantoc]) VALUES (N'DT11', N'Ê-đê')
INSERT [dbo].[tblDantoc] ([Madantoc], [Tendantoc]) VALUES (N'DT12', N'Ba-na')
INSERT [dbo].[tblDotphongvan] ([Madotphongvan], [Tendotphongvan], [Manguoiphongvan], [Ngaybatdau], [Ngayketthuc], [Chude]) VALUES (N'1', N'Tuyển NV Kinh Doanh', N'NV001', CAST(N'2018-09-01T00:00:00.000' AS DateTime), CAST(N'2018-11-01T00:00:00.000' AS DateTime), N'Tuyển NV phòng kinh doanh')
INSERT [dbo].[tblDotphongvan] ([Madotphongvan], [Tendotphongvan], [Manguoiphongvan], [Ngaybatdau], [Ngayketthuc], [Chude]) VALUES (N'2', N'Tuyển NV Nhân Sự', N'NV001', CAST(N'2018-09-01T00:00:00.000' AS DateTime), CAST(N'2018-11-01T00:00:00.000' AS DateTime), N'Tuyển nhân sự')
INSERT [dbo].[tblKhenthuong] ([Makhenthuong], [MaNV], [Lydo], [Hinhthuc], [Ngaykhen], [Ghichu]) VALUES (N'KT01', N'NV001', N'Đạt được nhiều thành tích', N'Thưởng tiềndsg', CAST(N'2012-01-19T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[tblKhenthuong] ([Makhenthuong], [MaNV], [Lydo], [Hinhthuc], [Ngaykhen], [Ghichu]) VALUES (N'KT02', N'NV003', N'Đạt được nhiều thành tích', N'Thưởng tiền', CAST(N'2012-01-25T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[tblKhenthuong] ([Makhenthuong], [MaNV], [Lydo], [Hinhthuc], [Ngaykhen], [Ghichu]) VALUES (N'KT03', N'NV003', N'Đạt được nhiều thành tích', N'Thưởng tiền', CAST(N'2012-01-25T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[tblKhenthuong] ([Makhenthuong], [MaNV], [Lydo], [Hinhthuc], [Ngaykhen], [Ghichu]) VALUES (N'KT04', N'NV004', N'hoàn thành tốt công việc', N'Thưởng tiền', CAST(N'2012-06-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[tblKyluatphat] ([Makyluat], [MaNV], [Lydo], [Hinhthuc], [Ngaykyluat], [Ghichu]) VALUES (N'KL01', N'NV002', N'Đi muộn nhiều lần', N'Cắt tiền thưởng', CAST(N'2012-02-15T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[tblLLuong] ([MaLuong], [MaNV], [Heso], [Luongcoban], [Thang], [Ngaylamviec], [Phucap], [BHXH], [BHYT], [TongLuong], [ThucLinh], [GhiChu]) VALUES (N'ML001', N'NV001', 2, 1232, CAST(N'2018-08-01T00:00:00.000' AS DateTime), 2, 3, 123, 21312, 900000, 8000000, N'xăng')
INSERT [dbo].[tblLLuong] ([MaLuong], [MaNV], [Heso], [Luongcoban], [Thang], [Ngaylamviec], [Phucap], [BHXH], [BHYT], [TongLuong], [ThucLinh], [GhiChu]) VALUES (N'ML002', N'NV002', 2, 4000000, CAST(N'2018-11-07T00:00:00.000' AS DateTime), 26, 0, 640000, 120000, 8000000, 7240000, N'')
INSERT [dbo].[tblNgoaingu] ([Mangoaingu], [Tenngoaingu]) VALUES (N'NN01', N'Tiếng Anh')
INSERT [dbo].[tblNgoaingu] ([Mangoaingu], [Tenngoaingu]) VALUES (N'NN02', N'Tiếng Pháp')
INSERT [dbo].[tblNgoaingu] ([Mangoaingu], [Tenngoaingu]) VALUES (N'NN03', N'Tiếng Nhật')
INSERT [dbo].[tblNgoaingu] ([Mangoaingu], [Tenngoaingu]) VALUES (N'NN04', N'Tiếng Hàn')
INSERT [dbo].[tblNgoaingu] ([Mangoaingu], [Tenngoaingu]) VALUES (N'NN05', N'Tiếng Trung ')
INSERT [dbo].[tblNguoidung] ([Usename], [Pass], [Chophepthaotac], [Email]) VALUES (N'admin', N'123456', N'2', N'thanhtam28ss@gmail.com')
INSERT [dbo].[tblNguoidung] ([Usename], [Pass], [Chophepthaotac], [Email]) VALUES (N'bcd', N'123', NULL, N'abc1@gmail.com')
INSERT [dbo].[tblNguoidung] ([Usename], [Pass], [Chophepthaotac], [Email]) VALUES (N'hieu', N'123', N'0', NULL)
INSERT [dbo].[tblNguoidung] ([Usename], [Pass], [Chophepthaotac], [Email]) VALUES (N'nga', N'123', N'1', NULL)
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [CMND], [Ngaycap], [Tinhthanh], [Ngaysinh], [Gioitinh], [Nguyenquan], [Dctamtru], [Email], [SDTrieng], [SDTnha], [Tinhtranghonnhan], [Tinhtranglamviec], [Maphongban], [Machucvu], [Ngayvaolam], [Thamnien], [Heso], [Matinhoc], [Mangoaingu], [Mabangcap], [SoBHXH], [SoBHYT], [Cannang], [Cao], [Nhommau], [Tinhtrangsuckhoe], [TaikhoanNH], [Madantoc], [Matongiao], [Anh]) VALUES (N'NV001', N'Phạm Trung Hiếu', N'281179567', CAST(N'2014-02-20T00:00:00.000' AS DateTime), N'Bình Dương', CAST(N'1998-10-01T00:00:00.000' AS DateTime), N'Nam', N'Dầu Tiếng', N'Dầu Tiếng', N'phamhieu@gmail.com', N'0363073789', N'06503561131', N'Độc Thân', N'Đang làm việc', N'P01', N'CV01', CAST(N'2010-05-12T00:00:00.000' AS DateTime), 2, 2, N'TH01', N'NN01', N'BC01', N'15536535', N'45666666', N'65', N'1.73', N'O', N'Tốt', N'745A65645855', N'DT01', N'TG01', NULL)
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [CMND], [Ngaycap], [Tinhthanh], [Ngaysinh], [Gioitinh], [Nguyenquan], [Dctamtru], [Email], [SDTrieng], [SDTnha], [Tinhtranghonnhan], [Tinhtranglamviec], [Maphongban], [Machucvu], [Ngayvaolam], [Thamnien], [Heso], [Matinhoc], [Mangoaingu], [Mabangcap], [SoBHXH], [SoBHYT], [Cannang], [Cao], [Nhommau], [Tinhtrangsuckhoe], [TaikhoanNH], [Madantoc], [Matongiao], [Anh]) VALUES (N'NV002', N'Thuý Nga', N'015896573', CAST(N'2015-08-24T00:00:00.000' AS DateTime), N'Bình Dương', CAST(N'1998-04-12T00:00:00.000' AS DateTime), N'Nữ', N'Bàu Bàng - Bình Dương', N'Bàu Bàng', N'hoainam@gmail.com', N'0985163118', N'15437658769780', N'Độc thân', N'Đang làm việc', N'P01', N'CV01', CAST(N'2010-05-12T00:00:00.000' AS DateTime), 2, 2, N'TH01', N'NN01', N'BC01', N'1578989', N'1456896', N'46', N'1.4', N'O', N'Tốt', N'712A44556745', N'DT01', N'TG01', NULL)
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [CMND], [Ngaycap], [Tinhthanh], [Ngaysinh], [Gioitinh], [Nguyenquan], [Dctamtru], [Email], [SDTrieng], [SDTnha], [Tinhtranghonnhan], [Tinhtranglamviec], [Maphongban], [Machucvu], [Ngayvaolam], [Thamnien], [Heso], [Matinhoc], [Mangoaingu], [Mabangcap], [SoBHXH], [SoBHYT], [Cannang], [Cao], [Nhommau], [Tinhtrangsuckhoe], [TaikhoanNH], [Madantoc], [Matongiao], [Anh]) VALUES (N'NV003', N'Châu Đại Dương', N'158952536', CAST(N'2014-08-04T00:00:00.000' AS DateTime), N'Bình Thuận', CAST(N'1998-07-06T00:00:00.000' AS DateTime), N'Nam', N'Phan Thiết - Bình Thuận', N'Bình Dương', N'chaudaiduong@gmail.com', N'0903124568', N'436543765487', N'Độc thân', N'Đang làm việc', N'P01', N'CV01', CAST(N'2010-05-12T00:00:00.000' AS DateTime), 2, 2, N'TH01', N'NN01', N'BC01', N'1578989', N'1456896', N'46', N'1.5', N'B', N'Tốt', N'712A44556745', N'DT01', N'TG01', NULL)
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [CMND], [Ngaycap], [Tinhthanh], [Ngaysinh], [Gioitinh], [Nguyenquan], [Dctamtru], [Email], [SDTrieng], [SDTnha], [Tinhtranghonnhan], [Tinhtranglamviec], [Maphongban], [Machucvu], [Ngayvaolam], [Thamnien], [Heso], [Matinhoc], [Mangoaingu], [Mabangcap], [SoBHXH], [SoBHYT], [Cannang], [Cao], [Nhommau], [Tinhtrangsuckhoe], [TaikhoanNH], [Madantoc], [Matongiao], [Anh]) VALUES (N'NV004', N'Trịnh Trọng Thành', N'151786245', CAST(N'2015-02-15T00:00:00.000' AS DateTime), N'Bình Dương', CAST(N'1998-06-14T00:00:00.000' AS DateTime), N'Nam       ', N'Thủ Dầu Một', N'Thủ Dầu Một', N'danghatk@gmail.com', N'0983123425', N'0363125485', N'Độc thân', N'Đang làm việc', N'P02', N'CV04', CAST(N'2008-11-04T00:00:00.000' AS DateTime), 4, 2.2, N'TH02', N'NN01', N'BC05', N'1578555', N'1456656', N'62', N'1,72', N'AB        ', N'Tốt', N'744A45552222', N'DT01', N'TG03', NULL)
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [CMND], [Ngaycap], [Tinhthanh], [Ngaysinh], [Gioitinh], [Nguyenquan], [Dctamtru], [Email], [SDTrieng], [SDTnha], [Tinhtranghonnhan], [Tinhtranglamviec], [Maphongban], [Machucvu], [Ngayvaolam], [Thamnien], [Heso], [Matinhoc], [Mangoaingu], [Mabangcap], [SoBHXH], [SoBHYT], [Cannang], [Cao], [Nhommau], [Tinhtrangsuckhoe], [TaikhoanNH], [Madantoc], [Matongiao], [Anh]) VALUES (N'NV005', N'Trần Công Hậu', N'281179566', CAST(N'2014-02-20T00:00:00.000' AS DateTime), N'Bình Dương', CAST(N'1998-01-01T00:00:00.000' AS DateTime), N'Nam', N'Thuận An - Bình Dương', N'Thuận An - Bình Dương', N'hau@gmail.com', N'0363077777', N'06503561111', N'Độc Thân', N'Đang làm việc', N'P03', N'CV04', CAST(N'2017-02-07T00:00:00.000' AS DateTime), 1, 1.2000000476837158, N'TH03', N'NN01', N'BC06', N'7435435', N'4354354', N'77', N'1.8', N'A         ', N'Tốt', N'534545436554', N'DT01', N'TG05', NULL)
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [CMND], [Ngaycap], [Tinhthanh], [Ngaysinh], [Gioitinh], [Nguyenquan], [Dctamtru], [Email], [SDTrieng], [SDTnha], [Tinhtranghonnhan], [Tinhtranglamviec], [Maphongban], [Machucvu], [Ngayvaolam], [Thamnien], [Heso], [Matinhoc], [Mangoaingu], [Mabangcap], [SoBHXH], [SoBHYT], [Cannang], [Cao], [Nhommau], [Tinhtrangsuckhoe], [TaikhoanNH], [Madantoc], [Matongiao], [Anh]) VALUES (N'NV06', N'Hồ Anh Tuấn', N'148572345', CAST(N'2002-03-04T00:00:00.000' AS DateTime), N'Bình Dương', CAST(N'1994-08-14T00:00:00.000' AS DateTime), N'Nam', N'Bình Dương', N'Bình Dương', N'Tuan@gmail.com', N'01689745123', N'34576879678', N'độc thân', N'', N'P01', N'CV01', CAST(N'2018-11-01T00:00:00.000' AS DateTime), 1, 1.2000000476837158, N'TH01', N'NN01', N'BC01', N'4234324', N'3242343', N'77', N'1.6', N'O', N'Tốt', N'12412445345', N'DT01', N'TG01', NULL)
INSERT [dbo].[tblPhongban] ([Maphongban], [Tenphongban], [Ghichu], [Email]) VALUES (N'P01', N'Phòng giám đốc', N'Phạm Trung Hiếu', N'phamhieunote5@gmail.com')
INSERT [dbo].[tblPhongban] ([Maphongban], [Tenphongban], [Ghichu], [Email]) VALUES (N'P02', N'Phòng kinh doanh', N'', N'phongkinhdoanh@gmail.com')
INSERT [dbo].[tblPhongban] ([Maphongban], [Tenphongban], [Ghichu], [Email]) VALUES (N'P03', N'Phòng hành chính', N'', N'phonghanhchinh@gmail.com')
INSERT [dbo].[tblPhongban] ([Maphongban], [Tenphongban], [Ghichu], [Email]) VALUES (N'P04', N'Phòng marketing', N'', N'phongmarketing@gmail.com')
INSERT [dbo].[tblPhongban] ([Maphongban], [Tenphongban], [Ghichu], [Email]) VALUES (N'P05', N'Phòng nhân sự', N'', N'phongnhansu@gmail.com')
INSERT [dbo].[tblTinhoc] ([Matinhoc], [Tentinhoc]) VALUES (N'TH01', N'Tin học cơ bản')
INSERT [dbo].[tblTinhoc] ([Matinhoc], [Tentinhoc]) VALUES (N'TH02', N'Tin học ứng dụng')
INSERT [dbo].[tblTinhoc] ([Matinhoc], [Tentinhoc]) VALUES (N'TH03', N'Tin học nâng cao')
INSERT [dbo].[tblTongiao] ([Matongiao], [Tentongiao]) VALUES (N'TG01', N'Phật giáo')
INSERT [dbo].[tblTongiao] ([Matongiao], [Tentongiao]) VALUES (N'TG02', N'Đạo giáo')
INSERT [dbo].[tblTongiao] ([Matongiao], [Tentongiao]) VALUES (N'TG03', N'Hồi giáo')
INSERT [dbo].[tblTongiao] ([Matongiao], [Tentongiao]) VALUES (N'TG04', N'Kitô giáo')
INSERT [dbo].[tblTongiao] ([Matongiao], [Tentongiao]) VALUES (N'TG05', N'Không tôn giáo')
INSERT [dbo].[tblUngvien] ([Maungvien], [Tenungvien], [CMND], [Ngaycap], [Tinhthanh], [Ngaysinh], [Gioitinh], [Diachi], [Email], [SDTrieng], [SDTnha], [Tinhtranghonnhan], [Mabangcap], [Mangoaingu], [Matinhoc], [Namkinhnghiem], [Ngaynophoso], [Trangthai], [Ghichu], [Madantoc], [Matongiao], [Madotphongvan]) VALUES (N'UV02', N'Vũ Văn Trung', N'148572345', CAST(N'2002-03-04T00:00:00.000' AS DateTime), N'TPHCM', CAST(N'1993-08-14T00:00:00.000' AS DateTime), N'Nữ', N'TPHCM', N'Trung@gmail.com', N'36547657356', N'34576879678', N'độc thân', N'BC01', N'NN01', N'TH01', 1, CAST(N'2012-02-20T00:00:00.000' AS DateTime), N'chưa PV', NULL, N'DT01', N'TG01', N'1')
INSERT [dbo].[tblUngvien] ([Maungvien], [Tenungvien], [CMND], [Ngaycap], [Tinhthanh], [Ngaysinh], [Gioitinh], [Diachi], [Email], [SDTrieng], [SDTnha], [Tinhtranghonnhan], [Mabangcap], [Mangoaingu], [Matinhoc], [Namkinhnghiem], [Ngaynophoso], [Trangthai], [Ghichu], [Madantoc], [Matongiao], [Madotphongvan]) VALUES (N'UV03', N'Trần Văn Giàu', N'281179675', CAST(N'2014-11-06T00:00:00.000' AS DateTime), N'Bình Dương', CAST(N'1998-11-04T00:00:00.000' AS DateTime), N'Nam', N'Bình Dương', N'abc@gmail.com', N'01663073789', N'06503561131', N'Độc Thân', N'BC05', N'NN01', N'TH02', 1, CAST(N'2018-11-07T00:00:00.000' AS DateTime), N'Đang xét', NULL, N'DT01', N'TG05', N'1')
ALTER TABLE [dbo].[tblBangchamcong]  WITH CHECK ADD  CONSTRAINT [FK_tblBangchamcong_tblNhanvien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[tblBangchamcong] CHECK CONSTRAINT [FK_tblBangchamcong_tblNhanvien]
GO
ALTER TABLE [dbo].[tblDotphongvan]  WITH CHECK ADD  CONSTRAINT [FK_Dotphongvan_tblNhanvien] FOREIGN KEY([Manguoiphongvan])
REFERENCES [dbo].[tblNhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[tblDotphongvan] CHECK CONSTRAINT [FK_Dotphongvan_tblNhanvien]
GO
ALTER TABLE [dbo].[tblKhenthuong]  WITH CHECK ADD  CONSTRAINT [FK_tblKhenthuong_tblNhanvien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[tblKhenthuong] CHECK CONSTRAINT [FK_tblKhenthuong_tblNhanvien]
GO
ALTER TABLE [dbo].[tblKyluatphat]  WITH CHECK ADD  CONSTRAINT [FK_tblKyluatphat_tblNhanvien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[tblKyluatphat] CHECK CONSTRAINT [FK_tblKyluatphat_tblNhanvien]
GO
ALTER TABLE [dbo].[tblLLuong]  WITH CHECK ADD  CONSTRAINT [FK_Luong_tblNhanvien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[tblLLuong] CHECK CONSTRAINT [FK_Luong_tblNhanvien]
GO
ALTER TABLE [dbo].[tblNhanvien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanvien_tblBangcap] FOREIGN KEY([Mabangcap])
REFERENCES [dbo].[tblBangcap] ([Mabangcap])
GO
ALTER TABLE [dbo].[tblNhanvien] CHECK CONSTRAINT [FK_tblNhanvien_tblBangcap]
GO
ALTER TABLE [dbo].[tblNhanvien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanvien_tblChucvu] FOREIGN KEY([Machucvu])
REFERENCES [dbo].[tblChucvu] ([Machucvu])
GO
ALTER TABLE [dbo].[tblNhanvien] CHECK CONSTRAINT [FK_tblNhanvien_tblChucvu]
GO
ALTER TABLE [dbo].[tblNhanvien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanvien_tblDantoc] FOREIGN KEY([Madantoc])
REFERENCES [dbo].[tblDantoc] ([Madantoc])
GO
ALTER TABLE [dbo].[tblNhanvien] CHECK CONSTRAINT [FK_tblNhanvien_tblDantoc]
GO
ALTER TABLE [dbo].[tblNhanvien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanvien_tblNgoaingu] FOREIGN KEY([Mangoaingu])
REFERENCES [dbo].[tblNgoaingu] ([Mangoaingu])
GO
ALTER TABLE [dbo].[tblNhanvien] CHECK CONSTRAINT [FK_tblNhanvien_tblNgoaingu]
GO
ALTER TABLE [dbo].[tblNhanvien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanvien_tblPhongban] FOREIGN KEY([Maphongban])
REFERENCES [dbo].[tblPhongban] ([Maphongban])
GO
ALTER TABLE [dbo].[tblNhanvien] CHECK CONSTRAINT [FK_tblNhanvien_tblPhongban]
GO
ALTER TABLE [dbo].[tblNhanvien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanvien_tblTinhoc] FOREIGN KEY([Matinhoc])
REFERENCES [dbo].[tblTinhoc] ([Matinhoc])
GO
ALTER TABLE [dbo].[tblNhanvien] CHECK CONSTRAINT [FK_tblNhanvien_tblTinhoc]
GO
ALTER TABLE [dbo].[tblNhanvien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanvien_tblTongiao] FOREIGN KEY([Matongiao])
REFERENCES [dbo].[tblTongiao] ([Matongiao])
GO
ALTER TABLE [dbo].[tblNhanvien] CHECK CONSTRAINT [FK_tblNhanvien_tblTongiao]
GO
ALTER TABLE [dbo].[tblUngvien]  WITH CHECK ADD  CONSTRAINT [FK_tblUngvien_Dotphongvan] FOREIGN KEY([Madotphongvan])
REFERENCES [dbo].[tblDotphongvan] ([Madotphongvan])
GO
ALTER TABLE [dbo].[tblUngvien] CHECK CONSTRAINT [FK_tblUngvien_Dotphongvan]
GO
ALTER TABLE [dbo].[tblUngvien]  WITH CHECK ADD  CONSTRAINT [FK_tblUngvien_tblBangcap] FOREIGN KEY([Mabangcap])
REFERENCES [dbo].[tblBangcap] ([Mabangcap])
GO
ALTER TABLE [dbo].[tblUngvien] CHECK CONSTRAINT [FK_tblUngvien_tblBangcap]
GO
ALTER TABLE [dbo].[tblUngvien]  WITH CHECK ADD  CONSTRAINT [FK_tblUngvien_tblDantoc] FOREIGN KEY([Madantoc])
REFERENCES [dbo].[tblDantoc] ([Madantoc])
GO
ALTER TABLE [dbo].[tblUngvien] CHECK CONSTRAINT [FK_tblUngvien_tblDantoc]
GO
ALTER TABLE [dbo].[tblUngvien]  WITH CHECK ADD  CONSTRAINT [FK_tblUngvien_tblNgoaingu] FOREIGN KEY([Mangoaingu])
REFERENCES [dbo].[tblNgoaingu] ([Mangoaingu])
GO
ALTER TABLE [dbo].[tblUngvien] CHECK CONSTRAINT [FK_tblUngvien_tblNgoaingu]
GO
ALTER TABLE [dbo].[tblUngvien]  WITH CHECK ADD  CONSTRAINT [FK_tblUngvien_tblTinhoc] FOREIGN KEY([Matinhoc])
REFERENCES [dbo].[tblTinhoc] ([Matinhoc])
GO
ALTER TABLE [dbo].[tblUngvien] CHECK CONSTRAINT [FK_tblUngvien_tblTinhoc]
GO
ALTER TABLE [dbo].[tblUngvien]  WITH CHECK ADD  CONSTRAINT [FK_tblUngvien_tblTongiao] FOREIGN KEY([Matongiao])
REFERENCES [dbo].[tblTongiao] ([Matongiao])
GO
ALTER TABLE [dbo].[tblUngvien] CHECK CONSTRAINT [FK_tblUngvien_tblTongiao]
GO
/****** Object:  StoredProcedure [dbo].[NewDeleteCommand]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewDeleteCommand]
(
	@Original_Mabangcap varchar(10),
	@IsNull_Tenbangcap Int,
	@Original_Tenbangcap nvarchar(50)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [tblBangcap] WHERE (([Mabangcap] = @Original_Mabangcap) AND ((@IsNull_Tenbangcap = 1 AND [Tenbangcap] IS NULL) OR ([Tenbangcap] = @Original_Tenbangcap)))
GO
/****** Object:  StoredProcedure [dbo].[NewInsertCommand]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewInsertCommand]
(
	@Mabangcap varchar(10),
	@Tenbangcap nvarchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [tblBangcap] ([Mabangcap], [Tenbangcap]) VALUES (@Mabangcap, @Tenbangcap);
	
SELECT Mabangcap, Tenbangcap FROM tblBangcap WHERE (Mabangcap = @Mabangcap)
GO
/****** Object:  StoredProcedure [dbo].[NewSelectCommand]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewSelectCommand]
AS
	SET NOCOUNT ON;
SELECT     tblNhanvien.TenNV, tblChucvu.Tenchucvu, tblBangchiluong.Ngaylamviec, tblBangchiluong.Luongthang, tblBangchiluong.PhucapCV, 
                      tblBangchiluong.Phucapdochai, tblBangchiluong.Trocaptrachnhiem, tblBangchiluong.Trocapantrua, tblBangchiluong.Trocapxanha, 
                      tblBangchiluong.TrocapQLDN, tblBangchiluong.Tongluong, tblBangchiluong.BHXH, tblBangchiluong.BHYT, tblBangchiluong.Doanphi, 
                      tblBangchiluong.Thuclinh, tblBangchiluong.Thangchi
FROM         tblChucvu INNER JOIN
                      tblNhanvien ON tblChucvu.Machucvu = tblNhanvien.Machucvu INNER JOIN
                      tblBangchiluong ON tblNhanvien.MaNV = tblBangchiluong.MaNV
GO
/****** Object:  StoredProcedure [dbo].[NewUpdateCommand]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewUpdateCommand]
(
	@Mabangcap varchar(10),
	@Tenbangcap nvarchar(50),
	@Original_Mabangcap varchar(10),
	@IsNull_Tenbangcap Int,
	@Original_Tenbangcap nvarchar(50)
)
AS
	SET NOCOUNT OFF;
UPDATE [tblBangcap] SET [Mabangcap] = @Mabangcap, [Tenbangcap] = @Tenbangcap WHERE (([Mabangcap] = @Original_Mabangcap) AND ((@IsNull_Tenbangcap = 1 AND [Tenbangcap] IS NULL) OR ([Tenbangcap] = @Original_Tenbangcap)));
	
SELECT Mabangcap, Tenbangcap FROM tblBangcap WHERE (Mabangcap = @Mabangcap)
GO
/****** Object:  StoredProcedure [dbo].[proc_Bangcap_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Bangcap_Delete]
@Mabangcap varchar(10)
AS
DELETE tblBangcap 
WHERE  Mabangcap=@Mabangcap
GO
/****** Object:  StoredProcedure [dbo].[proc_Bangcap_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Bangcap_Insert]
@Mabangcap varchar(10),
@Tenbangcap nvarchar(50)=null
AS
INSERT INTO tblBangcap(Mabangcap,Tenbangcap)
VALUES (@Mabangcap,@Tenbangcap)

GO
/****** Object:  StoredProcedure [dbo].[proc_Bangcap_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Bangcap_Update]
@Mabangcap varchar(10),
@Tenbangcap nvarchar(50)=null
AS 
UPDATE tblBangcap SET Tenbangcap=@Tenbangcap
WHERE Mabangcap=@Mabangcap
GO
/****** Object:  StoredProcedure [dbo].[Proc_BC_Chucvu]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Proc_BC_Chucvu]
@Machucvu varchar(10)
AS
BEGIN
Select * from tblNhanvien WHERE Machucvu=@Machucvu
END
GO
/****** Object:  StoredProcedure [dbo].[Proc_BC_Dotuoi]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Proc_BC_Dotuoi]
@Tunam int,
@Toinam int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.

    -- Insert statements for procedure here
	select * from tblNhanvien where  ((year(getdate()) - year(Ngaysinh)) between @Tunam AND @Toinam)
END
GO
/****** Object:  StoredProcedure [dbo].[proc_BC_Phongban]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[proc_BC_Phongban]
@Phongban varchar(10)
as
select * from tblNhanvien
where Maphongban=@Phongban
GO
/****** Object:  StoredProcedure [dbo].[proc_ChucVu_BC]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ChucVu_BC]
AS
SELECT Machucvu,Tenchucvu,Hesochucvu,Luongcoban,Ghichu
FROM tblChucvu
GO
/****** Object:  StoredProcedure [dbo].[proc_Chucvu_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Chucvu_Delete]
@Machucvu varchar(10)
AS
DELETE tblChucvu WHERE Machucvu=@Machucvu
GO
/****** Object:  StoredProcedure [dbo].[proc_Chucvu_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Chucvu_Insert]
@Machucvu varchar(10),
@Tenchucvu nvarchar(50)=null,
@Hesochucvu real=null,
@Ghichu nvarchar(max)=null
AS
INSERT INTO tblChucvu (Machucvu,Tenchucvu,Hesochucvu,Ghichu)
VALUES(@Machucvu,@Tenchucvu,@Hesochucvu,@Ghichu )
GO
/****** Object:  StoredProcedure [dbo].[proc_Chucvu_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Chucvu_Update]
@Machucvu varchar(10),
@Tenchucvu nvarchar(50)=null,
@Hesochucvu real=null,
@Ghichu nvarchar(max)=null
AS
UPDATE tblChucvu SET Tenchucvu=@Tenchucvu, Hesochucvu=@Hesochucvu,Ghichu=@Ghichu
WHERE Machucvu=@Machucvu
GO
/****** Object:  StoredProcedure [dbo].[proc_ChuyenNV_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ChuyenNV_Insert]
	@MaNV varchar(10),
@TenNV nvarchar(50),
@CMND varchar(20),
@Ngaycap datetime =null,
@Tinhthanh nvarchar(50)=null,
@Ngaysinh datetime=null,
@Gioitinh nvarchar(10)=null,
@Dctamtru nvarchar(50)=null,
@Email nvarchar(50) =null,
@SDTrieng varchar(15) =null,
@SDTnha varchar(15) =null,
@Tinhtranghonnhan nvarchar(50) =null,
@Maphongban varchar(10) =null,
@Machucvu varchar(10) =null,
@Matinhoc varchar(10) =null,
@Mangoaingu varchar(10) =null,
@Mabangcap varchar(10)=null,
@Madantoc varchar(10) =null,
@Matongiao varchar(10) =null


as
insert into tblNhanvien (MaNV,TenNV,CMND,Ngaycap,Tinhthanh,Ngaysinh,Gioitinh,
	Dctamtru,Email,SDTrieng,SDTnha,Tinhtranghonnhan,Maphongban,Machucvu,Matinhoc,Mangoaingu,Mabangcap,Madantoc,Matongiao)
values(@MaNV,@TenNV,@CMND,@Ngaycap,@Tinhthanh,@Ngaysinh,@Gioitinh,@Dctamtru,
	@Email,@SDTrieng,@SDTnha,@Tinhtranghonnhan,@Maphongban,@Machucvu,@Matinhoc,@Mangoaingu,@Mabangcap,@Madantoc,@Matongiao)
GO
/****** Object:  StoredProcedure [dbo].[proc_Dantoc_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Dantoc_Delete]
@Madantoc varchar(10)
AS
delete tblDantoc
where Madantoc=@Madantoc
GO
/****** Object:  StoredProcedure [dbo].[proc_Dantoc_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Dantoc_Insert]
@Madantoc varchar(10),
@Tendantoc varchar(50)=null
AS
INSERT INTO tblDantoc (Madantoc,Tendantoc)
VALUES (@Madantoc,@Tendantoc)
GO
/****** Object:  StoredProcedure [dbo].[proc_Dantoc_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Dantoc_Update]
@Madantoc varchar(10),
@Tendantoc nvarchar(50)=null
AS
UPDATE tblDantoc SET Tendantoc=@Tendantoc
WHERE Madantoc=@Madantoc
GO
/****** Object:  StoredProcedure [dbo].[proc_DiaDiem_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DiaDiem_Delete]
	@Madiadiem varchar(10)
AS
DELETE tblDiadiem 
WHERE  Madiadiem=@Madiadiem

GO
/****** Object:  StoredProcedure [dbo].[proc_DiaDiem_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DiaDiem_Insert]
	@Madiadiem varchar(10),
@Tendiadiem nvarchar(50)=null
AS
INSERT INTO tblDiadiem(Madiadiem,Tendiadiem)
VALUES (@Madiadiem,@Tendiadiem)
GO
/****** Object:  StoredProcedure [dbo].[proc_DiaDiem_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DiaDiem_Update]
	@Madiadiem varchar(10),
@Tendiadiem nvarchar(50)=null
AS
UPDATE tblDiadiem SET Tendiadiem=@Tendiadiem
WHERE Madiadiem=@Madiadiem
GO
/****** Object:  StoredProcedure [dbo].[proc_DotPV_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DotPV_Delete]
	@Madotphongvan varchar(10)
AS
DELETE tblDotphongvan 
WHERE  Madotphongvan=@Madotphongvan
GO
/****** Object:  StoredProcedure [dbo].[proc_DotPV_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DotPV_Insert]
	@Madotphongvan varchar(10),
@Tendotphongvan nvarchar(50)=null,
@Madottuyendung varchar(10),
@Manguoiphongvan varchar(10),
@Ngaybatdau datetime=null,
@Ngayketthuc datetime=null,
@Chude nvarchar(50)=null,
@Madiadiem varchar(10),
@Tinhtrang nvarchar(20)=null,
@Ghichu nvarchar(max)=null

AS
INSERT INTO tblDotphongvan (Madotphongvan,Tendotphongvan,Madottuyendung,Manguoiphongvan,Ngaybatdau,Ngayketthuc,Chude,Madiadiem,Tinhtrang,Ghichu)
VALUES (@Madotphongvan,@Tendotphongvan,@Madottuyendung,@Manguoiphongvan,@Ngaybatdau,@Ngayketthuc,@Chude,@Madiadiem,@Tinhtrang,@Ghichu)

GO
/****** Object:  StoredProcedure [dbo].[proc_DotPV_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DotPV_Update]
	@Madotphongvan varchar(10),
@Tendotphongvan nvarchar(50)=null,
@Madottuyendung varchar(10),
@Manguoiphongvan varchar(10),
@Ngaybatdau datetime=null,
@Ngayketthuc datetime=null,
@Chude nvarchar(50)=null,
@Madiadiem varchar(10),
@Tinhtrang nvarchar(20)=null,
@Ghichu nvarchar(max)=null

AS
UPDATE tblDotphongvan SET Tendotphongvan=@Tendotphongvan,Madottuyendung=@Madottuyendung,Manguoiphongvan=@Manguoiphongvan,Ngaybatdau=@Ngaybatdau,Ngayketthuc=@Ngayketthuc,Chude=@Chude,Madiadiem=@Madiadiem,Tinhtrang=@Tinhtrang,Ghichu=@Ghichu
WHERE Madotphongvan=@Madotphongvan

GO
/****** Object:  StoredProcedure [dbo].[proc_DotTD_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DotTD_Delete]
	@Madottuyendung varchar(10)
AS
DELETE tblDottuyendung 
WHERE  Madottuyendung=@Madottuyendung
GO
/****** Object:  StoredProcedure [dbo].[proc_DotTD_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DotTD_Insert]
	@Madottuyendung varchar(10),
@Tendottuyendung nvarchar(50)=null,
@Maphongban varchar(10),
@Manguoiphutrach varchar(10),
@Mabangcap varchar(10),
@Capbac nvarchar(50)=null,
@Dotuoi nvarchar(50)=null,
@Gioitinh nvarchar(10)=null,
@Soluong int=null,
@Trangthai nvarchar(20)=null

AS
INSERT INTO tblDottuyendung (Madottuyendung,Tendottuyendung,Maphongban,Manguoiphutrach,Mabangcap,Capbac,Dotuoi,Gioitinh,Soluong,Trangthai)
VALUES (@Madottuyendung,@Tendottuyendung,@Maphongban,@Manguoiphutrach,@Mabangcap,@Capbac,@Dotuoi,@Gioitinh,@Soluong,@Trangthai)
GO
/****** Object:  StoredProcedure [dbo].[proc_DotTD_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DotTD_Update]
	@Madottuyendung varchar(10),
@Tendottuyendung nvarchar(50)=null,
@Maphongban varchar(10),
@Manguoiphutrach varchar(10),
@Mabangcap varchar(10),
@Capbac nvarchar(50)=null,
@Dotuoi nvarchar(50)=null,
@Gioitinh nvarchar(10)=null,
@Soluong int=null,
@Trangthai nvarchar(20)=null

AS
UPDATE tblDottuyendung SET Tendottuyendung=@Tendottuyendung,Maphongban=@Maphongban,Manguoiphutrach=@Manguoiphutrach,Mabangcap=@Mabangcap,Capbac=@Capbac,Dotuoi=@Dotuoi,Gioitinh=@Gioitinh,Soluong=@Soluong,Trangthai=@Trangthai
WHERE Madottuyendung=@Madottuyendung

GO
/****** Object:  StoredProcedure [dbo].[proc_Hopdong_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Hopdong_Delete]
@Mahopdong varchar(10)
AS
DELETE tblHopdong
WHERE Mahopdong=@Mahopdong 
GO
/****** Object:  StoredProcedure [dbo].[proc_Hopdong_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Hopdong_Insert]
@Mahopdong varchar(10),
@MaNV varchar(10),
@Ngaybatdau datetime =null,
@Ngayketthuc datetime =null,
@Lanky int=null,
@Noidung nvarchar(max)=null,
@Ngayky datetime=null,
@Tennguoiky nvarchar(50)=null,
@Ghichu nvarchar(max)=null
AS
INSERT INTO tblHopdong (Mahopdong,MaNV,Ngaybatdau,Ngayketthuc,Lanky,Noidung,Ngayky,Tennguoiky,Ghichu)
VALUES (@Mahopdong,@MaNV,@Ngaybatdau,@Ngayketthuc,@Lanky,@Noidung,@Ngayky,@Tennguoiky,@Ghichu)


GO
/****** Object:  StoredProcedure [dbo].[proc_Hopdong_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Hopdong_Update]
@Mahopdong varchar(10),
@MaNV varchar(10),
@Ngaybatdau datetime =null,
@Ngayketthuc datetime =null,
@Lanky int=null,
@Noidung nvarchar(max)=null,
@Ngayky datetime=null,
@Tennguoiky nvarchar(50)=null,
@Ghichu nvarchar(max)=null
AS
UPDATE tblHopdong SET Ngaybatdau=@Ngaybatdau,Ngayketthuc=@Ngayketthuc,Lanky=@Lanky,Noidung=@Noidung,Ngayky=@Ngayky,Tennguoiky=@Tennguoiky,Ghichu=@Ghichu
WHERE Mahopdong=@Mahopdong 
GO
/****** Object:  StoredProcedure [dbo].[proc_khenthuong_BC]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[proc_khenthuong_BC]
AS
SELECT tblKhenthuong.Makhenthuong,tblNhanvien.MaNV,tblNhanvien.TenNV,tblNhanvien.Maphongban,tblKhenthuong.Ngaykhen,tblKhenthuong.Hinhthuc,tblKhenthuong.Lydo,tblKhenthuong.Ghichu
FROM tblKhenthuong,tblNhanvien
WHERE tblNhanvien.MaNV=tblKhenthuong.MaNV
GO
/****** Object:  StoredProcedure [dbo].[proc_Khenthuong_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Khenthuong_Delete]
@Makhenthuong varchar(10),
@MaNV varchar(10)
AS
DELETE tblKhenthuong
WHERE Makhenthuong=@Makhenthuong And MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[proc_Khenthuong_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Khenthuong_Insert]
@Makhenthuong varchar(10),
@MaNV varchar(10),
@Lydo nvarchar(max)=null,
@Hinhthuc nvarchar(50)=null,
@Ngaykhen datetime=null
AS
INSERT INTO tblKhenthuong (Makhenthuong,MaNV,Lydo,Hinhthuc,Ngaykhen)
VALUES (@Makhenthuong,@MaNV,@Lydo,@Hinhthuc,@Ngaykhen)

GO
/****** Object:  StoredProcedure [dbo].[proc_Khenthuong_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Khenthuong_Update]
@Makhenthuong varchar(10),
@MaNV varchar(10),
@Lydo nvarchar(max)=null,
@Hinhthuc nvarchar(50)=null,
@Ngaykhen datetime=null
AS
UPDATE tblKhenthuong SET Lydo=@Lydo,Hinhthuc=@Hinhthuc,Ngaykhen=@Ngaykhen
WHERE (Makhenthuong=@Makhenthuong And MaNV=@MaNV)

GO
/****** Object:  StoredProcedure [dbo].[proc_Kyluat_BC]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[proc_Kyluat_BC]
AS
SELECT tblKyluatphat.Makyluat,tblNhanvien.MaNV,tblNhanvien.TenNV,tblNhanvien.Maphongban,tblKyluatphat.Lydo,Hinhthuc,tblKyluatphat.Ngaykyluat,tblKyluatphat.Ghichu
FROM tblKyluatphat,tblNhanvien
WHERE tblKyluatphat.MaNV=tblNhanvien.MaNV

GO
/****** Object:  StoredProcedure [dbo].[proc_Kyluat_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Kyluat_Delete]
@Makyluat varchar(10),
@MaNV varchar(10)
as
delete tblKyluatphat
where Makyluat=@Makyluat and MaNV=@MaNV

GO
/****** Object:  StoredProcedure [dbo].[proc_Kyluat_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Kyluat_Insert]
@Makyluat varchar(10),
@MaNV varchar(10),
@Lydo nvarchar(50)=null,
@Hinhthuc nvarchar(50)=null,
@Ngaykyluat datetime=null
AS
INSERT INTO tblKyluatphat (Makyluat,MaNV,Lydo,Hinhthuc,Ngaykyluat)
VALUES(@Makyluat,@MaNV,@Lydo,@Hinhthuc,@Ngaykyluat)
GO
/****** Object:  StoredProcedure [dbo].[proc_Kyluat_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Kyluat_Update]
@Makyluat varchar(10),
@MaNV varchar(10),
@Lydo nvarchar(50)=null,
@Hinhthuc nvarchar(50)=null,
@Ngaykyluat datetime=null
as
update tblKyluatphat set Lydo=@Lydo,Hinhthuc=@Hinhthuc,Ngaykyluat=@Ngaykyluat
where Makyluat=@Makyluat and MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[proc_LLuong_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_LLuong_Delete]
@maluong varchar(10) 
AS 
BEGIN 
DELETE FROM tblLLuong
WHERE MaLuong = @maluong 
END 
GO
/****** Object:  StoredProcedure [dbo].[proc_LLuong_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_LLuong_Insert]
    @MaLuong varchar(10),
    @MaNV varchar(10),
    @Heso float,
    @Luongcoban float,
	@Thang datetime,
	@Ngaylamviec int,
	@Phucap float,
	@BHXH float,
	@BHYT float,
	@TongLuong float,
	@ThucLinh float,
	@GhiChu nvarchar(50)
AS
BEGIN
     INSERT INTO tblLLuong(MaLuong,MaNV,Heso, Luongcoban,Thang,Ngaylamviec,Phucap,BHXH,BHYT,TongLuong,ThucLinh,GhiChu)
     VALUES(@MaLuong,@MaNV,@Heso,@Luongcoban,@Thang,@Ngaylamviec,@Phucap,@BHXH,@BHYT,@TongLuong,@ThucLinh,@GhiChu)
END
GO
/****** Object:  StoredProcedure [dbo].[proc_LLuong_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_LLuong_Update]
    @MaLuong varchar(10),
    @MaNV varchar(10),
    @Heso float,
    @Luongcoban float,
	@Thang datetime,
	@Ngaylamviec int,
	@Phucap float,
	@BHXH float,
	@BHYT float,
	@TongLuong float,
	@ThucLinh float,
	@GhiChu nvarchar(50)
AS
BEGIN
UPDATE tblLLuong
	Set MaLuong= @MaLuong, MaNV=@MaNV ,Heso=@Heso,Luongcoban=@Luongcoban,Thang=@Thang,Ngaylamviec=@Ngaylamviec,Phucap=@Phucap,BHXH=@BHXH,BHYT=@BHYT,TongLuong=@TongLuong,ThucLinh=@ThucLinh,GhiChu=@GhiChu
	where MaLuong=@MaLuong
END
GO
/****** Object:  StoredProcedure [dbo].[proc_Nghiviec_BC]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[proc_Nghiviec_BC]
as 
select tblNghiviec.Manghiviec,tblNhanvien.MaNV,tblNhanvien.TenNV,tblNghiviec.Ngayquyetdinh,tblNghiviec.Ngayhieuluc,tblNghiviec.Lydo,tblNghiviec.Tienboithuong
from tblNghiviec,tblNhanvien
where tblNghiviec.MaNV=tblNhanvien.MaNV
GO
/****** Object:  StoredProcedure [dbo].[proc_Nghiviec_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Nghiviec_Delete]
@Manghiviec varchar(10),
@MaNV varchar(10)
as
delete tblNghiviec
where Manghiviec=@Manghiviec and MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[proc_Nghiviec_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Nghiviec_Insert]
@Manghiviec varchar(10),
@MaNV varchar(10),
@Ngayquyetdinh datetime=null,
@Ngayhieuluc datetime=null,
@Lydo nvarchar(MAX)=null,
@Ghichu nvarchar(MAX)=null
AS 
INSERT INTO tblNghiviec (Manghiviec,MaNV,Ngayquyetdinh,Ngayhieuluc,Lydo,Ghichu)
VALUES (@Manghiviec,@MaNV,@Ngayquyetdinh,@Ngayhieuluc,@Lydo,@Ghichu)
GO
/****** Object:  StoredProcedure [dbo].[proc_Nghiviec_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Nghiviec_Update]
@Manghiviec varchar(10),
@MaNV varchar(10),
@Ngayquyetdinh datetime=null,
@Ngayhieuluc datetime=null,
@Lydo nvarchar(MAX)=null,
@Ghichu nvarchar(MAX)=null
as
update tblNghiviec set Ngayquyetdinh=@Ngayquyetdinh,Ngayhieuluc=@Ngayhieuluc,Lydo=@Lydo,Ghichu=@Ghichu
where Manghiviec=@Manghiviec and MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[proc_Ngoaingu_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Ngoaingu_Delete]
@Mangoaingu varchar(10)
as
delete tblNgoaingu
where Mangoaingu=@Mangoaingu

GO
/****** Object:  StoredProcedure [dbo].[proc_Ngoaingu_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Ngoaingu_Insert]
@Mangoaingu varchar(10),
@Tenngoaingu nvarchar(50)
as
insert into tblNgoaingu(Mangoaingu,Tenngoaingu)
values(@Mangoaingu,@Tenngoaingu)

GO
/****** Object:  StoredProcedure [dbo].[proc_Ngoaingu_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Ngoaingu_Update]
@Mangoaingu varchar(10),
@Tenngoaingu nvarchar(50)
as
update tblNgoaingu set Tenngoaingu=@Tenngoaingu
where Mangoaingu=@Mangoaingu
GO
/****** Object:  StoredProcedure [dbo].[proc_NhanVien_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_NhanVien_Delete]
@MaNV varchar(10)
AS
DELETE tblNhanvien
WHERE MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[proc_NhanVien_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_NhanVien_Insert]
@MaNV varchar(10),
@TenNV nvarchar(50),
@CMND varchar(20),
@Ngaycap datetime =null,
@Tinhthanh nvarchar(50)=null,
@Ngaysinh datetime=null,
@Gioitinh nvarchar(10)=null,
@Nguyenquan nvarchar(50)=null,
@Dctamtru nvarchar(50)=null,
@Email nvarchar(50) =null,
@SDTrieng varchar(15) =null,
@SDTnha varchar(15) =null,
@Tinhtranghonnhan nvarchar(50) =null,
@Tinhtranglamviec nvarchar(50)=null,
@Maphongban varchar(10) =null,
--@Mato varchar(10) =null,
@Machucvu varchar(10) =null,
@Ngayvaolam datetime =null,
@Thamnien int =null,
@Heso float =null,
@Matinhoc varchar(10),
@Mangoaingu varchar(10),
@Mabangcap varchar(10),
@SoBHXH varchar(20) =null,
@SoBHYT varchar(20)=null,
@Cannang nvarchar(50) =null,
@Cao nvarchar(50) =null,
@Nhommau nchar(10)=null,
@Tinhtrangsuckhoe nvarchar(50) =null,
@TaikhoanNH varchar(20)=null,
@Madantoc varchar(10),
@Matongiao varchar(10)
as
insert into tblNhanvien (MaNV,TenNV,CMND,Ngaycap,Tinhthanh,Ngaysinh,Gioitinh,
	Nguyenquan,Dctamtru,Email,SDTrieng,SDTnha,Tinhtranghonnhan,Tinhtranglamviec,
	Maphongban,Machucvu,Ngayvaolam,Thamnien,Heso,Matinhoc,Mangoaingu,Mabangcap,
	SoBHXH,SoBHYT,Cannang,Cao,Nhommau,Tinhtrangsuckhoe,TaikhoanNH,Madantoc,Matongiao)
values(@MaNV,@TenNV,@CMND,@Ngaycap,@Tinhthanh,@Ngaysinh,@Gioitinh,@Nguyenquan,@Dctamtru,
	@Email,@SDTrieng,@SDTnha,@Tinhtranghonnhan,@Tinhtranglamviec,@Maphongban,
	@Machucvu,@Ngayvaolam,@Thamnien,@Heso,@Matinhoc,@Mangoaingu,@Mabangcap,@SoBHXH,
	@SoBHYT,@Cannang,@Cao,@Nhommau,@Tinhtrangsuckhoe,@TaikhoanNH,@Madantoc,@Matongiao)



GO
/****** Object:  StoredProcedure [dbo].[proc_NhanVien_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_NhanVien_Update]
@MaNV varchar(10),
@TenNV nvarchar(50),
@CMND varchar(20),
@Ngaycap datetime =null,
@Tinhthanh nvarchar(50)=null,
@Ngaysinh datetime=null,
@Gioitinh nvarchar(10)=null,
@Nguyenquan nvarchar(50)=null,
@Dctamtru nvarchar(50)=null,
@Email nvarchar(50) =null,
@SDTrieng varchar(15) =null,
@SDTnha varchar(15) =null,
@Tinhtranghonnhan nvarchar(50) =null,
@Tinhtranglamviec nvarchar(50)=null,
@Maphongban varchar(10) =null,
--@Mato varchar(10) =null,
@Machucvu varchar(10) =null,
@Ngayvaolam datetime =null,
@Thamnien int =null,
@Heso float =null,
@Matinhoc varchar(10),
@Mangoaingu varchar(10),
@Mabangcap varchar(10),
@SoBHXH varchar(20) =null,
@SoBHYT varchar(20)=null,
@Cannang nvarchar(50) =null,
@Cao nvarchar(50) =null,
@Nhommau nvarchar(10)=null,
@Tinhtrangsuckhoe nvarchar(50) =null,
@TaikhoanNH varchar(20)=null,
@Madantoc varchar(10),
@Matongiao varchar(10)
as
update tblNhanvien set TenNV=@TenNV,CMND=@CMND,Ngaycap=@Ngaycap,Tinhthanh=@Tinhthanh,Ngaysinh=@Ngaysinh,Gioitinh=@Gioitinh,
	Nguyenquan=@Nguyenquan,Dctamtru=@Dctamtru,Email=@Email,SDTrieng=@SDTrieng,SDTnha=@SDTnha,Tinhtranghonnhan=@Tinhtranghonnhan,Tinhtranglamviec=@Tinhtranglamviec,
	Maphongban=@Maphongban,Machucvu=@Machucvu,Ngayvaolam=@Ngayvaolam,Thamnien=@Thamnien,Heso=@Heso,Matinhoc=@Matinhoc,Mangoaingu=@Mangoaingu,Mabangcap=@Mabangcap,
	SoBHXH=@SoBHXH,SoBHYT=@SoBHYT,Cannang=@Cannang,Cao=@Cao,Nhommau=@Nhommau,Tinhtrangsuckhoe=@Tinhtrangsuckhoe,TaikhoanNH=@TaikhoanNH,Madantoc=@Madantoc,Matongiao=@Matongiao
where MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[proc_Phongban_BC]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[proc_Phongban_BC]
AS
SELECT Maphongban,Tenphongban,MaNV
FROM tblPhongban
GO
/****** Object:  StoredProcedure [dbo].[proc_Phongban_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Phongban_Delete]
	@Maphongban varchar(10)
AS
DELETE tblPhongban
WHERE  Maphongban=@Maphongban
GO
/****** Object:  StoredProcedure [dbo].[proc_Phongban_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Phongban_Insert]
	@Maphongban varchar(10),
@Tenphongban nvarchar(50)=null,
@Ghichu nvarchar(50)=null,
@Email nvarchar(50)=null
AS
INSERT INTO tblPhongban(Maphongban,Tenphongban,Ghichu,Email)
VALUES (@Maphongban,@Tenphongban,@Ghichu,@Email)
GO
/****** Object:  StoredProcedure [dbo].[proc_Phongban_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Phongban_Update]
	@Maphongban varchar(10),
@Tenphongban nvarchar(50)=null,
@Ghichu nvarchar(50)=null,
@Email nvarchar(50)=null
AS
UPDATE tblPhongban SET Tenphongban=@Tenphongban,Ghichu=@Ghichu,Email=@Email
WHERE Maphongban=@Maphongban
GO
/****** Object:  StoredProcedure [dbo].[proc_Taikhoan_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Taikhoan_Delete]
	@Usename varchar(10)
AS
DELETE tblNguoidung 
WHERE  Usename=@Usename

GO
/****** Object:  StoredProcedure [dbo].[proc_Taikhoan_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Taikhoan_Insert]
	@Usename varchar(10),
@Pass varchar(20)=null,
@Email nvarchar(50)=null

AS
INSERT INTO tblNguoidung(Usename,Pass,Email)
VALUES (@Usename,@Pass,@Email)
GO
/****** Object:  StoredProcedure [dbo].[proc_Taikhoan_PQ_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Taikhoan_PQ_Update]
	@Usename varchar(10),
@Pass varchar(20)=null,
@Chophepthaotac nvarchar(20)=null,
@Email nvarchar(50)=null,
@Phone int=null

AS
UPDATE tblNguoidung SET Pass=@Pass,Chophepthaotac=@Chophepthaotac,Email=@Email,Phone=@Phone
WHERE Usename=@Usename
GO
/****** Object:  StoredProcedure [dbo].[proc_Taikhoan_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Taikhoan_Update]
	@Usename varchar(10),
@Pass varchar(20)=null,
@Chophepthaotac nvarchar(20)=null,
@Email nvarchar(50)=null,
@Phone int=null

AS
UPDATE tblNguoidung SET Pass=@Pass,Chophepthaotac=@Chophepthaotac,Email=@Email,Phone=@Phone
WHERE Usename=@Usename
GO
/****** Object:  StoredProcedure [dbo].[proc_ThanNhan_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ThanNhan_Delete]
	@Mathannhan varchar(10)
	
AS
DELETE tblThannhan 
WHERE  Mathannhan=@Mathannhan 

GO
/****** Object:  StoredProcedure [dbo].[proc_ThanNhan_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ThanNhan_Insert]
	@Mathannhan varchar(10),
@Tenthannhan nvarchar(50)=null,
@MaNV varchar(10),
@Quanhe nvarchar(50)=null,
@Diachi nvarchar(max)=null,
@Ghichu nvarchar(max)=null

AS
INSERT INTO tblThannhan (Mathannhan,Tenthannhan,MaNV,Quanhe,Diachi,Ghichu)
VALUES (@Mathannhan,@Tenthannhan,@MaNV,@Quanhe,@Diachi,@Ghichu)
GO
/****** Object:  StoredProcedure [dbo].[proc_ThanNhan_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ThanNhan_Update]
	@Mathannhan varchar(10),
@Tenthannhan nvarchar(50)=null,
@MaNV varchar(10),
@Quanhe nvarchar(50)=null,
@Diachi nvarchar(max)=null,
@Ghichu nvarchar(max)=null

AS
UPDATE tblThannhan SET Tenthannhan=@Tenthannhan,MaNV=@MaNV,Quanhe=@Quanhe,Diachi=@Diachi,Ghichu=@Ghichu
WHERE Mathannhan=@Mathannhan

GO
/****** Object:  StoredProcedure [dbo].[proc_Tinhoc_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Tinhoc_Delete]
	@Matinhoc varchar(10)
AS
DELETE tblTinhoc 
WHERE  Matinhoc=@Matinhoc
GO
/****** Object:  StoredProcedure [dbo].[proc_Tinhoc_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Tinhoc_Insert]
	@Matinhoc varchar(10),
@Tentinhoc nvarchar(50)=null
AS
INSERT INTO tblTinhoc(Matinhoc,Tentinhoc)
VALUES (@Matinhoc,@Tentinhoc)

GO
/****** Object:  StoredProcedure [dbo].[proc_Tinhoc_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Tinhoc_Update]
	@Matinhoc varchar(10),
@Tentinhoc nvarchar(50)=null
AS 
UPDATE tbltinhoc SET Tentinhoc=@Tentinhoc
WHERE Matinhoc=@Matinhoc
GO
/****** Object:  StoredProcedure [dbo].[proc_Tolamviec_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Tolamviec_Delete]
	@Mato varchar(10)
AS
DELETE tblTolamviec
WHERE  Mato=@Mato
GO
/****** Object:  StoredProcedure [dbo].[proc_Tolamviec_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Tolamviec_Insert]
	@Mato varchar(10),
@Tento nvarchar(50)=null,
@Ghichu nvarchar(50)=null,
@Maphongban varchar(10)

AS
INSERT INTO tblTolamviec(Mato,Tento,Ghichu,Maphongban)
VALUES (@Mato,@Tento,@Ghichu,@Maphongban)
GO
/****** Object:  StoredProcedure [dbo].[proc_Tolamviec_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Tolamviec_Update]
	@Mato varchar(10),
@Tento nvarchar(50)=null,
@Ghichu nvarchar(50)=null,
@Maphongban varchar(10)

AS
UPDATE tblTolamviec SET Tento=@Tento,Ghichu=@Ghichu,Maphongban=@Maphongban
WHERE Mato=@Mato
GO
/****** Object:  StoredProcedure [dbo].[proc_Tongiao_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Tongiao_Delete]
	@Matongiao varchar(10)
AS
DELETE tblTongiao 
WHERE  Matongiao=@Matongiao
GO
/****** Object:  StoredProcedure [dbo].[proc_Tongiao_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Tongiao_Insert]
	@Matongiao varchar(10),
@Tentongiao nvarchar(50)=null
AS
INSERT INTO tblTongiao(Matongiao,Tentongiao)
VALUES (@Matongiao,@Tentongiao)

GO
/****** Object:  StoredProcedure [dbo].[proc_Tongiao_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Tongiao_Update]
	@Matongiao varchar(10),
@Tentongiao nvarchar(50)=null
AS 
UPDATE tblTongiao SET Tentongiao=@Tentongiao
WHERE Matongiao=@Matongiao
GO
/****** Object:  StoredProcedure [dbo].[proc_UngVien_Delete]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_UngVien_Delete]
	@Maungvien varchar(10)
AS
DELETE tblUngvien 
WHERE  Maungvien=@Maungvien

GO
/****** Object:  StoredProcedure [dbo].[proc_UngVien_Insert]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_UngVien_Insert]
	@Maungvien varchar(10),
@Tenungvien nvarchar(50)=null,
@CMND varchar(20)=null,
@Ngaycap datetime =null,
@Tinhthanh nvarchar(50)=null,
@Ngaysinh datetime=null,
@Gioitinh nvarchar(10)=null,
@Diachi nvarchar(max)=null,
@Email nvarchar(max) =null,
@SDTrieng varchar(20) =null,
@SDTnha varchar(20) =null,
@Tinhtranghonnhan nvarchar(50) =null,
@Mabangcap varchar(10) =null,
@Mangoaingu varchar(10) =null,
@Matinhoc varchar(10) =null,
@Namkinhnghiem int =null,
@Ngaynophoso datetime =null,
@Trangthai nvarchar(20) =null,
@Madotphongvan varchar(10),
@Madantoc varchar(10)=null,
@Matongiao varchar(10)=null
AS
INSERT INTO tblUngvien (Maungvien,Tenungvien,CMND,Ngaycap,Tinhthanh,Ngaysinh,Gioitinh,
	Diachi,Email,SDTrieng,SDTnha,Tinhtranghonnhan,Mabangcap,Mangoaingu,Matinhoc,Namkinhnghiem,Ngaynophoso,Trangthai,Madotphongvan,Madantoc,Matongiao)
VALUES (@Maungvien,@Tenungvien,@CMND,@Ngaycap,@Tinhthanh,@Ngaysinh,@Gioitinh,@Diachi,@Email,@SDTrieng,
    @SDTnha,@Tinhtranghonnhan,@Mabangcap,@Mangoaingu,@Matinhoc,@Namkinhnghiem,@Ngaynophoso,@Trangthai,@Madotphongvan,@Madantoc,@Matongiao)
	
GO
/****** Object:  StoredProcedure [dbo].[proc_UngVien_Update]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_UngVien_Update]
	@Maungvien varchar(10),
@Tenungvien nvarchar(50)=null,
@CMND varchar(20)=null,
@Ngaycap datetime =null,
@Tinhthanh nvarchar(50)=null,
@Ngaysinh datetime=null,
@Gioitinh nvarchar(10)=null,
@Diachi nvarchar(max)=null,
@Email nvarchar(max) =null,
@SDTrieng varchar(20) =null,
@SDTnha varchar(20) =null,
@Tinhtranghonnhan nvarchar(50) =null,
@Mabangcap varchar(10) =null,
@Mangoaingu varchar(10) =null,
@Matinhoc varchar(10) =null,
@Namkinhnghiem int =null,
@Ngaynophoso datetime =null,
@Trangthai nvarchar(20) =null,
@Madotphongvan varchar(10),
@Madantoc varchar(10)=null,
@Matongiao varchar(10)=null


AS
UPDATE tblUngvien SET Tenungvien=@Tenungvien,CMND=@CMND,Ngaycap=@Ngaycap,Tinhthanh=@Tinhthanh,Ngaysinh=@Ngaysinh,Gioitinh=@Gioitinh,
	Diachi=@Diachi,Email=@Email,SDTrieng=@SDTrieng,SDTnha=@SDTnha,Tinhtranghonnhan=@Tinhtranghonnhan,Mabangcap=@Mabangcap,Mangoaingu=@Mangoaingu,Matinhoc=@Matinhoc,Namkinhnghiem=@Namkinhnghiem,Ngaynophoso=@Ngaynophoso,Trangthai=@Trangthai,Madotphongvan=@Madotphongvan,Madantoc=@Madantoc,Matongiao=@Matongiao
WHERE Maungvien=@Maungvien
	
GO
/****** Object:  StoredProcedure [dbo].[report_bangcap]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[report_bangcap]
AS
	SET NOCOUNT ON;
SELECT     tblBangcap.*
FROM         tblBangcap
GO
/****** Object:  StoredProcedure [dbo].[select_BC_Chamcongthangnam]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[select_BC_Chamcongthangnam]
@thang INT,
@nam INT
AS
SELECT tblBangchamcong.Machamcong,tblBangchamcong.Thangchamcong,tblBangchamcong.MaNV,tblNhanvien.TenNV,tblBangchamcong.Tongsongay,tblBangchamcong.Ngaydilam,tblBangchamcong.Ngayvang,tblPhongban.Tenphongban,tblBangchamcong.Ngay1,
tblBangchamcong.Ngay2,tblBangchamcong.Ngay3,tblBangchamcong.Ngay4,tblBangchamcong.Ngay5,tblBangchamcong.Ngay6,tblBangchamcong.Ngay7,tblBangchamcong.Ngay8,tblBangchamcong.Ngay9,tblBangchamcong.Ngay10,tblBangchamcong.Ngay11,
tblBangchamcong.Ngay12,tblBangchamcong.Ngay13,tblBangchamcong.Ngay14,tblBangchamcong.Ngay15,tblBangchamcong.Ngay16,tblBangchamcong.Ngay17,tblBangchamcong.Ngay18,tblBangchamcong.Ngay19,tblBangchamcong.Ngay20,tblBangchamcong.Ngay21,tblBangchamcong.Ngay22,
tblBangchamcong.Ngay23,tblBangchamcong.Ngay24,tblBangchamcong.Ngay25,tblBangchamcong.Ngay26,tblBangchamcong.Ngay27,tblBangchamcong.Ngay28,tblBangchamcong.Ngay29,tblBangchamcong.Ngay30,tblBangchamcong.Ngay31
FROM tblBangchamcong,tblNhanvien,tblPhongban
WHERE MONTH(tblBangchamcong.Thangchamcong)= @thang AND  YEAR(tblBangchamcong.Thangchamcong)=@nam
and tblBangchamcong.MaNV=tblNhanvien.MaNV and tblPhongban.Maphongban=tblNhanvien.Maphongban





GO
/****** Object:  StoredProcedure [dbo].[Select_BC_Chamcongtheophong]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Select_BC_Chamcongtheophong]
@maphong varchar(10)
AS
SELECT tblBangchamcong.Machamcong,tblBangchamcong.Thangchamcong,tblBangchamcong.MaNV,tblNhanvien.TenNV,tblBangchamcong.Tongsongay,tblBangchamcong.Ngaydilam,tblBangchamcong.Ngayvang,tblPhongban.Tenphongban,tblBangchamcong.Ngay1,
tblBangchamcong.Ngay2,tblBangchamcong.Ngay3,tblBangchamcong.Ngay4,tblBangchamcong.Ngay5,tblBangchamcong.Ngay6,tblBangchamcong.Ngay7,tblBangchamcong.Ngay8,tblBangchamcong.Ngay9,tblBangchamcong.Ngay10,tblBangchamcong.Ngay11,
tblBangchamcong.Ngay12,tblBangchamcong.Ngay13,tblBangchamcong.Ngay14,tblBangchamcong.Ngay15,tblBangchamcong.Ngay16,tblBangchamcong.Ngay17,tblBangchamcong.Ngay18,tblBangchamcong.Ngay19,tblBangchamcong.Ngay20,tblBangchamcong.Ngay21,tblBangchamcong.Ngay22,
tblBangchamcong.Ngay23,tblBangchamcong.Ngay24,tblBangchamcong.Ngay25,tblBangchamcong.Ngay26,tblBangchamcong.Ngay27,tblBangchamcong.Ngay28,tblBangchamcong.Ngay29,tblBangchamcong.Ngay30,tblBangchamcong.Ngay31
FROM tblBangchamcong,tblNhanvien,tblPhongban
WHERE (tblPhongban.Maphongban)=@maphong
and tblBangchamcong.MaNV=tblNhanvien.MaNV and tblPhongban.Maphongban=tblNhanvien.Maphongban






GO
/****** Object:  StoredProcedure [dbo].[Select_BC_Chiluongtheophong]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Select_BC_Chiluongtheophong]
@maphong varchar(10)
AS
SELECT tblBangchiluong.Maluong,tblBangchiluong.Thangchi,tblNhanvien.TenNV,tblBangchiluong.Ngaylamviec,tblBangchiluong.Luongthang,tblBangchiluong.Truluong,tblBangchiluong.PhucapCV,tblBangchiluong.Tongluong,tblBangchiluong.BHXH,tblBangchiluong.BHYT,tblBangchiluong.Doanphi,tblBangchiluong.Thuclinh,tblPhongban.Tenphongban,
tblBangchiluong.Phucapdochai,tblBangchiluong.Trocaptrachnhiem,tblBangchiluong.Trocapantrua,tblBangchiluong.Trocapxanha,tblBangchiluong.TrocapQLDN
FROM tblBangchiluong,tblNhanvien,tblPhongban
WHERE tblPhongban.Maphongban=@maphong and tblBangchiluong.MaNV=tblNhanvien.MaNV and tblNhanvien.Maphongban=tblPhongban.Maphongban





GO
/****** Object:  StoredProcedure [dbo].[Select_BC_Chiluongtheothang]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Select_BC_Chiluongtheothang]
@thang INT,
@nam INT
AS
SELECT tblBangchiluong.Maluong,tblBangchiluong.Thangchi,tblNhanvien.TenNV,tblBangchiluong.Ngaylamviec,tblBangchiluong.Luongthang,tblBangchiluong.Truluong,tblBangchiluong.PhucapCV,tblBangchiluong.Tongluong,tblBangchiluong.BHXH,tblBangchiluong.BHYT,tblBangchiluong.Doanphi,tblBangchiluong.Thuclinh,tblPhongban.Tenphongban,
tblBangchiluong.Phucapdochai,tblBangchiluong.Trocaptrachnhiem,tblBangchiluong.Trocapantrua,tblBangchiluong.Trocapxanha,tblBangchiluong.TrocapQLDN

FROM tblBangchiluong,tblNhanvien,tblPhongban
WHERE MONTH(Thangchi)= @thang AND  YEAR(Thangchi)=@nam and tblBangchiluong.MaNV=tblNhanvien.MaNV and tblNhanvien.Maphongban=tblPhongban.Maphongban



GO
/****** Object:  StoredProcedure [dbo].[Select_BC1]    Script Date: 1/2/2019 8:09:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Select_BC1]
@maphong varchar(10)
AS
SELECT tblBangchamcong.Machamcong,tblBangchamcong.Thangchamcong,tblBangchamcong.MaNV,tblNhanvien.TenNV,tblBangchamcong.Tongsongay,tblBangchamcong.Ngaydilam,tblBangchamcong.Ngayvang,tblPhongban.Tenphongban
FROM tblBangchamcong,tblNhanvien,tblPhongban
WHERE (tblPhongban.Maphongban)=@maphong
and tblBangchamcong.MaNV=tblNhanvien.MaNV and tblPhongban.Maphongban=tblNhanvien.Maphongban

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblNhanvien"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 207
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblChucvu"
            Begin Extent = 
               Top = 6
               Left = 245
               Bottom = 121
               Right = 397
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblBangchiluong"
            Begin Extent = 
               Top = 6
               Left = 435
               Bottom = 121
               Right = 602
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 17
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'BC_chiluong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'BC_chiluong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblBangchamcong"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 122
               Right = 195
            End
            DisplayFlags = 280
            TopColumn = 33
         End
         Begin Table = "tblNhanvien"
            Begin Extent = 
               Top = 6
               Left = 425
               Bottom = 121
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblPhongban"
            Begin Extent = 
               Top = 6
               Left = 235
               Bottom = 106
               Right = 387
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_BC_chamcong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_BC_chamcong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblBangchiluong"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 205
            End
            DisplayFlags = 280
            TopColumn = 13
         End
         Begin Table = "tblNhanvien"
            Begin Extent = 
               Top = 6
               Left = 243
               Bottom = 121
               Right = 412
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblPhongban"
            Begin Extent = 
               Top = 6
               Left = 450
               Bottom = 106
               Right = 602
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_BC_Chiluongtheophong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_BC_Chiluongtheophong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblNhanvien"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 207
            End
            DisplayFlags = 280
            TopColumn = 14
         End
         Begin Table = "tblBangchamcong"
            Begin Extent = 
               Top = 6
               Left = 245
               Bottom = 121
               Right = 404
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Chamcongchucvu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Chamcongchucvu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblNhanvien"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 207
            End
            DisplayFlags = 280
            TopColumn = 17
         End
         Begin Table = "tblBangchiluong"
            Begin Extent = 
               Top = 6
               Left = 245
               Bottom = 121
               Right = 412
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Chiluongtheochucvu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Chiluongtheochucvu'
GO
USE [master]
GO
ALTER DATABASE [Quanlynhansu] SET  READ_WRITE 
GO

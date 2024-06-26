USE [NpnK22CNT3Lesson09Db]
GO
/****** Object:  Table [dbo].[npnKhoa]    Script Date: 6/26/2024 9:08:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[npnKhoa](
	[NpnMaKH] [nchar](10) NOT NULL,
	[NpnTenKH] [nchar](50) NULL,
	[NpnTrangThai] [bit] NULL,
 CONSTRAINT [PK_npnKhoa] PRIMARY KEY CLUSTERED 
(
	[NpnMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[npnSinhVien]    Script Date: 6/26/2024 9:08:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[npnSinhVien](
	[NpnMaSV] [nvarchar](50) NULL,
	[NpnHoSV] [nvarchar](50) NULL,
	[NpnTenSV] [nvarchar](50) NULL,
	[NpnNgaySinh] [date] NULL,
	[NpnPhai] [bit] NULL,
	[NpnPhone] [nchar](10) NULL,
	[NpnEmail] [nvarchar](50) NULL,
	[NpnMaKH] [nchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[npnKhoa] ([NpnMaKH], [NpnTenKH], [NpnTrangThai]) VALUES (N'K22CNT3   ', N'K22CNT3                                           ', 1)
GO
INSERT [dbo].[npnSinhVien] ([NpnMaSV], [NpnHoSV], [NpnTenSV], [NpnNgaySinh], [NpnPhai], [NpnPhone], [NpnEmail], [NpnMaKH]) VALUES (N'2210900047', N'Nguyễn Phú ', N'Nam', CAST(N'2004-07-26' AS Date), 1, N'0902069171', N'nambkvn2004@gmail.com', N'K22CNT3   ')
GO

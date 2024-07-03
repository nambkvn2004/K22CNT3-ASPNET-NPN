USE [NpnK22CNT3Lesson10]
GO
/****** Object:  Table [dbo].[NpnAccount]    Script Date: 7/3/2024 9:09:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NpnAccount](
	[NpnID] [nvarchar](50) NOT NULL,
	[NpnUserName] [nvarchar](50) NULL,
	[NpnPassword] [nvarchar](50) NULL,
	[NpnFullName] [nvarchar](50) NULL,
	[NpnEmail] [nvarchar](50) NULL,
	[NpnActive] [bit] NULL,
 CONSTRAINT [PK_NpnAccount] PRIMARY KEY CLUSTERED 
(
	[NpnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NpnAccount] ([NpnID], [NpnUserName], [NpnPassword], [NpnFullName], [NpnEmail], [NpnActive]) VALUES (N'2210900047', N'nambk', N'nambkvn', N'Nguyễn Phú Nam', N'nambkvn2004@gmail.com', 1)
GO

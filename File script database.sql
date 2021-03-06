USE [master]
GO
/****** Object:  Database [User Accounts]    Script Date: 05/23/2019 12:11:57 ******/
CREATE DATABASE [User Accounts] ON  PRIMARY 
( NAME = N'User Accounts', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\User Accounts.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'User Accounts_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\User Accounts_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 COLLATE SQL_Latin1_General_CP1_CI_AS
GO
ALTER DATABASE [User Accounts] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [User Accounts].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [User Accounts] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [User Accounts] SET ANSI_NULLS OFF
GO
ALTER DATABASE [User Accounts] SET ANSI_PADDING OFF
GO
ALTER DATABASE [User Accounts] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [User Accounts] SET ARITHABORT OFF
GO
ALTER DATABASE [User Accounts] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [User Accounts] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [User Accounts] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [User Accounts] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [User Accounts] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [User Accounts] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [User Accounts] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [User Accounts] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [User Accounts] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [User Accounts] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [User Accounts] SET  DISABLE_BROKER
GO
ALTER DATABASE [User Accounts] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [User Accounts] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [User Accounts] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [User Accounts] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [User Accounts] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [User Accounts] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [User Accounts] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [User Accounts] SET  READ_WRITE
GO
ALTER DATABASE [User Accounts] SET RECOVERY SIMPLE
GO
ALTER DATABASE [User Accounts] SET  MULTI_USER
GO
ALTER DATABASE [User Accounts] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [User Accounts] SET DB_CHAINING OFF
GO
USE [User Accounts]
GO
/****** Object:  Table [dbo].[Student_List]    Script Date: 05/23/2019 12:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student_List](
	[Username] [varchar](20) COLLATE SQL_Latin1_General_CP1_CS_AS NOT NULL,
	[Password] [varchar](50) COLLATE SQL_Latin1_General_CP1_CS_AS NOT NULL,
 CONSTRAINT [PK_Login_Data] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Student_List] ([Username], [Password]) VALUES (N'admin', N'')
INSERT [dbo].[Student_List] ([Username], [Password]) VALUES (N'chath', N'')
INSERT [dbo].[Student_List] ([Username], [Password]) VALUES (N'Fields', N'0000')
INSERT [dbo].[Student_List] ([Username], [Password]) VALUES (N'Nam', N'1234')
/****** Object:  Table [dbo].[Subject_List]    Script Date: 05/23/2019 12:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subject_List](
	[Subject Code] [varchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Subject Name] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Credits] [int] NOT NULL,
 CONSTRAINT [PK_Subject_List] PRIMARY KEY CLUSTERED 
(
	[Subject Code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Subject_List] ([Subject Code], [Subject Name], [Credits]) VALUES (N'10010101', N'Lập trình trên Windows', 3)
INSERT [dbo].[Subject_List] ([Subject Code], [Subject Name], [Credits]) VALUES (N'123112232', N'Phân tích hệ thống thông tin', 1)
INSERT [dbo].[Subject_List] ([Subject Code], [Subject Name], [Credits]) VALUES (N'182101003403', N'Đại số và số học', 3)
INSERT [dbo].[Subject_List] ([Subject Code], [Subject Name], [Credits]) VALUES (N'182105001603', N'Hệ quản trị cơ sở dữ liệu', 3)
INSERT [dbo].[Subject_List] ([Subject Code], [Subject Name], [Credits]) VALUES (N'182105007503', N'Toán rời rạc', 3)
INSERT [dbo].[Subject_List] ([Subject Code], [Subject Name], [Credits]) VALUES (N'182105013303', N'Lập trình cơ bản', 4)
INSERT [dbo].[Subject_List] ([Subject Code], [Subject Name], [Credits]) VALUES (N'182109016636', N'Tiếng Anh', 3)
INSERT [dbo].[Subject_List] ([Subject Code], [Subject Name], [Credits]) VALUES (N'182112000225', N'Giáo dục thể chất 1', 3)
INSERT [dbo].[Subject_List] ([Subject Code], [Subject Name], [Credits]) VALUES (N'182112009503', N'Giáo dục Quốc phòng - An ninh 1', 2)
INSERT [dbo].[Subject_List] ([Subject Code], [Subject Name], [Credits]) VALUES (N'182112009603', N'Giáo dục Quốc phòng - An ninh 2', 1)
INSERT [dbo].[Subject_List] ([Subject Code], [Subject Name], [Credits]) VALUES (N'182112009701', N'Giáo dục Quốc phòng - An ninh 3', 1)
INSERT [dbo].[Subject_List] ([Subject Code], [Subject Name], [Credits]) VALUES (N'182113004609', N'Những NLCB của chủ nghĩa Mác-Lênin 2', 3)
INSERT [dbo].[Subject_List] ([Subject Code], [Subject Name], [Credits]) VALUES (N'323443332', N'Tính toán số lớn', 2)
/****** Object:  Table [dbo].[Student_Subject]    Script Date: 05/23/2019 12:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student_Subject](
	[Username] [varchar](20) COLLATE SQL_Latin1_General_CP1_CS_AS NOT NULL,
	[Subject Code] [varchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Lecturer] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Start Date] [date] NOT NULL,
	[End Date] [date] NOT NULL,
	[Information] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_Student_Subject] PRIMARY KEY CLUSTERED 
(
	[Username] ASC,
	[Subject Code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Student_Subject] ([Username], [Subject Code], [Lecturer], [Start Date], [End Date], [Information]) VALUES (N'admin', N'123112232', N'Đào Duy Từ', CAST(0x07240B00 AS Date), CAST(0x0B240B00 AS Date), N'')
INSERT [dbo].[Student_Subject] ([Username], [Subject Code], [Lecturer], [Start Date], [End Date], [Information]) VALUES (N'admin', N'182101003403', N'Trương Đạt', CAST(0x75250B00 AS Date), CAST(0x53280B00 AS Date), N'')
INSERT [dbo].[Student_Subject] ([Username], [Subject Code], [Lecturer], [Start Date], [End Date], [Information]) VALUES (N'admin', N'182105001603', N'Khổng Minh', CAST(0x042E0B00 AS Date), CAST(0x0B240B00 AS Date), N'')
INSERT [dbo].[Student_Subject] ([Username], [Subject Code], [Lecturer], [Start Date], [End Date], [Information]) VALUES (N'admin', N'182105007503', N'Vũ Hạn Thoại', CAST(0x07240B00 AS Date), CAST(0x0B240B00 AS Date), N'')
INSERT [dbo].[Student_Subject] ([Username], [Subject Code], [Lecturer], [Start Date], [End Date], [Information]) VALUES (N'admin', N'182105013303', N'Trương Phi', CAST(0x07240B00 AS Date), CAST(0x0B240B00 AS Date), N'')
INSERT [dbo].[Student_Subject] ([Username], [Subject Code], [Lecturer], [Start Date], [End Date], [Information]) VALUES (N'admin', N'182109016636', N'Tật Bất Đạt', CAST(0x07240B00 AS Date), CAST(0x0B240B00 AS Date), N'')
INSERT [dbo].[Student_Subject] ([Username], [Subject Code], [Lecturer], [Start Date], [End Date], [Information]) VALUES (N'admin', N'182112000225', N'Đào Duy Từ', CAST(0x07240B00 AS Date), CAST(0x0B240B00 AS Date), N'')
INSERT [dbo].[Student_Subject] ([Username], [Subject Code], [Lecturer], [Start Date], [End Date], [Information]) VALUES (N'chath', N'182105001603', N'Khổng Minh', CAST(0x972C0B00 AS Date), CAST(0x0B240B00 AS Date), N'')
INSERT [dbo].[Student_Subject] ([Username], [Subject Code], [Lecturer], [Start Date], [End Date], [Information]) VALUES (N'chath', N'182109016636', N'Trương Ngữ', CAST(0x07240B00 AS Date), CAST(0x0B240B00 AS Date), N'Thứ 2, Tiết: 8-9, Tuần: T36, Phòng: A8.53
Thứ 2, Tiết: 8-10, Tuần: T20->T22, T26->T28, T30->T33, T35, Phòng: A8.53')
INSERT [dbo].[Student_Subject] ([Username], [Subject Code], [Lecturer], [Start Date], [End Date], [Information]) VALUES (N'chath', N'182112000225', N'Đào Duy Từ', CAST(0x07240B00 AS Date), CAST(0x0B240B00 AS Date), N'')
/****** Object:  ForeignKey [FK_Student_Subject_Login_Data]    Script Date: 05/23/2019 12:11:58 ******/
ALTER TABLE [dbo].[Student_Subject]  WITH CHECK ADD  CONSTRAINT [FK_Student_Subject_Login_Data] FOREIGN KEY([Username])
REFERENCES [dbo].[Student_List] ([Username])
GO
ALTER TABLE [dbo].[Student_Subject] CHECK CONSTRAINT [FK_Student_Subject_Login_Data]
GO
/****** Object:  ForeignKey [FK_Student_Subject_Subject_List]    Script Date: 05/23/2019 12:11:58 ******/
ALTER TABLE [dbo].[Student_Subject]  WITH CHECK ADD  CONSTRAINT [FK_Student_Subject_Subject_List] FOREIGN KEY([Subject Code])
REFERENCES [dbo].[Subject_List] ([Subject Code])
GO
ALTER TABLE [dbo].[Student_Subject] CHECK CONSTRAINT [FK_Student_Subject_Subject_List]
GO

USE [master]
GO
/****** Object:  Database [SDS_DATA]    Script Date: 21.06.2021 22:58:09 ******/
CREATE DATABASE [SDS_DATA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SDS_DATA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\SDS_DATA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SDS_DATA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\SDS_DATA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SDS_DATA] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SDS_DATA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SDS_DATA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SDS_DATA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SDS_DATA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SDS_DATA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SDS_DATA] SET ARITHABORT OFF 
GO
ALTER DATABASE [SDS_DATA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SDS_DATA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SDS_DATA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SDS_DATA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SDS_DATA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SDS_DATA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SDS_DATA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SDS_DATA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SDS_DATA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SDS_DATA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SDS_DATA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SDS_DATA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SDS_DATA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SDS_DATA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SDS_DATA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SDS_DATA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SDS_DATA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SDS_DATA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SDS_DATA] SET  MULTI_USER 
GO
ALTER DATABASE [SDS_DATA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SDS_DATA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SDS_DATA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SDS_DATA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SDS_DATA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SDS_DATA] SET QUERY_STORE = OFF
GO
USE [SDS_DATA]
GO
/****** Object:  Table [dbo].[data]    Script Date: 21.06.2021 22:58:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[data](
	[login] [nvarchar](50) NOT NULL,
	[date] [nvarchar](50) NOT NULL,
	[height] [nvarchar](50) NULL,
	[weight] [nvarchar](50) NULL,
	[chest_std] [nvarchar](50) NULL,
	[chest_in] [nvarchar](50) NULL,
	[chest_out] [nvarchar](50) NULL,
	[waist] [nvarchar](50) NULL,
	[hips] [nvarchar](50) NULL,
	[years] [nvarchar](50) NULL,
	[gender] [nvarchar](50) NULL,
	[smg] [nvarchar](10) NULL,
 CONSTRAINT [PK_data] PRIMARY KEY CLUSTERED 
(
	[login] ASC,
	[date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[data_additional]    Script Date: 21.06.2021 22:58:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[data_additional](
	[login] [nvarchar](50) NOT NULL,
	[date] [nvarchar](50) NOT NULL,
	[still_pulse] [nvarchar](50) NULL,
	[pulse_20squats] [nvarchar](50) NULL,
	[pulse_1min] [nvarchar](50) NULL,
	[pulse_2min] [nvarchar](50) NULL,
	[pulse_3min] [nvarchar](50) NULL,
	[step_pulse] [nvarchar](50) NULL,
	[step_pulse_2m] [nvarchar](50) NULL,
	[step_pulse_3m] [nvarchar](50) NULL,
	[stange] [nvarchar](50) NULL,
	[ghenci] [nvarchar](50) NULL,
	[kuper] [nvarchar](50) NULL,
 CONSTRAINT [PK_data_additional] PRIMARY KEY CLUSTERED 
(
	[login] ASC,
	[date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[masters]    Script Date: 21.06.2021 22:58:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[masters](
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](150) NULL,
	[email] [nvarchar](50) NULL,
	[phone] [nvarchar](50) NULL,
	[first_name] [nchar](10) NULL,
	[second_name] [nchar](10) NULL,
	[patronymic] [nchar](10) NULL,
 CONSTRAINT [PK_masters] PRIMARY KEY CLUSTERED 
(
	[login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[normes]    Script Date: 21.06.2021 22:58:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[normes](
	[login] [nvarchar](50) NOT NULL,
	[date] [nvarchar](50) NOT NULL,
	[run_100m] [nvarchar](50) NULL,
	[cross_run] [nvarchar](50) NULL,
	[pull_up] [nvarchar](50) NULL,
	[push_ups] [nvarchar](50) NULL,
	[press] [nvarchar](50) NULL,
	[forward_bend] [nvarchar](50) NULL,
	[jump] [nvarchar](50) NULL,
	[swimming] [nvarchar](50) NULL,
	[ski] [nvarchar](50) NULL,
	[kettlebell] [nvarchar](50) NULL,
 CONSTRAINT [PK_normes] PRIMARY KEY CLUSTERED 
(
	[login] ASC,
	[date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 21.06.2021 22:58:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](150) NULL,
	[email] [nvarchar](50) NULL,
	[master] [nvarchar](50) NULL,
	[first_name] [nvarchar](50) NULL,
	[last_name] [nvarchar](50) NULL,
	[patronymic] [nvarchar](50) NULL,
	[phone] [nvarchar](50) NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[data]  WITH CHECK ADD  CONSTRAINT [FK_data_users] FOREIGN KEY([login])
REFERENCES [dbo].[users] ([login])
GO
ALTER TABLE [dbo].[data] CHECK CONSTRAINT [FK_data_users]
GO
ALTER TABLE [dbo].[data_additional]  WITH CHECK ADD  CONSTRAINT [FK_data_additional_users] FOREIGN KEY([login])
REFERENCES [dbo].[users] ([login])
GO
ALTER TABLE [dbo].[data_additional] CHECK CONSTRAINT [FK_data_additional_users]
GO
ALTER TABLE [dbo].[normes]  WITH CHECK ADD  CONSTRAINT [FK_normes_users] FOREIGN KEY([login])
REFERENCES [dbo].[users] ([login])
GO
ALTER TABLE [dbo].[normes] CHECK CONSTRAINT [FK_normes_users]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_masters] FOREIGN KEY([master])
REFERENCES [dbo].[masters] ([login])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_masters]
GO
USE [master]
GO
ALTER DATABASE [SDS_DATA] SET  READ_WRITE 
GO

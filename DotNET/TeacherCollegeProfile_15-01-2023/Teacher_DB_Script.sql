USE [master]
GO
/****** Object:  Database [Teacher_DB]    Script Date: 1/15/2023 4:35:56 PM ******/
CREATE DATABASE [Teacher_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Teacher_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Teacher_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Teacher_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Teacher_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Teacher_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Teacher_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Teacher_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Teacher_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Teacher_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Teacher_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Teacher_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Teacher_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Teacher_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Teacher_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Teacher_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Teacher_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Teacher_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Teacher_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Teacher_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Teacher_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Teacher_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Teacher_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Teacher_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Teacher_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Teacher_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Teacher_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Teacher_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Teacher_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Teacher_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [Teacher_DB] SET  MULTI_USER 
GO
ALTER DATABASE [Teacher_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Teacher_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Teacher_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Teacher_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Teacher_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Teacher_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Teacher_DB', N'ON'
GO
ALTER DATABASE [Teacher_DB] SET QUERY_STORE = OFF
GO
USE [Teacher_DB]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 1/15/2023 4:35:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[MiddleName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[CNIC] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[ContactNo] [varchar](50) NULL,
	[Department] [varchar](50) NULL,
	[Designation] [varchar](50) NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Teacher_DB] SET  READ_WRITE 
GO

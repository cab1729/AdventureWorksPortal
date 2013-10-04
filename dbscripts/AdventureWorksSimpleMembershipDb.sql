USE [master]
GO

/****** Object:  Database [aspnet-AdventureWorksPortal]    Script Date: 09/05/2013 07:46:12 ******/
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'aspnet-AdventureWorksPortal')
DROP DATABASE [aspnet-AdventureWorksPortal]
GO

USE [master]
GO

/****** Object:  Database [aspnet-AdventureWorksPortal]    Script Date: 09/05/2013 07:46:12 ******/
CREATE DATABASE [aspnet-AdventureWorksPortal] ON  PRIMARY 
( NAME = N'aspnet-AdventureWorksPortal', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\aspnet-AdventureWorksPortal.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'aspnet-AdventureWorksPortal_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\aspnet-AdventureWorksPortal_log.LDF' , SIZE = 512KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [aspnet-AdventureWorksPortal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET ARITHABORT OFF 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET  ENABLE_BROKER 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET  READ_WRITE 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET  MULTI_USER 
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [aspnet-AdventureWorksPortal] SET DB_CHAINING OFF 
GO



USE [master]
GO

/****** Object:  Database [Employeeinfo]    Script Date: 21-08-2019 18:24:21 ******/
DROP DATABASE [Employeeinfo]
GO

/****** Object:  Database [Employeeinfo]    Script Date: 21-08-2019 18:24:21 ******/
CREATE DATABASE [Employeeinfo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Employeeinfo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\emp' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Employeeinfo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\Employeeinfo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Employeeinfo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Employeeinfo] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Employeeinfo] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Employeeinfo] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Employeeinfo] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Employeeinfo] SET ARITHABORT OFF 
GO

ALTER DATABASE [Employeeinfo] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Employeeinfo] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Employeeinfo] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Employeeinfo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Employeeinfo] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Employeeinfo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Employeeinfo] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Employeeinfo] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Employeeinfo] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Employeeinfo] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Employeeinfo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Employeeinfo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Employeeinfo] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Employeeinfo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Employeeinfo] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Employeeinfo] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Employeeinfo] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Employeeinfo] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Employeeinfo] SET  MULTI_USER 
GO

ALTER DATABASE [Employeeinfo] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Employeeinfo] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Employeeinfo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Employeeinfo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Employeeinfo] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Employeeinfo] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Employeeinfo] SET  READ_WRITE 
GO



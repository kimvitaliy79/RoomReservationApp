USE [master]
GO

/****** Object:  Database [RoomReservation]    Script Date: 12/05/19 6:57:50 AM ******/
CREATE DATABASE [RoomReservation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RoomReservation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL2014\MSSQL\DATA\RoomReservation.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RoomReservation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL2014\MSSQL\DATA\RoomReservation_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [RoomReservation] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RoomReservation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [RoomReservation] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [RoomReservation] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [RoomReservation] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [RoomReservation] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [RoomReservation] SET ARITHABORT OFF 
GO

ALTER DATABASE [RoomReservation] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [RoomReservation] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [RoomReservation] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [RoomReservation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [RoomReservation] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [RoomReservation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [RoomReservation] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [RoomReservation] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [RoomReservation] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [RoomReservation] SET  DISABLE_BROKER 
GO

ALTER DATABASE [RoomReservation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [RoomReservation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [RoomReservation] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [RoomReservation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [RoomReservation] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [RoomReservation] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [RoomReservation] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [RoomReservation] SET RECOVERY FULL 
GO

ALTER DATABASE [RoomReservation] SET  MULTI_USER 
GO

ALTER DATABASE [RoomReservation] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [RoomReservation] SET DB_CHAINING OFF 
GO

ALTER DATABASE [RoomReservation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [RoomReservation] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [RoomReservation] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [RoomReservation] SET  READ_WRITE 
GO



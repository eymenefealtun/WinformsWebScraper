USE [master]
GO

/****** Object:  Database [TracksineSpinHistory]    Script Date: 06/09/23 8:58:39 PM ******/
CREATE DATABASE [TracksineSpinHistory]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TracksineSpinHistory', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\TracksineSpinHistory.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TracksineSpinHistory_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\TracksineSpinHistory.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TracksineSpinHistory].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE TracksineSpinHistory SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE TracksineSpinHistory SET ANSI_NULLS OFF 
GO

ALTER DATABASE TracksineSpinHistory SET ANSI_PADDING OFF 
GO

ALTER DATABASE TracksineSpinHistory SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE TracksineSpinHistory SET ARITHABORT OFF 
GO

ALTER DATABASE TracksineSpinHistory SET AUTO_CLOSE OFF 
GO

ALTER DATABASE TracksineSpinHistory SET AUTO_SHRINK OFF 
GO

ALTER DATABASE TracksineSpinHistory SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE TracksineSpinHistory SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE TracksineSpinHistory SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE TracksineSpinHistory SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE TracksineSpinHistory SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE TracksineSpinHistory SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE TracksineSpinHistory SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE TracksineSpinHistory SET  DISABLE_BROKER 
GO

ALTER DATABASE TracksineSpinHistory SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE TracksineSpinHistory SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE TracksineSpinHistory SET TRUSTWORTHY OFF 
GO

ALTER DATABASE TracksineSpinHistory SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE TracksineSpinHistory SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE TracksineSpinHistory SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE TracksineSpinHistory SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE TracksineSpinHistory SET RECOVERY SIMPLE 
GO

ALTER DATABASE TracksineSpinHistory SET  MULTI_USER 
GO

ALTER DATABASE TracksineSpinHistory SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE TracksineSpinHistory SET DB_CHAINING OFF 
GO

ALTER DATABASE TracksineSpinHistory SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE TracksineSpinHistory SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE TracksineSpinHistory SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE TracksineSpinHistory SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE TracksineSpinHistory SET QUERY_STORE = ON
GO

ALTER DATABASE TracksineSpinHistory SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

ALTER DATABASE TracksineSpinHistory SET  READ_WRITE 
GO



USE [TracksineSpinHistory]
GO

/****** Object:  Table [dbo].[SlotResultImage]    Script Date: 06/09/23 9:05:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SlotResultImage](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[ImageText] [varchar](100) NOT NULL,
	[ImageCode] [varbinary](max) NULL,
 CONSTRAINT [PK_SlotResultImage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO



USE [TracksineSpinHistory]
GO

/****** Object:  Table [dbo].[SpinResultImage]    Script Date: 06/09/23 9:07:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SpinResultImage](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[ImageText] [varchar](100) NULL,
	[ImageCode] [varbinary](max) NULL,
 CONSTRAINT [PK_SlotResultResource] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO






USE [TracksineSpinHistory]
GO

/****** Object:  Table [dbo].[SpinHistory]    Script Date: 06/09/23 9:06:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SpinHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OccuredAt] [varchar](100) NOT NULL,
	[SlotResultImageId] [smallint] NOT NULL,
	[SlotResultText] [varchar](100) NOT NULL,
	[SpinResultId] [smallint] NOT NULL,
	[Multiplier] [varchar](100) NOT NULL,
	[TotalWinners] [int] NOT NULL,
	[TotalPayout] [varchar](100) NOT NULL,
 CONSTRAINT [PK_SpinHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SpinHistory]  WITH CHECK ADD  CONSTRAINT [FK_SpinHistory_SlotResultImage1] FOREIGN KEY([SlotResultImageId])
REFERENCES [dbo].[SlotResultImage] ([Id])
GO

ALTER TABLE [dbo].[SpinHistory] CHECK CONSTRAINT [FK_SpinHistory_SlotResultImage1]
GO

ALTER TABLE [dbo].[SpinHistory]  WITH CHECK ADD  CONSTRAINT [FK_SpinHistory_SpinResultImage1] FOREIGN KEY([SpinResultId])
REFERENCES [dbo].[SpinResultImage] ([Id])
GO

ALTER TABLE [dbo].[SpinHistory] CHECK CONSTRAINT [FK_SpinHistory_SpinResultImage1]
GO







INSERT INTO TracksineSpinHistory.[dbo].[SpinResultImage] (ImageCode, ImageText)
SELECT BulkColumn, '1' AS ImageText
FROM OPENROWSET(BULK 'yourpath\SpinResult\SpinResult1.PNG', SINGLE_BLOB) AS ImageCode;


INSERT INTO TracksineSpinHistory.[dbo].[SpinResultImage] (ImageCode, ImageText)
SELECT BulkColumn, '2' AS ImageText
FROM OPENROWSET(BULK 'yourpath\SpinResult\SpinResult2.PNG', SINGLE_BLOB) AS ImageCode;

INSERT INTO TracksineSpinHistory.[dbo].[SpinResultImage] (ImageCode, ImageText)
SELECT BulkColumn, '5' AS ImageText
FROM OPENROWSET(BULK 'yourpath\SpinResult\SpinResult5.PNG', SINGLE_BLOB) AS ImageCode;


INSERT INTO TracksineSpinHistory.[dbo].[SpinResultImage] (ImageCode, ImageText)
SELECT BulkColumn, '10' AS ImageText
FROM OPENROWSET(BULK 'yourpath\SpinResult\SpinResult10.PNG', SINGLE_BLOB) AS ImageCode;

INSERT INTO TracksineSpinHistory.[dbo].[SpinResultImage] (ImageCode, ImageText)
SELECT BulkColumn, 'Cash Hunt' AS ImageText
FROM OPENROWSET(BULK 'yourpath\SpinResult\SpinResultCashHunt.PNG', SINGLE_BLOB) AS ImageCode;

INSERT INTO TracksineSpinHistory.[dbo].[SpinResultImage] (ImageCode, ImageText)
SELECT BulkColumn, 'Coin Flip' AS ImageText
FROM OPENROWSET(BULK 'yourpath\SpinResult\SpinResultCoinFlip.PNG', SINGLE_BLOB) AS ImageCode;

INSERT INTO TracksineSpinHistory.[dbo].[SpinResultImage] (ImageCode, ImageText)
SELECT BulkColumn, 'Crazy Time' AS ImageText
FROM OPENROWSET(BULK 'yourpath\SpinResult\SpinResultCrazyTime.PNG', SINGLE_BLOB) AS ImageCode;

INSERT INTO TracksineSpinHistory.[dbo].[SpinResultImage] (ImageCode, ImageText)
SELECT BulkColumn, 'Pachinko' AS ImageText
FROM OPENROWSET(BULK 'yourpath\SpinResult\SpinResultPachinko.PNG', SINGLE_BLOB) AS ImageCode;








INSERT INTO TracksineSpinHistory.[dbo].[SlotResultImage] (ImageCode, ImageText)
SELECT BulkColumn, '1' AS ImageText
FROM OPENROWSET(BULK 'yourpath\SlotResult\SlotResult1.PNG', SINGLE_BLOB) AS ImageCode;


INSERT INTO TracksineSpinHistory.[dbo].[SlotResultImage] (ImageCode, ImageText)
SELECT BulkColumn, '2' AS ImageText
FROM OPENROWSET(BULK 'yourpath\SlotResult\SlotResult2.PNG', SINGLE_BLOB) AS ImageCode;

INSERT INTO TracksineSpinHistory.[dbo].[SlotResultImage] (ImageCode, ImageText)
SELECT BulkColumn, '5' AS ImageText
FROM OPENROWSET(BULK 'yourpath\SlotResult\SlotResult5.PNG', SINGLE_BLOB) AS ImageCode;


INSERT INTO TracksineSpinHistory.[dbo].[SlotResultImage] (ImageCode, ImageText)
SELECT BulkColumn, '10' AS ImageText
FROM OPENROWSET(BULK 'yourpath\SlotResult\SlotResult10.PNG', SINGLE_BLOB) AS ImageCode;

INSERT INTO TracksineSpinHistory.[dbo].[SlotResultImage] (ImageCode, ImageText)
SELECT BulkColumn, 'Cash Hunt' AS ImageText
FROM OPENROWSET(BULK 'yourpath\SlotResult\SlotResultCashHunt.PNG', SINGLE_BLOB) AS ImageCode;

INSERT INTO TracksineSpinHistory.[dbo].[SlotResultImage] (ImageCode, ImageText)
SELECT BulkColumn, 'Coin Flip' AS ImageText
FROM OPENROWSET(BULK 'yourpath\SlotResult\SlotResultCoinFlip.PNG', SINGLE_BLOB) AS ImageCode;

INSERT INTO TracksineSpinHistory.[dbo].[SlotResultImage] (ImageCode, ImageText)
SELECT BulkColumn, 'Crazy Time' AS ImageText
FROM OPENROWSET(BULK 'yourpath\SlotResult\SlotResultCrazyTime.PNG', SINGLE_BLOB) AS ImageCode;

INSERT INTO TracksineSpinHistory.[dbo].[SlotResultImage] (ImageCode, ImageText)
SELECT BulkColumn, 'Pachinko' AS ImageText
FROM OPENROWSET(BULK 'yourpath\SlotResult\SlotResultPachinko.PNG', SINGLE_BLOB) AS ImageCode;









# TracksinoWebScrapper
<p align="center">
  <img src="https://github.com/eymenefealtun/TracksinoWebScraper/blob/master/Resources/Tracksino_Web_Scraper_600_200.png?raw=true" alt="Sublime's custom image"/>
</p>

<p align="center">
    <a href="#backers" alt="Backers on Open Collective">
        <img src="https://img.shields.io/badge/MADE_WITH-CSharp-green?style=plastic" /></a>
         <a href="#backers" alt="Backers on Open Collective">
        <img src="https://img.shields.io/github/commit-activity/t/eymenefealtun/TracksinoWebScraper?style=plastic" /></a>
          <a href="#backers" alt="Backers on Open Collective">
        <img src="https://img.shields.io/github/downloads/eymenefealtun/TracksinoWebScraper/total?style=plastic" /></a>
        <a href="#backers" alt="Backers on Open Collective">
        <img src="https://img.shields.io/github/languages/code-size/eymenefealtun/TracksinoWebScraper?style=plastic" /></a>
                <a href="#backers" alt="Backers on Open Collective">
        <img src="https://img.shields.io/github/stars/eymenefealtun/TracksinoWebScraper?style=plastic" /></a>
                <a href="#backers" alt="Backers on Open Collective">
        <img src="https://img.shields.io/github/watchers/eymenefealtun/TracksinoWebScraper?style=plastic" /></a>
                <a href="#backers" alt="Backers on Open Collective">
        <img src="https://img.shields.io/github/forks/eymenefealtun/TracksinoWebScraper?style=plastic" /></a>

</p>

**Tracksino Web Scraper** is a web scraper built for the Spin History table of [tracksino.com/crazytime](https://tracksino.com/crazytime). It is written in [C#](https://learn.microsoft.com/en-us/dotnet/csharp/) and based on [WinForms](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/overview/?view=netdesktop-7.0).
![](https://github.com/eymenefealtun/TracksinoWebScraper/blob/master/Resources/TracksinpScrapingGif.gif)

## Technologies used
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- [Selenium Web Driver](https://www.nuget.org/packages/Selenium.WebDriver)

## How to use?
Use following T-SQL queries to create the database.

```js
USE [master]
GO

/****** Object:  Database [TracksineSpinHistory]    Script Date: 06/09/23 8:58:39 PM ******/
CREATE DATABASE [TracksineSpinHistory]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TracksineSpinHistory', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\TracksineSpinHistory.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TracksineSpinHistory_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\TracksineSpinHistory_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TracksineSpinHistory].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [TracksineSpinHistory] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET ARITHABORT OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [TracksineSpinHistory] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [TracksineSpinHistory] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET  DISABLE_BROKER 
GO

ALTER DATABASE [TracksineSpinHistory] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [TracksineSpinHistory] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [TracksineSpinHistory] SET  MULTI_USER 
GO

ALTER DATABASE [TracksineSpinHistory] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [TracksineSpinHistory] SET DB_CHAINING OFF 
GO

ALTER DATABASE [TracksineSpinHistory] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [TracksineSpinHistory] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [TracksineSpinHistory] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [TracksineSpinHistory] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [TracksineSpinHistory] SET QUERY_STORE = ON
GO

ALTER DATABASE [TracksineSpinHistory] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

ALTER DATABASE [TracksineSpinHistory] SET  READ_WRITE 
GO



```

## How to clone?
- `git clone https://github.com/eymenefealtun/TracksinoWebScraper.git`

## Created By: [@eymenefealtun](https://github.com/eymenefealtun)
* [Linkedin](https://www.linkedin.com/in/eymen-efe-altun-a1681821b)
* [Youtube](https://www.youtube.com/@eymenefealtunn/videos)
* [Fiverr](https://www.fiverr.com/eymenefealtun?public_mode=true)
* [Upwork](https://www.upwork.com/freelancers/~012eff1f3b2a153f38)
* [Buy me a coffee](https://www.buymeacoffee.com/altuneymenefe) 

## How to contribute?
 1. [Fork](https://github.com/eymenefealtun/TracksinoWebScraper/fork) the repository.
 2. Make changes.
 3. Submit a pull request.
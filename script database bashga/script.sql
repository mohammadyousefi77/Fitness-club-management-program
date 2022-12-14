USE [master]
GO
/****** Object:  Database [DbBashgah]    Script Date: 9/27/2022 1:08:37 PM ******/
CREATE DATABASE [DbBashgah]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbBashgah', FILENAME = N'E:\Gym\Datebase\DbBashgah.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DbBashgah_log', FILENAME = N'E:\Gym\Datebase\DbBashgah_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DbBashgah] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbBashgah].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbBashgah] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbBashgah] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbBashgah] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbBashgah] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbBashgah] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbBashgah] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbBashgah] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbBashgah] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbBashgah] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbBashgah] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbBashgah] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbBashgah] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbBashgah] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbBashgah] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbBashgah] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbBashgah] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbBashgah] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbBashgah] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbBashgah] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbBashgah] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbBashgah] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbBashgah] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbBashgah] SET RECOVERY FULL 
GO
ALTER DATABASE [DbBashgah] SET  MULTI_USER 
GO
ALTER DATABASE [DbBashgah] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbBashgah] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbBashgah] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbBashgah] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DbBashgah] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DbBashgah', N'ON'
GO
USE [DbBashgah]
GO
/****** Object:  Table [dbo].[frosh]    Script Date: 9/27/2022 1:08:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[frosh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OzveCode] [nvarchar](50) NOT NULL,
	[OzvName] [nvarchar](50) NOT NULL,
	[kalaname] [nvarchar](50) NOT NULL,
	[PriceKala] [nvarchar](50) NOT NULL,
	[tedadkala] [nvarchar](50) NOT NULL,
	[Datatarakonesh] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_frosh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tarakoneshTBl]    Script Date: 9/27/2022 1:08:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tarakoneshTBl](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Tarakoneshdate] [nvarchar](50) NOT NULL,
	[TarakoneshKind] [nvarchar](50) NOT NULL,
	[CustomerID] [nvarchar](50) NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[Price] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tarakoneshTBl] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TBkomod]    Script Date: 9/27/2022 1:08:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBkomod](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KomodNum] [nvarchar](50) NOT NULL,
	[State] [nvarchar](50) NOT NULL,
	[Customer] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TBkomod] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tblfrooshgah]    Script Date: 9/27/2022 1:08:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tblfrooshgah](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KalaName] [nvarchar](50) NOT NULL,
	[Price] [nvarchar](50) NOT NULL,
	[Mujodi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tblfrooshgah] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblUser]    Script Date: 9/27/2022 1:08:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblUser](
	[ID] [int] IDENTITY(1000,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[BirthDate] [nvarchar](50) NOT NULL,
	[OzviatDate] [nvarchar](50) NOT NULL,
	[EtebarDate] [nvarchar](50) NOT NULL,
	[Komod] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TblUser] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [DbBashgah] SET  READ_WRITE 
GO

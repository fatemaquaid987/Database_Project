USE [master]
GO
/****** Object:  Database [Gulzar-e-Rahim]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE DATABASE [Gulzar-e-Rahim]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gulzar-e-Rahim', FILENAME = N'E:\SQL\MSSQL14.SQLEXPRESS\MSSQL\DATA\Gulzar-e-Rahim.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Gulzar-e-Rahim_log', FILENAME = N'E:\SQL\MSSQL14.SQLEXPRESS\MSSQL\DATA\Gulzar-e-Rahim_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Gulzar-e-Rahim] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gulzar-e-Rahim].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gulzar-e-Rahim] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET  MULTI_USER 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gulzar-e-Rahim] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Gulzar-e-Rahim] SET QUERY_STORE = OFF
GO
USE [Gulzar-e-Rahim]
GO
/****** Object:  Table [dbo].[Attendence]    Script Date: 5/2/2020 1:34:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attendence](
	[Scouts_GZR_no] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Present] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[award]    Script Date: 5/2/2020 1:34:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[award](
	[idaward] [int] IDENTITY(1,1) NOT NULL,
	[Unit_idUnit] [int] NOT NULL,
	[Scouts_GZR_no] [int] NOT NULL,
	[Event_idEvent] [int] NOT NULL,
	[Name] [int] NULL,
	[DateOfaward] [date] NULL,
	[Description] [text] NULL,
	[type_2] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[idaward] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Badges]    Script Date: 5/2/2020 1:34:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Badges](
	[idbadges] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[type_2] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[idbadges] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Camps]    Script Date: 5/2/2020 1:34:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Camps](
	[idCamps] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[Place] [varchar](255) NULL,
	[Typee] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[idCamps] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Camps_has_Scouts]    Script Date: 5/2/2020 1:34:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Camps_has_Scouts](
	[Camps_idCamps] [int] NOT NULL,
	[Scouts_GZR_no] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Camps_idCamps] ASC,
	[Scouts_GZR_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Event]    Script Date: 5/2/2020 1:34:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Event](
	[idEvent] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
	[Date] [date] NULL,
	[Time] [time](7) NULL,
	[Place] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEvent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Event_has_Scouts]    Script Date: 5/2/2020 1:34:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Event_has_Scouts](
	[Event_idEvent] [int] NOT NULL,
	[Scouts_GZR_no] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Event_idEvent] ASC,
	[Scouts_GZR_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FeeRecord]    Script Date: 5/2/2020 1:34:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FeeRecord](
	[Scouts_GZR_no] [int] NOT NULL,
	[FeeMonth] [int] IDENTITY(1,1) NOT NULL,
	[Fee] [int] NULL,
	[feeYear] [int] NULL,
	[feeDate] [date] NULL,
	[paid] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Password]    Script Date: 5/2/2020 1:34:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Password](
	[idPassword] [int] IDENTITY(1,1) NOT NULL,
	[Unit_idUnit] [int] NOT NULL,
	[string] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPassword] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Scouts]    Script Date: 5/2/2020 1:34:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Scouts](
	[GZR_no] [int] NOT NULL,
	[Unit_idUnit] [int] NOT NULL,
	[Name] [varchar](45) NULL,
	[IDBSA] [int] NULL,
	[DateOfBirth] [date] NULL,
	[Post] [varchar](1) NULL,
	[DateOfJoining] [date] NULL,
	[DateOfLeaving] [date] NULL,
	[FatherName] [varchar](45) NULL,
	[Photo] [varchar](255) NULL,
	[ContactNum] [int] NULL,
	[CNIC] [int] NULL,
	[Email] [varchar](255) NULL,
	[BloodGroup] [varchar](45) NULL,
	[ResidentialAddress] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[GZR_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Scouts_has_Badges]    Script Date: 5/2/2020 1:34:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Scouts_has_Badges](
	[Scouts_GZR_no] [int] NOT NULL,
	[Badges_idbadges] [int] NOT NULL,
	[Unit_idUnit] [int] NOT NULL,
	[DateOfPassing] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Scouts_GZR_no] ASC,
	[Badges_idbadges] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table1]    Script Date: 5/2/2020 1:34:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table1](
	[gzr] [int] NOT NULL,
	[nam] [varchar](45) NULL,
	[DOB] [date] NULL,
	[DoPass1] [date] NULL,
	[DoPass2] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table2]    Script Date: 5/2/2020 1:34:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table2](
	[gzr] [int] NULL,
	[badge1] [varchar](1) NULL,
	[DOPB1] [date] NULL,
	[badge2] [varchar](1) NULL,
	[DOPB2] [date] NULL,
	[badge3] [varchar](1) NULL,
	[DOPB3] [date] NULL,
	[badge4] [varchar](1) NULL,
	[DOPB4] [date] NULL,
	[badge5] [varchar](1) NULL,
	[DOPB5] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transfer]    Script Date: 5/2/2020 1:34:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transfer](
	[idtransfer] [int] IDENTITY(1,1) NOT NULL,
	[Unit_idUnit] [int] NOT NULL,
	[Scouts_GZR_no] [int] NOT NULL,
	[DateOfTransfer] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idtransfer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 5/2/2020 1:34:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[idUnit] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](45) NULL,
	[fee] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idUnit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit_has_Badges]    Script Date: 5/2/2020 1:34:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit_has_Badges](
	[Unit_idUnit] [int] NOT NULL,
	[Badges_idbadges] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Unit_idUnit] ASC,
	[Badges_idbadges] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [Attendence_FKIndex1]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [Attendence_FKIndex1] ON [dbo].[Attendence]
(
	[Scouts_GZR_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IFK_Rel_08]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [IFK_Rel_08] ON [dbo].[Attendence]
(
	[Scouts_GZR_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [award_FKIndex1]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [award_FKIndex1] ON [dbo].[award]
(
	[Event_idEvent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [award_FKIndex2]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [award_FKIndex2] ON [dbo].[award]
(
	[Scouts_GZR_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [award_FKIndex3]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [award_FKIndex3] ON [dbo].[award]
(
	[Unit_idUnit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IFK_Rel_21]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [IFK_Rel_21] ON [dbo].[award]
(
	[Event_idEvent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IFK_Rel_25]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [IFK_Rel_25] ON [dbo].[award]
(
	[Scouts_GZR_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IFK_Rel_26]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [IFK_Rel_26] ON [dbo].[award]
(
	[Unit_idUnit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Camps_has_Scouts_FKIndex1]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [Camps_has_Scouts_FKIndex1] ON [dbo].[Camps_has_Scouts]
(
	[Camps_idCamps] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Camps_has_Scouts_FKIndex2]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [Camps_has_Scouts_FKIndex2] ON [dbo].[Camps_has_Scouts]
(
	[Scouts_GZR_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IFK_Rel_09]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [IFK_Rel_09] ON [dbo].[Camps_has_Scouts]
(
	[Camps_idCamps] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IFK_Rel_10]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [IFK_Rel_10] ON [dbo].[Camps_has_Scouts]
(
	[Scouts_GZR_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Event_has_Scouts_FKIndex1]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [Event_has_Scouts_FKIndex1] ON [dbo].[Event_has_Scouts]
(
	[Event_idEvent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Event_has_Scouts_FKIndex2]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [Event_has_Scouts_FKIndex2] ON [dbo].[Event_has_Scouts]
(
	[Scouts_GZR_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IFK_Rel_11]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [IFK_Rel_11] ON [dbo].[Event_has_Scouts]
(
	[Event_idEvent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IFK_Rel_12]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [IFK_Rel_12] ON [dbo].[Event_has_Scouts]
(
	[Scouts_GZR_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [FeeRecord_FKIndex1]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [FeeRecord_FKIndex1] ON [dbo].[FeeRecord]
(
	[Scouts_GZR_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IFK_Rel_21]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [IFK_Rel_21] ON [dbo].[FeeRecord]
(
	[Scouts_GZR_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IFK_Rel_01]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [IFK_Rel_01] ON [dbo].[Scouts]
(
	[Unit_idUnit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Scouts_FKIndex1]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [Scouts_FKIndex1] ON [dbo].[Scouts]
(
	[Unit_idUnit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IFK_Rel_04]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [IFK_Rel_04] ON [dbo].[Scouts_has_Badges]
(
	[Scouts_GZR_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IFK_Rel_05]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [IFK_Rel_05] ON [dbo].[Scouts_has_Badges]
(
	[Badges_idbadges] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IFK_Rel_20]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [IFK_Rel_20] ON [dbo].[Scouts_has_Badges]
(
	[Unit_idUnit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Scouts_has_Badges_FKIndex1]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [Scouts_has_Badges_FKIndex1] ON [dbo].[Scouts_has_Badges]
(
	[Scouts_GZR_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Scouts_has_Badges_FKIndex2]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [Scouts_has_Badges_FKIndex2] ON [dbo].[Scouts_has_Badges]
(
	[Badges_idbadges] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Scouts_has_Badges_FKIndex3]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [Scouts_has_Badges_FKIndex3] ON [dbo].[Scouts_has_Badges]
(
	[Unit_idUnit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IFK_Rel_18]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [IFK_Rel_18] ON [dbo].[transfer]
(
	[Scouts_GZR_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IFK_Rel_19]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [IFK_Rel_19] ON [dbo].[transfer]
(
	[Unit_idUnit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [transfer_FKIndex1]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [transfer_FKIndex1] ON [dbo].[transfer]
(
	[Scouts_GZR_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [transfer_FKIndex2]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [transfer_FKIndex2] ON [dbo].[transfer]
(
	[Unit_idUnit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IFK_Rel_02]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [IFK_Rel_02] ON [dbo].[Unit_has_Badges]
(
	[Unit_idUnit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IFK_Rel_03]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [IFK_Rel_03] ON [dbo].[Unit_has_Badges]
(
	[Badges_idbadges] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Unit_has_Badges_FKIndex1]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [Unit_has_Badges_FKIndex1] ON [dbo].[Unit_has_Badges]
(
	[Unit_idUnit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Unit_has_Badges_FKIndex2]    Script Date: 5/2/2020 1:34:46 AM ******/
CREATE NONCLUSTERED INDEX [Unit_has_Badges_FKIndex2] ON [dbo].[Unit_has_Badges]
(
	[Badges_idbadges] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Attendence]  WITH CHECK ADD FOREIGN KEY([Scouts_GZR_no])
REFERENCES [dbo].[Scouts] ([GZR_no])
GO
ALTER TABLE [dbo].[award]  WITH CHECK ADD FOREIGN KEY([Event_idEvent])
REFERENCES [dbo].[Event] ([idEvent])
GO
ALTER TABLE [dbo].[award]  WITH CHECK ADD FOREIGN KEY([Scouts_GZR_no])
REFERENCES [dbo].[Scouts] ([GZR_no])
GO
ALTER TABLE [dbo].[award]  WITH CHECK ADD FOREIGN KEY([Unit_idUnit])
REFERENCES [dbo].[Unit] ([idUnit])
GO
ALTER TABLE [dbo].[Camps_has_Scouts]  WITH CHECK ADD FOREIGN KEY([Camps_idCamps])
REFERENCES [dbo].[Camps] ([idCamps])
GO
ALTER TABLE [dbo].[Camps_has_Scouts]  WITH CHECK ADD FOREIGN KEY([Scouts_GZR_no])
REFERENCES [dbo].[Scouts] ([GZR_no])
GO
ALTER TABLE [dbo].[Event_has_Scouts]  WITH CHECK ADD FOREIGN KEY([Event_idEvent])
REFERENCES [dbo].[Event] ([idEvent])
GO
ALTER TABLE [dbo].[Event_has_Scouts]  WITH CHECK ADD FOREIGN KEY([Scouts_GZR_no])
REFERENCES [dbo].[Scouts] ([GZR_no])
GO
ALTER TABLE [dbo].[FeeRecord]  WITH CHECK ADD FOREIGN KEY([Scouts_GZR_no])
REFERENCES [dbo].[Scouts] ([GZR_no])
GO
ALTER TABLE [dbo].[Password]  WITH CHECK ADD FOREIGN KEY([Unit_idUnit])
REFERENCES [dbo].[Unit] ([idUnit])
GO
ALTER TABLE [dbo].[Scouts]  WITH CHECK ADD FOREIGN KEY([Unit_idUnit])
REFERENCES [dbo].[Unit] ([idUnit])
GO
ALTER TABLE [dbo].[Scouts_has_Badges]  WITH CHECK ADD FOREIGN KEY([Badges_idbadges])
REFERENCES [dbo].[Badges] ([idbadges])
GO
ALTER TABLE [dbo].[Scouts_has_Badges]  WITH CHECK ADD FOREIGN KEY([Scouts_GZR_no])
REFERENCES [dbo].[Scouts] ([GZR_no])
GO
ALTER TABLE [dbo].[Scouts_has_Badges]  WITH CHECK ADD FOREIGN KEY([Unit_idUnit])
REFERENCES [dbo].[Unit] ([idUnit])
GO
ALTER TABLE [dbo].[transfer]  WITH CHECK ADD FOREIGN KEY([Scouts_GZR_no])
REFERENCES [dbo].[Scouts] ([GZR_no])
GO
ALTER TABLE [dbo].[transfer]  WITH CHECK ADD FOREIGN KEY([Unit_idUnit])
REFERENCES [dbo].[Unit] ([idUnit])
GO
ALTER TABLE [dbo].[Unit_has_Badges]  WITH CHECK ADD FOREIGN KEY([Badges_idbadges])
REFERENCES [dbo].[Badges] ([idbadges])
GO
ALTER TABLE [dbo].[Unit_has_Badges]  WITH CHECK ADD FOREIGN KEY([Unit_idUnit])
REFERENCES [dbo].[Unit] ([idUnit])
GO
/****** Object:  StoredProcedure [dbo].[addAttendence]    Script Date: 5/2/2020 1:34:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[addAttendence]
 @date date
 as
 begin
if( @date not in (select date from Attendence))
begin 
insert into Attendence(Scouts_GZR_no, Date)
select GZR_no, @date from scouts
end
end
GO
USE [master]
GO
ALTER DATABASE [Gulzar-e-Rahim] SET  READ_WRITE 
GO

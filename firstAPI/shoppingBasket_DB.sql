USE [master]
GO
/****** Object:  Database [shopingBasket]    Script Date: 21.04.2020 0:42:35 ******/
CREATE DATABASE [shopingBasket]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'shopingBasket', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\shopingBasket.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'shopingBasket_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\shopingBasket_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [shopingBasket] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [shopingBasket].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [shopingBasket] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [shopingBasket] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [shopingBasket] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [shopingBasket] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [shopingBasket] SET ARITHABORT OFF 
GO
ALTER DATABASE [shopingBasket] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [shopingBasket] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [shopingBasket] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [shopingBasket] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [shopingBasket] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [shopingBasket] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [shopingBasket] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [shopingBasket] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [shopingBasket] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [shopingBasket] SET  ENABLE_BROKER 
GO
ALTER DATABASE [shopingBasket] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [shopingBasket] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [shopingBasket] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [shopingBasket] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [shopingBasket] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [shopingBasket] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [shopingBasket] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [shopingBasket] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [shopingBasket] SET  MULTI_USER 
GO
ALTER DATABASE [shopingBasket] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [shopingBasket] SET DB_CHAINING OFF 
GO
ALTER DATABASE [shopingBasket] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [shopingBasket] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [shopingBasket] SET DELAYED_DURABILITY = DISABLED 
GO
USE [shopingBasket]
GO
/****** Object:  Table [dbo].[Kosik]    Script Date: 21.04.2020 0:42:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kosik](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Uzivatel_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PolozkaNakupu]    Script Date: 21.04.2020 0:42:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PolozkaNakupu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kosik_id] [int] NOT NULL,
	[produkt_id] [int] NOT NULL,
	[pocet_ks] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Produkt]    Script Date: 21.04.2020 0:42:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Produkt](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nazev] [varchar](30) NOT NULL,
	[cena] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Uzivatel]    Script Date: 21.04.2020 0:42:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Uzivatel](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[jmeno] [varchar](30) NOT NULL,
	[prijmeni] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Kosik] ON 

INSERT [dbo].[Kosik] ([id], [Uzivatel_id]) VALUES (1, 1)
SET IDENTITY_INSERT [dbo].[Kosik] OFF
SET IDENTITY_INSERT [dbo].[PolozkaNakupu] ON 

INSERT [dbo].[PolozkaNakupu] ([id], [kosik_id], [produkt_id], [pocet_ks]) VALUES (1, 1, 1, 10)
INSERT [dbo].[PolozkaNakupu] ([id], [kosik_id], [produkt_id], [pocet_ks]) VALUES (2, 1, 2, 1)
INSERT [dbo].[PolozkaNakupu] ([id], [kosik_id], [produkt_id], [pocet_ks]) VALUES (3, 1, 4, 3)
INSERT [dbo].[PolozkaNakupu] ([id], [kosik_id], [produkt_id], [pocet_ks]) VALUES (4, 1, 3, 2)
INSERT [dbo].[PolozkaNakupu] ([id], [kosik_id], [produkt_id], [pocet_ks]) VALUES (5, 1, 3, 4)
INSERT [dbo].[PolozkaNakupu] ([id], [kosik_id], [produkt_id], [pocet_ks]) VALUES (6, 1, 3, 55)
SET IDENTITY_INSERT [dbo].[PolozkaNakupu] OFF
SET IDENTITY_INSERT [dbo].[Produkt] ON 

INSERT [dbo].[Produkt] ([id], [nazev], [cena]) VALUES (1, N'Rohlik', 2)
INSERT [dbo].[Produkt] ([id], [nazev], [cena]) VALUES (2, N'Chleba', 30)
INSERT [dbo].[Produkt] ([id], [nazev], [cena]) VALUES (3, N'Máslo', 35)
INSERT [dbo].[Produkt] ([id], [nazev], [cena]) VALUES (4, N'Mléko', 15)
SET IDENTITY_INSERT [dbo].[Produkt] OFF
SET IDENTITY_INSERT [dbo].[Uzivatel] ON 

INSERT [dbo].[Uzivatel] ([id], [jmeno], [prijmeni]) VALUES (1, N'Michal', N'Ch')
SET IDENTITY_INSERT [dbo].[Uzivatel] OFF
/****** Object:  Index [UQ__Kosik__442062D593D2B005]    Script Date: 21.04.2020 0:42:35 ******/
ALTER TABLE [dbo].[Kosik] ADD UNIQUE NONCLUSTERED 
(
	[Uzivatel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Kosik]  WITH CHECK ADD FOREIGN KEY([Uzivatel_id])
REFERENCES [dbo].[Uzivatel] ([id])
GO
ALTER TABLE [dbo].[PolozkaNakupu]  WITH CHECK ADD FOREIGN KEY([kosik_id])
REFERENCES [dbo].[Kosik] ([id])
GO
ALTER TABLE [dbo].[PolozkaNakupu]  WITH CHECK ADD FOREIGN KEY([produkt_id])
REFERENCES [dbo].[Produkt] ([id])
GO
/****** Object:  StoredProcedure [dbo].[mp_pridej_produkt]    Script Date: 21.04.2020 0:42:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[mp_pridej_produkt] @Kosik_id int, @Produkt nvarchar(30), @Pocet_ks int
AS

DECLARE @Product_id int;

SELECT @Product_id = id FROM Produkt WHERE Nazev = @Produkt;

INSERT INTO PolozkaNakupu(kosik_id, produkt_id, pocet_ks) values (@Kosik_id, @Product_id, @Pocet_ks);
GO
USE [master]
GO
ALTER DATABASE [shopingBasket] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [Lv-284.Net_EasyTravel]    Script Date: 28.01.2018 16:11:28 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'Lv-284.Net_EasyTravel')
BEGIN
CREATE DATABASE [Lv-284.Net_EasyTravel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Lv-284.Net_EasyTravel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.TC\MSSQL\DATA\Lv-284.Net_EasyTravel.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Lv-284.Net_EasyTravel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.TC\MSSQL\DATA\Lv-284.Net_EasyTravel_log.ldf' , SIZE = 2624KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Lv-284.Net_EasyTravel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET ARITHABORT OFF 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET RECOVERY FULL 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET  MULTI_USER 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Lv-284.Net_EasyTravel', N'ON'
GO
USE [Lv-284.Net_EasyTravel]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 28.01.2018 16:11:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[__MigrationHistory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 28.01.2018 16:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetRoles]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 28.01.2018 16:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserClaims]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 28.01.2018 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserLogins]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 28.01.2018 16:11:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserRoles]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 28.01.2018 16:11:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUsers]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[City]    Script Date: 28.01.2018 16:11:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[City]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[City](
	[CityID] [bigint] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](40) NOT NULL,
	[CityDescription] [text] NULL,
	[CityPhoto] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Favorite]    Script Date: 28.01.2018 16:11:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Favorite]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Favorite](
	[FavoriteId] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[PlaceId] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FavoriteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Place]    Script Date: 28.01.2018 16:11:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Place]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Place](
	[PlaceID] [bigint] IDENTITY(1,1) NOT NULL,
	[CityID] [bigint] NOT NULL,
	[PlaceName] [nvarchar](40) NOT NULL,
	[PlaceDescription] [text] NULL,
	[MainPlaceImage] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[PlaceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201801191131216_InitialCreate', N'EasyTravelWeb.Models.ApplicationDbContext', 0x1F8B0800000000000400ED5CDD6EE43414BE47E21DA25C01EA366D57A0A59A0175A72D54F44F3B5DE06EE5493CD36813271B3BA515E2C9B8E0917805ECFC3AFE499C493A33452B24D489EDEF1C1F1FFB1CDB9FF7DFBFFF99FCF81806D6034CB01FA1A97DB87F605B10B991E7A3D5D44EC9F2D51BFBC71FBEFC6272E6858FD6AF65BDD7AC1E6D89F0D4BE27243E761CECDEC310E0FDD0779308474BB2EF46A103BCC8393A38F8DE393C742085B02996654DDEA588F821CC7ED09FB308B930262908AE220F06B8F84E4BE619AA750D428863E0C2A97D06F0D35D021E60F01B5CECE7F56DEB24F001D5650E83A56D0184220208D5F4F83D8673924468358FE90710DC3DC590D65B8200C3A207C77575D3CE1C1CB1CE3875C312CA4D3189C29E8087AF0BEB3862F3B56C6C57D6A3F63BA376264FACD7990DA7F62C13F12E0A68F74571C7B3206155D546DEAF9BEE598D0A7B956350FF61FFED59B334206902A708A62401C19E759B2E02DFFD053EDD451F219AA234087845A9AAB4ACF1817EBA4DA21826E4E91D5C16EA5F78B6E534DB3962C3AA19D726EFD60522AF8F6CEB9A0A078B00567EC099604EA204FE04114C0081DE2D2004268861C0CC9292744116FB7F298D3A1E9D45B675051E2F215A91FBA97DF4ED77B675EE3F42AFFC5268F01EF974D2D1462449A1424341EA3578F05799C2827CEAEF099D0EEF609095E27B3FCE6705377A1F8A4AE749FE9B778ABCECC33C4A13977524D254B803C90A92A65E13A7F636031F644003FCB06CBE3D5F641AC8FEA8ACCA145DC7754B11EDEEDBEE92A56C730CE3813C89636AC86CCC98A6BD475268FF7959D1C93AF7134C3AD616FAA7D1DAD22EE9126C48D05908FC6084A5D2400A4D2F967E12C26AC0DE46744E00D47B2ADD028CFF8812EF6780EF9FDD4073E8A609F58D390161FCECD26EEF2304AFD370C1A6F1E6648D3634777F44E7C0A5B3EC0CB15683F12E23F763949233E49DD219FB9EB82520FB79E787E600A3A873E2BA10E373EACCD09B45347B1E1613D86ABBED546516003F54E72A425CF85056AD3316750D296FD15453652F6DAA5E462B1F99A95A56D5AB9AD7E854B5A8D657550666A6695153AF6856A153CFBCD648F960363E0312C2ACFDE734A26DDA0F4D2733133380670F1399A45F41908E2D6A0DC7CC66E300C7CCDA6FCF3133F1F4F383EFB1F86EB063292B5378A3FAEACD50B7FB0B9A69C7F9F0E8CD28E1484C45F86E6E5A78FFE9A8F3DC138C23D7CF5C523AE729B6FB4D4D685E6375EDFD736B34CF0EA859A88BFA2C045035A8656CD1356ED0290C2081D6899B9F80CD007681271B8376C53356AA8C2F9252F5294253B16F2479D45761C2D649C0360498CE2F1F11D9B17DE4FA31083AAC23B4338C06ACD79504B1E414C610B185BCC30626A2D5E70D4C7C2545188C2EEB4C1CCEC7DA5D4F93BDE9C6BA2B95AB475C3A6ED8882F76E4904A8F2CF2986771C9767B6DC031DB0D62A280F6E46C1BEE5964ECA6C32FA6EFBBE69EC2BE41E99E4536B311F76CDA6B0BEED934C88B73CF7C9B663AFAC29E6DD79CB3B959DC74306F35D6163CB3618D1D73CC3CCFA46D086D0113D9394F17AC103E12C5AE88EA596C8C70911A8B0EC2C0E790340F2DEADC5691773AED104D07D283D52ED601585C924930D2443256AC3CC56AD1ACC81B8C21CBD3A616C862AD1720B9511771F92B42AE9AEE1A517445839D45D59F6AE4258736D80A7028D2E08B4B54B3BB06A6D09D40CA0631C976FBE4BB5CB78A4168314E476EAA3451D995D16D543A63B78D5429579FA46B908D84044969A3B22BA3DBA8F0CF6E1329C27E8FC03FC840CD203DCA342BCF2DAA7852954D9C9CE2537C98381A2ED0E40AC4B18F561C37A8F862CD7362D0ECD5BC3F5F26CC311C172B683395B695241225600585522A9A6A9A5DD19E020216809DDACCBC50AAA68C9E9AA5BE14C907487908CB55BFACCDFE2E2E3EDB193C8A74A3C038A73D0C59CE929D354BA3AF6E6C31A6160840A238DC9E45411A227D02A56F9DDF50F1EDF32F32C2C411B4971224C9565212DB34BCD1B0881362A401AA72947507490FA033759959F2C6D6659B7A94F2D88947D11D456D6DD074694BCFA112F3C0FE63D589F03CB38AE392F020DC6773AC9A2DC243D55FCD910A3A080F537CEA89C1310A2430AECC1CB549FAE0319B25E68802B38387148A7A68C9F3371A4AF2056BE1692CAAAE612E41666CF0E872690FAF94B91B0DF7948BD7C056E82C9699A32AE81D3CB0A2D81CBBE67A888BFBCE4653ED1E6AED709A6FAC87C4530DC2F3ACD1E38463EEAA9E07E23EF7C42A2EE325B0E2FB0E7A9276A7B9B627E5E729433C4983A05F711A37E4CD05A7F55A5F8FD9B8F66E2CEA6DD7FE7ABC7EFEFAAC5E216D35C52A95F46ACB296C2D27C536AFFB2D8AB4EFCBABD85669461AD09F3081E13EABB03FFF14CC021FB2E5BBAC700590BF8498E4F40EFBE8E0F04878CCB23B0F4B1C8CBD40B14D56BF2E698ED806E8533EB36B2741AA2745832749A20790B8F7404573BF401E7C9CDA7F66AD8EB37315F657F679CFBAC0EF91FF29A50577490AADBF649EE53874FCCE7715959A7FBD88F70ED98876D9FAE2F70F79AB3DEB26A133EAD83A60161EF448C25470DEAA87E0B55F56FC3F6693F48CA19C525F85E0F16B1E6E9DA70A83C01ACF11EA99AE9FA8EBBF3E58F86494970783FAAB7C5D300851F182602CBC514CA87B21B00E96F67580477F92EC75404F5F56BE16584735ED4B816C460F7C27601E02CB965B0B818AFDDA8B5D37B7161625B2F7A0192D13BA7BC08D48DA1E9606BD302EB532966584E6E154E9D1B037E4E0CF4A9FDE05C6749DFB6F8F28BD396E74CB3DD9FF8A12BD03443E89A2B46DDAF366BD4C777CBCE3DCD17ED4E69D72B322766F9BBEBC5937D39D2DEFB89BF5A228EF94976D27566ED5C78C03E6D6C9C632AB4A73F9231F3EB75389F3537ABA595F4474F0F36CF104C7D790A8796DED5C6303AAB15EA09E4C270A95A64A3733B95D6C9F7E1681BD9BB9DC2E52433DEDE0379BD09BDBE56AE89C9B25412BA8942A227AEB4AA5677ABD24CA73A31F1D7CFAF62CB4E5A6FE25F19B47304863A6282F9C5F0E997904738C375D7A5097E57B631A13B97FE9904665ECAF6A08F6EF1E22E836A26155E7022DA332280B1A95558443942B48804743E54942FC2570092D6647C1D963F6ECD48D5D482CA077816E5212A7847619868BA07126C5827B9BFC8C9FDDD4797213B35F788C2E50357D76847E83DEA67EE0557A9F2BCE7234102C6B288E5ED958127604BB7AAA90AE2364085498AF4A76EE601807140CDFA0397880EBE846DDEF12AE80FB541FD2E940BA07A269F6C9A90F560908718151B7A73FA90F7BE1E30FFF01C864C793F0530000, N'6.2.0-61023')
SET IDENTITY_INSERT [dbo].[AspNetUsers] ON 

INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (1, N'Pavlo', N'Shostak', N'shostakpavlo@gmail.com', 1, N'ANFScUiNnS/wHYLtEp345E378GwBBgrYo/x1eAWAMGEfDc7rZCoRUrA6xZo9SFbb2Q==', N'ecd8f768-7298-4186-a685-3075e90e9abe', NULL, 0, 0, NULL, 0, 0, N'shostakpavlo@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (3, N'Oleh', N'Trush', N'trusholegi@gmail.com', 1, N'AJ5/6T+w2Cwx8oeKMLIIlQQRsFhAGRxCMd67HrHR81dRZISSpSrQYJ43QJIZ7V8cAg==', N'879a2b3b-1641-4fd6-8029-496f2093bdf5', NULL, 0, 0, NULL, 0, 0, N'trusholegi@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (6, N'Karapet', N'Badzhaksuzian', N'mrkell0000@gmail.com', 1, N'AHzab08KNGyldyPNGb7HNVtCGPSW4sPJlcsRiQ1YxMvnWTfnepYxt5A6GRy0euU6IA==', N'9453ccae-3696-4306-a11b-3daa4b3df573', NULL, 0, 0, NULL, 0, 0, N'mrkell0000@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (7, N'Bohdan', N'Shchur', N'bogdanshur1@gmail.com', 1, N'AEg/tQTHnXaDzdT2VKtuEtS7XL5aaiODzCDPRuwyzkogycphL131sqVrSmU7gtt2sg==', N'34c48a54-7853-489f-93b7-9ae6718797f0', NULL, 0, 0, NULL, 0, 0, N'bogdanshur1@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (8, N'Ostap', N'Oshurko', N'patso1912@gmail.com', 1, N'AFMtEFa9401w2hkASw4gnWedNotU4V66hStdpIz4YXnseq6mmcocZoZ9QzrJsXF4kA==', N'c9025bdb-4c8a-4420-bd92-3ff031cfdfd5', NULL, 0, 0, NULL, 0, 0, N'patso1912@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (9, N'Mykola', N'Tsenov', N'tsnovronia3@gmail.com', 1, N'AJ0U9B2Fw99rKF/+93C2T2ImvRgIu7KZ91QoZo1Kk2OhPlqRQrhUb6EAuZHtuiiKWw==', N'28e83eb1-247a-4447-a12f-a0ab97e93418', NULL, 0, 0, NULL, 0, 0, N'tsnovronia3@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (10, N'Bohdan', N'Kulchutskyi', N'bogdankulch244@gmail.com', 1, N'AN4RRzQu+6DHCdtDr6V7tFlBuIDNtgy/BYr30I3h7kOWhEPmZuZHzzYg4gid2MjUow==', N'747b6575-97e6-415e-a2ec-bc4d2b541f6d', NULL, 0, 0, NULL, 0, 0, N'bogdankulch244@gmail.com')
SET IDENTITY_INSERT [dbo].[AspNetUsers] OFF
SET IDENTITY_INSERT [dbo].[City] ON 

INSERT [dbo].[City] ([CityID], [CityName], [CityDescription], [CityPhoto]) VALUES (1, N'Lviv', N'Lviv, the capital of Western Ukraine, is a large industrial and commercial centre of Ukraine. Its narrow old streets and its historic centre make it one of the best places in the country. Lviv was founded as a fort in the mid-13th century by Danylo Halytsky and was named after his son Lev, which means lion. The lion is the historic symbol of the city. For centuries it has been the Western Ukraine’s main city. Lviv’s main street is Freedom Avenue. It runs from Mitskevych Square to the Ivan Franko Opera and Ballet Theatre.', N'https://lh3.googleusercontent.com/-7nA6tjVYzxQUZjnn2-6g0g7x4HSR-YBkhl2ZhrIo2elJIijP-WPgAr2txZdlTEhC3-si6wsqsZum-Xrjlx_yEnTOUdGjabRE6eCthnJKUKB3ElP0yvKJAsaOYtiZKAq5k2B35dc5BLXFAyAqDY-s_j3yR1XfTauq3G8vIJGuBoi6drw3mBq5hR-vTDm-fk4dZGCMjPDpNlAzDCmefTOrCTE2vt_dfBuj2DUcraWKph__LCiwBUpeGDV48mbpGvvOLvlQQmI3cYCKsGGobzvYwZNONAHai6xwoqFJeiUu_tgXh97weSxyiTWsFlDjodMIfzb92OnKItuvywGFuC2LwYg_ZszRtLYWtsVO5c9M5KUedh7hRGB45ht_1Y1xK6A4qjU7Q8_hs--iNrLAo4AeykQm14FS91mXnbbrUFx3fGe2weULL22JqhDj_0zOVtmME2E8kTprwX9oSeK-31oZcHj-ap6vWJnAwGfBjnh1I5sVTxdJZ-EzxPF01ySHqxzg5cfe7x23uDK_bvzjA1E4ZmYOJw4BtUyz-uE_QtD2tcImt3VG2VOXXj1lZfq7yeMOR4ddd6FNruZ3fgQkzk5aeLnGH6gtNt3RVH5Wnc0qmt-p1nIUsr8nyUa0HPZWBYd6l1f7KlO1OgvLUHmZW5vgrMgwAqwhXU=w946-h629-no')
INSERT [dbo].[City] ([CityID], [CityName], [CityDescription], [CityPhoto]) VALUES (2, N'Donetsk', N'Donetsk is a large industrial, scientific and cultural city of Ukraine. It is the centre of coal-mining industry. It is also the main fuel base of Ukraine. It was founded in 1869. Until 1924 it was called Uzovka. From 1924 to 1961 it was called Stalino, and only in 1961 it became Donetsk. The city is situated on the river Kalmius. It is very famous for its waste banks.', N'https://lh3.googleusercontent.com/uxIaDBIkkwO0x1WMf9k_qrTBvQTXwSyU3N-ZxvIiP0ewvIb-O80XUk-XSRsumKHgUuko9-puJKCipPoLClmr2O8M0Yd-CjbzIfkG57ljMFi8xBWVcmJVCHB-95sc5QlgFukfU6wBPu92lPrKP5hk0HhCfcQepMQGXCUZR4sYE8_XDgkR_sPVyKrnQ5Wwji-EPteJmxTgOAxWp464zgNMd1j88ONRgds6-lxAehfxMX7_ftQFgoUeaj4Tc-FrWnF05QQaACnA4uzOqSZ3aViFxkuG5TGn6t4d2omfW03DK7XcwxupIBd_YEoM9P3AYMSF2MHfTW4lxrgAGczMU16vF_zRntAb7bo282ezORIIXJAyk0DnCK-O5WMidrLy-PBz0gxVE-I7nJ0WiUeWZ0Dx1CL2xN12S5OeRKblTkuVtKztuLN16fbQbcUyFw5VlOMTJK92CTKCzgAH3wehDEFcm0__QB-tWPnPOztrYJyOoLR698g2LXsw-6CKAcz7AXaFTEoLZPZAHxGjbQsspYV9I3UZEp1194IlrLDnkas84nQmhDdMH8hS5R2NPuK_QdghkL3_u2WJGATWev2o52_AKeeJsqouPfH-mQCopc-NfeRCzaNqv7G9CI7ej9UVJVJXz24HUkr9mvHvYcOB6KMAu2FLiehIZPfF=w944-h629-no')
INSERT [dbo].[City] ([CityID], [CityName], [CityDescription], [CityPhoto]) VALUES (3, N'Odesa', N'Odesa is the Black Sea gateway to Ukraine. It is the country’s largest commercial Black Sea port and a large industrial city. Odesa is a crossroads of cultures, languages and trade. Pushkin lived here in exile during the 1820s, and also it was home to writer and film director Alexander Dovzhenko. The site of Odesa was controlled from 1526 to 1789 by the Ottoman Turks. In the 18th century Russia took this region and constructed a new port at Odesa. It was named after the ancient Greek colony Odessos.', N'https://lh3.googleusercontent.com/Hgc7yNfLBpzLPuVGnu7P3rD83krQro7BQeDegCndX0PZLki8WGXppRJbD-c5PdxThwuy3UjZgb3HupkK80frJL45jL4ZHBWWGqe1LDXWAC9GoPyxIq0msPTLDjKvKJFv4kkgPLpQoTLfvaUY--MUX3WX9IjRfQOncxc4X8yAyvhBp56vWcf0-mYn0lyKb_EOPlwTw5m2oSy1DwtTYZAkDjNAaTNDmTJXmPXtUZfoLh7-Z3F9g3NBGJvDRP_2qtN1WBbJ_y3-codq0DwySGXyl4FMu86MlPsF4y4BtzLxFHMt_bs0ZoN9BFE9uuZNuP9pXubnEZuOWOTODxxIA5RD7UNvi5LnMrMR-rAm0YLRHvD7TuGH5CycAFX_0E6USPS46FSHGo3o43Sgpzl4z6heYM0Ii1oftVdoAa3k9Fz2npQpcRRq0lNf_OueAqkohLZi4BBzNkoMac74qc3Pj9qjaEaSfdLaaUkI9ZNDxVY2p2cldbBWLnfohk6sVHXsNJcf1CqQiMOvS1UBe3z8-Z3X9qpO02U0vVpCfB1dOKR4Iln5RdihTzm2BAhGxAsBrAPmTwFdcE6fDhR4wTQBbdomLUWZqGRRZYhzi8rTMl2V9GDUugMMTa7GaJZczo-3eKvr66v0ISqtiSNXQcfpJCpI6lksygGKwGIV=w1200-h600-no')
INSERT [dbo].[City] ([CityID], [CityName], [CityDescription], [CityPhoto]) VALUES (4, N'Rivne', N'Rivne was founded in the 13th century. In the 18th and 19th centuries it officially belonged to Russia, but in fact it was the capital of a private kingdom of the Polish Lubomirsky family which had its own army. Their palace was burnt down in 1927. During the World War II the Germans used Rivne as their administrative capital in Ukraine. The city was fully destroyed as a result of fatal fighting. Today the places of interest in the city are the Resurrection Cathedral, built in 1895 (formerly the atheism museum), the Music and Drama Theatre, the Regional Ethnographic Museum.', N'https://lh3.googleusercontent.com/OHyNFBXSh1RsILFBsonXZRckHq1hpi4Gmk3IA-_J64NwcQzXzbsiVoafR2KpvSPEI3AlW6_w-7TkT17z2m8iy_R0i5XGhEZtioiPtokops5tajd5vP_4Meuwu7sojlRb79LD3KmBO18FJ78hGUJAES5QF3ii_pLLqCWqOH9WGUBGmz_SxKbZZW16tO_Ev0WsD47BDXzWaGLBdmR43z_h24Pkr4vV8kaIDEgjqga0nKNEKrqwESz2cw4LZyELTqg5VuVuQq-tCHJ_jDR51XIXWs0LVLo3NHBd28D3C_2-pvwCNWT1hWlbMyJ7OOuWROJyoh4NUlgjcVm543QPdAhp4MwK5FnOB2oe-NmyCvL0MbWWpzUMDx2pxcOldy-Tb_znacfe77XhnJEqY0WBpbzEiOoRWSup32vR4BJcdmhPFuxxiy-xh1ZpD78KSgPujWMOMabVG6hZ4mAfLg2qOSxnBsBC5D6SbhwRbsNgisNzwYpJp1Yu_n1KxffOm_YjWXzih2Mre_fZEAScLivOLamstIIb9thQSAEJpDFS2-SjOH_KtRV2cXzh7qo0iOvEEQbS7D9XR39qe7TEJ_WmVEbsbdvPytoZalKzFegieReQT8Af_0LLPapT1Uzbgr_q4FsOFi3ySbr3Rl4OUBS6mGL5rNHdTzJGPUUP=w650-h316-no')
INSERT [dbo].[City] ([CityID], [CityName], [CityDescription], [CityPhoto]) VALUES (5, N'Poltava', N'Poltava — one of the most interesting towns of Ukraine — is situated on the picturesque bank of the river Vorskla. Due to its history Poltava rouses great interest. It was first mentioned in chronicles as Ltava in 1174. This old name changed only in 1430. The history of Poltava is full of different events. Since 1569 it was a part of Poland. And only in 1667 it became a part of Russia. The town is also well-known thanks to Poltava battle, when Peter the Great with his army defeated the Swedish army of Karl XII.', N'https://lh3.googleusercontent.com/oOr_J8mEg3hl7CU0KR7h3eRQ-USvmpiqZzWkxIRrxe__D-M5COgTrYYsqfbW4hBYGA7Z7byZLo1qzISM87EyigYJVQhl1fq02ZVYCZMOmpdJpq1TmPCR3KhAcvZq_CjzXniy9O1svLkRdN3lHrwtSBbP2xxtcS64f_6Y-Fp7xpTsD-2tB8VNA9PEqHyVtoC9S4PFjP6byj6tekzYcmepXGM8MQJofoBuLNjbIp9-h7sUwNL7K3HtXV6-x7sjegwOPchUtAXxBLyDG3orbU7YKI-pknWoBEcFDpKVLhGgO_5E47RGzQTCRrvva7QM3D7-Unh8Dww-cLvbd2Iuv2sub6XlyJlKX80HymE2gp8s7OeABwRYj3f6bJkd4GGujPeoUtMGUInD3jkSspKLaFvsc0fw10gy4zwVyYlVCiH0mYMuYDtXl_XdmaoSONZ4Cc32HKDzXgQE-KZd82GHagCWn1SZkVsjsRSyrSwTjn9hMVorNI4Sk46Vfrtc0hlQgoWiK9RRn7VZ8Q6fD2xyAp2zuU1FOHJ2ipzS-TvfEMH-l2rtMTvkDBlfI3Jev4BKiA6e3WRyCryNphIjlbBuXUgD1u1zjCWczHxdX0nUHUHpjIPXKhFaiM-NGCqYEtJu89BTo2j_xef-NsmmRKDjbpB4b8XCu3wjh0UJ=w720-h340-no')
INSERT [dbo].[City] ([CityID], [CityName], [CityDescription], [CityPhoto]) VALUES (6, N'Chernihiv', N'Chernihiv is situated on the high right bank of the Desna River. The city is divided into two districts. Chernihiv is one of the most ancient cities of Ukraine. It was founded in the 7th century. It was named by the prince Chorny. The first mention of Chernihiv in the chronicles occurred in 907. The city was incorporated into Kievan Rus in the 9th century and became one of the most important and wealthiest cities of the realm.', N'https://lh3.googleusercontent.com/w0_z4st-cXum0GoieLajMtj-BfqEsRYmTsXH7cCLbR9FoMLgk-sNrJWnnXs6je5nMlxd7WcSQFk3VgTm50_XFf8p7vTAHnroCh5eVAWQEekti3CA_WI5Wdubt1hqND4SouuW7-OabvMgAyMr7Zzkk72ijLbjMQoKVo_pIhlr-f1Gliofy5ePOgZqhQcCOPssMg1LiQ-Zz4gSO-2PuAbwEEaQatt-ZkkxF__gnDHo3WEI4nFgxSJqxr1ScY1OMDCw6Wv2081ZeDSbGqkYlrGNopiZbD2gNi05X2fT2v81Hg5MH2d5mLds8hBTvU-wUouvmDbNfVQZQiaw4VMS-Tr5cE3uPoQK7wsjW2mHPZhsvQWTrWwTmyu-Vs2RlRwJgoDKDW30Qn-0rMmgh7oRTimEqdAqOZJ5g1WTkdB5rCbntOaAqzAPGtaQd5TorF4P3S49kr0ARrsHG5jD0YRoZfqLAWI7ELiKSKyYegl9hk6v_2Po99ryIHM_lxPQajFG3tqwTyvYrpHjaaqsn2nLP4SZ_-LI1_i303eqQVMXXO_wy8AsuoAFzz-ezcAKEnue8bDm1jiU1-nkN2A3rvnz5VjceD0_3hWnV_03UPAzRWPqPSMER0PDJQIjvxrrYU98l0R9wfdA7YEqeB01Nwici08h0lXpE4ElGhfz=w450-h301-no')
INSERT [dbo].[City] ([CityID], [CityName], [CityDescription], [CityPhoto]) VALUES (7, N'Zhytomyr', N'Zhytomyr is situated in the north of Ukraine on the Teterev river. Its total area is 6100 hectares. The city is divided into two districts, and its population is 292 000. Zhytomyr was founded, according to the local legend, in the 9th century. It is first mentioned in the chronicles under the year of 1240, when it was destroyed by the Mongols. It became a town in 1444. The chief architectural monuments are the Jesuit monastery, a Roman Catholic church (1744), the Assumption Church (1752), the Transfiguration Cathedral (1866—1874), the city hall.', N'https://lh3.googleusercontent.com/LuC9Q3HRWc_OLcbK6oBhDDHa5Vu_og2IhE-Gw3LlCKTgdRkd8X-Ec0aTWVmxXh9hy80RZFatHVTLsEJ72rwAtlEKwu2VywJd7p5-1u97UuCc7mAIb5Bg64hsXeiKlYV5vpaYeF-4Rha-RFils2o4wEQ1Ym0oRC74k7jTtGAyYaN1b-rO-yU2NdbOQW4iBb29MBaOCxzcCunr51ak62Isyk33UFSAEsWwBZGn0UJRQAyvMUOZeBOLPAlHzVxBl6iuA9qGRz0RA9G5Ay57h0DY0cIUA63FroU2puAhcrqsR18j8Ant60OWJS96UNsHhzF7FqCvMupD-XMs6MKJu7a4leSzbvhu0WwtDpC5j7p4TyRJTHr7J0amcgyBIuRGo5MbhpP6cIX6mmK4ZOvRpHKXeq-jKlhoAbB3BXYjPZxcqZMsClPzeDvoagam6a66vVULqFvb1z7S0U2TTBjDdoD_4Kytx81nl9JXILgmr_uC9iMTN7I_ueu5o3nXPwVcOV2d3f9rqvqoEiFNwKJ_a3Pmf7DB29zA6iJae-GZYlk7pnp7VHBmDnDSKsKDwwFfu3145op3e4lBDUT2HFvWTZENKAnpmYMknQnEBEBdJSvTqOhGMfBHvT4QXQ-dwLIBl5BTxpb-eT3ExcbL9fIcR8PVgnHZC152LUXr=w848-h400-no')
INSERT [dbo].[City] ([CityID], [CityName], [CityDescription], [CityPhoto]) VALUES (8, N'Mykolaiv', N'First of all Mykolaiv is known as a town of ship-builders. And it is not by accident. Mykolaiv was founded in 1789 as a shipyard. The town is situated near the Black Sea and is a large sea and river port now. That is why it is the centre of ship-building in Ukraine. Besides there are also such industries as light, perfumery and food processing there. Mykolaiv is also a large transport junction. One of Mykolaiv sights is its astronomical observatory.', N'https://lh3.googleusercontent.com/_mm-1CPUlUuQp9pkwUuOtH1nwmdwTc9vaHRD2YH0rJS2mvMxfApptO017DTom_C9tFBgCLEHhYxt8MPmxw3wtHi2sXHHEqLhS1UEhO2WpjcdsYWgaD2sqWuc-nIpmJQm72qvQQxZXBr0ivA6LozdAMaLnUDlpc1vQe3lFePNo81qtRbft2gA7uZgyr5udrUQJChSMPMM-jzfRMlDNJsmIpKhzb-ZokWPo4DKOpk8fE3p_h5cHrMLbAF2jIdLnu-HbPYyKTmm3Jdw5fVUHhpPIvq-34muT5G1eam97e2sCtC4ngMm-DAp75gDrmLkYwgLMAkmtrhnuhdDp2HyDeqEJYKqBITG6O7peEbSPv-6W66cM6ST7d5X1V0gBsqMY9IRkm-EFwgLszCws6yWzAs3serd7L-8Xvo4Nu6BQ29WHdovkz5zZSGnCBgRSkxY0BZPS43WPO9MuGVshUZ0Rj5QjSlwYnkxJQyVEUB1DOcXPpLvAJf4PlVgUkgIMdSTA2o6uyA5wzM8fmXnRiB0xCAxC9ESr9T0kpVLNx9AJpCNwZwBVCAsQT0iRemuTf4f92hhSVrMrBKB59v4Q2kAm3TqItl4HyYRT5qJjg03KyZcpYbI2vtBvEWZshKT9pHSCg3J9mR_1mmOi32WkYQUMJ5jDuKrJiPPBkU0=w800-h500-no')
INSERT [dbo].[City] ([CityID], [CityName], [CityDescription], [CityPhoto]) VALUES (9, N'Sumy', N'A city situated at the confluence of the Psel and the Sumka rivers is a region’s centre. The city is divided into two districts. The first mention of Sumy in the chronicles occurred in 1652. It became a town in 1780. At first it belonged to the Kharkiv Region, later the Sumy Region was founded, and Sumy became a region’s centre. The main architectural monuments are the guildhall (17th century), the Church of the Resurrection (1702), the Cathedral of the Transfiguration (1776), and St Elijah’s Church (1851), and the bell-tower (1908). Sumy is a modern city, and it is very green. There are six parks in the city.', N'https://lh3.googleusercontent.com/oKp8-o1sOuTZFxiWEc9HfHFvri72Q2A_Ff7EHeK9iTbECDTR0uDo6mPNIct1IFn5cGUxilanRAOPJUV3vtNLWjLYBOgTO0YuXv1Q_F-QdXfDZzpuZGvP9EiYEFXdqSbtH4b7W_5g53fwRXHBEKym0i87J1l-PfAqPHPyOSY6qAKQcKDq-b_ylyS2C7Vem6i8yncXXhcmvBVq3Tlf6q4hEYP6_T6MdfRfIuEMDM7Mlhe6vIgDTtkqFbv7ddAClBS4sV_cg5VZj2rs2eo7E5AEtT0Ow2s_WFQbnfQJPO-2MmN6WRCXxsERGQX577ssUvGmjBkXIaVPJKC_hT5uMlcSNX36eRnSx2OAHdCzUNsBV7hx2dOSgRrB8pjODwh3dkS9MTGZtFce6p_CWBhF1jk5fK0wvgwHpM1-QwyDQH88-Ga_XHtFk3sIlNRtyn-xuydwSO7pvzz561oUECyzJ2OlYTixs3We0swGDt-z7NZMamS_miSQ3coYxFfVgevXb-GDVX_bvH6RV0ffSuObvJZswJxLnR2NOsGx6kMvU7KLFq_bnWADAqaRz5LKRiVC1PrH-ELsbHm8MLLSGYQ1SPJn5QO_cRxbq67XGiG6r2mrcK1Jw1uwf_mw1MAMPM_p-jAE-ogNa-P3bHwkmn_EF_hux-3vjNvuY08x=w615-h462-no')
INSERT [dbo].[City] ([CityID], [CityName], [CityDescription], [CityPhoto]) VALUES (10, N'Ternopil', N'Ternopil is a place of the music and drama theatre, a concert hall, a Natural History Museum, an Art Museum and a gallery. Regional review-contests dedicated to Oles Kurbas, Solomia Krushelnytska, Volodymyr Gnatyuk, Olena Kulchytska as well as festivals dedicated to famous town-fellows have become traditional. The region is proud of 237 artistic groups, which have won the title “national”. Recently created museums after Bohdan Lepkiy in Berezhany, Ulas Samchuk in Tylyavtsy have become outstanding centres of renewal of historical truth of the past. Numerous visitors of the region are attracted by the architecture of the Pochayiv Lavra and Monastery, as well as by the longest in the world caves located in the outskirts of Borshchov.', N'https://lh3.googleusercontent.com/jFUFGy-ar97Dft4mCR7VIZTAGtMmxnRVX8qOqFAjydUNi8bNeJTetMEl4OVahj2rZkhgB4RMHy7QJqZqkhXtX7uUcxsNMTqTS3RdTJhHHvqncS_baJBLRBMwlCpDyVu7yMQ_TNeMqqGI6AKwtI96GEk4XdNgUiD8pCPe0zAFQII8D3x-kSrTqrGclJMeqvlpcAtAsvO9yocnLWk_bygaE0NIMkNDjmdAzC7ZZFI_A5Juam4yOVm1VjQMteaIeYELVqb6e2MpJ9kDd3-EBRoCkqJaZkjMRakQ-YdJWqbb68WMGoAQh9trmGm5-0lWBnMSIpdtyF0NyynrQMoZOcSrEos9mImM3TNNNS7E33bv5GPHaUsC5OIdOfEqBgD0hpVc31-JBgAiSLVcJgfTw9NtQLxBB7nmhc3pvynWcnjp3rXtzbSiAZ6vMcqcQdj9sRqUl6ZRH_Lcy6JJjhYQUqInCQWgrd8LTYKNYjtbCn3FBKYe2-d0V6DIe5fmQRSIf7viptg5jL5bNhDlKY5sL4aYdQDZOEY1Ck7kSKFPW_XKWrES3tuNInKqqtxwgfXoWefJH0MHO4xudlaBF8rjZgp72Z9gfk-oe9VRLhqhPnztCY5JTcXZDr_CFsDB-xqY6xyqJB_sJvAfnvKt3raGbsbC7QMJ_7RLsB6F=w650-h358-no')
SET IDENTITY_INSERT [dbo].[City] OFF
SET IDENTITY_INSERT [dbo].[Favorite] ON 

INSERT [dbo].[Favorite] ([FavoriteId], [UserId], [PlaceId]) VALUES (15, 6, 47)
INSERT [dbo].[Favorite] ([FavoriteId], [UserId], [PlaceId]) VALUES (25, 6, 1)
INSERT [dbo].[Favorite] ([FavoriteId], [UserId], [PlaceId]) VALUES (27, 6, 2)
INSERT [dbo].[Favorite] ([FavoriteId], [UserId], [PlaceId]) VALUES (68, 9, 3)
INSERT [dbo].[Favorite] ([FavoriteId], [UserId], [PlaceId]) VALUES (69, 9, 4)
INSERT [dbo].[Favorite] ([FavoriteId], [UserId], [PlaceId]) VALUES (70, 9, 1)
INSERT [dbo].[Favorite] ([FavoriteId], [UserId], [PlaceId]) VALUES (78, 6, 46)
INSERT [dbo].[Favorite] ([FavoriteId], [UserId], [PlaceId]) VALUES (79, 6, 48)
INSERT [dbo].[Favorite] ([FavoriteId], [UserId], [PlaceId]) VALUES (80, 6, 45)
INSERT [dbo].[Favorite] ([FavoriteId], [UserId], [PlaceId]) VALUES (81, 6, 53)
INSERT [dbo].[Favorite] ([FavoriteId], [UserId], [PlaceId]) VALUES (82, 6, 52)
INSERT [dbo].[Favorite] ([FavoriteId], [UserId], [PlaceId]) VALUES (98, 10, 37)
SET IDENTITY_INSERT [dbo].[Favorite] OFF
SET IDENTITY_INSERT [dbo].[Place] ON 

INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (1, 1, N'Rynok Square', N'description.....', N'https://lh3.googleusercontent.com/piiagJgv1PJw8PUVONyZeQmdLivigH1x0GILVsYbdfodGRGSeMoL3CaAqePfjjZVW0PLnOtTZ22elPsMeE1P_-qmz8o7ou6bXlQn6hKznkE62qfakoXmXveD-kxxbOjKZDLD3jLU446VvCjo-Z1C5FoaNOKxqcE6eIsW34wuh3RT-IrEymlyCvzXNTsUnJMa0rE4qXc_bpq6TLHximpNKCXmTBk5szib1rAkPGymKrAAYqZ5JGP_7gUeV5yM-0AEayzOCnr0TYliB9_f_HRUxf8lJLH6Ao3iBaAQySxkrRuw42QmBl9XayeAf_UQxZAySdqO2S0bTR6w1QJOZPv-L5FYTBxhPMNJ6v_m6OtKEC5lLV0nocRN9_TWsw-W4rkMauMhcn6OeFyajjK9tumETV6BNdXrogsLURVIR0mvBSzVhm2x62Lpp27LP_rAOx2DWGzGRTIAI8NvYTWsGOjSWGrdnnOLWHbDqUap9ohBOIYlKXn6VG4cchxK-3mj0wdQHY7OAb6tJTsHid1lV49irVPTu9EX3In067HX1ikIy8o9255VHY4cOMCPi-hgOZYV5UfqrV4FrTJZqSr8mNbkTEfKP_ZzjYkyIZ4Bj8LVS-DKxamP0yW_XeWhgN3_ZLu8Oy43NJ5vS98I7Xd29DJtOF8o4sEy72U=w800-h533-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (2, 1, N'Lviv Town Hall', N'description.....', N'https://lh3.googleusercontent.com/Udq_TUcvMUpLlcgWOL18gzdgDTx-hBvy-_J-jWeFN2D7l5nChaITB0Fwqy5pKf71XRY8aEpwpiWQWMA28jTtnvg26uZjYvjYIjq3tUv9kmIodexh47zPJkP-uTuJAakhrx1EH9CZxUac9lpDUlta7zic1CtMa5cn6vlQIGbgWvYbipmSmQNalnMVVgs1wbc8Godios4rQckOiccjoQEPfzx07HvtbEX7zBSo667ih0W9S2ZOt29VGq3B6rYaP9I1Bp03SY5AcrZpsZeK-fbIxqecQxfgQtF7aSjIeQV_IccAirqxDIx_eT4t4ytbRqEMnplBTlXW3BePSDkIcN-dxwH73_LmB_KKM-3U81ABUzUOGQNDfLLTwtq3FiVqQwKPhQgSRiTM4uLTGcd3gpnW2YAwcLKzOywOOPoUahrkcbCvzuy51HE1O2IMtNaXQkkx6IYABvpXlep4b1vgNVu5NZx6C9TA8zOubqjOVO1rqZUTt26vjnPtIOkC6W3s2GrXWnmr3QigZ8-DzQZBub-dkqbBAWSuyvWN6tBw03Co0ix3KYz9nHUjWq_v085jych6fcuciKSWvY4I8MfAtVNu2uNJnJtmGH_imY9GjTrDo5yPnX_RbjxRlMK0EBQ8r6DJ-G4MjLO_Zd68YX5u2zPid4KWgPYcJgw=w800-h595-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (3, 1, N'Lviv Theatre of Opera and Ballet', N'description.....', N'https://lh3.googleusercontent.com/LjuYVYlNcfuN0DdGyjPZnxrNtXPTwUhDGpu17SmbEAl7vvmDZG0y35khK2pBrzvh4zH-wgg2lLGqC9ni-xfOe0h8WV5QoPZCF4W__oR4uen1IxUs1rMG7ji-MreW98tKZmHJfzkmoaCaTqtCzmUaREXLM0i3IJJuqDFUa1DeN4qMpWLm8NfGoePr373-m30r3l4yVX1pqaRBQdYk_S1-mKfevWCn0uEPHNokTC7rtx2JAN3A1ZGOeKMGMtX6PzX_nW8djzshSzF4LgKd46EgAa3NAeKUT54TwesEbX0pnrHkvroJBG87c9piJujl5fEnQPLyBYijULm-HHIrBi4IBwtgWC0l0jE7VxAc61zGT0QVW1S1f6C1t859RGHzpTQhpQ8lQGlwOH_Z6CLUvjXpA9EAm-vZ3qgaSYCA1Y-YuSqhy0kwJycw_iRQRIG3WjYM-fdR2_WpwxCmYsWqyKf7RDq-z8Q6GXj1lM_sdXHvuPHUV6VZxdt6yn40EcUAGSOwFLBv15uLjLkSySW0HYzvZM9xbrASJ4I_1r6ORSuENwLOFjuN8VnP-R-pHi7kBPKgp2v6rbLMibuUmMBK_05bhBF6pcY5SY5O9mX8mM0iy-vlqb1nhNqkbw-u5oiZAMLJpPIURn8QWmI60hoFLocrIJKOf5Ytu8I=w730-h486-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (4, 1, N'Potocki Palace', N'description.....', N'https://lh3.googleusercontent.com/EmIC6_APJNp60Pz_FlQbzS83c9E4y70tO022nmUZBKv5alcTHjmmmjf4cpz6bjlHXZne0LkvmLTQvqY6VJkYNTMmqrvsbORzKFRYj4S67zqEzqv4KQ1dXTXT3UpplAUT3zmCaq8NUUI0YWeOykNPepH2fHDXhYn3dbV5xo0E_4D1lz-NiF0yK4IDjB6rGjZlp-HDpBlfz0O0lUqu5VUMSzECVlTJCvH3ITk0OdGRIg5Mz0fmFSbZ8JVbseklxv2-MxbDoUCxqcKgQgGxX7ZzK3vm5SGX3Xf5Jbg8LTck1Yo8f5IdrLqErCm1RtI5EQHNsPsb6dflv3MAyHYbpbKFxGHLd0V4mk93O_KIElCHNqQEpIVTCHOi-ReCHbt7GstA9GzCmtD4Vtnffl6Yow1PTO2Km_cKDM7PagILaJOpA65N-Uv4Mg-QGqwjxuZt3ZeWaZgIOnJ16KUOlLYQXriBnO8sL1qsyL9_tZMBVlVoBOZKWPwV3bVDFwH-SDoVvFL_sE6vcc1NhqjRo3_FB1LXbE57Iz6yQT0PdHYVHY7MEaKL0gffNqZn_GZCGLeDhSHrWocAhnlaGF81AmGa4zmT5UGec3x9426Uq5XN95AvNlcGSjvvt15ffgqwKlHes40UBpz7C0phSLpFk5akXt7UOPmygOwR03s=w720-h395-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (5, 1, N'Bernardine Church', N'description.....', N'https://lh3.googleusercontent.com/VWhMMrWpWfPwMfvb3orxhYjYcM9WF-co4B6pp5gbi_ImPa0d3NQmRVmV2cnAUZXztwerI3F8s31wksUZgtRQAa1aHVVGqrNgT0TnipI0XgXyOvxyuGMVahDNaZQxWwY7oxbtmoVtKKaWaItsipSh-r1Xy_tqhwI_DhBwtZBud4stBwMYbnfYjlntfR7bbemaCPo9pg_WETCkf3WdwKoZ33ZxWBSVLvEJqO0KvjcQmGlfK299rrLsmRUbujmnWhx1LcECVq6xPfkbqW7OsX2x338xsYftuuVe0EkwOOIGUA_9KS7xZ9v8ZqI-TS3y8jmcrIglVU9i84ixtBl0_do7JYEXd8YiGnTNX_T7tIWxsyuK4-BuOtNnTa4LtrXLF6sRnVtqjjx5Wf_Fgg8o_3p6yWNBKLxTrk_vVIG44JvyHSBCj_fzVg3KH2-Y_ydgUaIU4_Cmv1aptEikBbWgCmsvodV5_MIEA6eLcorp2SC9s5_PoHlYN5UgjFlLk3nf-mJV5978O_DB1tkc8YquaKd-NIwfBKy_c2xmW6lArUZcH2-EFVoQYd03cwZOd5ztr-7_b6OQ0wufH72JEPoj7Uuu5GWy1r-OCXAas5_DQCEjA4PoOyAuM52dYDAG4vN3nt1vsxTXgNrTXVrzoLYyf6HmpPQsFilvTLY=w300-h399-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (6, 1, N'Boim Chapel', N'description.....', N'https://lh3.googleusercontent.com/3FwzY5bxY6xDdE_3RslKHagdCtSc_A9DBtFzhXheR56cTfax8bacTM728xzjjilnSbEIXEHg4lvMPqNv15R2TqJSkvJEn-hBdl5gJat2owC53OQbYnklAZ_sYsCoJXF8Wc5UTKj7ZbVcdn8NEjZm16DWVAeOEJYjWMm1sAwU3eMDsFJ49r2eZcilH2Z0amu__KIbh1QY23qj6IjOwisTQ3lkhGjjFJ8A5fszmpyJ3X6uWyosMEqSTyYb-9ptAoIo_NH-CQ-9IRr5TmeE51fqhUKBj2nP4fvfy7bgaxBJFSRfhyFF6bPxfFph104Q5_mw5J0PRkpXjLzoUJft-D4DvEKCShdYwXChRJplwcu_Fdh109kGOG3uz3b3iMnxCsaIfvh9i-t3FRkdpZUJDNtQRoy2tA1btAgqZ29QVf4hY4KkeJypuzJ05SpZyfUmILxUoFIyTxkmyorDVOqCvd_zqgLKtt5tODUZ1e3ADwVPliZTiK7FZWmgVPY2WiMx7iEvROmQWOKm3a-9JAeYUWmTT5LbpLL5EzilzaZoW405qL2mSwJ1q1Tdf4wwRB8QqyjBbIGVVECH5vgEsTrJ15atWwJbB8msrVD6QLc19hgeD1xpv-Ins1mNY4_3ym_wW1xYTnLcjY1yzh0E7uCG35-hwajq1qxBZPQ=w220-h294-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (7, 1, N'Pharmacy Museum', N'description.....', N'https://lh3.googleusercontent.com/odik3JbHwVjjqP3-aD5-Q0Emy15leO0-AGq14OiDJB966kQ_aWcXzvIx7chpM_6Wt7HCnBMNI5bGX0DNnhD2RXCyFDPz5Yn7rZCPjayK1jdptzk8_xIWMjAcz91eIUAVOld7mv8V5zFiCgGmXClAGZcdR7Xag7RiG2fJBvJcAQuMaHDcftqxzbuA5fx3lghkpGp9Hsr92nwTmBmALYk9wEM39xpt7sHDeUR9sJB2VdWytmZ2tkCRAiwLQOQT1-Xyr8CgbTbToh_KyF6dHg4UEE7_1Ml0O2nK-iipR98r84OmvWxSgp-u27QRyLjO56KT9gxZTBY2JZJzw1HPSO0I6dAtYFBborewAPZjhoXP0oJUAl0KUwV2RbnrVmpMy3k6Hh2JYyMj-p340ofoE39tORmbKd3DhGGgUx9N0yoMVK3Dbss0mMAORBK3QNlUawjfNR9letP9g_2XJT2ZR3hBFl9wJmSvtBFTxBHa-n823CAE66d5UQU3iovKrCHBD8x5fEjHNdDXOhbAXdzrPOflZLxkA6N4AMZ0Av06HWPJkNv-I1sSi7GHXbHPwy2XXuntfUZT0qeNB1qiexamzDUaz4rN3mCNnYFtG1vz5TEi2pvK5_C3iV-1RvNmI7MQdPTlCJ5SWGo9AjKuHVe0lg9HPbY2M1AywHc=w800-h333-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (8, 1, N'Lviv Modern Art Museum «SALO»', N'description.....', N'https://lh3.googleusercontent.com/Q2SE1BmSewLwkmRxgw56_pRb998KlRLHQNtIMNxJrnXoHv0rkuPJ0YdGmzYg9ICkdo_3Y9l-xooVGG8gpVu8v9s0d1X1SmTwAOXUJYSdfzbgR2hwmsf3GyPeC0ygxSz2lXPua6mCmDoDXKoWF9oa1VdyDWVLRPwkVaOlmxJpqosOFJBb0UtZ99ub6-lYltay6V4cauk0bThqWFDDcY6mSvAfs0fStlyOf_MmMNhNNTzh7MwoKxvPk-FP_R8Q7qr2h7JcbPckYzj0ko1yhUKN-pW0UNZWve8uPMpnFVJ9hsoXXabSnSN_85z9zuU7X8R2cUQCMNCQNGsP-2zS7qfjyw93uPZlpumHD9PSprV7oDkLz5Rswcz0LkvQDks9ZJ74E80YDwBSLqJY3EAN4k7X7z8MG54TZTHj_Cv6uNK2JzOcWOehzz3ufkNM4OVCJ3a6RxTF1hoD-v99ZuuJMhjHiM-UzWyzCsV5wJWlVbDhdQ7e_U7pHbJq1RDE3oyw70W4xRQ3QCk4ZWvqL62T1GJWi-tjMqhUFOhueYcMVU4OjcuIWbFktyKfCGXFR2-EWRmPZp8-rUNa-UrTNYM-_eVpE2xML3xFaVwnwm-y6QfcG6wW3tfWqrPj5mXy6RWExS5ymwhYOFU8E8rdvhZpKQa2jCM-XlVai5A=w1200-h500-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (9, 1, N'Kryivka', N'description.....', N'https://lh3.googleusercontent.com/6kj3PsQ5Xqhf8QKcc0llcQh2gE_6Yaig5lPLFqGF1O3Llq_HE86F9P-xhZftzK5OUxTUOmSboZiJCPDCTcGjVDoHWaswsLIuUHXG0EAAthyX-XGECG47fFsAQNMvRtgQrKux2ztS5zwlVQY1DYh5KrarG4dq1foDxxRL1hkgqomY7xaDRnE8au3fLsE9hEqraj7adWCDZlPJPJAuV7LeKxh0r-DPg0T0VZ8A87KshV7HeaWMHmaQqna7YSYyRonxlAM3K6QVz5-WYWJ0z-6ArBz1SYpkgnkuKp7AoUskU8M-DQ3JMBVLEDupVEe1aITNXn3iX3YW8TjxpxMwuiMuJNOack_qxgJYTaMUlJKNxz9ftAKKglrNAm0HoZxyO4XgRwlzGfstPtwRPknqrh1vxtRiah_wAQ8xe5mEwXvmsBu5nCU5Cyx3IaGEe35Myo47m2haSUNXDuP8pnZ0iebcDhil0uWEzKiWuw7O6CKA0zWFMgbN799RYEIp-Wkkw0IOkFJGMYLyHpvENwrU4-cFOZhKWV0cwaQ-prlGXVuWGf20aQcSjDwhYIAD-JlYmI0tm1oz8OPJ-0Zi2KonLq86aehsZEDjkdrVkHpitNaiRD6LIRqS03kGS9E3fDbNWXXzW3sYUM55lqMFcrKTwZjVrhcvGGXvsKc=w800-h509-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (10, 1, N'Adam Mickiewicz Monument', N'description....', N'https://lh3.googleusercontent.com/LVP5q2IUAtmFfkiX3TQlI3rHSb9qUV-9owipSWz9C18hMFx4TGNx_nruNv9kCxvhSvd3hsPNoEi4ZcH-T5RAKVYHWJzj5LftuB8GOTBeKVJma9k14mSX5oms3R_jO9P5OrWdi79A_oS9dtg7ZJ5NcviHFoB7xCGe9Am12C1d2O5wopRej5_F15Xmv9yqghkRBKWW5k_unEIoXEqzKEqgEKMNeJcrKEyBDw3YgdlSwolhtKh3yG8hHGay3EIfAg_Ku6tyJ1zClFZEDsTBE-8OwoXnyOlxye0TNhLT6NBOA-MtZTS2cAsxWIfiT_Iov2f7-YoGJ8BOV6ycLOFfUlILopVvHotk_FTaGP3n9FTfWguykBKH8ALNTE8Tn3o0khWlgQwH1b72tbIdLh26ITBffL-6un4YNOpKzQEW0oTm8x2nDyeP4m0rF7wN3PXJsNSgd2WmrOp1Gx73sf-6aWlz7wYws2gUl-um2YodQtwlYT_Bla0txQ-SZKmpRqfiTJ4eKTS-N19_NEJM3wSG7RWz8yndzTkujoT6lhrBiXvMqU-vBlxS21pIroXC3gvUIDyGx9zpFIgUDzzf13fXDKcyX-R0HjqDi51DLfcoKECxxgIjhXiMkDrrfRThECngeyOcUBcyVoOh3FE8stGV9ecPzdq1T3wODF0=w960-h1280-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (11, 1, N'Lviv Handmade Chocolate', N'description....', N'https://lh3.googleusercontent.com/P_sK1_En3pBxEMZssjoCHJGqm4qs79RbmgRnmwjMW9bdxnbMBDMSkSypApQA3EZURqsjUB162y_QrqGQdcNU7kk_34IM0I4JW1O2v2RmG38O6Iqltvsj3KXWOIw7nGefWg9LwzNnn5CO0VzPzB2mnXGn29GtYbPvqJAisEqNh4388O8c-npyVO7FrwawnYwHtvneAVs3RZe4FygbEug6RZasiJGFARx_cnvXybsqlaPzPhXHPGC70ra2TYuV7ahYM6D5PPyY_pwDNAr2CbImwTOXpYUgnThxwOFSzexcWCsYSY1LB6Wfs6YoyLWtKyJKaxXkN4si-p0FebGUsibL8v1o05Ez-XH7ydjTeQFKXr22S-bnpy0z2H5XuXnjLPmbwd0fR0fBbfOPJroUyt6Ek0jcIyXIjxY-Kf8_IzpTJG_xlwbMz5f2byQ2luJ2cQ-A8bDd4glf-ryyo4LKx5lb3zsogCSNOpf0rMNpZtwlrsGJMq-hGwbAoIqTkpzDIpjY4YwRS-qXaUInfZ3bKlELfkLR4ijSQNAlWSVcdVyE0Y1qFbvMSA0Y-Xy_F4c_3ymd81363O1z_N6pfYQgAlYqMNuAufpNfmln01DaF1TP9Er_8imLaY68F6zR8DEW7sQrWCSFBEhYqmuLmu-Lf9uiTLS1FQImlIU=w800-h533-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (12, 1, N'Monument to Pipe', N'description....', N'https://lh3.googleusercontent.com/8VB6oVX850oJFXpZG-mWsvD7iz_Dz6ADnwaYGOW0T4dsz8FT7pDfg0iz02lWFxJ6S8_Gya4pU8n8fbKLVemBKY2AW8SLMWnBbQL49cDY3-77ERmdZ7snTwE1JbWwlM_oKUQ0rYu1tVIKPq2bCsoUdlS-BkOqAqjVviLpe29wl6gaDO1JhEvK-Aq1tpA0u2VR0hbEf5NT8hnc5pspbgGRhk3PjEYapVDzj-vKCNED3WBtHv5CeVO-sZwBvjByU-7gXKUg4znyZnzl5INvIst1HNmgvLmoAsGnL0hxg6IT2yPaN3kgUPTxMSD8n00_X6HDYA-pRTfS_xF4_W6hqn7FPGsVVPtGqkFgfUBtjv3Wy2valW_da5CdaHc0ZLQ6FVUkb7NCPInFjB9wFgFh5tW2p3pnwqeKR4n3qrETVSVAJfJK8mbpLV_LW2LMJn48EU6oUlvSullzB_jqaKvEjDh3SrlKp5MpVLi3vQCGkJVfgbmmeJEHhkN7SfoavnxoIAFtm0JtHjNb_KKO01BoivfQ0GMmWZ27BjObSJ5rHL2SPdqRoT-DLpOKXdKFXyDUfMF23ABYSWCFmdbOJOU805DAbSslf7oBmePkVlg4yDCsl69pokQrsRfu5e4MR85BByZvuUig2FKqfrg8Xg7jHPZoW3ZLL28e_jY=w800-h532-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (13, 1, N'Lychakiv Cemetery', N'description....', N'https://lh3.googleusercontent.com/DA03GVYLDxfJpaQURv0zd9JZOZ6pFCC44Mctp8aQ9ExvlnZw10mpGuC-MhgabKaeZ6jaezuz_hadETy3cIDaOhgSNihW_UlkQrwQbOUU8cV1YXymFXCDkbRNkrGQMaWNWfa1oIgtNeSVK9DIb0e7_s-MQtsfewGErJf_U9hP3Te_LrehI1JOun_9rQYhltgM_Nwkn2YaBCmD7hq1IYDbHSpcYTkJAr_fnWHe4J_S5ADgCgmCpxPc6sFzYN98ttIvuQF2vlMuAc34tuqCbQKVA7DAAsPPcq152MRgeQJy_bIAMrlCMmYUyweL-Eqyb7tVlUfv8qCTNeFwCUOzZMHnDR5CB-fHA1Q7ACJuy44Hg9DDRMHcH44ZilZtqeBLkTFhgOyictzLNm9Mm5ppcG0AL_BPMZwKK2jaQpYZLXCezPsSSpHA3IWHzwxNbCRW5en8u1OVAN-cIAP1uciK_eB1k2kafcgnLP06eI_-Wo3-EgbMsSFaWngmCRZ6Ru8vgOeUTXgq02lMHJ_htR1iWn-Fcbhxc1JcgsTCkvuI3KBDblKGMtfFLT5CodRz7ZDodlxcobqpvJgsVu4_rSDUNxgrCJPllM-z_snHaUg-CulnHjIEPx-cslui4CXXP0xegoFOb9Mbc1KvLVtxM8hct_0dGOc-ma7e1Zo=w800-h600-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (14, 1, N'The underground river Poltva', N'description....', N'https://lh3.googleusercontent.com/BOFJmMngnjYqfSYu5WhsokYjAu2yMrDw_1IFDq20e4EEvBG-yRbCG1EMWKLMXz-dsho0IUiHNadQfmRZfpatukOdMyYgfpNrvdppp1thUrw062zUzdA5xaJKs_6yo41tdhNE8PHRdKVE9Fii0rp-CL0K0zh8GC2644Y6b3yg86FR2BVYuIXeVm7aUdUa8V1ZGikecn-UEvexKOgkyjJkcueBjcV2PRDICkEMHbYo4TtOdZ4mz5nzAXplM-1KbW_MM_jjtG2dsPeDmlxmqGXFQoUgfnpTdA25kcWguqp5ub_0EXcR957k-wM9xmALIxzBYTqlODGfAyUuDNBs1IDQj3RnuWaodYejRQOmo0og3FgWM-OAhrR-eQ7S5b3q5u2CvIKkSNj4BVKWQ5iGYalF5QG6JSlTmGXYQlQPCvqTcnGSqVFJ3b7VqvhWkWl5YUd-7e4gy7R5oInHadHh2M5Q4UkDhXVps3tKJQH6hgNSqXHfZDFicM8_M-QNKnyx048-S8qIbzIO_sKPzuweQgn9-jBmvP386SPoYcjA1RhMsdB0gqFDE_Yk4Bomjb5ADzWCzZnv_ZjAPZy38Gzwl2uFm6fxSi_OrUux_5j4ijW0Sn53fZGx_82xId6B3aJCTyUzmy4QjCYVmkv7a3G-oyMCI5qIPW_fykg=w800-h508-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (15, 1, N'Arena Lviv', N'description....', N'https://lh3.googleusercontent.com/z_JMUgy2fYplfNaHZbn03TIr47E5dIYi4Gf0MqdUZFqWdz4cHDk8zhnJKoXOr8AwswHE-omWHOESCEJ3eZ4cQXG8dNr-D2AcJ5BDxuD-ejUuf0CWgvdS_Z8tdAtwd8g1VE1ErZAON5lhwHzzlbkGCt9fTqGBuhBSdPyoyLW3EsyfpZuX4mqLCA6bWeWs5gr4G9QkvHqSXBV7pbwMJvov_dbzta_WFbb0ISoT4rl-jFYk1a25pnMQ9U2IVadT0uFks4ca9Giy-T82zEvdjldgunoE_--2eRJf443kPrBNT81oWTpCMGcnJIJD9ild5tR1dXJwK4UHgiQ4YrG1ji6CnAtuVSYX6BBzKfU7uf9COAbg0iKwXpOMLAI0WcUZbTxiG9wGWGZanNTWGaqBkcVGvs7t7Kd_HQglcekKVX5rNd4337-SKFlNWe9A2kk6w2B3LRLoEg56FzsOzin5tlo89OS2ZcIyb7dSlMbm_RPdIs0qOrImTIsB7njI7aXauJxmD1X5BZ0FCwbldRVQELm69S8B6ELakAhz_FmK48i0Wa9r0B_6QRXtX0vUmGvxg3dqCNaRhbVNw-X4P7Y3r2iISmMdepjqDP2GSTPHtUD1hneAxWFeTnnYpQGDvtcBHY91SREZef_00zOorPFUjIACrQSoJPVTVOY=w700-h333-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (16, 1, N'Vernissage', N'description....', N'https://lh3.googleusercontent.com/6zjSwnTo_5BT4BuhCzBT5cjM0b5C9yJD8OGKIPCqoE4uaovUV81oNUcdRxUvSLsVqYBGoQ0ianUJg7Tul5zXa0KT3XZA0haG0R4dP2reCL89dMQ0G708Ge2laGiA6J66DTsu_WVA5uB8v8-Gp9epqrBtxzjR80kGTATCj9rXEd4b-kvJroDpkW4x3NkjHLI54D3PVUbit5TV-xpMJCLkMf-b_frIxreG_by5fV9SJgcthBpTeN-pC4GBdMnQ2H1ntzJmJaGCC9r8Z_2pIiA2d9nj9fCTM1HDgmrxREbve981ox0OxaGZFmktrKcwS44On9b_VcZo06In8OSD6Z6YeFiqpg-NSWZ5N2hLmB4TSpREaZ2nVKQe58brkO6L-ABAmojpiFkFkKQcnutqO6zFm4DrMncfwyMZl_hZ1O4572IWtfOlDSZpwwJ8jn16hRPbGCtnFWOB3wash9CL94smoUImXicsuPJd8C0P5pDsX8BbhKpT_m0hIJu1Ry1ZzsStinHXiPxJz_Slihxp4aIVrZU7HLVqT1P5ZaFApEKBaJmTXLySV_TWldIdZODn745qhyUkiSRKD5aBFC7yHtu2ylMxy4CLBYMw6NrJ95A-_ud6fqp1ihajksNhVkLwYHCUDBts0eqM8xVcfbnpcrGIBZos3BVaH_A=w800-h600-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (17, 1, N'Armenian street', N'description....', N'https://lh3.googleusercontent.com/baQSTP4jzGUbOiuDZBwwSvJstq37aL3dz7x0eiq6H7ELaj681u2eLF7cClspJr6sai7KmdPH70sxFMgTtGzKaKzutXx2s99NObhqHqo2ZZQueHVhbkBJtH5i8rB_tfnm6hdnqCIUVymhjmgRbuqnZU_iefx2pJhWzDCoB8e_fZBXAUUp8Mdg02FnUWm6RCn-0ZBNaicXwFNyg_-utw3PEYD3ksF4_aAJ2iFwuTqhAtnaH6QvgytOEcwziaLZv2T_jGxMXQoqDkyfeuOR5uRHG7K80dqgynFKOeVfa6mM8LBU9mj9bWi2btaCaTRLdXSiCPWr5LLA4kSTsOiI7NnRkFGPt2racZs2974ie04JrgT5tZz4wcWmS_d6TUVOJsMvNqpqp6IRrNBfZceVFrBTAJbsraMJQoidHfh6rVtxruJHh1p4Wfn4d4EY59tOrB9Mcj2lI6ZhQJ8W9ce3uj_9EY4hrVlrnLoWsvp_dPDpMDnhC-jOYhAq5UM2XDN6ZlruqIxElU9B8JzDc-uGhCK-bgMcq5KgVx30Ww9vFKZbM-wfX979B02BCzQ8pajCdTWanpRQPFuoXqC_GErDIu5PNOu14uo2yZPHOisvfU5K2ICaDwUh9O4RNTwEcGOCHbmnutRd7fXr3HFOA-M-ax5gxXGt6Bo5jGs=w488-h325-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (18, 1, N'Italian courtyard', N'description....', N'https://lh3.googleusercontent.com/iOd3a9wIKFDvWzPp2L9yB5KeaAGehXnjXl7xTii5Wo8Cr4jh7_wKH6xOWolNjYGi5EWOHEadG8lH5O-lT8GDP_vAzZOhLeVWzWJZRoOaJsAfcd-X6IconCXVMlN8SwhZ8CmHlGX4qo0qOTAePX8syhhhaSNaUgsJBr9asQwUSzGJbYtf2Oxi51u2HcF2OkXcnTQHMhq1hKYpJkVj7PJ19nO73nT4ah69TiPMvs8RzNkd0E8TgW_nwXQ14FQEWRmUbWzsDrXbFftd3f4Lkv_Lk4K0gbwUi47EzWSm3hoiadZItV_sWnhncKRCnkjsz29BmQ6dwWpiwfQFU0nS0BQs4ucW6K1OoW5iosteKglX8duxFl80X30qrwq74a9kaGWLX6r4R1ph2P6HUvlDr76NMYd2FuB10Achg9pAsoOCgyVYpUbkxoJgJNSHHV74YjU1HQsqyYT7gN7kYXiInFBJmHQFeLkJ9eSqlcHfjwoEnf_7UI9CKaXz4roux5fSQcIWm4HimPUIboFawzZNXdwVkLugJyW_dlzARURwNSwcOyPb_g5EkiHY1A5mkoTvaV-2IruInUrRkuszOc60taRqjX5Ew8dWhf_iawMdXFR03T8Lc_O7H3bXTDhszpDofUuoqppstdJ_PUf3jy1mbbQemEqi0awjW2I=w1000-h664-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (19, 1, N'Park High Castle', N'description....', N'https://lh3.googleusercontent.com/FGQexsW2_8TfS31kxNFPIUr-snbOhIQtyZkFmFCqoaiWiXK3nb5E8LueszCaXpRJofo48xFeaBWhuqWnBo5xiO7Zx5XZNuA1iok7Y7xfbjgC8LMi8B69sLFJnmdQpNXW9DdPpS6lTLPD9pcBlYeD_Fn-UIYQCXzOq9psHz4JBhSpsehoQ1gCRWWBVXzdWquEL32D7ntTWIEBrt2x7IUa21JIzxf0Riz95i15BKU-ZirHoI6f1FlN2kIzyCScr883_UOCLsvEk_vrjrUJFxVJWub556omgBMEkTfkevS6NlMek_Scbw1Ghw0Ei_PFYIsCSYGj16pGtqPvcYBKEagn_g9CunDv7glTIOgVTZ9bmjqnBrdupgigbkItDA0Cw5d4FtmFc2_89L0ge7kM-iZjdwXhKggEyseW7o0lqc1VtQDKmB54Osn9jE8Up7vvz8O8uPEe-Rwa-SCdRBjR-xkID3ckCoIBY5EdFzA7zQNXTiwk4XCkV3mOndWwdCYjP3uRasJ7ZyXa7Tw6ttyITPLDNFwzt9lKydbt9bPwbRIdGlJ7kvCqvA5SnT7xXyJkyO8QFhCdydE-7NpkDU9OTis6uxWHouGhinK0FLwxiVGkTJBArAHv-vYmSZXmyKgWHf3lo2FdTEyvN0sUvjN-MzSuNyZUrFUlBHI=w750-h465-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (20, 1, N'St. George''s Cathedral', N'description....', N'https://lh3.googleusercontent.com/XAieyV2osk5yXepVwynnd_c8DnYcIsYE6_5OX6pC6KtNERIR4n3lWjppxPq1qy4pi1hK-NMitsq79PASUSvvdWE7kb1fCWjiyUX7pmSE0_Kii34tSYT7-06k-kKQURon8jPLTQ9SiKRXN-96757GFN_aZbh3Q4X5WW1gmf7OwrCP08EGySWd4F7i64Z6NKnw9J3z7ZfKy2PHm-7RUrppXnMDZNwOpAGBYk-HVmhkb3qETKOX4iCcv6126G0SW2wvExKwmT3KThD-MCZe6MNWzc7J_9bdqKooULWZFs9SLjJSJn524RXFPEYwf67DVC-3SwLfh-y0PynZXpcaxAKruKW_FnqjwHLX3VsgGLgweSqP-fQwPTp2WkJz2OP3kX4pFcJo_5UFOaQER3nFzD5b0ov7boEEj5Ksmt-aZRfes9Mr62Dhlj_11oj5ISS1hY7rcyaP_ehx3Dbd6jPWbgZv0HY_6VeIy4XYKGHZZkAXh0-GgSy5PE8enP2UjCyVFnx0-zkCvmIQjPO3PtdH3yXj0poho8DfeDy7OsgOyMaNhj5dIaA0f1GyxW6rtlMvMhhR-gG4jXBO1-dWQ3R1LudLH8m6qqNk0qZ33saHmQhCt4Iih7Xf0Xj_TsgekZ__9mspOwsAROAUHlmHQvKHbJxqlbMTYMTmKzw=w960-h1280-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (21, 1, N'Gasova Lampa', N'description....', N'https://lh3.googleusercontent.com/BvUmyiQUXKyD3znGNjLntkiIfp8EAILQnpeQIYNUwC2nEZ_lIjlcXcw0K937QCKXoIwOVZnb1tAoguIFwD91ZTekJqYU5obQMS9TeiPHCZraHkS1aVMOS0w1RxlyG3TgYVv9YBGsD-SnRn9smWLVgft3hjeZmmnBFwzuwY4V6yqpb-QYZhS27yQwDX9ZHi9cjEBa0w1rEXwZweOBRmbOn3P7L2R2zDqWuNU7Tyo3JLPUsKFRwJOL2n7FAFY497f5pXOwk1GgjzVIrjQdCQe94PeZDo4HBVKVyUGNlxFE9N4fuTP7W2B5MvRv8eImUcrxk7kBPQg6qhvs2YAEE87v_Uwzniw2wI9Vf7dg6VnuJnm8ilX5TS03QSmBGpzKRdIZJaQHGnJ6vq2KuTJbbhEMAc8iBrUjfRxWXdmCYbVV3M1nE7wAzJQchORFrpLe5vUJ7i8TySs0jUW249J4aylRpnEAXlZlxpLbmdCS3tfxcjjuNwvvd_Un8rjv48u7X1b5CynGiz4oz4c7arlhQkeV3NttPC6WKn0SA-gF6bh58ygz9AVwzbv7OUa5JNbQDKEi9LO_6JEyUo-LTl6qShoAjQZlfgdf0KqM0WBS1xLxM8XrPDHUSftaBsGWNqYFLiFkuM_GRfmIMioM5_D5VsmgKfmQqV941Ck=w900-h599-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (22, 1, N'Arsenal Museum', N'description....', N'https://lh3.googleusercontent.com/Wn6Of0fLtpA8a2qCCztU9DLH2d5ZYLaIKWk91GTKd8hiWhcSGkHvXIVtlI__tkyv5l0dwYtDzpEEoaN6tMSvHqlApEfe0RwvP2GR8nJ5qP79aAd1oeN51_THVjMUFPpzo3L5ghl3twmjItGipgqCUrMO5VIP7r_1Gk7BI_vzSdiV7xj_GbJaJLvMtG8AEwVzQvlviDitI2ss-Z81caDwL-19VyntehdpU8gUJt2ntWlB-vYqb8s4jKl5nmdY5xi8QzwzbS4vpEcdQvaQ1OmHp-G42Ns7xBz_EKj1su6Pkdhlvc-wYI4BIxevetEVKI61ZD-VwneRpx9z-tLlXPR9aS6jOMKg0GC-ZcyiAnyWXro4-82gvxofcfuCNDZzCWEXDL3ac7xtAcF_6pFV9M5Vc4epJuvYstUqUFRcrDaDaXnBUNOxvM13HOfhhVzwXEqUTRHaN9p09cwxCgDkudgAKKvNloW7yJB9XBgzr_Cnl4QFNGsvwdGfb3_txYMA4moquA9DRNobX8JYKuJP3eS88blceDCP_stvx8wNzVLGfmPbi-NREiyoQ_lcyKhx0LBdnaNfoXi7Fj-X7caKSgQvSMksjg3z4z7AoJSS7PybwkggmzZcCI4BN1BwNMCjlJuq_8B1N5zzJGibk2kkqAX5ByvDLkhXl2E=w600-h250-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (23, 1, N'Monument To King Danylo', N'description....', N'https://lh3.googleusercontent.com/5HrFFGdQOktSs37hQK58IM8jr4HFWX3z2V4AHdPv0sRcTRmzz2J11EcIUEt7Tacc8QZu4-DvouGi66Et6cNCkB0AU_oRBY6ZtW5-orrZ8ltFHAxtM_MuhgafdB6Phbo1bZjLd8By7iJZyXgFxrwBT4pCO4zaO-Hk3OkynS7nraBU2xCXXwS7bki8KTx0s76IuQqS0YzSd6zYMoiPEnU8TAj1I-d7benz_WhD5WPK5slFSEAuq1fjI5yH58YP3z-fxlgNEKo09I9waz4JBaYI4L19hWnuvqQBN1MyRIpB6MuEJwY4GlC6TIvinKUcG4SnSSE1ZtBQlZsTkvZJ1LLLmlXwPwnXGxlL4QBX0hbWTjLz-x_ImfWD-uaHDeaCd_7gUOcP5Yv5373iYPC4LduQkwYB3fEqONQcfBpQRes1v4MMU7TY4ChoYYouiDWEM9fh8FLBiMe57q2PbtQIYnF6YqOZDak52GzVMjNt2CllvtDFLQRDNj3jOzZ-jetxi6-P-9sT8XYB-jt6kjIdq55XMzURE2xa4E8JJvYwkBmGhU7qt6F6uPWlhNXpBa6ooA_NwujJjwWM0lDLJsnbXU8La_yuPA1Yp2ACbHoGjf0XYo9DivvNpypmTUMFll3b5gCpSDjQ-Uc6B0eBg0zzjGsDgPon0A_PsYk=w700-h525-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (24, 1, N'Monument to Leopold von Sacher-Masoch', N'description....', N'https://lh3.googleusercontent.com/CNP05jlydzqEUDPfgx3tCwOxZD-OQFEZoLVBf5o5Rd5f_ea4iagXj37tEHSzi5-Y37MnL90SIbQefvnJgNOTbFqzgF_Mv-1rycXLCCH43HyQurZQvon5tFgtoTN0kkXq9IQcKQ3JgPyRz9dQmlfukRbeFfPjblpScjOX3G3S-sMGr6YZhl90EY5TOhxLaCFIr2XpnEkctzEGcVFNwAv0_7GfTNmT16WI5Z-0xCVPo4tbt9hFPvRcH3kIwoIVRAtNVRSC4A9rRXBv13j175iKkji7qpxvxyaB9PZR6NYcZ_aTG75LP61u5LyqV-yKvJ3wCkm8o8zEOuOcTf-HMGRgthqmuW3bTPXqYNiUHCmT-7P1RdVN9LiDxjGpGlmPo19t8m9OFhrRi98WcuXg_wA04iSM1YO7umwMe3WL5xRNm5lkExyWHo9AnYAnNRgbkFuyfTfttbrJe4pM6sHPwB4LM3GW9Fm4snr6yZxzrM1fLT9P5NJZZ-NVB_Mntge1XpEVlv4HI0UIaOv6Yh651VTbgIvRKzN2FG1Y6ni7ywnIfhghKHZ26FvOLJgHNi5XvqTbqyChcGUoUyra-jeS57SQUeKxA2p9xgqJFGOHaKs83YZE2Fqu6rb80saxgxKs4dk-IDAPZD1D7PRnCGp55rklUJox1K7OcVc=w360-h450-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (25, 1, N'Monument to Inventors of Petroleum Lamp', N'description....', N'https://lh3.googleusercontent.com/CYds5SFMY7Wdr7ScNCTNsA7UP5Ne_Rwb-UCqwov58HKFSiIVetXtlPOeku2yggC2ffk5nwUB-0t_E9yCAgJ7TDCC363ph5nZAb2256R0dYGNCHS0fs5aO75mmyNueCe5RLvBtuWKsfypG9LDYgyhJnwnBlK_TOxNKiwrnANA8EDui2MkyEgyTIGWPRBNsRG0fu-zHrChd-mQNzlCiRS0GwaY4QaaHLzFa4fa5d1ANhMEH1UC4nvF_tdKBHpTJUKyaH3cuYWak28g6PSnk8uvlbIPlPAxQnmiyYyDOP7fe1RoeEccM5jo1UycWF2UoogI_LbouUEElylS6NMsUdJTGZmcTtUwBfE3t3cdviRc_8FygNFJBa4jK9cDlAXlvnUaPp4stZjCJcXKcE0cnLIHRcnPBdlYr2I0TgrEJ4mp1GiJnktRTXEaw80bVv9RlUkoxAW07b5E_1Zuaz0u1NJI5-qPXK2aoZcEez7fPkMYCyCzHnb9FMO1x6qMHa7A5xMAlH9i9fYvIvcxwj7e0SJXJ_eI7dzUXuxMGNlTDEhu5dFxlF4Zc6g43GNrCMArM6BwW4Cc7D7LHQuKn7wfetxg1UsC5nr6E7BKJjtQpK462ugXGot-ZE_NNoa7gliyqPrbjg_TqyitH0U91SMrbfVXBZ5NVh0rgm0=w749-h562-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (26, 1, N'Citadel', N'description....', N'https://lh3.googleusercontent.com/lcTexquwMsrx0c2reiH_RzfQPlgog7dTsQNX6ucc_iMo65ntk8EPnPlVdvW2XBn1ZEqiy11jjSy-LX4PDyanxNZC0UPx5d_ntnl0IiG6tGZn83GyPcMln124c94m9tpBrzNX2WAm7Hdk9NdThcqesVqITlnQ0myCX9-VxMd901_y6ojp5jmw9tXOr5mixDFW2Szz6gRGjz_a4iVG2J6bulauLkeymg0OtgdIRXQa2WDy_V9sHfkqmio0sxAZtgiWAhiaSHiFL71hnOsIk1wQyR_lLeX4js13_2ISyMcvieuJV03o6j3-lRunQ7NkFs0nyFtt1Nme6S2vbeJ_1Xs_gVdRKvpOdWIqCtrBskPqKDHL2ZiAAvlJtoqGTLxUPX9X4niswq7wWV-uXFErnT_CFrakPpd0KA4Mvyr_NNvIIYj2kMWvKFTVgmSKHe9jgLMQsfJwSAGb7PMT-x8NYEHdhCrL5ryD4EL20AV86AH7qb1woyEGHJkeL-c7xoEsAYrYpHMZhpyCPDWIiQVcNpjIZK_N-y_enakcMaJ13zL9afIh3RNo0OX7Okd3swJN6P5wkSiEBrPUBFq3Rm9OdH92DOlcGyn5LywaEEo_A8XRfR99vv4m9m97FpE0nmbjqBg0mLhkUsAM2ZeP-Jmn9SnnboCbGqfLdBk=w1150-h768-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (27, 1, N'Prospekt Svobody', N'description....', N'https://lh3.googleusercontent.com/4YgZWaVA2_6bnEsywMUwvXAZPdM6jP0m4kuPqJyGfOaQcIjZNVEUcXg3GLJJbFTLndksTxmad445ZNX5z1xgO5ihylbaWE512Q8_xXQcpz0SoUN81YPNvlI5un_-eV6VIR2iVJ-212nqVWeNb5xRA4CSZeJ_vxJagvZiaodaup4Y3GNKLNeuGxEETCsdHJDh4YOA_xvjNQ0Ax7yLtMv7F9dS7TKzsrbcOL5SzAbtPTeqULqtAVk-Mky96urm9clxXpuamZONyiL0KYTUxgk0HBcpFaDukCBQEjrK6ndJWjKK-8uxw5qE9zPTADTGyVoqqmHQpidCz9S7RbsZtsY-irnxkd-DVh7h1woIwnHOlFelEtjglJE2RcvC20dqMOLAVVmwdGqGmoE2AI1PboCIQ7ZuIwpJyAnPaGyXLUfD9DyYypK8UkV0I4WzwlyGdNE2hbKjsyt_RI9Gg7XANYCBKwLvdg_ydcVjVRbWJA__y3OUrSM_JlNNRdOYrvzLUkFCaloVYlQH5lE84osoDUatOYTdgyPB5lpDb4CPE-fKMxY4Hztgotjezn9ULYrDq9we1jilQq3AqY5OfjG0fzPPs-ZoVExqjb9kNUySSX7GKNwCf_Kywyvvzkip4Wv2c3fPl8KoC9sh125SUJz4Mf1I8iEY914AGaE=w990-h669-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (28, 1, N'The House of Scientists', N'description....', N'https://lh3.googleusercontent.com/ES6xBV02VwLXEQKcOPiJ1nCSdZAjsknozyXfOQpLcDXnRchELBLKOnFWlUQqwF_4J7Xsa4vewSLmk8Ma2HhiZ1laWj8eg3eecRAnfTglJItuqdPU07pKWMaaxRSJbgGIQnm_aVS3KTNLSd-6SxDKuWJt8RL93d7MdReJtnzSmC6T7Y7Xyrp8dTeRTpja-5ecl_pLrW0dcLam_QzIVbCWBWcrGAKTMktOP1BPdAyES38mJhqca7cIzwRywrDYQ9pytXsZsFt5gyMWC6PIyZRR1iKQkW7zHqhN86s1kIHgjcvGxPTwEvcvVKNmvhB9DMY8YWWXFkDd9H8JwHAuO84avSN3eNykiVqw1wvEnUDt8Cusxiz_WlXhxmed-fHHhZpUuXeJv66J35XpBZBXE3241Hr1MnCFh6zZTLQUmQ4EMeRoSJaGC2Db3_PZir-Ji7FkK86NBWZ_o-TXGOWkqRA0tIuJi0vUc0ZT_JEXmm_qajl0aNtcMD0LvXab7Yf1CZu-vk6FH666eEHF-IX_eyWa_xqgL_ogYO9Eykxg8vKSNfO7lMw3SgbPCPfE--BtEp-wHZJiNR3q1A37TTxjQTavyiPQOnfK_6A89fiOaud34JDYH72mgNPoQFzQL5_NcOyuGvDL9dXK8SsPGtdQ40xJoLC1pFJkgHM=w848-h400-no')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (29, 5, N'Ivanova Mountain', N'Ivanova Mountain is a sacred place, people come here to feel the aura of ages, to bow down in deep honor to our ancestors, who here founded our city and many of which bone fell into this holy land. This place is abandoned by many generations of our grandfathers and great-grandfathers. Here Poltava speaks with God. Here, Poltava worships the Word, which itself is a god and which brought the Ukrainian people from the darkness of bondage and statelessness. It is not a place to drown dumplings and get drunk with a buggy', N'https://drive.google.com/uc?export=view&id=1ds6hElW3yJb6jWx_bVUk0RkAzGGHD61m')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (30, 5, N'Local history museum', N'Poltava local history museum named after Vasyl Krichevsky, an important scientific and cultural center, was founded in 1891 on the initiative of the prominent scientist professor V. V. Dokuchaev, who passed over 4000 soil samples, about 500 samples of rocks, and 862 herbarium sheets. Among the patrons and the native of the Poltava province, Katerina Skarzynskaya (1854-1932), who presented over 20 thousand exhibits and a scientific library. In the gift of the museum during 1894-1913 years, the valuable collections of oriental antiquities gave Paul Bobrovsky.', N'https://drive.google.com/uc?export=view&id=1zfK2dJ4CFabQgAnHT1X04qUXeBVuqsJF')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (31, 5, N'Round Square (Corpuscular Gardens)', N'Round Square is a historic square in Poltava, a composite center and a symbol of the city. A monument of urban planning and architecture of national importance. The basis of the classical architectural ensemble of the square was laid in 1805-1841. In the years 1840-1842, the central part of the square, planted with trees, turned into a park with a circular highway and radial avenues - Corpuscular Gardens. Composite completion of the area received in 1945-1969 after reconstruction.', N'https://drive.google.com/uc?export=view&id=113gyEnh3vrktAnEdzKVVZpcuHW9NTuYX')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (32, 5, N'Museum of Long Range Aviation', N'The Poltava Museum of Long Range Aviation is a unique aviation museum of the open air in Poltava. The museum was created on the basis of a flight launched in the 20s of the 20th century and which traveled from the civil aerodrome to provide the first passenger airline in Ukraine to one of the most powerful strategic airbases in the world. The beginning of the formation of a museum exposition can be considered 1987, when along with the training building of the 185th Guards Heavy Bomber Aviation Regiment, a legendary Tu-16 aircraft, which was equipped with long-range aviation of the USSR for nearly 40 years, was installed for a lifetime parking lot.', N'https://drive.google.com/uc?export=view&id=1BIuioBIpAqnRdln50hpb6bceoaVGC6cd')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (33, 5, N'Kotliarevsky Museum', N'Ivan Kotlyarevsky manor-museum is a memorial complex in Poltava based on the estate where in 1769 the founder of the new Ukrainian literature Ivan Petrovich Kotlyarevskyi was born. The manor-museum, which is a branch of the Poltava literary-memorial museum of I.P. Kotlyarevsky, is located next to the Assumption Cathedral, which is on the same name square, named after the writer Ivan the Hill. The farmstead is listed in the State Register of immovable monuments of Ukraine in the status of monuments of national significance. By the arrangement of the museum, the theme-based excursions "On a visit to Ivan the Hill" are arranged: a theatrical performance with the participation of Ivan Kotlyarevsky, his literary characters with the treatment of the Poltava dumplings.', N'https://drive.google.com/uc?export=view&id=1SP0Nmd5nUBPA3zMnW-ub3QM81EJwkxB2')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (34, 5, N'Field of the Poltava battle', N'The State Historical and Cultural Reserve "The Field of Poltava Battle" is a significant cultural scientific and methodological center for the study of the history of Ukraine during the XVII-XVIII centuries in the context of European history. Since 1994, the museum has a permanent exhibition "Cossack State". The media of Ukraine, Russia, Sweden and other states, scientists, and the public are interested in the activity of the reserve. The reserve "The Field of Poltava Battle" is the only one in Ukraine that belongs to the International Committee for Museums of Arms and Military History (ICOMAM), the International Organization of Military Historical Museums under the auspices of UNESCO, included in the World Tourism Route.', N'https://drive.google.com/uc?export=view&id=1pQfMCCHLcggIFnU266bVr5HZ2QZnG5Yb')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (35, 5, N'Peasant Bank in Poltava', N'The original decoration of Poltava streets is the Peasant Bank, built in the early 20th century by a famous Kyiv architect. The building, constructed in a modernist style, is a permanent place of tourist rendezvous. Interesting history and attractive architecture - this is what makes the peasant bank popular among travelers.', N'https://drive.google.com/uc?export=view&id=1EG-MX5dZcPmf8ZbdIKnzSXl8fz0uNIzE')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (36, 2, N'Aquasphera Aquapark', N'Aquapark "Aquaphera" (AquaSferra) in Donetsk (originally called Royal Marine) is one of the largest and most modern indoor water attraction park in Ukraine. It consists of an open aqua zone with swimming pools and attractions, as well as a covered entertainment zone under a transparent dome with a diameter of 85 and a height of 24 m, which operates at any time of the year and in all weather conditions. In summer, the dome of the water park moves apart, turning the entire water park into an open area.', N'https://drive.google.com/uc?export=view&id=13fuHAJvyTmvYlaTUm8iLu6c9GeqTE9V9')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (37, 2, N'Dolphinarium Nemo', N'Donetsk city dolphinarium "Nemo" - is located in the park Shcherbakova. It was opened on December 19, 2009, it works all year round. It is part of the national network of cultural and recreational complexes "Nemo", which has 5 dolphinariums in Berdyansk, Donetsk, Kiev, Odessa and Kharkov. Donetsk city dolphinarium united a dolphinarium, an oceanarium and a dolphin therapy center.', N'https://drive.google.com/uc?export=view&id=1QlvtXypEeavlurNEv9lXO3r1nQq9v9nN')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (38, 2, N'Donbass-Arena', N'"Donbass Arena" - a stadium located in the city center of Donetsk, in the park of culture and rest, opened on August 29, 2009 - Day of the miner and the day of the city of Donetsk. Designed for over 50,000 spectators and with a budget of 175.8 million euros. This is the first stadium in Eastern Europe, designed and built in accordance with the standards of the "five stars" category. According to the accreditation of UEFA and FIFA - the building corresponds to the class "elites".', N'https://drive.google.com/uc?export=view&id=1UA1hqVE72Oiw5Xtjz7MfESP5FqieOXJl')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (39, 2, N'Donetsk Botanical Garden', N'Donetsk Botanical Garden was officially founded in 1964 on the territory of the former green building of the city of Donetsk. On May 31, 1977, the Botanical Garden in Donetsk was opened for visitors. In 1983 the Donetsk Botanical Garden was recognized as a monument of landscape art of national importance and was given the status of a botanical garden of national importance. Unfortunately, after 1991, the garden area has decreased significantly, interesting plants and whole corners have disappeared from the garden collection, where the park flora of other ecosystems was presented. Since its inception, the Botanical Garden has been functioning as a research institute of the National Academy of Sciences of Ukraine. Here, research and selection of plants capable of surviving in extreme conditions of the steppe zone and an industrial city are conducted, industrial botany develops.', N'https://drive.google.com/uc?export=view&id=1bi1wm-TWXBGcVwfqAnaMt8_9jZxQExB5')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (40, 2, N'Shcherbakova Park', N'Central park of culture and rest named after A.S.Shcherbakov is a park of the city of Donetsk, located in Voroshilovsky area. Restricted from the east by the University Street, from the south - by the Stadion Street, from the west by Shakhtar Stadium, from the north by the Second City Pond. Works since 1932. The park has amusement rides, playgrounds, walkways and other recreation halls. The park is named after Alexander Sergeyevich Shcherbakov, secretary of the Donetsk Regional Party Committee of 1938. However, the original name was different, the park was named after Pavel Petrovich Postyshev, but after he was repressed, there was a renaming.', N'https://drive.google.com/uc?export=view&id=1ueQH3xZb3WnyQCFevNVE576MpzhTaNiP')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (44, 2, N'Opera and Ballet Theatre Solovyanenko', N'Donetsk Academic State Opera and Ballet Theater. A.B. Solovyanenko still remains one of the main ornaments of the city. This is an intellectual and creative face of the Donbas. The stars of the world-class vocal sing at the stage of the stage, here is a beautiful orchestra, a ballet troupe of the theater under the guidance of the Peoples Artist of Ukraine Vadim Pisarev, whom the whole world knows. The wonderful sound of the choir, which is headed by the main choirmaster of the theater Peoples Artist of Ukraine Lyudmila Streltsova, captures the countrymen and listeners of many foreign countries.', N'https://drive.google.com/uc?export=view&id=1YarFLSItyNGH8k-qLYrE8RLoqUKFmDnZ')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (45, 3, N'Alley of Glory', N'The Alley of Glory is located in one of the main urban parks of Odessa - the park named after Shevchenko. Here, in the quiet afternoon poplar, the defenders of the city found their last refuge, who died heroically in the battles of the Second World War.', N'https://drive.google.com/uc?export=view&id=18NiiHphQ_LJRYIdwRc6ukwHgCd6_hJsf')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (46, 3, N'Archaeological Museum', N'Located near the most famous street of the city - Primorsky Boulevard, and popular Odessa hotels. The Archaeological Museum is currently the oldest museum of similar profile in the territory of Ukraine and the CIS. It was founded in 1825 on the basis of a private collection of the Odessa official I.P. Blumberg, which this man presented to his hometown.', N'https://drive.google.com/uc?export=view&id=1ENCEapJvsbdKLpy54ohg_UOBam1PP2w7')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (47, 3, N'Vorontsov Lighthouse', N'The Vorontsov lighthouse in Odessa is a sea business card of the city, the first Odessa building, which is seen by the arrival of ships on the ships of the city guests. In addition, the hydraulic engineering of the tower type for many years is an excellent means of navigation, designed to indicate the safe passage of ships or passage into the harbor.', N'https://drive.google.com/uc?export=view&id=1J0Q33StVIe4QJagxQOwVVyuUTmVgAydh')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (48, 3, N'Vorontsov Palace', N'Odesa is famous for its many magnificent buildings in the "royal" Empire style, which have created its unique and attractive appearance. One of the most striking architectural monuments of the city is the Vorontsov Palace, the mansion-residence of the governor-general of the Novorossiysk Territory, Count Mikhail Vorontsov, whose twenty-year cadence is fairly regarded as the golden age for the Southern Palmyra. The palace complex, which includes, in addition to the main building, a magnificent colonnade-belvedere and farm buildings, grew up on a seaside cliff in the center of the city in the first half of the XIX century. Created with the talent and fantasy of the prominent architect Franz Boffo, the palace became one of the most beautiful of Odesas homes.', N'https://drive.google.com/uc?export=view&id=1Z9bCbR8lLJpF8tTIVV4xxLwhl4oA1C0G')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (49, 3, N'Deribasovskaya street', N'Deribasovskaya street is one of the central streets of the city of Odessa, one of the most important monuments of the city. The roadway is lined with pavement. Nowadays most of Deribasovskaya is closed for traffic and is a pedestrian zone. Deribasovskaya street is a popular place for walks, as well as for holidays such as the City Day and the Odessa Yumorin.', N'https://drive.google.com/uc?export=view&id=1cefCEEPGVwd6z0cAUD6okCNtRt-LWqzx')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (50, 3, N'Opera', N'The theater of opera and ballet by the right can be called the oldest among a number of cultural institutions of Odessa. The predecessor of the opera, the first city theater was built in 1809, when the city was only 15 years old. In previous years, the theaters of the city were acquired, having managed to grow older or entering the mature summer. The creators of the theater recognized it possible and necessary to install four busts on the sides of the semicircular part of the building, one of which - the bust of O. Pushkin, which reflected his impressions of the old Odessa city theater in the work of "Eugene Onegin", which are printed among others as addition to the novel in verse.', N'https://drive.google.com/uc?export=view&id=1huN5grBtAKvxjcMJoZTG7MSYxz9I2UOQ')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (51, 3, N'Ostap Bender Square', N'The area of Ostap Bender is located in the central part of the historic Ukrainian city of Odessa, which is the capital of the eponymous region. The area named after the famous hero of the book by the authors Ilf and Petrov "The Golden Calf" is located directly in the center of the Park "City Gardens". The area of Ostap Bender is the smallest on the planet, its area does not exceed 5 square meters.', N'https://drive.google.com/uc?export=view&id=1K4c9u2SDwbUNuFfVpo6wSv3heCGzvCuv')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (52, 3, N'Potemkin Stairs', N'Potemkin Stairs (until 1955 Boulevard Stairs, formerly the Richelieu Stairs, in the XIXth Century Giant Staircases) - known staircases in Odessa combining the city center with the harbor and the Maritime station. Today, the stairs consist of 192 steps (initially they were exactly two hundred, but with the expansion of the port, eight steps were flooded) and ten spans. The length of the stairs is 142 meters, they are built promisingly - their lower part (21.7 m in length) is much wider than the upper part (12.5 m), which makes it look the same across the entire stairs when viewed from above the stairs. The parapets of the stairs seem to be parallel and only the platforms (except for the upper march) are visible. When looking down the stairs seem longer and visible only a solid cascade steps.', N'https://drive.google.com/uc?export=view&id=13J6RrFDTl-8uzZG8SeaLcMGcBOTacW-r')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (53, 3, N'Primorsky Boulevard', N'Primorsky Boulevard (1827-1831 - New Boulevard, 1831-1857 - Primorsky Boulevard, 1857-1877 - Municipal Boulevard, 1919-1941 - Feldman Boulevard, 1877-1919, 1941-1944 - Mykolaiv Boulevard) - Street in Odessa in the historic center of the city . Stretches from the City Duma to the Vorontsov Palace. Built only one side of the boulevard, the second - a green slope to the port. The streets of Pushkin, Tchaikovsky and Vorontsovsky streets stretch to the boulevard, adjacent to the Catherine Square and the Domska Square, and from the boulevard to the passenger terminal of the port you can reach either the Potemkin stairs or the funicular.', N'https://drive.google.com/uc?export=view&id=1hKeNmKaOC5rB7aXAr67nyXVKhY-wPr-d')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (54, 3, N'Teschin bridge', N'The pedestrian bridge, the highest in Odessa, stretched over the Military Descent. "Teschin" - so named his city legend. The bridge connects two majestic palaces - the strict and graceful Vorontsovsky on the Primorsky Boulevard and the magnificent neo-Gothic Palace of Bzhozovsky on Gogol Street. From the bridge there is a beautiful view of the sea, the harbor and the city.', N'https://drive.google.com/uc?export=view&id=1RAMMUYa2PgukGvqt5AGoATO6VGYzou2O')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (55, 4, N'Zoo', N'Rivne Zoo is a zoological park of national importance in the city of Rivne. Rivne Zoo is one of the youngest in Ukraine. It began to be created in 1982 and is being built practically every day. Today its territory reaches 13.5 hectares, where 150 species of animals (about 500 specimens) live. The zoo shows 24 species of animals listed in the International Red Book and the Red Data Book of Ukraine. Rivne Zoo - the first in Ukraine, where the polar wolves from the Czech Republic were brought, and the offspring from them were received.', N'https://drive.google.com/uc?export=view&id=1Lzz9vG4Id00RZ5O1dNN7Dw9NLwD-TCjU')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (56, 4, N'Local history museum', N'Rivne Regional Museum of Local Lore - regional museum of local lore in the city of Rivne; the educational and cultural center of the city and the region, the main collection of materials and subjects of material and spiritual culture of the Rivne region. Rivne Regional Museum of Local Lore - regional museum of local lore in the city of Rivne; the educational and cultural center of the city and the region, the main collection of materials and subjects of material and spiritual culture of the Rivne region.', N'https://drive.google.com/uc?export=view&id=1Gfq1XSrrIxt4qr0iB1vZ7gIrvJH9IeCA')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (57, 4, N'Swan Lake', N'The park "Swan Lake" or "Lebedynka" is the unofficial name of the Park of Youth, which is located at the intersection of Dragomanova and Zamkova streets. The park received its second name from the lake of the same name, located in the central part of the square. Until the middle of the XX century the lake was part of the manor of the princes Lubomirski, but after the First World War the manor house was completely burnt. Later the park was partially restored, and a couple of white and black swans settled in the pond.', N'https://drive.google.com/uc?export=view&id=1es5TXhUz0Hk-BJeKJ3jAE61bIDe0rr65')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (58, 4, N'Monument to Maria Rivnens''ka', N'After five centuries, Princess Nesvytska-Rivne was in the stone just in the place where she lived and where the citys life was raging the most. It was for the reign of Maria Nesvitskaya that Rivne received the Magdeburg Law and the status of the city.', N'https://drive.google.com/uc?export=view&id=1rzt1GdKeZjW7U8v2BxmWjY3bWy2Nn7hj')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (60, 4, N'Park of Culture and Rest T. Shevchenko', N'Rivne Park of Culture and Recreation named after Taras Shevchenko - a monument of garden art of national significance. It is located in the center of the city of Rivne. Park of Culture and Recreation named after. T.G. Shevchenko in Rivne - one of the oldest parks in Ukraine, founded in the XVIII century, and is a monument of garden and park art of national significance', N'https://drive.google.com/uc?export=view&id=1RHfisCmKiy8xB7_T1QzDOvSCNXN5QghQ')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (61, 4, N'Holy Dormition Church', N'The church in the name of the Assumption of the Blessed Virgin Mary was built in 1756 on the Tytkiv suburbs at the Equal Fund of the parishioners. In the people, the temple was called Omelyanovsky, because the street for a long time had such a name - Omelyanovskaya. In the 1930s, by the efforts of the inhabitants of the street Zemsky vowel Grigory Gnatovych Lukashevich, the street was called the name of the great Ukrainian prophet. First, the church was covered with a spit, there was only one dome under the tin and three iron crosses. The churchyard was surrounded by a fence of pine boards. The wooden iconostasis of the temple was created in 1784. According to folk legends in this church, he prayed with his gaydamaks Ivan Gont before the battle with the Polish gentry.', N'https://drive.google.com/uc?export=view&id=15BwzbALZZj9YosE5c4CP7j-_s2HXHnwq')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (62, 4, N'Hill of Glory', N'The real place to honor those who perished in the war, whose gigantism and grandeur make us realize the irreparable loss and appreciate what you have. The "Hill of Glory" park contains the Monument of Eternal Glory devoted to the 40th anniversary of the liberation of the city of Rivne from the Nazi invaders, opened on May 7, 1985. It is an oblique 48.5 meters high with a sculptural composition at the foot and a relief of 18 figures. on the theme of the war.', N'https://drive.google.com/uc?export=view&id=1XPyos1Zcm_Qx-UzufyEv4Xw6H--H7ZR2')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (63, 6, N'Anthonys Caves', N'Anthonys Caves in Chernigov are a memorial to the underground religious architecture of the XI-XIX centuries. They were founded in 1069 as a cave Christian monastery by Prince Svyatoslav Yaroslavich and a well-known church figure of the Old Russian era - Prp. Anthony Pechersky, who was born in Chernihiv region in the city of Liubechi. According to the chronicle, the monastery was originally called the Theotokos (Monastery of the Mother of God). The chronicler states that Antony arrived in Chernihiv, fleeing from the anger of the prince of Kiev Izyaslav. He loved the mountain of Boldina, dug a cave, and since then, there is a monastery on the Boldine Mountains. Its foundation is closely linked to the sharp rivalry between the two largest cultural and political centers of the state - Kiev and Chernihiv.', N'https://drive.google.com/uc?export=view&id=1A0B1DmRZEqBpc6ij_QB6U3_rgaVVSEpF')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (64, 6, N'Mazepas house', N'The house was built in late 1690. The first owner was Jacob Lizogub. After the death of Lyzohub, his widow sold the house to Ivan Mazepa. From the 18th century there was a regimental office of the Chernigov Cossack Regiment. Later, the archive was moved here. For a long time, the building was not used and subjected to destruction. In 1954 for the first time there was a complete restoration of all premises. And now it pleases with all its pristine beauty and luxury. Every guest respects himself in Chernihiv comes to the house.', N'https://drive.google.com/uc?export=view&id=1IXdgsVOpPBPSIq8EbNmyGLd1l-BsoIIS')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (65, 6, N'Catherine Church', N'Catherine Church (Cossack Cathedral of the Holy Martyr Catherine of the UOC-KP) - Church of the Ukrainian Orthodox Church of Kyiv Patriarchate in the city of Chernihiv, an architectural monument of national significance. A vivid example of the stone Ukrainian architecture of the Left Bank of the XVII-XVIII centuries. Consolidated at the expense of the Cossacks, the brothers Lyzogubov (Jacob and Semen), according to the will of their father Chernigov colonel Yefim Lizogub. The church was built in memory of the heroism of the grandfather, the Chernigov colonel and the commandant Hetman of Yakov and the Cossacks of the Chernigov regiment, discovered by them during the assault of the Turkish fortress Azov in 1696.', N'https://drive.google.com/uc?export=view&id=1GhwiMTTEu_LN7rOYTlNTUjP_x12ZLCmn')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (66, 6, N'Red Square', N'Red Square (Krasna Square, formerly Kuibyshev Square) is the central square of Chernigov at the intersection of Mira Avenue, Shevchenko Street, Magistratskaya Street and Hetman Polubotka Street, where cultural and administrative institutions are concentrated. The place of the modern location of the square in the times of Kievan Rus served as the citys main trade. Over time, when Chernigov, after the destruction by the Tatar-Mongols, significantly decreased in size and population, trade was conducted on the territory of the fortress, and after its liquidation again moved to the Pyatnitsky field, which eventually became known as the Bazaar and then the Red Square. In the early 19th century. on the square were built trading rows with columns-galleries, in which local merchants opened their stores.', N'https://drive.google.com/uc?export=view&id=1DaUsCrfRH6WAhmAlUC5HS-VtiYrcGny_')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (67, 6, N'Kurgan Gulbishte', N'Located in the Chernihiv mound, the Gulbishche was first discovered and excavated by archaeologist Dmitry Samokvasov in 1872. During the excavation, many interesting things were discovered.', N'https://drive.google.com/uc?export=view&id=15nQdUMHG2EiwAHYvrgul2P9ZnKtKH3eT')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (68, 6, N'Cathedral of the Saints Boris and Hliba', N'The Cathedral of the Saints Boris and Gleb is another exhibit in the collection of Chernihiv temples. Even this is another Chernihiv temple, built by the Prince Dob (the construction was completed, probably in 1123). This is the burial ground of the princes of the Chernihiv dynasty and high-ranking clergy. And yet, this is another temple, which, as a result of numerous destruction and rebuilding, became a virtual reconstruction of the Russo-Byzantine architectural style.', N'https://drive.google.com/uc?export=view&id=1sYluync9LfkXRtgSnEj4V_URIbviTgEy')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (69, 6, N'Chernihiv Val', N'Val - the oldest part of Chernigov. Here, on the upper plateau of the right native coast of the Desna River, where it meets with one of its tributaries - Stryj, in the last quarter of the ? century there was a fortified settlement, which gave rise to the future capital of the Chernigov-Siversky principality.', N'https://drive.google.com/uc?export=view&id=1RSwh8lDBVPGTQvmRegzxCf-1-rs4p8AY')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (70, 7, N'Castle Mountain', N'The mountain on the bank of the river. Kamenka, which until the XIX century. stood a stone castle, surrounded by moats. Probably, it was founded in the 9th c. a vigilante of the Kiev princes Askold and Dir, but then he could be in another place. In the written chronicles Zhytomyr Castle was first mentioned in 1392, when the Grand Duke of Lithuania Vytautas mastered it. Later, it was repeatedly destroyed and restored. The last castle buildings were razed in 1852. Now the city square is divided into a castle, a memorial sign was erected in honor of the foundation of Zhytomyr.', N'https://drive.google.com/uc?export=view&id=1Zwq0AYrvXRoWKKhR4a_qE5QyARcE-zMm')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (71, 7, N'Baron Shoduar Park of Culture and Rest', N'Zhytomyr city park of culture and rest was named in the Soviet period by the name of the first cosmonaut Yuri Gagarin. Craftsmen say that the park with exotic trees was created by Baron de Choduar. In the early twentieth century, he built a four-story palace here.', N'https://drive.google.com/uc?export=view&id=1yggGi4NbgZVUuep5CelETbeYGL9Gk1fu')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (72, 7, N'Cathedral of St. Sophia', N'The Cathedral of St. Sophia is located on the square of Zamkova. The construction of the Catholic Cathedral ended in 1751. It is created in the Baroque style with elements of the Renaissance. The facade is divided into two tiers, the top is decorated with two sharp spire, as well as the sculpture of the Virgin Mary. The walls of the church are lined with bricks, the thickness of which reaches 2 meters, which suggests the possibility of defensive use of this structure.', N'https://drive.google.com/uc?export=view&id=1AAv-wrGTHKy0_Ay5KmMt3GqaHtlSmAVD')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (73, 7, N'Complex of Post Office facilities', N'The building complex of the Post Station in the city of Zhytomyr consists of buildings of the post office (adjacent to its main facade on both sides of the fence), hotel, stables, Yamsk services. National architectural monument [1]. Located on the former outskirts of the city at the entrance to the city of Novograd-Volynsky. Built in 1846 according to the typical project - "normal drawing" of the station building of the second level, approved in 1843, taking into account the value and size of the settlement, as well as local construction capabilities. The complex of buildings is one of the most fully preserved on the former highway Kyiv-Brest.', N'https://drive.google.com/uc?export=view&id=1n4UVoQp3BD1gze9o9A9HZTep7ExPEv8a')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (74, 7, N'Flat house', N'In the heart of Zhytomyr there is an unusual building, which surprises and enchants not only residents but also guests of the city for more than 120 years. This is a famous Flat House, located at the crossroads of Teatralna Street and Victory Square. From the windows of this building you can see the views of the Holy Transfiguration and the Cathedral and cover almost the whole area of Victory. The unique building has many popular names, and is often called its "House in the form of a heart".', N'https://drive.google.com/uc?export=view&id=1IugCVYFu2UxmtEHBSL9TpKWP9JFOtQbe')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (75, 7, N'Church of St. Michaels Archangel', N'The St. Michaels Cathedral in Zhytomyr is celebrated for 160 years from the completion of the construction and consecration - it is a monument of local significance and the church of the Ukrainian Orthodox Church of Kyiv Patriarchate. In the middle of the nineteenth century. in the city the vast majority of Orthodox churches were wooden, the stone church was only in the Russian cemetery. At the same time, only the stone Roman Catholic temples were four. The history of the temple is complex and ambiguous, the path to becoming long and often dramatic. Zhytomyr merchant Mikhail Fedorovich Habotin decided to build a temple at his own expense. His indispensable desire was to create a temple with independent, independent rights.', N'https://drive.google.com/uc?export=view&id=1AoK4NnkaCh6qSfI304SE07cxfR8L0cMD')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (76, 8, N'Admiralty', N'The building is located on the left bank of the river Ingul and plays a significant urban planning role, closing the wide and well-landscaped Garden Street, and serves as a composite center of the square formed at its intersection with the Admirals street. Surrounded by significant architectural monuments, the Admiralty successfully fits into the historically formed ensemble, orienting it to Garden Street. This is facilitated by the volumetric-spatial arrangement of the structure, built on accentuating its main axis with a spire tower.', N'https://drive.google.com/uc?export=view&id=104mWy0b6y5l44TUo_6Rjv6SKzfLLWjEh')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (77, 8, N'Admiral Street', N'Admirals Street is a street in the historic part of the city of Nikolaev. One of the most beautiful streets of Mykolayiv, a kind of open-air museum. On this street inhabited city nobility - officers of the maritime department, officials, merchants. Here there were beautiful stone two- and three-storied buildings, administrative buildings, commercial premises.', N'https://drive.google.com/uc?export=view&id=1kbicurCTbrjBNKnm_JM7nsUWAiYd5pTu')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (78, 8, N'Museum of Shipbuilding and Fleet', N'Mykolaiv Shipbuilding and Fleet Museum is the only museum of such a profile in Ukraine. He is considered a pearl of the ships edge and one of the business cards of the city of Nikolaev. An ancient building in which the museum has been located for 37 years is a monument of history and architecture of the late eighteenth and first half of the nineteenth century. Built in the style of early Russian classicism, designed by architect P. Neelov in 1793, the building served as the office and dwelling for the main commanders of the Black Sea Fleet and ports and military governors of Mykolayiv and Sevastopol during the years 1794-1900.', N'https://drive.google.com/uc?export=view&id=1LkgTXcZdiGMTTPav_N0mMKtmCVmZ8ARm')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (79, 8, N'Monument to Heavenly Hundreds', N'The height of the bronze monument without a pedestal reaches 4 meters. The sculpture symbolizes the resurrection, as well as the struggle and the world: it consists of two wings that symbolize the movement, one of them depicts the Archangel Michael, the second - the symbolic image of the Resurrection, from above two pigeons as symbols of peace.', N'https://drive.google.com/uc?export=view&id=18kIutkxLmmTPZGG3rqC-_fEj_yiVUOZQ')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (81, 8, N'Monument to Faleev', N'In 2002, before the foundation of Nikolaev, a monument to one of its founders appeared in the city. This is a monument to the first citizen of Nikolaev - Mikhail Leontievich Faleyev. Faleyev was a large landowner in Tavria. He was one of the most trusted companions of G. Potemkin and supported all his undertakings. He spent his entire life in the civil service, took an active part in the development of the Black Sea Admiralty and the construction of Nikolaev. He was buried in Nikolaev. Here still remember and honor its merits.', N'https://drive.google.com/uc?export=view&id=1iCgnCPlEUuFNGfEFpd5aUtVKVC3ugP54')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (83, 8, N'Council of Europe Square', N'A small square on Sadovaya Street in Mykolaiv is named after the Council of Europe. It was reconstructed to the 220th anniversary of the citys foundation, and opened in September 2009. It has an area of only one hectare, but is interesting with original sculptures and fountains.', N'https://drive.google.com/uc?export=view&id=1t1dFPgr7w5rOrR5PXmBPgkuarhfm2ZtH')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (84, 8, N'Fleet Boulevard', N'Fleet Boulevard - Boulevard in the historic part of the city of Nikolaev on the left bank of the river Ingul. Located along the Embankment, it is divided into the upper and lower parts. Founded on the site of the city dump by Admiral Alexey Greig and opened in 1826. It was located from the home of the Chief Commander of the Black Sea Fleet (Admiral House) to the Admiralty wall, along the Military Harbor. On the territory of the boulevard there is the Nikolaev Chess Club, the monument to Admiral Stepan Makarov, the old gun - a memorial sign in honor of the citys foundation, a childrens town, a monument to Colonel Mikhail Faleev, who directed the construction of the city and the shipyard, the fountain.', N'https://drive.google.com/uc?export=view&id=1DdA78da576Ob9mzSWH4JcAufcvaVU92s')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (85, 9, N'Pavilion', N'Like three bags, a gazebo is a real symbol of the city of Sumy. Many of the townsmiths and guests of the city, it is associated with the play of the brass band, because it is here every year that the European days and the All-Ukrainian wind music festival "Surmies of the Constitution" are held. Already more than 100 years ago a gazebo, which means "outdoor terrace" from Poland, remains a favorite place for recreation and meetings of many residents of Sumy.', N'https://drive.google.com/uc?export=view&id=1C04F8qLGnZxylmTk8x2lgFmaNIcu8XLz')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (86, 9, N'House-museum A. P. Chekhov', N'One of the museums of the famous playwright Anton Pavlovich Chekhov is in Sumy, on the Louka, not the territory of the former estate of the family of Lintvarovs, in which from 1888 to 1889 the Russian writer lived and worked. He remembered warmly about his stay in Sumy, believed that this place is in no way inferior to the most famous resorts. In one of the wings of the estate Chekhov not only created literary masterpieces, but also took patients, treating him from various diseases', N'https://drive.google.com/uc?export=view&id=1G7uxTyQ8FQ0XcoDmhCCvW8IOiv4Ekxvj')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (87, 9, N'Resurrection Church', N'Resurrection Cathedral - is the largest temple of the city of Sumy. It is him, more often than other memorials of the regional center, depicted on tourist souvenirs. Most religious buildings in Ukraine are based on legends. Resurrection Cathedral was no exception. Built in the 17th and 18th centuries, the temple became a bright representative of the style of the Ukrainian Baroque. The founder of the city G. Kondratiev actively participated in the church building. According to the legend, his sister, the atamansh of the bandit gang of Mary, was buried in the walls of the cathedral, which his brother thus punished for his atrocities.', N'https://drive.google.com/uc?export=view&id=1SJK5mq6EiDD1RaGhf1fckxgzjggI8oZD')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (88, 9, N'Childrens Park "Kazka"', N'Park "Tale" is located on twelve hectares of the former flood of the river Bag. Therefore, on its territory there are several water sources, and in the middle of the park a fountain is installed. The height of its jet reaches ten meters. There are also many quiet ground alleys that lead to various parts of the park. It is decorated with flowering flowerbeds of various shapes, and for convenience of guests there are benches on the sides of the main alley.', N'https://drive.google.com/uc?export=view&id=1Zl3xlFWhPbTKny7mJe2BMl5kbJVZfdfU')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (89, 9, N'Holy Transfiguration Cathedral', N'One of the most majestic temples of the city is the Transfiguration Cathedral. Its golden domes with three-meter sculptures of apostles and evangelists, a majestic and harmonious 56-meter bell tower with chimes - are visible from anywhere in the city. The cathedral has been functioning since the 60s of the XVII century. Cathedral church on all the old acts has always been a temple of the Transfiguration of the Lord.', N'https://drive.google.com/uc?export=view&id=15G20Se9_NLdCCT3JE_ZpvyKBDjRiGR85')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (90, 9, N'Fountain-monument Sumtsi', N'This magnificent fountain symbolizes the legend of the appearance of the city on the spot where in 1655 the Cossack settlers found three hunting bags of coins. The find was found on the site of the confluence of a small river in the river Psel. Subsequently, the river was named Bag, and soon the city grew up - Sumy. The memorial was installed in 2008 to the 335th anniversary of the citys foundation. The monument contains several elements that can be deciphered: the bag symbolizes prosperity, well-being, arch of the well, which depicts the Resurrection Church and the Transfiguration Cathedral, the celestial arches.', N'https://drive.google.com/uc?export=view&id=1xai_yVWcBTW8EaWx6WvE3nhM3rG0QJKQ')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (91, 9, N'Museum of Art', N'Sumy Regional Art Museum named after. Nikanor Onatskii was founded in 1920 by artist and public figure Nikanor Kharitonovich Onatsky (1875-1937) as a Sumy district art historic museum. This is a real treasury of national and foreign fine and decorative art of the 17th - 21st centuries, based on the artistic collection of the famous Kyiv industrialist and philanthropist Oscar Hansen.', N'https://drive.google.com/uc?export=view&id=1J4BeW6IW5Pm3oKkisqz62_ywPwMD07aB')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (92, 10, N'"Limpopo" water park', N'In the water park there are three swimming pools of different types with a total volume of about 900 m3. "Limpopo" presents a multimedia attraction "Black Hole" with light effects, stereo sound and multiprogramming capabilities. When you fly in it, you can see an incredible play of light and hear the most unexpected sounds. The height of the "Black Hole" launch is 12.5 m, and the length of this exotic "route" is 160 m.', N'https://drive.google.com/uc?export=view&id=1prqhxOlLmzOhgS26JG1kcuGqqa8BK77L')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (93, 10, N'Vozdvizhenska church', N'Church of Exaltation of the Holy Cross (Vozdvizhenska, Zdvizhenska, Nadstvenna) is the oldest temple of Ternopil, a monument of national significance, erected at the end of the XVI century. Located on Podzamchi at a low elevation above the Ternopil pond. The monument differs from other sacred defense constructions of Podillya by the presence of semicircular apse, which dates back to the Old Russian traditions.', N'https://drive.google.com/uc?export=view&id=1W6MknswTyx7XJZjFH-XKj0dj4YjaphlL')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (94, 10, N'Local history museum', N'Ternopil Regional Museum of Local Lore is the oldest cultural institution in the region. The museum recently celebrated its 95th anniversary. Collection collections of the Podillya Museum of the "Peoples School" Society, which was officially opened on April 13, 1913, became the basis of the current museum.', N'https://drive.google.com/uc?export=view&id=15Q_buBebprrmromL9l_lCRUPnafCOO63')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (95, 10, N'Museum of Political Prisoners', N'This is the largest historical memorial museum of political prisoners in Ukraine. It was opened and consecrated on October 14, 1996. The regional museum of local lore, the Institute for National Renaissance of Ukraine and the regional organization of the Union of Political Prisoners and Repressed Ukraine became the founders of the museum. The materials of the fund and the museums exposition are located in 28 former investigatory detention facilities. They convey the history of the national liberation struggle in the territories of Ternopil region.', N'https://drive.google.com/uc?export=view&id=1qPx8Iods7hygEIF3KzHM2MyVHA-UrhK9')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (96, 10, N'The old castle', N'Ternopil (Old) castle - a fortification building in the city of Ternopil, an architectural monument of national significance. Consolidated 1540-1548 on the left bank of the river Seret in the tract Sopilche to protect the southeastern borders of the Commonwealth from the attacks of the Crimean Tatars. In our time, only the palace has left the castle.', N'https://drive.google.com/uc?export=view&id=1ZXsuQ4l_-NvRJwNlL_d7a0Dgcto_Zsv8')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (97, 10, N'Teatralna square', N'The theater square is the main square of Ternopil, which together with the Taras Shevchenko Boulevard compositionally forms the modern middle ground. In the western part of the square there is the Ternopil Academic Regional Drama Theater named after them. T. G. Shevchenko, where does the name, during the Soviet Union - Theater Square, in the time of Poland, Austro-Hungary - part of the street Mitskevich, Panskoy.', N'https://drive.google.com/uc?export=view&id=1dnVkWtAoXZDuD7QuSbV7GVbNMQ20cQHk')
INSERT [dbo].[Place] ([PlaceID], [CityID], [PlaceName], [PlaceDescription], [MainPlaceImage]) VALUES (98, 10, N'Ternopil became', N'The business card of Ternopil is a huge man-made lake in the heart of the city. This picturesque place is surrounded by parks on all sides. Ternopil began to be built in the 16th century on the bogs of the River Seret almost at the same time as the city itself. Its creator is Jan Tarnavsky, crown hetman of the Ternopil castle. The lake served as a connecting link for defense installations erected to protect against Turkish-Tatar incursions. Pond knew the times of decline, and during the Second World War it was completely destroyed.', N'https://drive.google.com/uc?export=view&id=1kkkB2BnzrcAIkxJXkTRtzwcp4riZ44-i')
SET IDENTITY_INSERT [dbo].[Place] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 28.01.2018 16:11:34 ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[AspNetRoles]') AND name = N'RoleNameIndex')
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserId]    Script Date: 28.01.2018 16:11:34 ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserClaims]') AND name = N'IX_UserId')
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserId]    Script Date: 28.01.2018 16:11:34 ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserLogins]') AND name = N'IX_UserId')
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_RoleId]    Script Date: 28.01.2018 16:11:34 ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserRoles]') AND name = N'IX_RoleId')
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserId]    Script Date: 28.01.2018 16:11:34 ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserRoles]') AND name = N'IX_UserId')
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 28.01.2018 16:11:34 ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUsers]') AND name = N'UserNameIndex')
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]') AND parent_object_id = OBJECT_ID(N'[dbo].[AspNetUserClaims]'))
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]') AND parent_object_id = OBJECT_ID(N'[dbo].[AspNetUserClaims]'))
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]') AND parent_object_id = OBJECT_ID(N'[dbo].[AspNetUserLogins]'))
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]') AND parent_object_id = OBJECT_ID(N'[dbo].[AspNetUserLogins]'))
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]') AND parent_object_id = OBJECT_ID(N'[dbo].[AspNetUserRoles]'))
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]') AND parent_object_id = OBJECT_ID(N'[dbo].[AspNetUserRoles]'))
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]') AND parent_object_id = OBJECT_ID(N'[dbo].[AspNetUserRoles]'))
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]') AND parent_object_id = OBJECT_ID(N'[dbo].[AspNetUserRoles]'))
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Favorite_AspNetUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[Favorite]'))
ALTER TABLE [dbo].[Favorite]  WITH CHECK ADD  CONSTRAINT [FK_Favorite_AspNetUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Favorite_AspNetUsers]') AND parent_object_id = OBJECT_ID(N'[dbo].[Favorite]'))
ALTER TABLE [dbo].[Favorite] CHECK CONSTRAINT [FK_Favorite_AspNetUsers]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Favorite_Place]') AND parent_object_id = OBJECT_ID(N'[dbo].[Favorite]'))
ALTER TABLE [dbo].[Favorite]  WITH CHECK ADD  CONSTRAINT [FK_Favorite_Place] FOREIGN KEY([PlaceId])
REFERENCES [dbo].[Place] ([PlaceID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Favorite_Place]') AND parent_object_id = OBJECT_ID(N'[dbo].[Favorite]'))
ALTER TABLE [dbo].[Favorite] CHECK CONSTRAINT [FK_Favorite_Place]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Place__CityID__15502E78]') AND parent_object_id = OBJECT_ID(N'[dbo].[Place]'))
ALTER TABLE [dbo].[Place]  WITH CHECK ADD FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([CityID])
GO
/****** Object:  StoredProcedure [dbo].[ChangeFirstName]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChangeFirstName]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ChangeFirstName] AS' 
END
GO

ALTER procedure [dbo].[ChangeFirstName] 
			(@Id nvarchar(256), 
			@FirstName nvarchar(256))
as

IF EXISTS (
  SELECT * 
  FROM   sys.objects 
  WHERE  object_id = OBJECT_ID(N'[dbo].[ChangeFirstName]') 
         AND type IN (N'P', N'PC')
)

begin 
	begin transaction 
	Update AspNetUsers
	Set FirstName = @FirstName
	Where [AspNetUsers].Id=@Id
	commit transaction 
End
GO
/****** Object:  StoredProcedure [dbo].[ChangeLastName]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChangeLastName]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ChangeLastName] AS' 
END
GO
ALTER procedure [dbo].[ChangeLastName] 
			(@Id nvarchar(256), 
			@LastName nvarchar(256))
as

IF EXISTS (
  SELECT * 
  FROM   sys.objects 
  WHERE  object_id = OBJECT_ID(N'[dbo].[ChangeLastName]') 
         AND type IN (N'P', N'PC')
)

begin 
	begin transaction 
	Update AspNetUsers
	Set LastName = @LastName
	Where [AspNetUsers].Id=@Id
	commit transaction 
End
GO
/****** Object:  StoredProcedure [dbo].[DeleteUserFavoritePlace]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteUserFavoritePlace]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DeleteUserFavoritePlace] AS' 
END
GO







ALTER procedure [dbo].[DeleteUserFavoritePlace] (@UserId int, @PlaceID bigint) 
as

set transaction isolation level read committed

begin try
begin transaction
	begin
		delete from [dbo].[Favorite] where UserID = @UserId and PlaceID = @PlaceID
	end
	commit transaction
end try
begin catch
	rollback transaction
	raiserror('Transaction rolled back', 16, 1)
end catch


GO
/****** Object:  StoredProcedure [dbo].[GetCities]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCities]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetCities] AS' 
END
GO
ALTER procedure [dbo].[GetCities]
as

set transaction isolation level read committed 

begin transaction
	SELECT [CityID]
      ,[CityName]
      ,[CityDescription]
      ,[CityPhoto] from [Lv-284.Net_EasyTravel].[dbo].[City]
commit transaction
GO
/****** Object:  StoredProcedure [dbo].[GetCitiesIdAndNames]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCitiesIdAndNames]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetCitiesIdAndNames] AS' 
END
GO
ALTER procedure [dbo].[GetCitiesIdAndNames]
as
select CityID, CityName from [City]	
GO
/****** Object:  StoredProcedure [dbo].[GetCitiesPage]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCitiesPage]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetCitiesPage] AS' 
END
GO

ALTER procedure [dbo].[GetCitiesPage] (@PageNumber int, @PageSize int)
as

IF EXISTS (
  SELECT * 
  FROM   sys.objects 
  WHERE  object_id = OBJECT_ID(N'[dbo].[GetCitiesPage]') 
         AND type IN (N'P', N'PC')
)


begin 
	SELECT [CityID]
      ,[CityName]
      ,[CityDescription]
      ,[CityPhoto] 
	  FROM [Lv-284.Net_EasyTravel].[dbo].[City]
  order by [City].CityID Offset (@PageNumber-1)*@PageSize Rows
  Fetch Next @PageSize Rows Only;
end;
GO
/****** Object:  StoredProcedure [dbo].[GetCityById]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCityById]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetCityById] AS' 
END
GO
ALTER procedure [dbo].[GetCityById](@CityID bigint)
as

set transaction isolation level read committed 

begin transaction
	select [CityID]
      ,[CityName]
      ,[CityDescription]
      ,[CityPhoto] 
	  from [Lv-284.Net_EasyTravel].[dbo].[City]
	where @CityID = [CityID]	
commit transaction
GO
/****** Object:  StoredProcedure [dbo].[GetCountCity]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCountCity]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetCountCity] AS' 
END
GO
ALTER procedure  [dbo].[GetCountCity] 
as
begin
select COUNT ([City].CityID) as Count from [City]
end;	
GO
/****** Object:  StoredProcedure [dbo].[GetCountPlace]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCountPlace]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetCountPlace] AS' 
END
GO
ALTER procedure [dbo].[GetCountPlace](@CityID bigint) 
as
begin
select COUNT ([Place].PlaceID) as Count from [Place]
where [Place].CityID=@CityID	
end
GO
/****** Object:  StoredProcedure [dbo].[GetPlaceById]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPlaceById]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetPlaceById] AS' 
END
GO
ALTER procedure [dbo].[GetPlaceById] (@PlaceID bigint)
as

set transaction isolation level read committed 

begin transaction
	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].PlaceDescription, [Place].MainPlaceImage
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	where @PlaceID = [Place].PlaceID;
commit transaction
GO
/****** Object:  StoredProcedure [dbo].[GetPlaceByName]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPlaceByName]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetPlaceByName] AS' 
END
GO
ALTER procedure [dbo].[GetPlaceByName] (@PlaceName nvarchar(40))
as

set transaction isolation level read committed

begin transaction
	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].PlaceDescription, [Place].MainPlaceImage
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	where @PlaceName = [Place].PlaceName;
commit transaction
GO
/****** Object:  StoredProcedure [dbo].[GetPlacesByCityId]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPlacesByCityId]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetPlacesByCityId] AS' 
END
GO

ALTER procedure [dbo].[GetPlacesByCityId] (@CityID bigint)
as

set transaction isolation level read committed 

begin transaction
	--select * from [Place]
	-- where CityID = @CityID;

	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].PlaceDescription, [Place].MainPlaceImage
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	where @CityID = [Place].CityID;
commit transaction
GO
/****** Object:  StoredProcedure [dbo].[GetPlacesIdsAndNames]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPlacesIdsAndNames]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetPlacesIdsAndNames] AS' 
END
GO
ALTER procedure [dbo].[GetPlacesIdsAndNames]
as
select PlaceID, CityID, PlaceName from [Place]	
GO
/****** Object:  StoredProcedure [dbo].[GetPlacesPage]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetPlacesPage]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetPlacesPage] AS' 
END
GO
ALTER procedure [dbo].[GetPlacesPage] (@PageNumber int, @PageSize int, @CityID bigint)
as

IF EXISTS (
  SELECT * 
  FROM   sys.objects 
  WHERE  object_id = OBJECT_ID(N'[dbo].[GetPlacesPage]') 
         AND type IN (N'P', N'PC')
)


begin 
	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].PlaceDescription, [Place].MainPlaceImage
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	Where [Place].CityID=@CityID
  order by [Place].[PlaceID] Offset (@PageNumber-1)*@PageSize Rows
  Fetch Next @PageSize Rows Only;
end;
GO
/****** Object:  StoredProcedure [dbo].[GetTopPlacesByCityId]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTopPlacesByCityId]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetTopPlacesByCityId] AS' 
END
GO
ALTER procedure [dbo].[GetTopPlacesByCityId] (@CityID bigint)
as

set transaction isolation level read committed 

begin transaction

	select top 4 [PlaceID]
      ,[CityID]
      ,[PlaceName]
      ,[PlaceDescription]
      ,[MainPlaceImage] 
	  from [Place]
	where CityID = @CityID;

commit transaction
GO
/****** Object:  StoredProcedure [dbo].[GetTopPlacesByCityName]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTopPlacesByCityName]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetTopPlacesByCityName] AS' 
END
GO

ALTER procedure [dbo].[GetTopPlacesByCityName] (@CityName nvarchar(40))
as

set transaction isolation level read committed 

begin transaction

	select top 4 [PlaceID]
      ,[CityID]
      ,[PlaceName]
      ,[PlaceDescription]
      ,[MainPlaceImage]
	   from [Place]
	where CityID = (select [CityID] 
					from [dbo].[City]
					where [CityName] = @CityName)

commit transaction



GO
/****** Object:  StoredProcedure [dbo].[GetUserById]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserById]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetUserById] AS' 
END
GO

ALTER procedure [dbo].[GetUserById] (@Id nvarchar(256))
as

IF EXISTS (
  SELECT * 
  FROM   sys.objects 
  WHERE  object_id = OBJECT_ID(N'[dbo].[GetUserById]') 
         AND type IN (N'P', N'PC')
)

begin 
	select [AspNetUsers].Email, [AspNetUsers].FirstName, [AspNetUsers].LastName 
	From AspNetUsers
	Where [AspNetUsers].Id=@Id
End
GO
/****** Object:  StoredProcedure [dbo].[GetUserFavoritePlaces]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserFavoritePlaces]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetUserFavoritePlaces] AS' 
END
GO



ALTER procedure [dbo].[GetUserFavoritePlaces] (@UserID int)
as

set transaction isolation level read committed

begin transaction
	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].MainPlaceImage, [Place].CityID
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	inner join [Favorite]
	on [Place].PlaceID = [Favorite].PlaceId
	where [Favorite].UserId = @UserID;
commit transaction


GO
/****** Object:  StoredProcedure [dbo].[InsertNewUserFavoritePlace]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertNewUserFavoritePlace]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertNewUserFavoritePlace] AS' 
END
GO






ALTER procedure [dbo].[InsertNewUserFavoritePlace] (@UserId int, @PlaceID bigint) 
as

set transaction isolation level read committed

begin try
begin transaction
	if NOT EXISTS (select UserID, PlaceID from [dbo].[Favorite] where UserID = @UserId and PlaceID = @PlaceID)
	begin
		insert into [dbo].[Favorite] (UserID, PlaceID)
		values (@UserId, @PlaceID)
		select 1;
	end
	commit transaction
end try
begin catch
	rollback transaction
	raiserror('Transaction rolled back', 16, 1)
end catch


GO
/****** Object:  StoredProcedure [dbo].[IsUserEmailConfirmed]    Script Date: 28.01.2018 16:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IsUserEmailConfirmed]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[IsUserEmailConfirmed] AS' 
END
GO

ALTER procedure [dbo].[IsUserEmailConfirmed] (@Email nvarchar(40))
AS
BEGIN
set transaction isolation level read committed

begin transaction
	select EmailConfirmed from [AspNetUsers]
	where @Email = Email;
commit transaction
END
GO
USE [master]
GO
ALTER DATABASE [Lv-284.Net_EasyTravel] SET  READ_WRITE 
GO

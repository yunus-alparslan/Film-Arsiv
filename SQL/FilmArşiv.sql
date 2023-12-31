USE [FilmArşiv]
GO
/****** Object:  Table [dbo].[Table_FilmKat]    Script Date: 13.07.2023 16:09:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_FilmKat](
	[Kategoriİd] [smallint] IDENTITY(1,1) NOT NULL,
	[KategoriAd] [varchar](30) NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[Kategoriİd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_Filmler]    Script Date: 13.07.2023 16:09:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Filmler](
	[İd] [tinyint] IDENTITY(1,1) NOT NULL,
	[FilmAd] [varchar](20) NULL,
	[Kategori] [varchar](20) NULL,
	[Link] [varchar](30) NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_Table_Filmler] PRIMARY KEY CLUSTERED 
(
	[İd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Table_FilmKat] ON 

INSERT [dbo].[Table_FilmKat] ([Kategoriİd], [KategoriAd]) VALUES (1, N'Korku')
INSERT [dbo].[Table_FilmKat] ([Kategoriİd], [KategoriAd]) VALUES (2, N'Komedi')
SET IDENTITY_INSERT [dbo].[Table_FilmKat] OFF
GO
SET IDENTITY_INSERT [dbo].[Table_Filmler] ON 

INSERT [dbo].[Table_Filmler] ([İd], [FilmAd], [Kategori], [Link], [Durum]) VALUES (1, N'f', N'f', N'f', NULL)
INSERT [dbo].[Table_Filmler] ([İd], [FilmAd], [Kategori], [Link], [Durum]) VALUES (2, N'asdf', N'asd', N'asd', NULL)
INSERT [dbo].[Table_Filmler] ([İd], [FilmAd], [Kategori], [Link], [Durum]) VALUES (3, N'd', N'd', N'd', NULL)
INSERT [dbo].[Table_Filmler] ([İd], [FilmAd], [Kategori], [Link], [Durum]) VALUES (4, N'asd', N'Korku', N'dsf', NULL)
INSERT [dbo].[Table_Filmler] ([İd], [FilmAd], [Kategori], [Link], [Durum]) VALUES (5, N'f', N'Korku', N'https://youtu.be/dqz4ATge4bo', NULL)
INSERT [dbo].[Table_Filmler] ([İd], [FilmAd], [Kategori], [Link], [Durum]) VALUES (6, N'FA', N'Komedi', N'https://youtu.be/6oef7rWTVGY', NULL)
INSERT [dbo].[Table_Filmler] ([İd], [FilmAd], [Kategori], [Link], [Durum]) VALUES (7, N'test', N'Korku', N'https://youtu.be/6oef7rWTVGY', NULL)
SET IDENTITY_INSERT [dbo].[Table_Filmler] OFF
GO

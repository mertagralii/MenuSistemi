## AcunMedya Akademi'de Back-End Temel Eğitim Alırken Yapmış Olduğum Projem  

Projeyi çalıştırabilmeniz için veritabanınıza eklemeniz gereken SQL scripti:  

```sql
USE [DBMenuSistemi]
GO
/****** Object:  Table [dbo].[TBLCategory]    Script Date: 30.01.2025 19:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](50) NULL,
 CONSTRAINT [PK_TBLCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLMenu]    Script Date: 30.01.2025 19:18:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLMenu](
	[MenuId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NULL,
	[FoodName] [varchar](50) NULL,
	[FoodPrice] [int] NULL,
	[FoodImageUrl] [varchar](200) NULL,
	[FoodDescription] [varchar](100) NULL,
 CONSTRAINT [PK_TBLMenu] PRIMARY KEY CLUSTERED 
(
	[MenuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBLCategory] ON 
GO
INSERT [dbo].[TBLCategory] ([Id], [CategoryName]) VALUES (1, N'Başlangıç')
GO
INSERT [dbo].[TBLCategory] ([Id], [CategoryName]) VALUES (2, N'AnaYemek')
GO
INSERT [dbo].[TBLCategory] ([Id], [CategoryName]) VALUES (3, N'Tatlılar')
GO
INSERT [dbo].[TBLCategory] ([Id], [CategoryName]) VALUES (4, N'İçecekler')
GO
SET IDENTITY_INSERT [dbo].[TBLCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLMenu] ON 
GO
INSERT [dbo].[TBLMenu] ([MenuId], [CategoryId], [FoodName], [FoodPrice], [FoodImageUrl], [FoodDescription]) VALUES (2, 1, N'Menemen', 80, N'https://i.lezzet.com.tr/images-xxlarge-recipe/cakalli-menemen-4fa9d77d-3427-496b-8db7-ee0275108c13.jpg', N'Sucuk+Yumurta+Soğan')
GO
INSERT [dbo].[TBLMenu] ([MenuId], [CategoryId], [FoodName], [FoodPrice], [FoodImageUrl], [FoodDescription]) VALUES (3, 2, N'Pişi', 90, N'https://i.nefisyemektarifleri.com/2019/10/28/pisi-tarifi-7.jpg', N'Hamur İşi')
GO
INSERT [dbo].[TBLMenu] ([MenuId], [CategoryId], [FoodName], [FoodPrice], [FoodImageUrl], [FoodDescription]) VALUES (4, 2, N'Çorba', 100, N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQfTK8MeJ8b4Nc6paLoOUsG1J6YFQPlgK4s_g&s', N'Tereyağlı')
GO
INSERT [dbo].[TBLMenu] ([MenuId], [CategoryId], [FoodName], [FoodPrice], [FoodImageUrl], [FoodDescription]) VALUES (5, 3, N'Muhallebi', 20, N'https://i.nefisyemektarifleri.com/2021/10/15/en-kolay-muhallebi-1.jpg', N'Az Şekerli')
GO
INSERT [dbo].[TBLMenu] ([MenuId], [CategoryId], [FoodName], [FoodPrice], [FoodImageUrl], [FoodDescription]) VALUES (6, 3, N'Bal', 30, N'https://bilimgenc.tubitak.gov.tr/sites/default/files/styles/bp-770px-custom_user_desktop_1x/public/Bal.jpg?itok=_7rHMQVl', N'Organik')
GO
INSERT [dbo].[TBLMenu] ([MenuId], [CategoryId], [FoodName], [FoodPrice], [FoodImageUrl], [FoodDescription]) VALUES (7, 4, N'Çay', 5, N'https://www.popeyes.com.tr/cmsfiles/products/cay.png?v=305', N'Taze')
GO
INSERT [dbo].[TBLMenu] ([MenuId], [CategoryId], [FoodName], [FoodPrice], [FoodImageUrl], [FoodDescription]) VALUES (8, 4, N'Kahve', 7, N'https://img-kahvedunyasi.mncdn.com/kahvedunyasi/product/500x500/37bfe_Orta_Kavrulmus_Turk_Kahvesi_250g.jpg', N'Granür')
GO
INSERT [dbo].[TBLMenu] ([MenuId], [CategoryId], [FoodName], [FoodPrice], [FoodImageUrl], [FoodDescription]) VALUES (14, 1, N'Sucuklu Yumurta', 100, N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ9nT4q8U7n_4R5nbZ4a33rwHmY9lydd7ixdw&s', N'Sucuk+Yumurta')
GO
INSERT [dbo].[TBLMenu] ([MenuId], [CategoryId], [FoodName], [FoodPrice], [FoodImageUrl], [FoodDescription]) VALUES (15, 1, N'Tost', 20, N'https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRzs0AGLicivUVYuV0tpXM6PQvaawWmXASbG8jS3VXXXZwtRJu7kDQj8n3qf-_xSDxLB1G2iJ5KnupLjS_eBjrOG3ru6lAesRY1U03Eb_s', N'Çift Kaşarlı')
GO
SET IDENTITY_INSERT [dbo].[TBLMenu] OFF
GO

```


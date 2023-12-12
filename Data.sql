USE [amalCollections_db]
GO
INSERT [amal_sa].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'a262f9f3-9201-4488-93c3-f5eb7a338625', N'Customer', N'CUSTOMER', N'9bb42901-805e-41ab-8355-f5992f10197e')
GO
INSERT [amal_sa].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'ef21ec5b-55e6-4ea1-9e49-ff5017554824', N'Admin', N'ADMIN', N'2eb4483a-64eb-45ee-b224-6cf2a46ec63e')
GO
INSERT [amal_sa].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'764d3060-a174-428c-9b1a-0ad80830084a', N'Haider', N'HAIDER', NULL, NULL, 0, N'AQAAAAEAACcQAAAAEPn9hl9I5KVlLLO9tRU7ZSCR9ODhNmIuX+M/CM9bzhVo6KK/kOB96wxweG2v0Ajjlw==', N'KGAKUSEZAYDGMO4NA5KSSUHSVVBJHV26', N'16ce192b-034f-4b90-84d8-1e44d507a541', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [amal_sa].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'8d3e4b81-009b-4aa4-a34a-27c6b3d275aa', N'admin', N'ADMIN', NULL, NULL, 0, N'AQAAAAEAACcQAAAAEMPFq6OU1qgo/kpWZrx/iLfNKIwHceOnkYMsWGoPNP0T5GNqudNEIJXXNEruJ+S9HQ==', N'67HLDZIIZYBPA5TXDS2CJTK77ZGF7DGY', N'581b329f-8066-4b41-9ab2-d87c86634078', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [amal_sa].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'764d3060-a174-428c-9b1a-0ad80830084a', N'a262f9f3-9201-4488-93c3-f5eb7a338625')
GO
INSERT [amal_sa].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8d3e4b81-009b-4aa4-a34a-27c6b3d275aa', N'ef21ec5b-55e6-4ea1-9e49-ff5017554824')
GO
SET IDENTITY_INSERT [amal_sa].[Customers] ON 
GO
INSERT [amal_sa].[Customers] ([Id], [FirstName], [LastName], [Address], [City], [Country], [PostalCode], [Phone], [UserId]) VALUES (1, N'Haider', N'Haider', NULL, NULL, NULL, NULL, NULL, N'764d3060-a174-428c-9b1a-0ad80830084a')
GO
SET IDENTITY_INSERT [amal_sa].[Customers] OFF
GO
SET IDENTITY_INSERT [amal_sa].[Brands] ON 
GO
INSERT [amal_sa].[Brands] ([Id], [Name], [ImagePath], [IsActive]) VALUES (7, N'Amal Premium', N'2314a49c-7def-4aca-a256-bf09165d147a.jpg', 1)
GO
INSERT [amal_sa].[Brands] ([Id], [Name], [ImagePath], [IsActive]) VALUES (9, N'MORJA', N'004d370e-4eca-49d2-ac00-599d5580501f.jpg', 1)
GO
SET IDENTITY_INSERT [amal_sa].[Brands] OFF
GO
SET IDENTITY_INSERT [amal_sa].[Categories] ON 
GO
INSERT [amal_sa].[Categories] ([Id], [Name], [IsActive]) VALUES (1, N'All', 1)
GO
INSERT [amal_sa].[Categories] ([Id], [Name], [IsActive]) VALUES (13, N'Linen', 1)
GO
INSERT [amal_sa].[Categories] ([Id], [Name], [IsActive]) VALUES (14, N'viscous', 1)
GO
INSERT [amal_sa].[Categories] ([Id], [Name], [IsActive]) VALUES (15, N'Jacquard Viscous', 1)
GO
INSERT [amal_sa].[Categories] ([Id], [Name], [IsActive]) VALUES (16, N'Lawn Karrandi', 1)
GO
INSERT [amal_sa].[Categories] ([Id], [Name], [IsActive]) VALUES (17, N'Stapple Karrandi', 1)
GO
INSERT [amal_sa].[Categories] ([Id], [Name], [IsActive]) VALUES (18, N'2020', 1)
GO
INSERT [amal_sa].[Categories] ([Id], [Name], [IsActive]) VALUES (19, N'Dhanak', 1)
GO
INSERT [amal_sa].[Categories] ([Id], [Name], [IsActive]) VALUES (20, N'Kutail', 1)
GO
INSERT [amal_sa].[Categories] ([Id], [Name], [IsActive]) VALUES (21, N'Khaddar', 1)
GO
INSERT [amal_sa].[Categories] ([Id], [Name], [IsActive]) VALUES (22, N'Replica', 1)
GO
INSERT [amal_sa].[Categories] ([Id], [Name], [IsActive]) VALUES (23, N'Linen Bamber Dupatta', 1)
GO
INSERT [amal_sa].[Categories] ([Id], [Name], [IsActive]) VALUES (24, N'Stapple', 1)
GO
SET IDENTITY_INSERT [amal_sa].[Categories] OFF
GO
SET IDENTITY_INSERT [amal_sa].[Products] ON 
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (26, 7, 13, N'Desire Black', N'Product Detail:
Unstitched 3-Piece Suit.
Digital Printed Shirt: 3m
Digital Printed Linen Dupatta: 2.25m
Plain linen Trouser: 2.25m
Color: Black
Fabric: Linen

', 1800, 1800, CAST(N'2020-08-18T00:00:00.0000000' AS DateTime2), 1, 1, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (27, 7, 13, N'Aegian blue', N'Product Detail:
Unstitched 3-Piece Suit.
Digital Printed Shirt: 3m
Digital Printed Linen Dupatta: 2.25m
Plain linen Trouser: 2.25m
Color: Blue
Fabric: Linen

', 1800, 1800, CAST(N'2020-08-18T00:00:00.0000000' AS DateTime2), 1, 0, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (28, 7, 13, N'Floral power', N'Product Detail:
Unstitched 3-Piece Suit.
Digital Printed Shirt: 3m
Digital Printed Linen Dupatta: 2.25m
Plain linen Trouser: 2.25m
Fabric: Linen

', 1800, 1800, CAST(N'2020-08-18T00:00:00.0000000' AS DateTime2), 1, 1, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (29, 7, 13, N'Bumblebee A', N'Product Detail:
Unstitched 3-Piece Suit.
Digital Printed Shirt: 3m
Digital Printed Linen Dupatta: 2.25m
Plain linen Trouser: 2.25m
Color: Yellow
Fabric: Linen

', 1800, 1800, CAST(N'2020-08-18T00:00:00.0000000' AS DateTime2), 0, 1, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (30, 7, 13, N'Blissful', N'Product Detail:
Unstitched 3-Piece Suit.
Digital Printed Shirt: 3m
Digital Printed Linen Dupatta: 2.25m
Plain linen Trouser: 2.25m
Fabric: Linen

', 1800, 1800, CAST(N'2020-08-18T00:00:00.0000000' AS DateTime2), 0, 1, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (31, 7, 13, N'Crimson A', N'Product Detail:
Unstitched 3-Piece Suit.
Digital Printed Shirt: 3m
Digital Printed Linen Dupatta: 2.25m
Plain linen Trouser: 2.25m
Color: crimson red
Fabric: Linen

', 1800, 1800, CAST(N'2020-08-18T00:00:00.0000000' AS DateTime2), 1, 1, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (32, 7, 13, N'Floral dreams ', N'Product Detail:
Unstitched 3-Piece Suit.
Digital Printed Shirt: 3m
Digital Printed Linen Dupatta: 2.25m
Plain linen Trouser: 2.25m
Fabric: Linen

', 1800, 1800, CAST(N'2020-08-18T00:00:00.0000000' AS DateTime2), 1, 0, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (33, 7, 13, N'Fuschia', N'Product Detail:
Unstitched 3-Piece Suit.
Digital Printed Shirt: 3m
Digital Printed Linen Dupatta: 2.25m
Plain linen Trouser: 2.25m
Color: Purple
Fabric: Linen

', 1800, 1800, CAST(N'2020-08-18T00:00:00.0000000' AS DateTime2), 0, 1, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (34, 7, 13, N'Daisywood', N'Product Detail:
Unstitched 3-Piece Suit.
Digital Printed Shirt: 3m
Digital Printed Linen Dupatta: 2.25m
Plain linen Trouser: 2.25m
Fabric: Linen

', 1800, 1800, CAST(N'2020-08-18T00:00:00.0000000' AS DateTime2), 1, 1, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (35, 7, 13, N'Walnut', N'Product Detail:
Unstitched 3-Piece Suit.
Digital Printed Shirt: 3m
Digital Printed Linen Dupatta: 2.25m
Plain linen Trouser: 2.25m
Color: Brown
Fabric: Linen

', 1800, 1800, CAST(N'2020-08-18T00:00:00.0000000' AS DateTime2), 1, 0, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (36, 7, 24, N'Obsidian', N'Product Detail:
Unstitched 3-Piece Suit.
Daman Embroided Shirt: 3m
Digital Printed Bamber Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2295, 2295, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 1, 1, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (37, 7, 24, N'Magical', N'Product Detail:
Unstitched 3-Piece Suit.
Daman Embroided Shirt: 3m
Digital Printed Bamber Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2295, 2295, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 1, 1, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (38, 7, 24, N'Blossoms', N'Product Detail:
Unstitched 3-Piece Suit.
Daman Embroided Shirt: 3m
Digital Printed Bamber Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2295, 2295, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 1, 1, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (39, 7, 24, N'Starlight', N'Product Detail:
Unstitched 3-Piece Suit.
Daman Embroided Shirt: 3m
Digital Printed Bamber Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2295, 2295, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 1, 0, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (40, 7, 24, N'Summerglow', N'Product Detail:
Unstitched 3-Piece Suit.
Daman Embroided Shirt: 3m
Digital Printed Bamber Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2295, 2295, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 1, 0, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (41, 7, 24, N'Scarlet', N'Product Detail:
Unstitched 3-Piece Suit.
Daman Embroided Shirt: 3m
Digital Printed Bamber Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2295, 2295, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 1, 0, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (42, 7, 24, N'Fierce', N'Product Detail:
Unstitched 3-Piece Suit.
Daman Embroided Shirt: 3m
Digital Printed Bamber Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2295, 2295, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 1, 0, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (43, 7, 1, N'Mocca', N'Product Detail:
Unstitched 3-Piece Suit.
Daman Embroided Shirt: 3m
Digital Printed Bamber Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2295, 2295, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 1, 1, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (44, 7, 24, N'Squash', N'Product Detail:
Unstitched 3-Piece Suit.
Daman Embroided Shirt: 3m
Digital Printed Bamber Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2295, 2295, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 0, 1, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (45, 7, 24, N'Peachy shades', N'Product Detail:
Unstitched 3-Piece Suit.
Daman Embroided Shirt: 3m
Digital Printed Bamber Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2295, 2295, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 0, 1, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (46, 7, 24, N'Goldenrod', N'Product Detail:
Unstitched 3-Piece Suit.
Stapple printed Shirt: 3m
Silk cutwork Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2195, 2195, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 1, 1, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (47, 7, 24, N'Garnet', N'Product Detail:
Unstitched 3-Piece Suit.
Stapple printedShirt: 3m
Silk cutwork Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2195, 2195, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 1, 0, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (48, 7, 1, N'Black dust', N'Product Detail:
Unstitched 3-Piece Suit.
Stapple printed Shirt: 3m
Silk cutwork Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2195, 2195, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 1, 0, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (49, 7, 24, N'Pistachio', N'Product Detail:
Unstitched 3-Piece Suit.
Stapple printed Shirt: 3m
Silk cutwork Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2195, 2195, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 1, 0, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (50, 7, 1, N'Summer spice', N'Product Detail:
Unstitched 3-Piece Suit.
Stapple printed Shirt: 3m
Silk cutwork Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2195, 2195, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 1, 0, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (51, 7, 24, N'Honeydew', N'Product Detail:
Unstitched 3-Piece Suit.
Stapple printed Shirt: 3m
Silk cutwork Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2195, 2195, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 1, 1, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (52, 7, 24, N'Pinkvibes', N'Product Detail:
Unstitched 3-Piece Suit.
Stapple printed Shirt: 3m
Silk cutwork Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2195, 2195, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 1, 0, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (53, 7, 24, N'Ebony', N'Product Detail:
Unstitched 3-Piece Suit.
Stapple printed Shirt: 3m
Silk cutwork Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2195, 2195, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 1, 0, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (54, 7, 24, N'Porpoise', N'Product Detail:
Unstitched 3-Piece Suit.
Stapple printed Shirt: 3m
Silk cutwork Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2195, 2195, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 1, 0, 1)
GO
INSERT [amal_sa].[Products] ([Id], [BrandId], [CategoryId], [Name], [Description], [CostPrice], [SalePrice], [LastUpdated], [IsBestSelling], [IsFeatured], [IsActive]) VALUES (55, 7, 24, N'Ethereal Glow', N'Product Detail:
Unstitched 3-Piece Suit.
Stapple printed Shirt: 3m
Silk cutwork Dupatta: 2.25m
Plain Trouser: 2.25m
Fabric: Stapple

', 2195, 2195, CAST(N'2020-08-25T00:00:00.0000000' AS DateTime2), 1, 1, 1)
GO
SET IDENTITY_INSERT [amal_sa].[Products] OFF
GO
SET IDENTITY_INSERT [amal_sa].[ProductImages] ON 
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (48, 13, 26, N'72755d24-bc64-4e50-b6f3-7575fa424977_26.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (49, 13, 26, N'a309f6f2-1798-4ea1-bf88-bffe6fb5f27c_26.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (50, 13, 26, N'cf48e95d-b34a-43b6-8ca8-6c0c45f3d311_26.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (51, 13, 27, N'687c816a-2b22-421d-8b07-087b6db589d9_27.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (52, 13, 27, N'97601b43-1ddc-4665-a7a6-8316e0a7d35b_27.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (53, 13, 27, N'48440103-460b-423d-8b4d-68c07944a652_27.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (54, 13, 28, N'c3debdfc-e536-4345-a993-f07231004a43_28.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (55, 13, 28, N'cd817616-4f48-48e5-bec0-f2b946230501_28.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (56, 13, 28, N'977c940a-8b28-4ca5-ade8-839c31e91af7_28.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (57, 13, 29, N'f6df0795-3f19-4abb-8eb0-3b56b62913bf_29.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (58, 13, 29, N'4b2bdef9-a9ff-4fbd-b727-49675a3a2673_29.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (59, 13, 29, N'18c2037e-ccdb-4a11-8b45-338527131533_29.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (60, 13, 30, N'a6611392-dd47-417a-bfa9-8656152f2447_30.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (61, 13, 30, N'8603cb7b-b277-43c9-82b3-49aaa97e2b43_30.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (62, 13, 30, N'd4365ae1-1954-4fd6-960c-d70f456d2496_30.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (63, 13, 31, N'32570bf8-f01f-4e25-90c5-fa7aa70683fc_31.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (64, 13, 31, N'eaeedba3-9d49-4d61-900b-cd04f8009791_31.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (65, 13, 31, N'4258fbd5-56f4-4152-b4a0-556563243502_31.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (66, 13, 32, N'fbeb6ae9-316f-446e-b3e5-7ce7de48cb82_32.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (67, 13, 32, N'6cd1208e-ec73-4843-9979-cf9614f36f13_32.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (68, 13, 32, N'b3cfea34-593f-4519-ba27-e3699a18d8d3_32.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (69, 13, 33, N'f0b8409c-45a2-4c0d-8e35-b979d2fed6fc_33.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (70, 13, 33, N'd94ebfc4-fec6-48f1-8f6d-3e3fc502f4ea_33.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (71, 13, 33, N'12a56a49-2912-4b01-8946-bf32f000aa96_33.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (72, 13, 34, N'a8663d97-29db-4ec3-84bf-45f6bc9006e5_34.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (73, 13, 34, N'5d1ec4cf-02c0-446d-b7bb-9311181f4203_34.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (74, 13, 34, N'18a297b1-269d-4332-86af-e2e9a47ecfe0_34.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (75, 13, 35, N'cc4289e9-697a-40ef-9c8d-12af3a63cb23_35.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (76, 13, 35, N'fdb91284-a231-4fbd-a56e-3a57a73d2360_35.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (77, 13, 35, N'dd8ef326-59a5-4c23-987d-86a5de9cc5ee_35.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (78, 24, 36, N'43e573a4-448a-4c45-a093-2533caf842a4_36.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (79, 24, 36, N'371705d4-3c9d-4f88-b8f4-70402ce08ec4_36.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (80, 24, 36, N'de473b72-7aa8-4308-98fd-182113c599ba_36.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (81, 24, 37, N'b8e49eeb-9815-478d-8a3b-a533a2a9f547_37.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (82, 24, 37, N'77b18fcf-0beb-479b-90fa-28f9643c8b4d_37.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (83, 24, 37, N'969078c8-3e27-43a1-9fa7-275523a543e7_37.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (84, 24, 38, N'de3e6254-d30b-4baa-bf2e-b615e887c56d_38.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (85, 24, 38, N'5b960dd9-bec5-4bfa-a66b-95f01d3611b9_38.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (86, 24, 38, N'5f280591-e131-44f4-8100-42b89782c02f_38.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (87, 24, 39, N'175c7afc-4739-4b8d-9ecc-18cc37588b97_39.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (88, 24, 39, N'68894159-3e82-4758-9534-aa47a857aaea_39.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (89, 24, 39, N'c9c3aae4-5bb3-4b11-969f-447ef00f6bdd_39.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (90, 24, 40, N'0337f9ae-ddfb-4352-896b-cd4fa40b4262_40.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (91, 24, 40, N'f88fe823-93ac-4285-a495-5fba06d341cb_40.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (92, 24, 40, N'81f4843b-2228-4c11-b6fc-0e5b7fc1f0f2_40.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (93, 24, 41, N'786aef6b-0a2a-456e-bf09-c4bc246b1742_41.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (94, 24, 41, N'468cd7f4-dd39-47fa-b7a6-bf4723b6b544_41.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (95, 24, 41, N'c197f44c-8ec2-41da-98ff-b20cd4f199ea_41.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (96, 24, 42, N'df8b4941-8881-4b0e-ac80-7df67310de02_42.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (97, 24, 42, N'794869f8-3868-4e49-bd55-80e2f92d4187_42.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (98, 24, 42, N'3a954df3-1e45-445c-9dd5-360964f2d143_42.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (99, 1, 43, N'fb2cc3f8-4ea6-4dc5-b4d5-0803ef1eb99a_43.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (100, 1, 43, N'953e7ba7-0d47-472e-9fc6-02b994d12b59_43.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (101, 1, 43, N'3d885011-a979-4522-898c-1c7cf75099c4_43.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (102, 24, 44, N'e561ded4-752c-4589-9165-e16b440681c0_44.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (103, 24, 44, N'daeb59e9-d5ea-423f-9eec-587671ad2bec_44.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (104, 24, 44, N'7cffa6dc-7361-49b2-81c6-45741a81d5b3_44.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (105, 24, 45, N'26d192c2-4a81-4088-9cd2-c6cb142e8959_45.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (106, 24, 45, N'4bad1082-0e76-43db-9440-9d7135e4367e_45.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (107, 24, 45, N'ca63e928-869f-4aef-b406-034803387045_45.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (108, 24, 46, N'37e1ac96-28e1-4b10-8f5c-af588d16c97b_46.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (109, 24, 46, N'4c75b5d6-9927-4954-8b55-85eaaa762f3a_46.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (110, 24, 46, N'bbfebd3f-f18b-4c12-9656-dd45d32e21c9_46.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (111, 24, 47, N'59d253ac-fa94-40ca-884a-34a8934a8061_47.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (112, 24, 47, N'20d777c9-dacb-43ce-8906-b527cb3f9d78_47.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (113, 24, 47, N'562967e1-b81c-42c2-a658-38d2e2d04611_47.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (114, 1, 48, N'79939fcb-6519-40aa-aebf-a0e12edcc66e_48.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (115, 1, 48, N'479eb81a-50b3-468f-9173-f77b1e9454b8_48.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (116, 1, 48, N'cce901eb-2df4-4917-a5d4-120f2ec3a6f2_48.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (117, 24, 49, N'549b9622-c684-47c3-b95c-d18640fe2ecb_49.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (118, 24, 49, N'ea2f1105-66d5-44b8-949f-2446620fb237_49.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (119, 24, 49, N'c07013fb-d295-45b4-87db-d81446ec5013_49.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (120, 1, 50, N'c4ac992e-5772-4d16-9dcc-68db24ea065b_50.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (121, 1, 50, N'4051bc5d-02ff-4955-aecd-3156684352c4_50.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (122, 1, 50, N'82292f87-5372-442e-916a-d9708456efed_50.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (123, 24, 51, N'356f1d97-303f-43fe-83de-f0a95963e4d6_51.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (124, 24, 51, N'88860b60-d379-483b-b02f-cb29f1ebe72f_51.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (125, 24, 51, N'72137fc6-bfd3-4fd2-a39a-8926ef9f5fd4_51.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (126, 24, 52, N'4e8f8472-eadd-498c-969a-8fc6c49dccae_52.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (127, 24, 52, N'3b8f03e6-8d3e-48e8-bab1-19e8f71ea7f0_52.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (128, 24, 52, N'838a7b69-a0c1-4072-abf9-7ff1faf4be82_52.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (129, 24, 53, N'247a3525-7c25-41c8-b7d3-df27f4745a95_53.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (130, 24, 53, N'331293d9-a1d8-4953-891d-f73defe980ea_53.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (131, 24, 53, N'0d64358e-793c-4b06-a8a3-bb4dde7b9214_53.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (132, 24, 54, N'5ef194e0-9938-4aea-a759-807b871c2bde_54.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (133, 24, 54, N'3a0b24e7-2a52-471f-b204-23a8f83271f3_54.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (134, 24, 54, N'28a6f79e-0193-41e5-99ec-104d32aeaf9a_54.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (135, 24, 55, N'7eda9d45-e1ba-473d-8868-a110da6857b3_55.jpg', 1)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (136, 24, 55, N'685ef181-cba8-4a17-be99-9c8962880a28_55.jpg', 0)
GO
INSERT [amal_sa].[ProductImages] ([Id], [CategoryId], [ProductId], [ImagePath], [IsMain]) VALUES (137, 24, 55, N'455429f5-6b8f-4500-8d3d-85fe42579c76_55.jpg', 0)
GO
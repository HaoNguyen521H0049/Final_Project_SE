CREATE DATABASE [FinalProjectDB]
go
use FinalProjectDB
go

CREATE TABLE [dbo].[Good_Delivery_Note](
	[dateCreated] [date] NULL,
	[exportReceiptNo] [int] NOT NULL,
	[ReceiverName] [nvarchar](50) NULL,
	[issuingReason] [nvarchar](50) NULL,
	[exportFactory] [nvarchar](50) NULL,
	[FactoryLocation] [nvarchar](50) NULL,
	[IsPaid] [bit],
PRIMARY KEY CLUSTERED 
(
	[exportReceiptNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Good_Receiver](
	[dateCreated] [date] NULL,
	[receiptNo] [int] NOT NULL,
	[DeliverName] [nvarchar](50) NULL,
	[ExportReceiptNo] [int] NULL,
	[ExportDMY] [date] NULL,
	[ExportCompanyName] [nvarchar](50) NULL,
	[exportFactory] [nvarchar](50) NULL,
	[FactoryLocation] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[receiptNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login_Management](
	[username] [varchar](20) NOT NULL,
	[password] [varchar](20) NULL,
	[role] [nvarchar](10) NULL,
	[Firstname] [nvarchar](50),
	[Lastname] [nvarchar](50),
	[Email] [nvarchar](50),
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Agent_Info_details](
	[username] [varchar](20) NOT NULL,
	[exportFactory] [nvarchar](50) NULL,
	[FactoryLocation] [nvarchar](50) NULL,
	FOREIGN KEY	(username) REFERENCES Login_Management(username),
);

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop table product
drop table Receipt_details

CREATE TABLE [dbo].[Product](
	[PID] [nvarchar](20) NOT NULL ,
	[PName] [nvarchar](50) NULL,
	[PMemory] [nvarchar](10) NULL,
	[PColor] [nvarchar](20) NULL,
	[PQuantity] [int] NULL,
	[PPrice] [int] NULL,
	[img] [nvarchar](200) NOT NULL ,
PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[Receipt_details](
	[OrderID] [int] NOT NULL,
	[PID] [nvarchar](20) NULL,
	[Quantity] [int] NULL,
	[PPrice] [int],
	FOREIGN KEY	(OrderID) REFERENCES Good_Delivery_Note(exportReceiptNo),
	FOREIGN KEY	(PID) REFERENCES Product(PID),
);
go

CREATE TABLE [dbo].[Import_details](
	[OrderID] [int] NOT NULL,
	[PID] [nvarchar](20) NULL,
	[Quantity] [int] NULL,
	[PPrice] [int],
	FOREIGN KEY	(OrderID) REFERENCES Good_Receiver(receiptNo),
	FOREIGN KEY	(PID) REFERENCES Product(PID),
);
go

CREATE TABLE [dbo].[Export_Requests](
		[RequestID] [int] NOT NULL,
		[PID] [nvarchar](20) NULL,
		[Quantity] [int] NULL,
		[username] [varchar](20) NOT NULL,
		FOREIGN KEY	(PID) REFERENCES Product(PID),
		FOREIGN KEY	(username) REFERENCES Login_Management(username),
);




go
GO
INSERT [dbo].[Login_Management] ([username], [password], [role], [Firstname] ,[Lastname] ,[Email] ) VALUES (N'admin', N'admin', N'admin', N' Nguyễn Đức Nhật', N'Hào',N'521h0049@student.tdtu.edu.vn')
INSERT [dbo].[Login_Management] ([username], [password], [role], [Firstname] ,[Lastname] ,[Email] ) VALUES (N'agent', N'agent', N'agent', N'Trương Chấn ', N'Bửu',N'01234@gmail.com')
INSERT [dbo].[Login_Management] ([username], [password], [role], [Firstname] ,[Lastname] ,[Email] ) VALUES (N'chidung', N'123', N'agent', N'Lương Chí', N'Dũng',N'01234@gmail.com')
INSERT [dbo].[Login_Management] ([username], [password], [role], [Firstname] ,[Lastname] ,[Email] ) VALUES (N'vietan', N'an333', N'agent', N'Luong Viết', N'An',N'01234@gmail.com')



GO


INSERT [dbo].[Agent_Info_details] ([username], [exportFactory], [FactoryLocation]) VALUES (N'agent',N'FPT',N'342 Nguyễn T.Thập, Q2, TPHCM')
INSERT [dbo].[Agent_Info_details] ([username], [exportFactory], [FactoryLocation]) VALUES (N'agent',N'FPT',N'745 Nguyễn T.Thập, Q7, TPHCM')
INSERT [dbo].[Agent_Info_details] ([username], [exportFactory], [FactoryLocation]) VALUES (N'agent',N'FPT',N'325 Nguyễn T.Thập, Q3, TPHCM')
INSERT [dbo].[Agent_Info_details] ([username], [exportFactory], [FactoryLocation]) VALUES (N'chidung',N'GearVN',N'343 Huỳnh Tấn Phát, Q7, TPHCM')
INSERT [dbo].[Agent_Info_details] ([username], [exportFactory], [FactoryLocation]) VALUES (N'vietan',N'ThinkPro',N'544 Lê Văn Lương, Q7, TPHCM')


GO
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'GP3A64P', N'Google Pixel 3a', N'64 GB', N'Pink', 494, 421, N'https://m.media-amazon.com/images/I/616krUmHvoL._AC_SL1000_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'GP45G128B', N'Google Pixel 4a 5G', N'128 GB', N'Black', 936, 677, N'https://m.media-amazon.com/images/I/613BqZda5qS._AC_SL1500_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'GP4XL64W', N'Google Pixel 4 XL', N'64 GB', N'White', 387, 546, N'https://m.media-amazon.com/images/I/61BfbeyPaeL._AC_SL1500_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'GS20FE128G', N'Galaxy S20 FE', N'128 GB', N'Green', 864, 679, N'https://m.media-amazon.com/images/I/71CxtxJYzqL._AC_SL1500_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'GS20U128B', N'Galaxy S20 Ultra', N'128 GB', N'Black', 573, 999, N'https://m.media-amazon.com/images/I/71k4yvlyPSL._AC_SL1500_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'GS20U128S', N'Galaxy S20 Ultra', N'128 GB', N'Silver', 302, 879, N'https://m.media-amazon.com/images/I/71k4yvlyPSL._AC_SL1500_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'GS20U128W', N'Galaxy S20 Ultra', N'128 GB', N'White', 3, 567, N'https://m.media-amazon.com/images/I/71k4yvlyPSL._AC_SL1500_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'HP30P128W', N'Huawei P30 Pro', N'128 GB', N'White', 746, 668, N'https://m.media-amazon.com/images/I/51UhGxv274L._AC_SL1000_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'HP40P256S', N'Huawei P40 Pro', N'256 GB', N'Silver', 654, 468, N'https://m.media-amazon.com/images/I/41OCQnC3koL._AC_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'IP11128R', N'iPhone 11', N'128 GB', N'Red', 582, 980, N'https://m.media-amazon.com/images/I/71i2XhHU3pL._AC_SL1500_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'IP12PM512G', N'iPhone 12 Pro Max', N'512 GB', N'Gray', 239, 897, N'https://m.media-amazon.com/images/I/71fVoqRC0wL._AC_SL1500_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'IPXS32B', N'iPhone XS', N'32 GB', N'Blue', 167, 888, N'https://m.media-amazon.com/images/I/51PuFBgBK4L._AC_SL1024_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'IPXS64B', N'iPhone XS', N'64 GB', N'Blue', 12, 888, N'https://m.media-amazon.com/images/I/51PuFBgBK4L._AC_SL1024_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'IPXS128B', N'iPhone XS', N'128 GB', N'Blue', 44, 888, N'https://m.media-amazon.com/images/I/51PuFBgBK4L._AC_SL1024_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'IPXS256B', N'iPhone XS', N'256 GB', N'Blue', 673, 888, N'https://m.media-amazon.com/images/I/51PuFBgBK4L._AC_SL1024_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'IPXS512B', N'iPhone XS', N'512 GB', N'Blue', 23, 888, N'https://m.media-amazon.com/images/I/51PuFBgBK4L._AC_SL1024_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'IPXS1TB', N'iPhone XS', N'1024 GB', N'Blue', 743, 888, N'https://m.media-amazon.com/images/I/51PuFBgBK4L._AC_SL1024_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'IPXS64GN', N'iPhone XS', N'64 GB', N'Green', 0, 678, N'https://m.media-amazon.com/images/I/51PuFBgBK4L._AC_SL1024_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'IPXS64GY', N'iPhone XS', N'64 GB', N'Grey', 329, 665, N'https://m.media-amazon.com/images/I/51PuFBgBK4L._AC_SL1024_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'IPXS64P', N'iPhone XS', N'64 GB', N'Purple', 413, 886, N'https://m.media-amazon.com/images/I/51PuFBgBK4L._AC_SL1024_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'IPXS64R', N'iPhone XS', N'64 GB', N'Red', 867, 415, N'https://m.media-amazon.com/images/I/51PuFBgBK4L._AC_SL1024_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'IPXS64Y', N'iPhone XS', N'64 GB', N'Yellow', 44, 576, N'https://m.media-amazon.com/images/I/51PuFBgBK4L._AC_SL1024_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'MME7P64D', N'Motorola Moto E7 Plus', N'64 GB', N'Denim', 512, 568, N'https://m.media-amazon.com/images/I/71BadghR6nL._AC_SL1500_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'MMG2032B', N'Motorola Moto G20', N'32 GB', N'Blue', 915, 643, N'https://m.media-amazon.com/images/I/71zj7XH8flL._AC_SL1500_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'N10256B', N'Nokia 10', N'256 GB', N'Black', 257, 536, N'https://m.media-amazon.com/images/I/71Q-eGULj-S._AC_SL1500_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'N632P', N'Nokia 6', N'32 GB', N'Purple', 0, 768, N'https://m.media-amazon.com/images/I/51ws4+yNwNL._AC_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'N632PK', N'Nokia 6', N'32 GB', N'Pink', 222, 865, N'https://m.media-amazon.com/images/I/51ws4+yNwNL._AC_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'N632Y', N'Nokia 6', N'32 GB', N'Yellow', 0, 885, N'https://m.media-amazon.com/images/I/51ws4+yNwNL._AC_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'N664PK', N'Nokia 6', N'64 GB', N'Pink', 0, 854, N'https://m.media-amazon.com/images/I/51ws4+yNwNL._AC_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'N664Y', N'Nokia 6', N'64 GB', N'Yellow', 12, 999, N'https://m.media-amazon.com/images/I/51ws4+yNwNL._AC_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'OP8T256B', N'OnePlus 8T', N'256 GB', N'Blue', 779, 867, N'https://m.media-amazon.com/images/I/71ep0VfsjOL._AC_SL1500_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'OP8T256G', N'OnePlus 8T', N'256 GB', N'Green', 310, 858, N'https://m.media-amazon.com/images/I/71ep0VfsjOL._AC_SL1500_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'RN9128G', N'Redmi Note 9', N'128 GB', N'Gray', 776, 768, N'https://m.media-amazon.com/images/I/81R13dfy5RL._AC_SL1500_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'SGM53128W', N'Samsung Galaxy M53', N'128 GB', N'White', 987, 967, N'https://m.media-amazon.com/images/I/61HXZoK+EEL._AC_SL1000_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'XPX3P128G', N'Xiaomi Poco X4 Pro', N'128 GB', N'Gold', 628, 8786, N'https://m.media-amazon.com/images/I/51Da+DQffNL._AC_.jpg')
INSERT [dbo].[Product] ([PID], [PName], [PMemory], [PColor], [PQuantity], [PPrice], [img]) VALUES (N'XRN10P64B', N'Xiaomi Redmi Note 10 Pro', N'64 GB', N'Blue', 432, 866, N'https://m.media-amazon.com/images/I/51UyTHwP6wL._AC_SL1000_.jpg')
GO
INSERT [dbo].[Good_Delivery_Note] ([dateCreated], [exportReceiptNo], [ReceiverName], [issuingReason], [exportFactory], [FactoryLocation], [IsPaid]) VALUES (CAST(N'2022-01-01' AS DATE), 1, N'Nhật Hào', N'Đại lý nhập hàng', N'CellphoneS', N'182 Nguyễn T.Thập, Q7, TPHCM',0)
INSERT [dbo].[Good_Delivery_Note] ([dateCreated], [exportReceiptNo], [ReceiverName], [issuingReason], [exportFactory], [FactoryLocation], [IsPaid]) VALUES (CAST(N'2022-02-02' AS DATE), 2, N'Viết An', N'Đại lý nhập hàng', N'ThinkPro', N'544 Lê Văn Lương, Q7, TPHCM',1)
INSERT [dbo].[Good_Delivery_Note] ([dateCreated], [exportReceiptNo], [ReceiverName], [issuingReason], [exportFactory], [FactoryLocation], [IsPaid]) VALUES (CAST(N'2022-06-03' AS DATE), 3, N'Chí Dũng', N'Đại lý nhập hàng', N'GearVN', N'343 Huỳnh Tấn Phát, Q7, TPHCM',1)
INSERT [dbo].[Good_Delivery_Note] ([dateCreated], [exportReceiptNo], [ReceiverName], [issuingReason], [exportFactory], [FactoryLocation], [IsPaid]) VALUES (CAST(N'2022-08-04' AS DATE), 4, N'Chấn Bửu', N'Đại lý nhập hàng', N'FPT', N'745 Nguyễn T.Thập, Q7, TPHCM',0)
INSERT [dbo].[Good_Delivery_Note] ([dateCreated], [exportReceiptNo], [ReceiverName], [issuingReason], [exportFactory], [FactoryLocation], [IsPaid]) VALUES (CAST(N'2022-09-05' AS DATE), 5, N'Nhật Hào', N'Đại lý nhập hàng', N'CellphoneS', N'444 Lê Hoàn, Q2, TPHCM',1)
INSERT [dbo].[Good_Delivery_Note] ([dateCreated], [exportReceiptNo], [ReceiverName], [issuingReason], [exportFactory], [FactoryLocation], [IsPaid]) VALUES (CAST(N'2022-11-06' AS DATE), 6, N'Nhật Hào', N'Đại lý nhập hàng', N'CellphoneS', N'435 CMT8, Q3, TPHCM',1)
INSERT [dbo].[Good_Delivery_Note] ([dateCreated], [exportReceiptNo], [ReceiverName], [issuingReason], [exportFactory], [FactoryLocation], [IsPaid]) VALUES (CAST(N'2022-12-07' AS DATE), 7, N'Viết Duy', N'Đại lý nhập hàng', N'TheGioiDiDong', N'754 Nguyễn T.Thập, Q7, TPHCM',0)
INSERT [dbo].[Good_Delivery_Note] ([dateCreated], [exportReceiptNo], [ReceiverName], [issuingReason], [exportFactory], [FactoryLocation], [IsPaid]) VALUES (CAST(N'2023-01-08' AS DATE), 8, N'Huỳnh Đức', N'Đại lý nhập hàng', N'DMX', N'132 Nguyễn T.Thập, Q7, TPHCM',1)
INSERT [dbo].[Good_Delivery_Note] ([dateCreated], [exportReceiptNo], [ReceiverName], [issuingReason], [exportFactory], [FactoryLocation], [IsPaid]) VALUES (CAST(N'2023-01-09' AS DATE), 9, N'Nhật Hào', N'Đại lý nhập hàng', N'CellphoneS', N'32 Bàn Cờ, Q1, TPHCM',0)
INSERT [dbo].[Good_Delivery_Note] ([dateCreated], [exportReceiptNo], [ReceiverName], [issuingReason], [exportFactory], [FactoryLocation], [IsPaid]) VALUES (CAST(N'2023-02-10' AS DATE), 10, N'Chấn Bửu', N'Đại lý nhập hàng', N'FPT', N'342 Nguyễn T.Thập, Q2, TPHCM',1)
INSERT [dbo].[Good_Delivery_Note] ([dateCreated], [exportReceiptNo], [ReceiverName], [issuingReason], [exportFactory], [FactoryLocation], [IsPaid]) VALUES (CAST(N'2023-04-11' AS DATE), 11, N'Chấn Bửu', N'Đại lý nhập hàng', N'FPT', N'325 Nguyễn T.Thập, Q3, TPHCM',1)
INSERT [dbo].[Good_Delivery_Note] ([dateCreated], [exportReceiptNo], [ReceiverName], [issuingReason], [exportFactory], [FactoryLocation], [IsPaid]) VALUES (CAST(N'2023-04-12' AS DATE), 12, N'Nhật Hào', N'Đại lý nhập hàng', N'CellphoneS', N'227 Nguyễn T.Thập, Q8, TPHCM',1)
GO
insert into Receipt_details (OrderID, PID, Quantity, PPrice) values 
							(1,N'GP3A64P',100,42100),
							(1,N'IPXS128B',100,88800),
							(1,N'IPXS512B',100,88800),
							(1,N'GP3A64P',100,12300),
							(1,N'GP3A64P',100,42400),
							(2,N'GP3A64P',100,55500),
							(2,N'IPXS128B',100,41100),
							(2,N'GP3A64P',100,46400),
							(3,N'IPXS128B',100,66400),
							(4,N'IPXS128B',100,12300);
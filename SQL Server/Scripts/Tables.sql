CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Surname] [nchar](50) NULL,
	[Name] [nchar](50) NULL,
	[Login] [nchar](44) NOT NULL,
	[Password] [nchar](44) NOT NULL,
	[Email] [nchar](30) NULL,
	[Tel] [nchar](15) NULL,
	[Adress] [nchar](100) NULL,
	[AccessLevel] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_AccessLevel]  DEFAULT ((1)) FOR [AccessLevel]
GO

/****** Object:  Table [dbo].[Shipment]    Script Date: 20.06.2024 5:29:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Providers]    Script Date: 20.06.2024 5:29:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Providers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](60) NOT NULL,
	[Adress] [nvarchar](100) NULL,
	[Tel] [nvarchar](15) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Providers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [TradeReportDP]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 20.06.2024 5:29:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[PricePurchase] [int] NULL,
	[PriceSale] [int] NULL,
	[Type] [nchar](50) NULL,
	[Provider] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Providers] FOREIGN KEY([Provider])
REFERENCES [dbo].[Providers] ([Id])
GO

ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Providers]
GO

/****** Object:  Table [dbo].[Shipment]    Script Date: 20.06.2024 5:29:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Shipment](
	[Num] [int] NOT NULL,
	[Product] [int] NULL,
	[Ammount] [int] NOT NULL,
	[TradeDate] [datetime] NULL,
	[SaleDate] [datetime] NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_Shipment] PRIMARY KEY CLUSTERED 
(
	[Num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Shipment] ADD  CONSTRAINT [DF_Shipment_Ammount]  DEFAULT ((1)) FOR [Ammount]
GO

ALTER TABLE [dbo].[Shipment]  WITH CHECK ADD  CONSTRAINT [FK_Shipment_Product] FOREIGN KEY([Product])
REFERENCES [dbo].[Product] ([Id])
GO

ALTER TABLE [dbo].[Shipment] CHECK CONSTRAINT [FK_Shipment_Product]
GO

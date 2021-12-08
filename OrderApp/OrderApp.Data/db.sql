CREATE TABLE [dbo].[Item](
	[Id] [int] NULL,
	[Name] [varchar](100) NULL,
	[UnitPrice] [int] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[OrderItem](
	[OrderId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
	[Quantity] [int] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Orderr](
	[Id] [int] NOT NULL,
	[CustomerName] [varchar](100) NULL,
	[Bill] [int] NULL
) ON [PRIMARY]
GO

INSERT [dbo].[Item] ([Id], [Name], [UnitPrice]) VALUES (1, N'Biskut', 20)
GO
INSERT [dbo].[Item] ([Id], [Name], [UnitPrice]) VALUES (2, N'Choklate', 30)
GO
INSERT [dbo].[Item] ([Id], [Name], [UnitPrice]) VALUES (3, N'Toffee', 5)
GO
INSERT [dbo].[Item] ([Id], [Name], [UnitPrice]) VALUES (4, N'Nimko', 20)
GO
INSERT [dbo].[Item] ([Id], [Name], [UnitPrice]) VALUES (5, N'Lays', 50)
GO
create database product_2
go

USE [product_2]
GO

USE [product_2]
GO

CREATE TABLE [dbo].[Catalog](
	[CatalogCode] [int] primary key identity,
	[CatalogName] [nchar](100) NOT NULL,
)
GO

CREATE TABLE [dbo].[Product](
	[ProductCode] [int] primary key identity,
	[ProductName] [nchar](100) NOT NULL,
	[ProductPrice] [float] NOT NULL,
	[CatalogCode] [int] NOT NULL,
)
GO

ALTER TABLE [dbo].[Product]  WITH CHECK ADD CONSTRAINT [FK_Product_Catalog1] FOREIGN KEY([CatalogCode])
REFERENCES [dbo].[Catalog] ([CatalogCode])
GO

INSERT INTO [dbo].[Catalog]
           ([CatalogName])
     VALUES
           (N'Điện thoại'),
		   (N'Laptop'),
		   (N'PC')
GO

INSERT INTO [dbo].[Product]
           ([ProductName]
           ,[ProductPrice]
           ,[CatalogCode])
     VALUES
           (N'Laptop Acer',10000000,2),
           (N'Laptop Acer',10000000,2),
           (N'Laptop Acer',10000000,2)
GO




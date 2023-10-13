create database c_product
go

use c_product
go

CREATE TABLE Product(
	[ProductCode] [int] identity(1,1) primary key,
	[ProductName] [nvarchar](200) NOT NULL,
	[ProductPrice] [money] NULL
)
GO


INSERT INTO Product (ProductName, ProductPrice)
values ('Tiger', 210000),
	(N'Sài gòn', 200000),
	('Pepsi', 140000)
go

--SELECT*FROM Product


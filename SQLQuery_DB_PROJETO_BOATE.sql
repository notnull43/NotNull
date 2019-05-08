CREATE DATABASE DB_PROJETO_BOATE
GO

USE [DB_PROJETO_BOATE]
GO

CREATE TABLE Clients
(
	IdCli int identity primary key,
	NamCli nvarchar(100) not null,
	AdrCli nvarchar(100),
	NumCli nvarchar(10),
	DisCli nvarchar (50),
	CitCli nvarchar(50),
	StaCli nchar(2),
	BirthCli date,
	CelCli nvarchar(15),
	CPFCli nvarchar(15),
	RGCli nvarchar(15),
	SEXO bit,
	IdProd int,
)

CREATE TABLE Products
(
	IdProd int identity primary key,
	CatProd nvarchar (100),
	NamProd nvarchar(100) not null,
	PriceCost decimal (9,2),
	PriceSale decimal (9,2),
	StockProd int,
)

alter table Clients
	add constraint fk_Rroducts_Clients
		foreign key(IdProd) references Products (IdProd);
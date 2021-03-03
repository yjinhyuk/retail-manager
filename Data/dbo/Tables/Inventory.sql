﻿CREATE TABLE [dbo].[Inventory]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ProductId] NCHAR(10) NOT NULL, 
    [Quantity] NCHAR(10) NOT NULL DEFAULT 1, 
    [PurchasePrice] MONEY NOT NULL, 
    [PurchaseDate] DATETIME2 NOT NULL DEFAULT getutcdate()
)

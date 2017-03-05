CREATE TABLE [dbo].SystemPC
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] CHAR(32) NULL, 
    [Price] FLOAT NULL, 
    [Guid] CHAR(32) NULL, 
    [InventoryQuantity] INT NULL, 
    [OrderedQuantity] INT NULL, 
    [DeliveredQuantity] INT NULL
)

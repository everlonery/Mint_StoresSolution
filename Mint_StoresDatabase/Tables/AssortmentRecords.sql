CREATE TABLE [dbo].[AssortmentRecords]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StoreId] INT NULL, 
    [ProductId] INT NULL, 
    [Quantity] INT NOT NULL, 
    [UnitId] INT NULL, 
    [IdTaxGroup] INT NULL, 
    CONSTRAINT [FK_AssortmentRecords_Stores] FOREIGN KEY ([StoreId]) REFERENCES [Stores]([StoreId]) ON DELETE SET NULL, 
    CONSTRAINT [FK_AssortmentRecords_Products] FOREIGN KEY ([ProductId]) REFERENCES [Products]([ProductId]) ON DELETE SET NULL, 
    CONSTRAINT [FK_AssortmentRecords_MeasurementUnits] FOREIGN KEY ([UnitId]) REFERENCES [MeasurementUnits]([Id]) ON DELETE SET NULL, 
    CONSTRAINT [FK_AssortmentRecords_TaxGroups] FOREIGN KEY ([IdTaxGroup]) REFERENCES [TaxGroups]([Id]) ON DELETE SET NULL
)

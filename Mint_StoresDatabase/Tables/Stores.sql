CREATE TABLE [dbo].[Stores]
(
	[StoreId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Phone] NVARCHAR(20) NOT NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Address] NVARCHAR(50) NULL, 
    [ZipCode] INT NOT NULL, 
    [CityId] INT NULL, 
    CONSTRAINT [FK_Stores_Cities] FOREIGN KEY ([CityId]) REFERENCES [Cities]([CityId]) ON DELETE SET NULL 
)

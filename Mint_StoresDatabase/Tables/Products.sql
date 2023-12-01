CREATE TABLE [dbo].[Products]
(
	[ProductId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Price] MONEY NOT NULL, 
    [CategoryId] INT NULL, 
    [IsForAdults] BIT NOT NULL, 
    [IsExcise] BIT NOT NULL, 
    [PicturePath] NVARCHAR(100) NULL, 
    CONSTRAINT [FK_Products_Categories] FOREIGN KEY ([CategoryId]) REFERENCES [Categories]([CategoryId]) ON DELETE SET NULL
)

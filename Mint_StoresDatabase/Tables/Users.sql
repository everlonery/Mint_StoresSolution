CREATE TABLE [dbo].[Users]
(
	[UserId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [ParentName] NVARCHAR(50) NOT NULL, 
    [BirthDate] DATE NOT NULL, 
    [IsActive] BIT NOT NULL, 
    [Phone] NVARCHAR(20) NOT NULL, 
    [Email] NVARCHAR(50) NULL 
)

CREATE TABLE [dbo].[EmploymentRecords]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StoreId] INT NULL, 
    [UserId] INT NULL, 
    [EmploymentDate] DATE NOT NULL, 
    [TerminationDate] DATE NULL, 
    CONSTRAINT [FK_EmploymentRecords_Stores] FOREIGN KEY ([StoreId]) REFERENCES [Stores]([StoreId]) ON DELETE SET NULL, 
    CONSTRAINT [FK_EmploymentRecords_Users] FOREIGN KEY ([UserId]) REFERENCES [Users]([UserId]) ON DELETE SET NULL
)

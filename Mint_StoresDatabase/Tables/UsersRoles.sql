CREATE TABLE [dbo].[UsersRoles]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] INT NULL, 
    [RoleId] INT NULL, 
    CONSTRAINT [FK_UsersRoles_Users] FOREIGN KEY ([UserId]) REFERENCES [Users]([UserId]) ON DELETE SET NULL, 
    CONSTRAINT [FK_UsersRoles_Roles] FOREIGN KEY ([RoleId]) REFERENCES [Roles]([RoleId]) ON DELETE SET NULL
)

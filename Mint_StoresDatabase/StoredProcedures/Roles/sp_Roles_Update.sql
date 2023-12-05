CREATE PROCEDURE [dbo].[sp_Roles_Update]
	@RoleId INT,
	@Name NVARCHAR(50)
AS
	UPDATE Roles
	SET Name = @Name
	WHERE RoleId = @RoleId
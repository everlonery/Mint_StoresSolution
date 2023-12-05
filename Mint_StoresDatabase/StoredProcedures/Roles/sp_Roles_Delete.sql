CREATE PROCEDURE [dbo].[sp_Roles_Delete]
	@RoleId INT
AS
	DELETE 
	FROM Roles
	WHERE RoleId = @RoleId

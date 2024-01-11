CREATE PROCEDURE [dbo].[sp_UsersRoles_Update]
	@Id INT,
	@UserId INT,
	@RoleId INT
AS
	UPDATE UsersRoles
	SET UserId = @UserId, RoleId = @RoleId
	WHERE Id = @Id

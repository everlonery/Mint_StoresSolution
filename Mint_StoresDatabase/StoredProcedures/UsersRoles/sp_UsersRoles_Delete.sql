CREATE PROCEDURE [dbo].[sp_UsersRoles_Delete]
	@Id INT
AS
	DELETE FROM UsersRoles
	WHERE Id = @Id

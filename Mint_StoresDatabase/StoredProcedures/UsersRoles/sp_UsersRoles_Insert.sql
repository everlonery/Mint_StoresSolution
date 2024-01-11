CREATE PROCEDURE [dbo].[sp_UsersRoles_Insert]
	@UserId INT,
	@RoleId INT
AS
	INSERT INTO UsersRoles(UserId, RoleId)
	VALUES(@UserId, @RoleId)

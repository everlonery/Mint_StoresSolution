CREATE PROCEDURE [dbo].[sp_UsersRoles_Select]
AS
	SELECT Id, UserId, RoleId
	FROM UsersRoles

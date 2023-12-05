CREATE PROCEDURE [dbo].[sp_Users_Delete]
	@UserId INT
AS
	DELETE 
	FROM Users
	WHERE UserId = @UserId
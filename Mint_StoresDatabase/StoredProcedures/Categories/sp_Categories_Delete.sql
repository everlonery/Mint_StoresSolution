CREATE PROCEDURE [dbo].[sp_Categories_Delete]
	@CategoryId INT
AS
	DELETE 
	FROM Categories
	WHERE CategoryId = @CategoryId

CREATE PROCEDURE [dbo].[sp_Categories_Update]
	@CategoryId INT,
	@Name NVARCHAR(50),
	@ParentId INT
AS
	UPDATE Categories
	SET Name = @Name, ParentId = @ParentId
	WHERE CategoryId = @CategoryId

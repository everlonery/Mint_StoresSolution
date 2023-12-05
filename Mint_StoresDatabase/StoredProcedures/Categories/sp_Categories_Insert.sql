CREATE PROCEDURE [dbo].[sp_Categories_Insert]
	@Name NVARCHAR(50),
	@ParentId INT
AS
	INSERT
	INTO Categories(Name, ParentId)
	VALUES(@Name, @ParentId)

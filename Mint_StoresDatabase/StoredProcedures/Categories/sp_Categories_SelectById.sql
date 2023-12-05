CREATE PROCEDURE [dbo].[sp_Categories_SelectById]
	@CategoryId INT
AS
	SELECT CategoryId, Name, ParentId
	FROM Categories
	
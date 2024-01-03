CREATE PROCEDURE [dbo].[sp_Stores_Delete]
	@StoreId INT
AS
	DELETE
	FROM Stores
	WHERE StoreId = @StoreId

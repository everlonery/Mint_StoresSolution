CREATE PROCEDURE [dbo].[sp_Products_Delete]
	@ProductId INT
AS
	DELETE FROM Products
	WHERE ProductId = @ProductId

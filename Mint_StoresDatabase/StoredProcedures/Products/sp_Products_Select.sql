CREATE PROCEDURE [dbo].[sp_Products_Select]
AS
	SELECT ProductId, Name, Price, CategoryId, IsForAdults, IsExcise, PicturePath
	FROM Products

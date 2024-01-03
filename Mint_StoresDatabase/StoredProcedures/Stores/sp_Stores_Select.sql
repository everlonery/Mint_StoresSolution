CREATE PROCEDURE [dbo].[sp_Stores_Select]
AS
	SELECT StoreId, Name, Phone, Email, Address, ZipCode, CityId
	FROM Stores

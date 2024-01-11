CREATE PROCEDURE [dbo].[sp_Assortment_Select]
AS
	SELECT Id, StoreId, ProductId, Quantity, UnitId, TaxGroupId
	FROM AssortmentRecords

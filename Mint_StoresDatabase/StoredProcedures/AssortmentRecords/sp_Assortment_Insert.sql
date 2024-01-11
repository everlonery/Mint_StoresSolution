CREATE PROCEDURE [dbo].[sp_Assortment_Insert]
	@StoreId INT, 
	@ProductId INT, 
	@Quantity INT, 
	@UnitId INT, 
	@TaxGroupId INT
AS
	INSERT INTO AssortmentRecords(StoreId, ProductId, Quantity, UnitId, TaxGroupId)
	VALUES(@StoreId, @ProductId, @Quantity, @UnitId, @TaxGroupId)

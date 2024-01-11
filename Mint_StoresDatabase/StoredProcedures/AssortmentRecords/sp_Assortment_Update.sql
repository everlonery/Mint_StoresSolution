CREATE PROCEDURE [dbo].[sp_Assortment_Update]
	@Id INT,
	@StoreId INT, 
	@ProductId INT, 
	@Quantity INT, 
	@UnitId INT, 
	@TaxGroupId INT
AS
	UPDATE AssortmentRecords
	SET StoreId = @StoreId, ProductId = @ProductId, Quantity = @Quantity, UnitId = @UnitId, TaxGroupId = @TaxGroupId
	WHERE Id = @Id

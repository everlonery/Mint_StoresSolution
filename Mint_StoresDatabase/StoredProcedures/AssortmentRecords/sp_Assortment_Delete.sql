CREATE PROCEDURE [dbo].[sp_Assortment_Delete]
	@Id INT
AS
	DELETE FROM AssortmentRecords
	WHERE Id = @Id

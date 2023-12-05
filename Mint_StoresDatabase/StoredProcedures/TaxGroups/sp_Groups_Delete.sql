CREATE PROCEDURE [dbo].[sp_Groups_Delete]
	@Id INT
AS
	DELETE 
	FROM TaxGroups
	WHERE Id = @Id

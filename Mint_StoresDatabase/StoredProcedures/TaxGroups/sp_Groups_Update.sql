CREATE PROCEDURE [dbo].[sp_Groups_Update]
	@Id INT,
	@Name NVARCHAR(50)
AS
	UPDATE TaxGroups
	SET Name = @Name
	WHERE Id = @Id

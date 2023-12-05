CREATE PROCEDURE [dbo].[sp_Units_Update]
	@Id INT,
	@Name NVARCHAR(50)
AS
	UPDATE MeasurementUnits
	SET Name = @Name
	WHERE Id = @Id

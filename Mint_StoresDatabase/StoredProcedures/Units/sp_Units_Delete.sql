CREATE PROCEDURE [dbo].[sp_Units_Delete]
	@Id INT
AS
	DELETE 
	FROM MeasurementUnits
	WHERE Id = @Id
CREATE PROCEDURE [dbo].[sp_Units_Insert]
	@Name NVARCHAR(50)
AS
	INSERT
	INTO MeasurementUnits(Name)
	VALUES(@Name)
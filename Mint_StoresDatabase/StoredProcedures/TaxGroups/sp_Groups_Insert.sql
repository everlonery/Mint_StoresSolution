CREATE PROCEDURE [dbo].[sp_Groups_Insert]
	@Name NVARCHAR(50)
AS
	INSERT
	INTO TaxGroups(Name)
	VALUES(@Name)

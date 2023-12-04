CREATE PROCEDURE [dbo].[sp_Cities_Insert]
	@Name NVARCHAR(50)
AS
	INSERT
	INTO Cities(Name)
	VALUES(@Name)


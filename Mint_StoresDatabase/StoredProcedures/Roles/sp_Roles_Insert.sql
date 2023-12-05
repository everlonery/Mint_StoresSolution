CREATE PROCEDURE [dbo].[sp_Roles_Insert]
	@Name NVARCHAR(50)
AS
	INSERT
	INTO Roles(Name)
	VALUES(@Name)
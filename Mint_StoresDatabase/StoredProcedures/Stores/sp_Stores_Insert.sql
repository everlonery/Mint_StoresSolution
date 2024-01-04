CREATE PROCEDURE [dbo].[sp_Stores_Insert]
	@Name NVARCHAR(50),
	@Phone NVARCHAR(20),
	@Email NVARCHAR(50),
	@Address NVARCHAR(50),
	@ZipCode int,
	@CityId int
AS
	INSERT
	INTO Stores(Name, Phone, Email, Address, ZipCode, CityId)
	VALUES(@Name, @Phone, @Email, @Address, @ZipCode, @CityId)

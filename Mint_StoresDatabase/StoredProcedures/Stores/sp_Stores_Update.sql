CREATE PROCEDURE [dbo].[sp_Stores_Update]
	@StoreId INT,
	@Name NVARCHAR(50),
	@Phone NVARCHAR(20),
	@Email NVARCHAR(50),
	@Address NVARCHAR(50),
	@ZipCode int,
	@CityId int
AS
	UPDATE Stores
	SET Name = @Name,
		Phone = @Phone,
		Email = @Email,
		Address = @Address,
		ZipCode = @ZipCode,
		CityId = @CityId
	WHERE StoreId = @StoreId

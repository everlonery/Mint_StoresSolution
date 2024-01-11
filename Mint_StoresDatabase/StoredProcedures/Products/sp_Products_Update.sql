CREATE PROCEDURE [dbo].[sp_Products_Update]
	@ProductId INT,
	@Name NVARCHAR(50), 
	@Price MONEY, 
	@CategoryId INT, 
	@IsForAdults BIT, 
	@IsExcise BIT, 
	@PicturePath NVARCHAR(100)
AS
	UPDATE Products
	SET Name = @Name, Price = @Price, CategoryId = @CategoryId, IsForAdults = @IsForAdults, IsExcise = @IsExcise, PicturePath = @PicturePath
	WHERE ProductId = @ProductId
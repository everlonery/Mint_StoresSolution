CREATE PROCEDURE [dbo].[sp_Products_Insert]
	@Name NVARCHAR(50), 
	@Price MONEY, 
	@CategoryId INT, 
	@IsForAdults BIT, 
	@IsExcise BIT, 
	@PicturePath NVARCHAR(100)
AS
	INSERT
	INTO Products(Name, Price, CategoryId, IsForAdults, IsExcise, PicturePath)
	VALUES(@Name, @Price, @CategoryId, @IsForAdults, @IsExcise, @PicturePath)
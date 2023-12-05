CREATE PROCEDURE [dbo].[sp_Users_Insert]
	@LastName NVARCHAR(50),
	@FirstName NVARCHAR(50),
	@ParentName NVARCHAR(50),
	@BirthDate DATE,
	@IsActive BIT,
	@Phone NVARCHAR(50),
	@Email NVARCHAR(50)
AS
	INSERT
	INTO Users(LastName, FirstName, ParentName, BirthDate, IsActive, Phone, Email)
	VALUES(@LastName, @FirstName, @ParentName, @BirthDate, @IsActive, @Phone, @Email)
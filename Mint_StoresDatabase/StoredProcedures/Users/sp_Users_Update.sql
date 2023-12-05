CREATE PROCEDURE [dbo].[sp_Users_Update]
	@UserId INT,
	@LastName NVARCHAR(50),
	@FirstName NVARCHAR(50),
	@ParentName NVARCHAR(50),
	@BirthDate DATE,
	@IsActive BIT,
	@Phone NVARCHAR(50),
	@Email NVARCHAR(50)
AS
	UPDATE Users
	SET LastName = @LastName, 
	FirstName = @FirstName, 
	ParentName = @ParentName, 
	BirthDate = @BirthDate, 
	IsActive = @IsActive, 
	Phone = @Phone, 
	Email = @Email
	WHERE UserId = @UserId

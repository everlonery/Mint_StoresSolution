CREATE PROCEDURE [dbo].[sp_Cities_Update]
	@CityId INT,
	@Name NVARCHAR(50)
AS
	UPDATE Cities
	SET Name = @Name
	WHERE CityId = @CityId
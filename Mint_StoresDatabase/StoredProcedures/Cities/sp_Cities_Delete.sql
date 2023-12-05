CREATE PROCEDURE [dbo].[sp_Cities_Delete]
	@CityId INT
AS
	DELETE 
	FROM Cities
	WHERE CityId = @CityId

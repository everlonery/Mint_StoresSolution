CREATE PROCEDURE [dbo].[sp_Employment_Insert]
	@StoreId INT,
	@UserId INT, 
	@EmploymentDate DATE, 
	@TerminationDate DATE
AS
	INSERT INTO EmploymentRecords(StoreId, UserId, EmploymentDate, TerminationDate)
	VALUES(@StoreId, @UserId, @EmploymentDate, @TerminationDate)


CREATE PROCEDURE [dbo].[sp_Employment_Update]
	@Id INT, 
	@StoreId INT,
	@UserId INT, 
	@EmploymentDate DATE, 
	@TerminationDate DATE
AS
	UPDATE EmploymentRecords
	SET StoreId = @StoreId, UserId = @UserId, EmploymentDate = @EmploymentDate, TerminationDate = @TerminationDate
	WHERE Id = @Id
CREATE PROCEDURE [dbo].[sp_Employment_Delete]
	@Id INT
AS
	DELETE FROM EmploymentRecords
	WHERE Id = @Id
	
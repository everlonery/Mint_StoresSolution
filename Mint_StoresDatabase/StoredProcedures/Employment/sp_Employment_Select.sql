CREATE PROCEDURE [dbo].[sp_Employment_Select]
AS
	SELECT Id, StoreId, UserId, EmploymentDate, TerminationDate
	FROM EmploymentRecords

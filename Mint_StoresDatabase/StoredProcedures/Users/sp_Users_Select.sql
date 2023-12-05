CREATE PROCEDURE [dbo].[sp_Users_Select]
AS
SELECT UserId, LastName, FirstName, ParentName, BirthDate, IsActive, Phone, Email 
FROM Users 

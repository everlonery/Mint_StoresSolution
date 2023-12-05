CREATE PROCEDURE [dbo].[sp_Categories_Select]
AS
SELECT CategoryId, Name, ParentId 
FROM Categories
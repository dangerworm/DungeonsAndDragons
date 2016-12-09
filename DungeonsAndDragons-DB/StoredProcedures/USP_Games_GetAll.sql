CREATE PROCEDURE [dbo].[USP_Games_GetAll]
AS

SELECT
    [GameId],
    [Name],
    [StartDate]
FROM
    dbo.Games

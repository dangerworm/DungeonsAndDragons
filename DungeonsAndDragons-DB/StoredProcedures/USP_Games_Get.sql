CREATE PROCEDURE [dbo].[USP_Games_Get]
@GameId INT
AS

SELECT
    [GameId],
    [Name],
    [StartDate]
FROM
    dbo.Games
WHERE
    GameId = @GameId

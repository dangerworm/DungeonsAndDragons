CREATE PROCEDURE [dbo].[USP_Games_Update]
	@GameId INT,
	@Name VARCHAR(50),
	@StartDate DATETIME2(3)
AS
BEGIN

UPDATE dbo.Games
SET
	[Name] = @Name,
	[StartDate] = @StartDate
WHERE [GameId] = ISNULL(@GameId, 0)

RETURN @@ROWCOUNT;

END

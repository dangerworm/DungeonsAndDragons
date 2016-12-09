CREATE PROCEDURE [dbo].[USP_Games_Create]
	@GameId INT = NULL OUTPUT,
	@Name VARCHAR(50),
	@StartDate DATETIME2(3) = SYSDATETIME
AS

IF NOT EXISTS (
	SELECT 1
	FROM dbo.Games
	WHERE
	[GameId] = ISNULL(@GameId, 0)
)
BEGIN
INSERT INTO dbo.Games (
	[Name],
	[StartDate]
)
VALUES (
	@Name,
	@StartDate
)

SELECT @GameId = SCOPE_IDENTITY()

RETURN @@ROWCOUNT
END

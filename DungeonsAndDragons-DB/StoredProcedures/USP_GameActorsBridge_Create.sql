CREATE PROCEDURE [dbo].[USP_GameActorsBridge_Create]
	@GameId INT,
	@ActorId INT
AS

IF NOT EXISTS(
SELECT 1 
FROM dbo.GameActorsBridge
WHERE
	GameId = @GameId AND
	ActorId = @ActorId
)
BEGIN
INSERT INTO dbo.GameActorsBridge(GameId, ActorId)
VALUES(@GameId, @ActorId)
END

RETURN @@ROWCOUNT

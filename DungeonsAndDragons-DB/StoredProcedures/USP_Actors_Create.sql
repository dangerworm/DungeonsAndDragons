CREATE PROCEDURE [dbo].[USP_Actors_Create]
@ActorId INT = NULL OUTPUT,
@ActorTypeId INT,
@MapAreaId INT
AS

IF NOT EXISTS (
SELECT 1
FROM dbo.Actors
WHERE
[ActorId] = ISNULL(@ActorId, 0)
)
BEGIN
INSERT INTO dbo.Actors (
[ActorTypeId],
[MapAreaId]
)
VALUES (
@ActorTypeId,
@MapAreaId
)

SELECT @ActorId = SCOPE_IDENTITY()

RETURN @@ROWCOUNT
END

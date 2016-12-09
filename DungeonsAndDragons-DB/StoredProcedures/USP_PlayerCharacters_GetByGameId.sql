CREATE PROCEDURE [dbo].[USP_PlayerCharacters_GetByGameId]
@GameId INT
AS

SELECT
    PC.[PlayerCharacterId],
    PC.[ActorId],
    PC.[Name],
    PC.[ClassId],
    PC.[ParagonPathId],
    PC.[EpicDestinyId],
    PC.[ExperiencePoints],
    PC.[RaceId],
    PC.[Age],
    PC.[GenderId],
    PC.[Height],
    PC.[WeightPounds],
    PC.[AlignmentId],
    PC.[DeityId],
    PC.[Picture]
FROM
    dbo.PlayerCharacters PC
	INNER JOIN dbo.GameActorsBridge GAB ON GAB.ActorId = PC.ActorId
WHERE
    GAB.GameId = @GameId

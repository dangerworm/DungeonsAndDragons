CREATE PROCEDURE [dbo].[USP_PlayerCharacters_GetAll]
AS

SELECT
    [PlayerCharacterId],
    [ActorId],
    [Name],
    [ClassId],
    [ParagonPathId],
    [EpicDestinyId],
    [ExperiencePoints],
    [RaceId],
    [Age],
    [GenderId],
    [Height],
    [WeightPounds],
    [AlignmentId],
    [DeityId],
    [Picture]
FROM
    dbo.PlayerCharacters

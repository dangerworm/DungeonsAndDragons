CREATE PROCEDURE [dbo].[USP_PlayerCharacters_Update]
@PlayerCharacterId INT,
@ActorId INT,
@Name VARCHAR(50),
@ClassId INT,
@ParagonPathId INT,
@EpicDestinyId INT,
@ExperiencePoints INT,
@RaceId INT,
@Age INT,
@GenderId INT,
@Height INT,
@WeightPounds INT,
@AlignmentId INT,
@DeityId INT,
@Picture BINARY
AS
BEGIN

UPDATE dbo.PlayerCharacters
SET
	[ActorId] = @ActorId,
	[Name] = @Name,
	[ClassId] = @ClassId,
	[ParagonPathId] = @ParagonPathId,
	[EpicDestinyId] = @EpicDestinyId,
	[ExperiencePoints] = @ExperiencePoints,
	[RaceId] = @RaceId,
	[Age] = @Age,
	[GenderId] = @GenderId,
	[Height] = @Height,
	[WeightPounds] = @WeightPounds,
	[AlignmentId] = @AlignmentId,
	[DeityId] = @DeityId,
	[Picture] = @Picture
WHERE [PlayerCharacterId] = ISNULL(@PlayerCharacterId, 0)

RETURN @@ROWCOUNT;

END

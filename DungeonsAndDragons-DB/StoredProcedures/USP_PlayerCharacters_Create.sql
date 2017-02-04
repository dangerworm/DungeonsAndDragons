CREATE PROCEDURE [dbo].[USP_PlayerCharacters_Create]
@PlayerCharacterId INT = NULL OUTPUT,
@ActorId INT,
@Name VARCHAR(50),
@ClassId INT,
@ParagonPathId INT,
@EpicDestinyId INT,
@ExperiencePoints INT,
@RaceId INT,
@Age INT,
@GenderId INT,
@Height VARCHAR(20),
@WeightPounds INT,
@AlignmentId INT,
@DeityId INT,
@Picture BINARY = NULL
AS

IF NOT EXISTS (
	SELECT 1
	FROM dbo.PlayerCharacters
	WHERE
		[PlayerCharacterId] = ISNULL(@PlayerCharacterId, 0)
)
BEGIN
INSERT INTO dbo.PlayerCharacters (
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
)
VALUES (
	@ActorId,
	@Name,
	@ClassId,
	@ParagonPathId,
	@EpicDestinyId,
	@ExperiencePoints,
	@RaceId,
	@Age,
	@GenderId,
	@Height,
	@WeightPounds,
	@AlignmentId,
	@DeityId,
	@Picture
)

SELECT @PlayerCharacterId = SCOPE_IDENTITY()

RETURN @@ROWCOUNT
END

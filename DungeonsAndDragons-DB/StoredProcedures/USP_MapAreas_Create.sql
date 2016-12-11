CREATE PROCEDURE [dbo].[USP_MapAreas_Create]
@MapAreaId INT = NULL OUTPUT,
@MapAreaTypeId INT,
@Name VARCHAR(50),
@FlavourText VARCHAR(MAX),
@ShopId INT ,
@MapImage BINARY,
@ParentMapAreaId INT ,
@ParentMapAreaLocationN DECIMAL,
@ParentMapAreaLocationE DECIMAL
AS

IF NOT EXISTS (
	SELECT 1
	FROM dbo.MapAreas
	WHERE
		[MapAreaId] = ISNULL(@MapAreaId, 0)
)
BEGIN
INSERT INTO dbo.MapAreas (
	[MapAreaId],
	[MapAreaTypeId],
	[Name],
	[FlavourText],
	[ShopId],
	[MapImage],
	[ParentMapAreaId],
	[ParentMapAreaLocationN],
	[ParentMapAreaLocationE]
)
VALUES (
	@MapAreaId,
	@MapAreaTypeId,
	@Name,
	@FlavourText,
	@ShopId,
	@MapImage,
	@ParentMapAreaId,
	@ParentMapAreaLocationN,
	@ParentMapAreaLocationE 
)

SELECT @MapAreaId = SCOPE_IDENTITY()

RETURN @@ROWCOUNT
END

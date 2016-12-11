CREATE PROCEDURE [dbo].[USP_MapAreas_GetById]
@MapAreaId INT
AS

SELECT
	[MapAreaId],
    [MapAreaId],
	[MapAreaTypeId],
	[Name],
	[FlavourText],
	[ShopId],
	[MapImage],
	[ParentMapAreaId],
	[ParentMapAreaLocationN],
	[ParentMapAreaLocationE]
FROM
    dbo.MapAreas MA
WHERE
	[MapAreaId] = @MapAreaId

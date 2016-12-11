CREATE PROCEDURE [dbo].[USP_MapAreas_GetAll]
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
    dbo.MapAreas

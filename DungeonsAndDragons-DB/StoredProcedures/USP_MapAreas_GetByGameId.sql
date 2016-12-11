CREATE PROCEDURE [dbo].[USP_MapAreas_GetByGameId]
@GameId INT
AS

SELECT
	MA.[MapAreaId],
    MA.[MapAreaId],
	MA.[MapAreaTypeId],
	MA.[Name],
	MA.[FlavourText],
	MA.[ShopId],
	MA.[MapImage],
	MA.[ParentMapAreaId],
	MA.[ParentMapAreaLocationN],
	MA.[ParentMapAreaLocationE]
FROM
    dbo.MapAreas MA
	INNER JOIN dbo.GameMapAreasBridge GMAB ON GMAB.MapAreaId = MA.MapAreaId
WHERE
	GMAB.GameId = @GameId

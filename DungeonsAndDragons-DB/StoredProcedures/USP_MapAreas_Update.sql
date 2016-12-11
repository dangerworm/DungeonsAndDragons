CREATE PROCEDURE [dbo].[USP_MapAreas_Update]
@MapAreaId INT,
@MapAreaTypeId INT,
@Name VARCHAR(50),
@FlavourText VARCHAR(MAX),
@ShopId INT ,
@MapImage BINARY,
@ParentMapAreaId INT ,
@ParentMapAreaLocationN DECIMAL,
@ParentMapAreaLocationE DECIMAL
AS
BEGIN

UPDATE dbo.MapAreas
SET
	[MapAreaTypeId]			 = @MapAreaTypeId,
	[Name]					 = @Name,
	[FlavourText]			 = @FlavourText,
	[ShopId]				 = @ShopId,
	[MapImage]				 = @MapImage,
	[ParentMapAreaId]		 = @ParentMapAreaId,
	[ParentMapAreaLocationN] = @ParentMapAreaLocationN,
	[ParentMapAreaLocationE] = @ParentMapAreaLocationE 
WHERE [MapAreaId] = ISNULL(@MapAreaId, 0)

RETURN @@ROWCOUNT;

END

CREATE TABLE [dbo].[MapAreas]
(
    MapAreaId INT IDENTITY(1,1)
		CONSTRAINT MapAreas_MapAreaId_PK PRIMARY KEY,
    MapAreaTypeId INT NOT NULL 
		CONSTRAINT MapAreas_MapAreaTypeId_FK FOREIGN KEY REFERENCES dbo.MapAreaTypes(MapAreaTypeId),
    Name VARCHAR(255) NOT NULL,
    FlavourText VARCHAR(MAX),
	ShopId INT 
		CONSTRAINT MapAreas_ShopId_FK FOREIGN KEY REFERENCES dbo.Shops(ShopId),
    MapImage BINARY,
    ParentMapAreaId INT 
		CONSTRAINT MapAreas_ParentMapAreaTypeId_FK FOREIGN KEY REFERENCES dbo.MapAreas(MapAreaId),
    ParentMapAreaLocationN DECIMAL,
    ParentMapAreaLocationE DECIMAL
);
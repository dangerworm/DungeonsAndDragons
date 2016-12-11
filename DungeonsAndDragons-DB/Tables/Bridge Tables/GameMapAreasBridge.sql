CREATE TABLE [dbo].[GameMapAreasBridge]
(
    GameMapAreaBridgeId INT IDENTITY(1,1) 
		CONSTRAINT GameMapAreasBridge_GameMapAreaBridgeId_PK PRIMARY KEY,
    GameId INT NOT NULL 
		CONSTRAINT GameMapAreasBridge_GameId_FK FOREIGN KEY REFERENCES dbo.Games(GameId),
    MapAreaId INT NOT NULL 
		CONSTRAINT GameMapAreasBridge_MapAreaId_FK FOREIGN KEY REFERENCES dbo.MapAreas(MapAreaId),
	CONSTRAINT GameMapAreasBridge_UQ UNIQUE(GameId, MapAreaId)
);
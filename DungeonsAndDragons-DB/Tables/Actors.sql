CREATE TABLE [dbo].[Actors]
(
	ActorId INT IDENTITY(0,1)
		CONSTRAINT Actors_ActorId_PK PRIMARY KEY,
	ActorTypeId TINYINT NOT NULL 
		CONSTRAINT Actors_ActorTypeId_FK FOREIGN KEY REFERENCES dbo.ActorTypes(ActorTypeId),
	MapAreaId INT
		CONSTRAINT Actors_MapAreaId_FK FOREIGN KEY REFERENCES dbo.MapAreas(MapAreaId),
);
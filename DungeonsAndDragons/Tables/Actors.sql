CREATE TABLE [dbo].[Actors]
(
    ActorId INT IDENTITY(1,1)
		CONSTRAINT Actors_ActorId_PK PRIMARY KEY,
    ActorTypeId INT NOT NULL 
		CONSTRAINT Actors_ActorTypeId_FK FOREIGN KEY REFERENCES dbo.ActorTypes(ActorTypeId),
    EntityId INT NOT NULL,
    
	UNIQUE (EntityId, ActorTypeId)
);
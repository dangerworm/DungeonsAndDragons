﻿CREATE TABLE [dbo].[GameActorsBridge]
(
    GameActorBridgeId INT IDENTITY(1,1) 
		CONSTRAINT GameActorsBridge_GameActorBridgeId_PK PRIMARY KEY,
    GameId INT NOT NULL 
		CONSTRAINT GameActorsBridge_GameId_FK FOREIGN KEY REFERENCES dbo.Games(GameId),
    ActorId INT NOT NULL 
		CONSTRAINT GameActorsBridge_ActorId_FK FOREIGN KEY REFERENCES dbo.Actors(ActorId),
	JoinDate DATETIME2(3) NOT NULL
		CONSTRAINT GameActorsBridge_JoinDate_DF DEFAULT(SYSDATETIME()),
	CONSTRAINT GameActorsBridge_UQ UNIQUE(GameId, ActorId)
);
CREATE TABLE [dbo].[TransportItems]
(
    TransportItemId INT IDENTITY(1,1)
		CONSTRAINT TransportItems_TransportItemId_PK PRIMARY KEY,
    Name INT NOT NULL,
    Cost DECIMAL(18,2) NOT NULL,
    MaxCapacityPounds INT NOT NULL,
   	OwnerActorId INT
		CONSTRAINT TransportItems_OwnerActorId_FK FOREIGN KEY REFERENCES dbo.Actors(ActorId)
);
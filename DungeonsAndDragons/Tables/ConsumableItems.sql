CREATE TABLE [dbo].[ConsumableItems]
(
    ConsumableItemId INT IDENTITY(1,1) 
		CONSTRAINT ConsumableItems_ConsumableItemId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Cost DECIMAL(18,2) NOT NULL,
   	OwnerActorId INT
		CONSTRAINT ConsumableItems_OwnerActorId_FK FOREIGN KEY REFERENCES dbo.Actors(ActorId)
);
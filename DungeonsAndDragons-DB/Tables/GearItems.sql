CREATE TABLE [dbo].[GearItems]
(
    GearItemId INT IDENTITY(1,1)
		CONSTRAINT GearItems_GearItemId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Cost DECIMAL(18,2) NOT NULL,
    WeightPounds INT NOT NULL,
	ImplementTypeId TINYINT 
		CONSTRAINT GearItems_ImplementTypeId_FK FOREIGN KEY REFERENCES dbo.ImplementTypes(ImplementTypeId),
	OwnerActorId INT
		CONSTRAINT GearItems_OwnerActorId_FK FOREIGN KEY REFERENCES dbo.Actors(ActorId)
);
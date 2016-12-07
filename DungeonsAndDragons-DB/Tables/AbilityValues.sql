CREATE TABLE [dbo].[AbilityValues]
(
    AbilityValueId INT IDENTITY(1,1) 
		CONSTRAINT AbilityValues_AbilityValueId_PK PRIMARY KEY,
    ActorId INT 
		CONSTRAINT AbilityValues_ActorId_FK FOREIGN KEY REFERENCES dbo.Actors(ActorId),
    FeatureId INT 
		CONSTRAINT AbilityValues_FeatId_FK FOREIGN KEY REFERENCES dbo.Features(FeatureId),
    RaceId INT 
		CONSTRAINT AbilityValues_RaceId_FK FOREIGN KEY REFERENCES dbo.Races(RaceId),
    AbilityId INT NOT NULL 
		CONSTRAINT AbilityValues_AbilityId_FK FOREIGN KEY REFERENCES dbo.Abilities(AbilityId),
    Modifier INT NOT NULL
);
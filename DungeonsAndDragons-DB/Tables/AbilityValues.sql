CREATE TABLE [dbo].[AbilityValues]
(
    AbilityValueId INT IDENTITY(1,1) 
		CONSTRAINT AbilityValues_AbilityValueId_PK PRIMARY KEY,
    ActorId INT 
		CONSTRAINT AbilityValues_ActorId_FK FOREIGN KEY REFERENCES dbo.Actors(ActorId),
    FeatureId TINYINT 
		CONSTRAINT AbilityValues_FeatId_FK FOREIGN KEY REFERENCES dbo.Features(FeatureId),
    RaceId TINYINT 
		CONSTRAINT AbilityValues_RaceId_FK FOREIGN KEY REFERENCES dbo.Races(RaceId),
    AbilityId TINYINT NOT NULL 
		CONSTRAINT AbilityValues_AbilityId_FK FOREIGN KEY REFERENCES dbo.Abilities(AbilityId),
    Modifier INT NOT NULL
);
CREATE TABLE [dbo].[AbilityScores]
(
    AbilityScoreId INT IDENTITY(1,1) 
		CONSTRAINT AbilityScores_AbilityScoreId_PK PRIMARY KEY,
    AbilityId TINYINT NOT NULL 
		CONSTRAINT AbilityScores_AbilityId_FK FOREIGN KEY REFERENCES dbo.Abilities(AbilityId),
    ActorId INT 
		CONSTRAINT AbilityScores_ActorId_FK FOREIGN KEY REFERENCES dbo.Actors(ActorId),
    FeatureId TINYINT 
		CONSTRAINT AbilityScores_FeatId_FK FOREIGN KEY REFERENCES dbo.Features(FeatureId),
    RaceId TINYINT 
		CONSTRAINT AbilityScores_RaceId_FK FOREIGN KEY REFERENCES dbo.Races(RaceId),
    Score INT NOT NULL
);
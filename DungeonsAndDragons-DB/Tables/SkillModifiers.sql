CREATE TABLE [dbo].[SkillModifiers]
(
    SkillModifierId INT IDENTITY(1,1)
		CONSTRAINT SkillModifiers_SkillModifierId_PK PRIMARY KEY,
    ActorId INT 
		CONSTRAINT SkillModifiers_ActorId_FK FOREIGN KEY REFERENCES dbo.Actors(ActorId),
    FeatureId TINYINT 
		CONSTRAINT SkillModifiers_FeatureId_FK FOREIGN KEY REFERENCES dbo.Features(FeatureId),
    RaceId TINYINT 
		CONSTRAINT SkillModifiers_RaceId_FK FOREIGN KEY REFERENCES dbo.Races(RaceId),
    SkillId TINYINT NOT NULL 
		CONSTRAINT SkillModifiers_SkillId_FK FOREIGN KEY REFERENCES dbo.Skills(SkillId),
    Modifier INT NOT NULL
);
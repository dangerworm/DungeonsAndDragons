CREATE TABLE [dbo].[DefenseModifiers]
(
    DefenseModifierId INT IDENTITY(1,1) 
		CONSTRAINT DefenseModifiers_DefenseModifierId_PK PRIMARY KEY,
    ActorId INT 
		CONSTRAINT DefenseModifiers_ActorId_FK FOREIGN KEY REFERENCES dbo.Actors(ActorId),
	ClassId INT 
		CONSTRAINT DefenseModifiers_ClassId_FK FOREIGN KEY REFERENCES dbo.Classes(ClassId),
    FeatureId INT 
		CONSTRAINT DefenseModifiers_FeatureId_FK FOREIGN KEY REFERENCES dbo.Features(FeatureId),
    RaceId INT 
		CONSTRAINT DefenseModifiers_RaceId_FK FOREIGN KEY REFERENCES dbo.Races(RaceId),
    DefenseId INT NOT NULL 
		CONSTRAINT DefenseModifiers_DefenseId_FK FOREIGN KEY REFERENCES dbo.Defenses(DefenseId),
    Modifier INT NOT NULL
);
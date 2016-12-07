CREATE TABLE [dbo].[NonPlayerCharacters]
(
    NonPlayerCharacterId INT IDENTITY(1,1) 
		CONSTRAINT NonPlayerCharacters_NonPlayerCharacterId_PK PRIMARY KEY,
    ActorId INT NOT NULL 
		CONSTRAINT NonPlayerCharacters_ActorId_FK FOREIGN KEY REFERENCES dbo.Actors(ActorId),
    Name VARCHAR(50) NOT NULL,
    CombatLevel INT NOT NULL 
		CONSTRAINT NonPlayerCharacters_CombatLevel_DF DEFAULT(1),
    ClassId INT NOT NULL 
		CONSTRAINT NonPlayerCharacters_ClassId_FK FOREIGN KEY REFERENCES dbo.Classes(ClassId),
    RaceId INT NOT NULL 
		CONSTRAINT NonPlayerCharacters_RaceId_FK FOREIGN KEY REFERENCES dbo.Races(RaceId),
    Age INT,
    GenderId INT 
		CONSTRAINT NonPlayerCharacters_GenderId_FK FOREIGN KEY REFERENCES dbo.Genders(GenderId),
    Height VARCHAR(50),
    WeightPounds INT,
    AlignmentId INT NOT NULL 
		CONSTRAINT NonPlayerCharacters_AlignmentId_FK FOREIGN KEY REFERENCES dbo.Alignments(AlignmentId),
    DeityId INT 
		CONSTRAINT NonPlayerCharacters_DeityId_FK FOREIGN KEY REFERENCES dbo.Deities(DeityId),
    HitPoints INT NOT NULL
);
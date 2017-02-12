CREATE TABLE [dbo].[PlayerCharacters]
(
    PlayerCharacterId INT IDENTITY(1,1) 
		CONSTRAINT PlayerCharacters_PlayerCharacterId_PK PRIMARY KEY,
    ActorId INT NOT NULL 
		CONSTRAINT PlayerCharacters_ActorId_FK FOREIGN KEY REFERENCES dbo.Actors(ActorId),
    Name VARCHAR(50) NOT NULL,
    ClassId TINYINT NOT NULL 
		CONSTRAINT PlayerCharacters_ClassId_FK FOREIGN KEY REFERENCES dbo.Classes(ClassId),
    ParagonPathId INT 
		CONSTRAINT PlayerCharacters_ParagonPathId_FK FOREIGN KEY REFERENCES dbo.ParagonPaths(ParagonPathId),
    EpicDestinyId TINYINT 
		CONSTRAINT PlayerCharacters_EpicDestinyId_FK FOREIGN KEY REFERENCES dbo.EpicDestinies(EpicDestinyId),
    ExperiencePoints INT NOT NULL 
		CONSTRAINT PlayerCharacters_ExperiencePoints_DF DEFAULT(0),
    RaceId TINYINT NOT NULL 
		CONSTRAINT PlayerCharacters_RaceId_FK FOREIGN KEY REFERENCES dbo.Races(RaceId),
    Age INT,
    GenderId TINYINT 
		CONSTRAINT PlayerCharacters_GenderId_FK FOREIGN KEY REFERENCES dbo.Genders(GenderId),
    Height VARCHAR(50),
    WeightPounds INT,
    AlignmentId TINYINT NOT NULL
		CONSTRAINT PlayerCharacters_AlignmentId_DF DEFAULT(5)
		CONSTRAINT PlayerCharacters_AlignmentId_FK FOREIGN KEY REFERENCES dbo.Alignments(AlignmentId),
    DeityId TINYINT 
		CONSTRAINT PlayerCharacters_DeityId_DF DEFAULT(0)
		CONSTRAINT PlayerCharacters_DeityId_FK FOREIGN KEY REFERENCES dbo.Deities(DeityId),
	Picture BINARY
);
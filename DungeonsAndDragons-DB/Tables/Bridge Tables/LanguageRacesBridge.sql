CREATE TABLE [dbo].[LanguageRacesBridge]
(
    LanguageRaceId INT IDENTITY(1,1)
		CONSTRAINT LanguageRacesBridge_LanguageRaceBridgeId_PK PRIMARY KEY,
    LanguageId TINYINT NOT NULL 
		CONSTRAINT LanguageRacesBridge_LanguageId_FK FOREIGN KEY REFERENCES dbo.Languages(LanguageId),
    RaceId TINYINT NOT NULL 
		CONSTRAINT LanguageRacesBridge_RaceId_FK FOREIGN KEY REFERENCES dbo.Races(RaceId)
);
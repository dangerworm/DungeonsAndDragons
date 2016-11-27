CREATE TABLE [dbo].[PlayerCharacterLanguagesBridge]
(
    PlayerCharacterLanguageId INT IDENTITY(1,1) 
		CONSTRAINT PlayerCharacterLanguagesBridge_PlayerCharacterLanguageBridgeId_PK PRIMARY KEY,
    PlayerCharacterId INT NOT NULL 
		CONSTRAINT PlayerCharacterLanguagesBridge_PlayerCharacterId_FK FOREIGN KEY REFERENCES dbo.PlayerCharacters(PlayerCharacterId),
    LanguageId INT NOT NULL 
		CONSTRAINT PlayerCharacterLanguagesBridge_LanguageId_FK FOREIGN KEY REFERENCES dbo.Languages(LanguageId)
);
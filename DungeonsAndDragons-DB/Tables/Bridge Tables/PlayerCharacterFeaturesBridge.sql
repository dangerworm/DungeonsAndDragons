CREATE TABLE [dbo].[PlayerCharacterFeaturesBridge]
(
    PlayerCharacterFeatureId INT IDENTITY(1,1) 
		CONSTRAINT PlayerCharacterFeaturesBridge_PlayerCharacterFeatureBridgeId_PK PRIMARY KEY,
    PlayerCharacterId INT NOT NULL 
		CONSTRAINT PlayerCharacterFeaturesBridge_PlayerCharacterId_FK FOREIGN KEY REFERENCES dbo.PlayerCharacters(PlayerCharacterId),
    FeatureId TINYINT NOT NULL 
		CONSTRAINT PlayerCharacterFeaturesBridge_FeatureId_FK FOREIGN KEY REFERENCES dbo.Features(FeatureId)
);
CREATE TABLE [dbo].[Deities]
(
    DeityId INT IDENTITY(1,1) 
		CONSTRAINT Deities_DeityId_PK PRIMARY KEY,
    AuthorityLevelId INT 
		CONSTRAINT Deities_AuthorityLevelId_FK FOREIGN KEY REFERENCES dbo.AuthorityLevels(AuthorityLevelId),
    CompassionLevelId INT 
		CONSTRAINT Deities_CompassionLevelId_FK FOREIGN KEY REFERENCES dbo.CompassionLevels(CompassionLevelId),
	Name VARCHAR(50) NOT NULL,
    FlavourText VARCHAR(MAX)
);
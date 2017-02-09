CREATE TABLE [dbo].[Races]
(
    RaceId INT IDENTITY(1,1) 
		CONSTRAINT Races_RaceId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    SizeId INT 
		CONSTRAINT Races_SizeId_FK FOREIGN KEY REFERENCES dbo.Sizes(SizeId),
    Speed INT,
    VisionLevelId INT 
		CONSTRAINT Races_VisionLevelId_FK FOREIGN KEY REFERENCES dbo.VisionLevels(VisionLevelId),
	InfoUrl VARCHAR(MAX),
    IsPlayable BIT NOT NULL
);
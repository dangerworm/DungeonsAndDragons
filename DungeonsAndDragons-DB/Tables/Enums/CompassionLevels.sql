CREATE TABLE [dbo].[CompassionLevels]
(
    CompassionLevelId INT IDENTITY(1,1) 
		CONSTRAINT CompassionLevels_CompassionLevelId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);
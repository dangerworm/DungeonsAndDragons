CREATE TABLE [dbo].[MapAreaTypes]
(
    MapAreaTypeId INT IDENTITY(1,1) 
		CONSTRAINT MapAreaTypes_MapAreaTypeId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);
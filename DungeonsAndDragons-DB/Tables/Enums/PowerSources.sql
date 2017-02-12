CREATE TABLE [dbo].[PowerSources]
(
    PowerSourceId TINYINT IDENTITY(1,1) 
		CONSTRAINT PowerSources_PowerSourceId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
	FlavourText VARCHAR(MAX)
);
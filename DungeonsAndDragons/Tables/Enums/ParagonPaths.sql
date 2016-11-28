CREATE TABLE [dbo].[ParagonPaths]
(
    ParagonPathId INT IDENTITY(1,1) 
		CONSTRAINT ParagonPaths_ParagonPathId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
	FlavourText VARCHAR(MAX)
);
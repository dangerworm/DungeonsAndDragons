CREATE TABLE [dbo].[Abilities]
(
    AbilityId TINYINT IDENTITY(1,1) 
		CONSTRAINT Abilities_AbilityId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
	FlavourText VARCHAR(MAX)
);
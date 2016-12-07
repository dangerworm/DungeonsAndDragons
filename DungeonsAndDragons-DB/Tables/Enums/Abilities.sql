CREATE TABLE [dbo].[Abilities]
(
    AbilityId INT IDENTITY(1,1) 
		CONSTRAINT Abilities_AbilityId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
	FlavourText VARCHAR(MAX)
);
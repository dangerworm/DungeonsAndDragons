CREATE TABLE [dbo].[DamageTypes]
(
    DamageTypeId TINYINT IDENTITY(1,1) 
		CONSTRAINT DamageTypes_DamageTypeId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
	FlavourText VARCHAR(MAX)
);
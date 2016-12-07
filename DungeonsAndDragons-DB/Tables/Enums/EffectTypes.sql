CREATE TABLE [dbo].[EffectTypes]
(
    EffectTypeId INT IDENTITY(1,1) 
		CONSTRAINT EffectTypes_EffectTypeId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
	FlavourText VARCHAR(MAX)
);
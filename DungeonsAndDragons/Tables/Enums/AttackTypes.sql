CREATE TABLE [dbo].[AttackTypes]
(
    AttackTypeId INT IDENTITY(1,1) 
		CONSTRAINT AttackTypes_AttackTypeId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
	FlavourText VARCHAR(MAX)
);
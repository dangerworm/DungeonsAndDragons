CREATE TABLE [dbo].[ActionTypes]
(
    ActionTypeId INT IDENTITY(1,1)
		CONSTRAINT ActionTypes_ActionTypeId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
	FlavourText VARCHAR(MAX)
);
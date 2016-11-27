CREATE TABLE [dbo].[Deities]
(
    DeityId INT IDENTITY(1,1)
		CONSTRAINT Deities_DeityId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);
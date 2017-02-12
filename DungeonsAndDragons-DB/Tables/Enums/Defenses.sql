CREATE TABLE [dbo].[Defenses]
(
    DefenseId TINYINT IDENTITY(1,1) 
		CONSTRAINT Defenses_DefenseId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);
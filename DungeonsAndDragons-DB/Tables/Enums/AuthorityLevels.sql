CREATE TABLE [dbo].[AuthorityLevels]
(
    AuthorityLevelId TINYINT IDENTITY(1,1) 
		CONSTRAINT AuthorityLevels_AuthorityLevelId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);
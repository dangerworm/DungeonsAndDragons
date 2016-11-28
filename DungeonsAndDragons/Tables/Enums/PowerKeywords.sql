CREATE TABLE [dbo].[PowerKeywords]
(
    PowerKeywordId INT IDENTITY(1,1) 
		CONSTRAINT PowerKeywords_PowerKeywordId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
	FlavourText VARCHAR(MAX)
);
CREATE TABLE [dbo].[PowerUsages]
(
    PowerUsageId INT IDENTITY(1,1) 
		CONSTRAINT PowerUsages_PowerUsageId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
	FlavourText VARCHAR(MAX)
);
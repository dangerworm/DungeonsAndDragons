CREATE TABLE [dbo].[DurationUnits]
(
    DurationUnitId INT IDENTITY(1,1) 
		CONSTRAINT DurationUnits_DurationUnitId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);
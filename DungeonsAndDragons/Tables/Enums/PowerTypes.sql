CREATE TABLE [dbo].[PowerTypes]
(
    PowerTypeId INT IDENTITY(1,1) 
		CONSTRAINT PowerTypes_PowerTypeId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);
CREATE TABLE [dbo].[TargetTypes]
(
    TargetTypeId INT IDENTITY(1,1) 
		CONSTRAINT TargetTypes_TargetTypeId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    ColumnValue INT NOT NULL
);
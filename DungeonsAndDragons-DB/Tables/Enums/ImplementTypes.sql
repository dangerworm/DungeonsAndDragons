CREATE TABLE [dbo].[ImplementTypes]
(
    ImplementTypeId TINYINT IDENTITY(1,1) 
		CONSTRAINT ImplementTypes_ImplementTypeId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);
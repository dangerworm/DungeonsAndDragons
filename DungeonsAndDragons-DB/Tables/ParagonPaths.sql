CREATE TABLE [dbo].[ParagonPaths]
(
    ParagonPathId INT IDENTITY(1,1) 
		CONSTRAINT ParagonPaths_ParagonPathId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    ClassId INT 
		CONSTRAINT ParagonPaths_ClassId_FK FOREIGN KEY REFERENCES dbo.Classes(ClassId),
    FlavourText VARCHAR(MAX)
);
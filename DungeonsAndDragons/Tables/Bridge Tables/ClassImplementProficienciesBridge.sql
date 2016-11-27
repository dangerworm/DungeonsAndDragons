CREATE TABLE [dbo].[ClassImplementProficienciesBridge]
(
    ClassImplementProficiencyId INT IDENTITY(1,1)
		CONSTRAINT ClassImplementProficienciesBridge_ClassImplementProficiencyId_PK PRIMARY KEY,
    ClassId INT NOT NULL 
		CONSTRAINT ClassImplementProficienciesBridge_ClassId_FK FOREIGN KEY REFERENCES dbo.Classes(ClassId),
    ImplementTypeId INT NOT NULL 
		CONSTRAINT ClassImplementProficienciesBridge_ImplementTypeId_FK FOREIGN KEY REFERENCES dbo.ImplementTypes(ImplementTypeId)
);
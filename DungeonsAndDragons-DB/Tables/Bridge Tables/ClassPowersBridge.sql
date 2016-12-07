CREATE TABLE [dbo].[ClassPowersBridge]
(
    ClassPowerId INT IDENTITY(1,1) 
		CONSTRAINT ClassPowersBridge_ClassPowerId_PK PRIMARY KEY,
    ClassId INT NOT NULL 
		CONSTRAINT ClassPowersBridge_ClassId_FK FOREIGN KEY REFERENCES dbo.Classes(ClassId),
    PowerId INT NOT NULL 
		CONSTRAINT ClassPowersBridge_PowerId_FK FOREIGN KEY REFERENCES dbo.Powers(PowerId)
);
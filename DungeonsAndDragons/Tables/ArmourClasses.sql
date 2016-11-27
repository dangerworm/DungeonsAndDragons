CREATE TABLE [dbo].[ArmourClasses]
(
    ArmourClassId INT IDENTITY(1,1)
		CONSTRAINT ArmourClasses_ArmourClassId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    ArmourWeightClassId INT
		CONSTRAINT ArmourClasses_ArmourWeightClassId_FK FOREIGN KEY REFERENCES dbo.ArmourWeightClasses(ArmourWeightClassId)
);

CREATE TABLE [dbo].[ClassArmourProficienciesBridge]
(
	ClassArmourProficiencyId INT IDENTITY(1,1) 
		CONSTRAINT ClassArmourProficienciesBridge_ClassArmourProficiencyId_PK PRIMARY KEY,
    ClassId TINYINT NOT NULL 
		CONSTRAINT ClassArmourProficienciesBridge_ClassId_FK FOREIGN KEY REFERENCES dbo.Classes(ClassId),
    ArmourClassId TINYINT NOT NULL 
		CONSTRAINT ClassArmourProficienciesBridge_ArmourClassId_FK FOREIGN KEY REFERENCES dbo.ArmourClasses(ArmourClassId)

)

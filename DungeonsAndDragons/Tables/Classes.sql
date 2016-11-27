CREATE TABLE [dbo].[Classes]
(
    ClassId INT IDENTITY(1,1) 
		CONSTRAINT Classes_ClassId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    BaseHitPoints INT NOT NULL,
    HitPointsPerLevel INT NOT NULL,
    HealingSurges INT NOT NULL,
    DefenseFortitudeBonus INT NOT NULL,
    DefenseReflexBonus INT NOT NULL,
    DefenseWillBonus INT NOT NULL,
    ClassArmourProficienciesId INT NOT NULL 
		CONSTRAINT Classes_ClassArmourProficienciesId_FK FOREIGN KEY REFERENCES dbo.ClassArmourProficienciesBridge(ClassArmourProficiencyId),
    ClassWeaponProficienciesId INT NOT NULL 
		CONSTRAINT Classes_ClassWeaponProficienciesId_FK FOREIGN KEY REFERENCES dbo.ClassWeaponProficienciesBridge(ClassWeaponProficiencyId),
    ClassImplementProficienciesId INT NOT NULL 
		CONSTRAINT Classes_ClassImplementProficienciesId_FK FOREIGN KEY REFERENCES dbo.ClassImplementProficienciesBridge(ClassImplementProficiencyId),
    ClassTrainedSkillsId INT NOT NULL 
		CONSTRAINT Classes_ClassTrainedSkillsId_FK FOREIGN KEY REFERENCES dbo.ClassTrainedSkillsBridge(ClassTrainedSkillId)
);

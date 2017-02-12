CREATE TABLE [dbo].[ClassWeaponProficienciesBridge]
(
    ClassWeaponProficiencyId INT IDENTITY(1,1) 
		CONSTRAINT ClassWeaponProficienciesBridge_ClassWeaponProficiencyId_PK PRIMARY KEY,
    ClassId TINYINT NOT NULL 
		CONSTRAINT ClassWeaponProficienciesBridge_ClassId_FK FOREIGN KEY REFERENCES dbo.Classes(ClassId),
    AttackClassId INT NOT NULL 
		CONSTRAINT ClassWeaponProficienciesBridge_WeaponClassId_FK FOREIGN KEY REFERENCES dbo.AttackClasses(AttackClassId)
);
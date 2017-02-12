CREATE TABLE [dbo].[WeaponTypes]
(
    WeaponTypeId INT IDENTITY(1,1) 
		CONSTRAINT WeaponTypes_WeaponTypeId_PK PRIMARY KEY,
	WeaponCategoryId TINYINT NOT NULL 
		CONSTRAINT WeaponTypes_WeaponCategoryId_FK FOREIGN KEY REFERENCES dbo.WeaponCategories(WeaponCategoryId),
    WeaponGroupId TINYINT NOT NULL
		CONSTRAINT WeaponTypes_WeaponGroupId_FK FOREIGN KEY REFERENCES dbo.WeaponGroups(WeaponGroupId),
	Name VARCHAR(50) NOT NULL,
    Handedness INT NOT NULL,
    ProficiencyBonus INT NOT NULL,
    DamageNumDice INT NOT NULL,
    DamageDieSides INT NOT NULL,
	IsMelee BIT NOT NULL,
    NormalRange INT,
    LongRange INT,
    Cost DECIMAL(18,2) NOT NULL,
    WeightPounds INT NOT NULL
);
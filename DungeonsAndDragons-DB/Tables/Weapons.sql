CREATE TABLE [dbo].[Weapons]
(
    WeaponId INT IDENTITY(1,1) 
		CONSTRAINT Weapons_WeaponId_PK PRIMARY KEY,
	WeaponCategoryId INT NOT NULL 
		CONSTRAINT Weapons_WeaponCategoryId_FK FOREIGN KEY REFERENCES dbo.WeaponCategories(WeaponCategoryId),
    AttackClassId INT NOT NULL 
		CONSTRAINT Weapons_AttackClassId_FK FOREIGN KEY REFERENCES dbo.AttackClasses(AttackClassId),
    Handedness INT NOT NULL,
    ProficiencyBonus INT NOT NULL,
    DamageNumDice INT NOT NULL,
    DamageDieSides INT NOT NULL,
    NormalRange INT,
    LongRange INT,
    Cost DECIMAL(18,2) NOT NULL,
    WeightPounds INT NOT NULL,
    WeaponGroupId INT NOT NULL
		CONSTRAINT Weapons_WeaponGroupId_FK FOREIGN KEY REFERENCES dbo.WeaponGroups(WeaponGroupId),
	OwnerActorId INT
		CONSTRAINT Weapons_OwnerActorId_FK FOREIGN KEY REFERENCES dbo.Actors(ActorId),
);
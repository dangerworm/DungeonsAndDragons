CREATE TABLE [dbo].[AttackClasses]
(
    AttackClassId INT IDENTITY(1,1) 
		CONSTRAINT AttackClasses_AttackClassId_PK PRIMARY KEY,
    AttackTypeId INT NOT NULL 
		CONSTRAINT AttackClasses_AttackTypeId_FK FOREIGN KEY REFERENCES dbo.AttackTypes(AttackTypeId),
    DamageNumDice INT,
    DamageDieSides INT,
    WeaponMultiplyer INT,
    Range1 INT,
    Range2 INT,
    IsSightRange INT NOT NULL 
		CONSTRAINT AttackClasses_IsSightRange_DF DEFAULT(0),

	CONSTRAINT AttackClasses_DiceOrWeapon_CK CHECK (
		CASE WHEN DamageNumDice IS NOT NULL AND DamageDieSides IS NOT NULL THEN 1 ELSE 0 END +
		CASE WHEN WeaponMultiplyer IS NOT NULL THEN 1 ELSE 0 END = 1
	)
);
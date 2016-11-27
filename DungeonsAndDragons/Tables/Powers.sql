CREATE TABLE [dbo].[Powers]
(
    PowerId INT IDENTITY(1,1) 
		CONSTRAINT Powers_PowerId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    TextDescription VARCHAR(255) NOT NULL,
    PowerTypeId INT NOT NULL 
		CONSTRAINT Powers_PowerTypeId_FK FOREIGN KEY REFERENCES dbo.PowerTypes(PowerTypeId),
    ActionTypeId INT NOT NULL 
		CONSTRAINT Powers_ActionTypeId_FK FOREIGN KEY REFERENCES dbo.ActionTypes(ActionTypeId),
    AttackTypeId INT NOT NULL 
		CONSTRAINT Powers_AttackTypeId_FK FOREIGN KEY REFERENCES dbo.AttackTypes(AttackTypeId),
    PrerequisiteId INT 
		CONSTRAINT Powers_PrerequisiteId_FK FOREIGN KEY REFERENCES dbo.Prerequisites(PrerequisiteId),
    TargetType TINYINT,
    MinNumTargets INT,
    MaxNumTargets INT,
    AttackAbilityId INT 
		CONSTRAINT Powers_AttackAbilityId_FK FOREIGN KEY REFERENCES dbo.Abilities(AbilityId),
    AttackAbilityComplement INT,
    AttackDefenseId INT 
		CONSTRAINT Powers_AttackDefenseId_FK FOREIGN KEY REFERENCES dbo.Defenses(DefenseId),
    AttackDefenseComplement INT,
    HitAbilityId INT 
		CONSTRAINT Powers_HitAbilityId_FK FOREIGN KEY REFERENCES dbo.Abilities(AbilityId),
    HitAbilityComplement INT,
    DamageTypeId INT 
		CONSTRAINT Powers_DamageTypeId_FK FOREIGN KEY REFERENCES dbo.DamageTypes(DamageTypeId),
    Duration INT,
    DurationUnitId INT 
		CONSTRAINT Powers_DurationUnitId_FK FOREIGN KEY REFERENCES dbo.DurationUnits(DurationUnitId),
    HasSecondaryAttack BIT,
    IsConjuration BIT NOT NULL 
		CONSTRAINT Powers_IsConjuration_DF DEFAULT(0),
    IsZone BIT NOT NULL 
		CONSTRAINT Powers_IsZone_DF DEFAULT(0)
);
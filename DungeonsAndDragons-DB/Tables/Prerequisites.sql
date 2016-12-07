CREATE TABLE [dbo].[Prerequisites]
(
    PrerequisiteId INT IDENTITY(1,1) 
		CONSTRAINT Prerequisites_PrerequisiteId_PK PRIMARY KEY,
    FeatureId INT 
		CONSTRAINT Prerequisites_FeatureId_FK FOREIGN KEY REFERENCES dbo.Features(FeatureId),
    PowerId INT 
		CONSTRAINT Prerequisites_PowerId_FK FOREIGN KEY REFERENCES dbo.Powers(PowerId),
    CombatLevel INT,
    ClassId INT 
		CONSTRAINT Prerequisites_ClassId_FK FOREIGN KEY REFERENCES dbo.Classes(ClassId),
    RaceId INT 
		CONSTRAINT Prerequisites_RaceId_FK FOREIGN KEY REFERENCES dbo.Races(RaceId),
    SizeId INT 
		CONSTRAINT Prerequisites_SizeId_FK FOREIGN KEY REFERENCES dbo.Sizes(SizeId),
    DeityId INT 
		CONSTRAINT Prerequisites_DeityId_FK FOREIGN KEY REFERENCES dbo.Deities(DeityId),
    PrerequisiteFeatureId INT 
		CONSTRAINT Prerequisites_PrerequisiteFeatureId_FK FOREIGN KEY REFERENCES dbo.Features(FeatureId),
    AbilityValueId INT 
		CONSTRAINT Prerequisites_AbilityId_FK FOREIGN KEY REFERENCES dbo.AbilityValues(AbilityValueId),
    MinAbilityScore INT,
    TrainedSkillId INT 
		CONSTRAINT Prerequisites_TrainedSkillId_FK FOREIGN KEY REFERENCES dbo.Skills(SkillId),
    WeaponGroupId INT 
		CONSTRAINT Prerequisites_WeaponGroupId_FK FOREIGN KEY REFERENCES dbo.WeaponGroups(WeaponGroupId)
);
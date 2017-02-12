CREATE TABLE [dbo].[Classes]
(
    ClassId TINYINT IDENTITY(1,1) 
		CONSTRAINT Classes_ClassId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    RoleId TINYINT NOT NULL 
		CONSTRAINT Classes_RoleId_FK FOREIGN KEY REFERENCES dbo.Roles(RoleId),
    PowerSourceId TINYINT NOT NULL 
		CONSTRAINT Classes_PowerSourceId_FK FOREIGN KEY REFERENCES dbo.PowerSources(PowerSourceId),
    BaseHitPoints TINYINT NOT NULL,
    BaseHitPointsAbilityId TINYINT
		CONSTRAINT Classes_BaseHitPointsAbilityId_FK FOREIGN KEY REFERENCES dbo.Abilities(AbilityId),
    HitPointsPerLevel INT NOT NULL,
    HealingSurges INT NOT NULL,
    HealingSurgesAbilityId TINYINT
		CONSTRAINT Classes_HealingSurgesAbilityId_FK FOREIGN KEY REFERENCES dbo.Abilities(AbilityId),
	FlavourText VARCHAR(MAX),
	InfoUrl VARCHAR(MAX)
);
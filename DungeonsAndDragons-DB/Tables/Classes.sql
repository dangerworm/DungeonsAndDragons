CREATE TABLE [dbo].[Classes]
(
    ClassId INT IDENTITY(1,1) 
		CONSTRAINT Classes_ClassId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    RoleId INT NOT NULL 
		CONSTRAINT Classes_RoleId_FK FOREIGN KEY REFERENCES dbo.Roles(RoleId),
    PowerSourceId INT NOT NULL 
		CONSTRAINT Classes_PowerSourceId_FK FOREIGN KEY REFERENCES dbo.PowerSources(PowerSourceId),
    BaseHitPoints INT NOT NULL,
    BaseHitPointsAbilityId INT
		CONSTRAINT Classes_BaseHitPointsAbilityId_FK FOREIGN KEY REFERENCES dbo.Abilities(AbilityId),
    HitPointsPerLevel INT NOT NULL,
    HealingSurges INT NOT NULL,
    HealingSurgesAbilityId INT
		CONSTRAINT Classes_HealingSurgesAbilityId_FK FOREIGN KEY REFERENCES dbo.Abilities(AbilityId),
	FlavourText VARCHAR(MAX),
	InfoUrl VARCHAR(MAX)
);
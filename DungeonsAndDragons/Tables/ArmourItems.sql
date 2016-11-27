CREATE TABLE [dbo].[ArmourItems]
(
    ArmourItemId INT IDENTITY(1,1)
		CONSTRAINT ArmourItems_ArmourItemId_PK PRIMARY KEY,
	ArmourClassId INT
		CONSTRAINT ArmourItems_ArmourClassId_FK FOREIGN KEY REFERENCES dbo.ArmourClasses(ArmourClassId),
    Name VARCHAR(50) NOT NULL,
    Bonus INT NOT NULL,
    MinEnchantmentBonus INT NOT NULL,
    CheckPenalty INT NOT NULL,
    SpeedPenalty INT NOT NULL,
    Cost DECIMAL(18,2),
	WeightPounds INT NOT NULL,
	OwnerActorId INT
		CONSTRAINT ArmourItems_OwnerActorId_FK FOREIGN KEY REFERENCES dbo.Actors(ActorId)
);

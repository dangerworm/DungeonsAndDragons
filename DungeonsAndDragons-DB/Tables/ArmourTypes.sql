CREATE TABLE [dbo].[ArmourTypes]
(
    ArmourTypeId TINYINT IDENTITY(1,1)
		CONSTRAINT ArmourTypes_ArmourTypeId_PK PRIMARY KEY,
	ArmourClassId TINYINT
		CONSTRAINT ArmourTypes_ArmourClassId_FK FOREIGN KEY REFERENCES dbo.ArmourClasses(ArmourClassId),
    Name VARCHAR(50) NOT NULL,
    Bonus INT NOT NULL,
    MinEnhancementBonus INT NOT NULL,
    CheckPenalty INT NOT NULL,
    SpeedPenalty INT NOT NULL,
    Cost DECIMAL(18,2),
	WeightPounds INT NOT NULL,
);

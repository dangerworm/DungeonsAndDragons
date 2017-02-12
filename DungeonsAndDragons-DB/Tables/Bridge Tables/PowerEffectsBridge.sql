CREATE TABLE [dbo].[PowerEffectsBridge]
(
    PowerEffectId INT IDENTITY(1,1) 
		CONSTRAINT PowerEffectsBridge_PowerEffectId_PK PRIMARY KEY,
    PowerId TINYINT NOT NULL 
		CONSTRAINT PowerEffectsBridge_PowerId_FK FOREIGN KEY REFERENCES dbo.Powers(PowerId),
    EffectId TINYINT NOT NULL 
		CONSTRAINT PowerEffectsBridge_EffectId_FK FOREIGN KEY REFERENCES dbo.EffectTypes(EffectTypeId)
);
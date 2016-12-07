CREATE TABLE [dbo].[WeaponPropertiesBridge]
(
	WeaponPropertyBridgeId INT IDENTITY(1,1) 
		CONSTRAINT WeaponPropertiesBridge_WeaponPropertyBridgeId_PK PRIMARY KEY,
	WeaponId INT NOT NULL 
		CONSTRAINT WeaponPropertiesBridge_WeaponId_FK FOREIGN KEY REFERENCES dbo.Weapons(WeaponId),
	PropertyId INT NOT NULL 
		CONSTRAINT WeaponPropertiesBridge_WeaponPropertyId_FK FOREIGN KEY REFERENCES dbo.WeaponProperties(WeaponPropertyId)
);
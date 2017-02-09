CREATE TABLE [dbo].[Weapons]
(
    WeaponId INT IDENTITY(1,1) 
		CONSTRAINT Weapons_WeaponId_PK PRIMARY KEY,
	WeaponTypeId INT NOT NULL 
		CONSTRAINT Weapons_WeaponTypeId_FK FOREIGN KEY REFERENCES dbo.WeaponTypes(WeaponTypeId),
	Name VARCHAR(50) NOT NULL,
	OwnerActorId INT
		CONSTRAINT Weapons_OwnerActorId_FK FOREIGN KEY REFERENCES dbo.Actors(ActorId),
);
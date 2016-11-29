CREATE TABLE [dbo].[ArmourItems]
(
    ArmourItemId INT IDENTITY(1,1)
		CONSTRAINT ArmourItems_ArmourItemId_PK PRIMARY KEY,
	ArmourTypeId INT
		CONSTRAINT ArmourItems_ArmourTypeId_FK FOREIGN KEY REFERENCES dbo.ArmourTypes(ArmourTypeId),
	OwnerActorId INT
		CONSTRAINT ArmourItems_OwnerActorId_FK FOREIGN KEY REFERENCES dbo.Actors(ActorId),
    Name VARCHAR(50),
	IsMagic BIT
);
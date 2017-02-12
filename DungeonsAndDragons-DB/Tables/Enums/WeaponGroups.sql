CREATE TABLE [dbo].[WeaponGroups]
(
    WeaponGroupId TINYINT IDENTITY(0,1) 
		CONSTRAINT WeaponGroups_WeaponGroupId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
	FlavourText VARCHAR(MAX)
);
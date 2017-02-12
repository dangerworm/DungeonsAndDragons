﻿CREATE TABLE [dbo].[WeaponProperties]
(
    WeaponPropertyId TINYINT IDENTITY(1,1) 
		CONSTRAINT WeaponProperties_WeaponPropertyId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
	FlavourText VARCHAR(MAX)
);
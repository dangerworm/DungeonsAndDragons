﻿CREATE TABLE [dbo].[EpicDestinies]
(
	EpicDestinyId INT IDENTITY(1,1) 
		CONSTRAINT EpicDestinies_EpicDestinyId_PK PRIMARY KEY,
	Name VARCHAR(50) NOT NULL,
	FlavourText VARCHAR(MAX)
);
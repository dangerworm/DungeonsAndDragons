﻿CREATE TABLE [dbo].[Skills]
(
    SkillId INT IDENTITY(1,1)
		CONSTRAINT Skills_SkillId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
	FlavourText VARCHAR(MAX)
);
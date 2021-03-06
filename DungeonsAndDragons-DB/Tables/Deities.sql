﻿CREATE TABLE [dbo].[Deities]
(
    DeityId TINYINT IDENTITY(0,1) 
		CONSTRAINT Deities_DeityId_PK PRIMARY KEY,
    AlignmentId TINYINT NOT NULL
		CONSTRAINT Deities_AlignmentId_DF DEFAULT(5)
		CONSTRAINT Deities_AlignmentId_FK FOREIGN KEY REFERENCES dbo.Alignments(AlignmentId),
	Name VARCHAR(50) NOT NULL,
    FlavourText VARCHAR(MAX)
);
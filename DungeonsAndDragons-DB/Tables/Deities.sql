CREATE TABLE [dbo].[Deities]
(
    DeityId INT IDENTITY(1,1) 
		CONSTRAINT Deities_DeityId_PK PRIMARY KEY,
    AlignmentId INT
		CONSTRAINT Deities_AlignmentId_FK FOREIGN KEY REFERENCES dbo.Alignments(AlignmentId),
	Name VARCHAR(50) NOT NULL,
    FlavourText VARCHAR(MAX)
);
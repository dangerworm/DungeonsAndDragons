CREATE TABLE [dbo].[Alignments]
(
	AlignmentId INT IDENTITY(1,1) 
		CONSTRAINT Alignments_AlignmentId_PK PRIMARY KEY,
	AuthorityLevelId INT NOT NULL
		CONSTRAINT Alignments_AuthorityTypeId_FK FOREIGN KEY REFERENCES dbo.AuthorityLevels(AuthorityLevelId),
	CompassionLevelId INT NOT NULL
		CONSTRAINT Alignments_CompassionLevelId_FK FOREIGN KEY REFERENCES dbo.CompassionLevels(CompassionLevelId)
);

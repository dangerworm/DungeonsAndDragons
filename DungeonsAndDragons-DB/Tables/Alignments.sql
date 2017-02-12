CREATE TABLE [dbo].[Alignments]
(
	AlignmentId TINYINT IDENTITY(1,1) 
		CONSTRAINT Alignments_AlignmentId_PK PRIMARY KEY,
	Name VARCHAR(50) NOT NULL,
	AuthorityLevelId TINYINT NOT NULL
		CONSTRAINT Alignments_AuthorityTypeId_FK FOREIGN KEY REFERENCES dbo.AuthorityLevels(AuthorityLevelId),
	CompassionLevelId TINYINT NOT NULL
		CONSTRAINT Alignments_CompassionLevelId_FK FOREIGN KEY REFERENCES dbo.CompassionLevels(CompassionLevelId)
);

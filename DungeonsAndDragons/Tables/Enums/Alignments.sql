CREATE TABLE [dbo].[Alignments]
(
    AlignmentId INT IDENTITY(1,1) 
		CONSTRAINT Alignments_AlignmentId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);
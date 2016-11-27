CREATE TABLE [dbo].[Scripts]
(
    ScriptId INT IDENTITY(1,1) CONSTRAINT Scripts_ScriptId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Lettering BINARY 
);
CREATE TABLE [dbo].[Languages]
(
    LanguageId TINYINT IDENTITY(1,1)
		CONSTRAINT Languages_LanguageId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    ScriptId TINYINT NOT NULL 
		CONSTRAINT Languages_ScriptId_FK FOREIGN KEY REFERENCES dbo.Scripts(ScriptId)
);
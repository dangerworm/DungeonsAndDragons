CREATE TABLE [dbo].[PowerEffects]
(
    PowerEffectId INT IDENTITY(1,1) 
		CONSTRAINT PowerEffects_PowerEffectId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    PowerKeywordId INT NOT NULL 
		CONSTRAINT PowerEffects_PowerKeywordId_FK FOREIGN KEY REFERENCES dbo.PowerKeywords(PowerKeywordId)
);
﻿--CREATE TABLE [dbo].[PowerKeywordsBridge]
--(
--    PowerKeywordId INT IDENTITY(1,1) 
--		CONSTRAINT PowerKeywordsBridge_PowerKeywordId_PK PRIMARY KEY,
--    PowerId INT NOT NULL 
--		CONSTRAINT PowerKeywordsBridge_PowerId_FK FOREIGN KEY REFERENCES dbo.Powers(PowerId),
--    KeywordId INT NOT NULL 
--		CONSTRAINT PowerKeywordsBridge_KeywordId_FK FOREIGN KEY REFERENCES dbo.PowerKeywords(PowerKeywordId)
--);
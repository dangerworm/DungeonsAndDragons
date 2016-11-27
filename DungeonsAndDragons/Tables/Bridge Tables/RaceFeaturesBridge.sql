﻿CREATE TABLE [dbo].[RaceFeaturesBridge]
(
    RaceFeatureId INT IDENTITY(1,1)
		CONSTRAINT RaceFeaturesBridge_RaceFeatureId_PK PRIMARY KEY,
    RaceId INT NOT NULL 
		CONSTRAINT RaceFeaturesBridge_RaceId_FK FOREIGN KEY REFERENCES dbo.Races(RaceId),
    FeatureId INT NOT NULL 
		CONSTRAINT RaceFeaturesBridge_FeatureId_FK FOREIGN KEY REFERENCES dbo.Features(FeatureId)
);
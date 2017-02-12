CREATE TABLE [dbo].[ClassFeaturesBridge]
(
    ClassFeatureId INT IDENTITY(1,1) 
		CONSTRAINT ClassFeaturesBridge_ClassFeatureId_PK PRIMARY KEY,
    ClassId TINYINT NOT NULL 
		CONSTRAINT ClassFeaturesBridge_ClassId_FK FOREIGN KEY REFERENCES dbo.Classes(ClassId),
    FeatureId TINYINT NOT NULL 
		CONSTRAINT ClassFeaturesBridge_FeatureId_FK FOREIGN KEY REFERENCES dbo.Features(FeatureId)
);
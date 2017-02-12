CREATE TABLE [dbo].[ClassTrainedSkillsBridge]
(
    ClassTrainedSkillId INT IDENTITY(1,1) 
		CONSTRAINT ClassTrainedSkillsBridge_ClassTrainedSkillId_PK PRIMARY KEY,
    ClassId TINYINT NOT NULL 
		CONSTRAINT ClassTrainedSkillsBridge_ClassId_FK FOREIGN KEY REFERENCES dbo.Classes(ClassId),
    SkillId TINYINT NOT NULL 
		CONSTRAINT ClassTrainedSkillsBridge_SkillId_FK FOREIGN KEY REFERENCES dbo.Skills(SkillId)
);
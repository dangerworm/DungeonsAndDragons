CREATE TABLE [dbo].[VisionLevels]
(
    VisionLevelId INT IDENTITY(1,1)
		CONSTRAINT VisionLevels_VisionLevelId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    HasLowLightVision BIT NOT NULL 
		CONSTRAINT VisionLevels_HasLowLightVision_DF DEFAULT(0),
    HasDarkVision BIT NOT NULL 
		CONSTRAINT VisionLevels_HasDarkVision_DF DEFAULT(0),
    HasBlindSight BIT NOT NULL 
		CONSTRAINT VisionLevels_HasBlindSight_DF DEFAULT(0),
    HasTremorSense BIT NOT NULL 
		CONSTRAINT VisionLevels_HasTremorSense_DF DEFAULT(0)
);
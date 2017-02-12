CREATE TABLE [dbo].[Features]
(
    FeatureId TINYINT IDENTITY(1,1)
		CONSTRAINT Features_FeatureId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    TextDescription VARCHAR(255) NOT NULL,
    InitiativeModifier INT,
    HitPointModifier INT,
    HealingSurgesModifier INT
);
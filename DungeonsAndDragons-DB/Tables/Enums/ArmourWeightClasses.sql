﻿CREATE TABLE [dbo].[ArmourWeightClasses]
(
    ArmourWeightClassId TINYINT IDENTITY(1,1) 
		CONSTRAINT ArmourWeightClasses_ArmourWeightClassId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);
﻿CREATE TABLE [dbo].[ActorTypes]
(
    ActorTypeId INT IDENTITY(1,1) 
		CONSTRAINT ActorTypes_ActorTypeId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);
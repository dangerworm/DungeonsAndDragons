﻿CREATE TABLE [dbo].[Genders]
(
    GenderId TINYINT IDENTITY(1,1) 
		CONSTRAINT Genders_GenderId_PK PRIMARY KEY,
    Name VARCHAR(10) NOT NULL
);
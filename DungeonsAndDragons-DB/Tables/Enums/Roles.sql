﻿CREATE TABLE [dbo].[Roles]
(
    RoleId TINYINT IDENTITY(1,1) CONSTRAINT Roles_RoleId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    FlavourText VARCHAR(MAX)
);
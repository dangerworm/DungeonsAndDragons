﻿CREATE TABLE [dbo].[Sizes]
(
    SizeId INT IDENTITY(1,1) 
		CONSTRAINT Sizes_SizeId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Reach INT NOT NULL
);
CREATE TABLE [dbo].[LightSources]
(
    LightSourceId INT IDENTITY(1,1) CONSTRAINT LightSources_LightSourceId_PK PRIMARY KEY,
    Name INT NOT NULL,
    Radius INT NOT NULL,
    Brightness INT NOT NULL,
    Duration INT NOT NULL
);
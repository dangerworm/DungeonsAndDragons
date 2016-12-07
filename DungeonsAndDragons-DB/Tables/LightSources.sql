CREATE TABLE [dbo].[LightSources]
(
    LightSourceId INT IDENTITY(1,1) CONSTRAINT LightSources_LightSourceId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Radius INT NOT NULL,
    Brightness VARCHAR(50) NOT NULL,
    Duration INT NOT NULL
);
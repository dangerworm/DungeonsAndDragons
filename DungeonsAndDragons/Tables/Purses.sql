CREATE TABLE [dbo].[Purses]
(
    PurseId INT IDENTITY(1,1) 
		CONSTRAINT Purses_PurseId_PK PRIMARY KEY,
    OwnerActorId INT NOT NULL 
		CONSTRAINT Purses_OwnerActorId_FK FOREIGN KEY REFERENCES dbo.Actors(ActorId),
    CopperPieces INT NOT NULL 
		CONSTRAINT Purses_CopperPieces_DF DEFAULT(0),
    SilverPieces INT NOT NULL 
		CONSTRAINT Purses_SilverPieces_DF DEFAULT(0),
    GoldPieces INT NOT NULL 
		CONSTRAINT Purses_GoldPieces_DF DEFAULT(0),
    Platinum INT NOT NULL 
		CONSTRAINT Purses_Platinum_DF DEFAULT(0),
    AstralDiamonds INT NOT NULL 
		CONSTRAINT Purses_AstralDiamonds_DF DEFAULT(0)
);
CREATE TABLE [dbo].[Shops]
(
    ShopId INT IDENTITY(1,1) 
		CONSTRAINT Shops_ShopId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    OwnerActorId INT NOT NULL 
		CONSTRAINT Shops_OwnerActorId_FK FOREIGN KEY REFERENCES dbo.Actors(ActorId),
    CostModifier DECIMAL NOT NULL 
		CONSTRAINT Shops_CostModifier_DF DEFAULT(0),
    SellsMagicItems BIT NOT NULL 
		CONSTRAINT Shops_SellsMagicItems_DF DEFAULT(0),
    FlavourText VARCHAR(MAX)
);
CREATE TABLE [dbo].[WeaponCategories]
(
    WeaponCategoryId TINYINT IDENTITY(1,1) 
		CONSTRAINT WeaponCategories_WeaponCategoryId_PK PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
	FlavourText VARCHAR(MAX)
);
INSERT INTO 
	dbo.Alignments(AuthorityLevelId, CompassionLevelId)
VALUES
	(1,1),
	(2,1),
	(3,1),
	(1,2),
	(2,2),
	(3,2),
	(1,3),
	(2,3),
	(3,3)
GO

INSERT INTO 
	dbo.ArmourClasses(Name, ArmourWeightClassId)
VALUES
	('Cloth Armour',1),
	('Leather Armour',1),
	('Hide Armour',1),
	('Chainmail',2),
	('Scale Armour',2),
	('Plate Armour',2),
	('Shield', NULL)
GO

INSERT INTO 
	dbo.ArmourTypes(ArmourClassId, Name, Bonus, MinEnchantmentBonus,
		CheckPenalty, SpeedPenalty, Cost, WeightPounds)
VALUES
	(1,	'Cloth armour (basic clothing)', 0, 0, 0, 0, 1.00, 4),
	(1,	'Feyweave armour', 1, 4, 0, 0, NULL, 5),
	(1,	'Starweave armour', 2, 6, 0, 0, NULL, 3),
	(2,	'Leather armour', 2, 0, 0, 0, 25.00, 15),
	(2,	'Feyleather armour', 3, 4, 0, 0, NULL, 15),
	(2,	'Starleather armour', 4, 6, 0, 0, NULL, 15),
	(3,	'Hide armour', 3, 0, -1, 0, 30.00, 25),
	(3,	'Darkhide armour', 4, 4, -1, 0, NULL, 25),
	(3,	'Elderhide armour', 5, 6, -1, 0, NULL, 25),
	(4,	'Chainmail', 6, 0, -1, -1, 40.00, 40),
	(4,	'Forgemail', 9, 4, -1, -1, NULL, 40),
	(4,	'Spiritmail', 12, 6, -1, -1, NULL, 40),
	(5,	'Scale armour', 7, 0, 0, -1, 45.00, 45),
	(5,	'Wyrmscale armour', 10, 4, 0, -1, NULL, 45),
	(5,	'Elderscale armour', 13, 6, 0, -1, NULL, 45),
	(6,	'Plate armour', 8, 0, -2, -1, 50.00, 50),
	(6,	'Warplate armour', 11, 4, -2, -1, NULL, 50),
	(6,	'Godplate armour', 14, 6, -2, -1, NULL, 50),
	(7,	'Light shield', 1, 0, 0, 0, 5.00, 6),
	(7,	'Heavy shield', 2, 0, -2, 0, 10.00, 15)
GO

INSERT INTO 
	dbo.Classes(Name, RoleId, PowerSourceId, 
		BaseHitPoints, BaseHitPointsAbilityId, HitPointsPerLevel,
		HealingSurges, HealingSurgesAbilityId)
VALUES
	('Cleric',3,2,12,2,5,7,2),
	('Fighter',2,3,15,2,6,9,2),
	('Paladin',2,2,15,2,6,10,2),
	('Ranger',4,3,12,2,5,6,2),
	('Rogue',4,3,12,2,5,6,2),
	('Warlock',4,1,12,2,5,6,2),
	('Warlord',3,3,12,2,5,7,2),
	('Wizard',1,1,10,2,4,6,2)
GO

INSERT INTO 
	dbo.LightSources(Name, Radius, Brightness, Duration, FlavourText)
VALUES
	('Candle',2,'Dim',1),
	('Torch',5,'Bright',1),
	('Lantern',10,'Bright',8),
	('Campfire',10,'Bright',8),
	('Sunrod',20,'Bright',4)
GO

INSERT INTO 
	dbo.Sizes(Name, MinSpace, Reach)
VALUES
	('Tiny',0.5,0,0),
	('Small',1,1,1),
	('Medium',1,1,1),
	('Large',2,1,2),
	('Huge',3,2,3),
	('Gargantuan',4,3,4)
GO

INSERT INTO 
	dbo.VisionLevels(Name, HasLowLightVision, HasDarkVision,
		HasBlindSight, HasTremorSense)
VALUES
	('Normal',0,0,0,0),
	('Low-light',1,0,0,0),
	('Darkvision',1,1,0,0),
	('Blindsight',1,1,1,0),
	('Tremorsense',0,0,0,1)
GO

INSERT INTO 
	dbo.Races(Name, SizeId, Speed, VisionLevelId, IsPlayable)
VALUES
	('Dragonborn',3,6,1,1),
	('Dwarf',3,5,2,1),
	('Eladrin',3,6,2,1),
	('Elf',3,7,2,1),
	('Half-Elf',3,6,2,1),
	('Halfling',2,6,1,1),
	('Human',3,6,1,1),
	('Tiefling',3,6,2,1)
GO
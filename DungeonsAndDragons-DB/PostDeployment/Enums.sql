INSERT INTO 
	dbo.Abilities(Name)
VALUES 
	('Charisma'),
	('Constitution'),
	('Dexterity'),
	('Intelligence'),
	('Strength'),
	('Wisdom')
GO

INSERT INTO dbo.ActionTypes(Name)
VALUES
	('Standard Action'),
	('Free Action'),
	('Immediate Interrupt'),
	('Immediate Reaction'),
	('Minor Action'),
	('Move Action'),
	('No Action')
GO

INSERT INTO dbo.ActorTypes(Name)
VALUES
	('Player Character'),
	('Non-Player Character'),
	('Trap')
GO


INSERT INTO dbo.ArmourWeightClasses(Name)
VALUES
	('Light'),
	('Heavy')
GO

INSERT INTO dbo.AttackTypes(Name)
VALUES
	('Area'),
	('Close'),
	('Melee'),
	('Ranged')
GO

INSERT INTO dbo.AuthorityLevels(Name)
VALUES
	('Lawful'),
	('Neutral'),
	('Chaotic')
GO

INSERT INTO dbo.CompassionLevels(Name)
VALUES
	('Good'),
	('Neutral'),
	('Evil')
GO

INSERT INTO dbo.DamageTypes(Name)
VALUES
	('Acid'),
	('Cold'),
	('Fire'),
	('Force'),
	('Lightning'),
	('Necrotic'),
	('Poison'),
	('Psychic'),
	('Radiant'),
	('Thunder')
GO

INSERT INTO dbo.Defenses(Name)
VALUES
	('Armour Class'),
	('Fortitude'),
	('Reflex'),
	('Will')
GO

INSERT INTO dbo.DurationUnits(Name)
VALUES
	('Action'),
	('Day'),
	('Encounter'),
	('Fortnight'),
	('Hour'),
	('Minute'),
	('Month'),
	('Round'),
	('Second'),
	('Turn'),
	('Week')
GO

INSERT INTO dbo.EffectTypes(Name)
VALUES
	('Charm'),
	('Conjuration'),
	('Fear'),
	('Healing'),
	('Illusion'),
	('Poison'),
	('Polymorph'),
	('Reliable'),
	('Sleep'),
	('Stance'),
	('Teleportation'),
	('Zone')
GO

INSERT INTO dbo.EpicDestinies(Name)
VALUES
	('Archmage'),
	('Deadly Trickster'),
	('Demigod'),
	('Eternal Seeker')
GO

INSERT INTO dbo.Genders(Name)
VALUES
	('Male'),
	('Female'),
	('Other')
GO

INSERT INTO dbo.ImplementTypes(Name)
VALUES
	('Orb'),
	('Rod'),
	('Staff'),
	('Wand')
GO

INSERT INTO dbo.PowerSources(Name)
VALUES
	('Arcane'),
	('Divine'),
	('Martial'),
	('Primal')
GO

INSERT INTO dbo.PowerUsages(Name)
VALUES
	('At-Will'),
	('Daily'),
	('Encounter'),
	('Utility')

GO

INSERT INTO dbo.Roles(Name)
VALUES
	('Controller'),
	('Defender'),
	('Leader'),
	('Striker')
GO
INSERT INTO dbo.Scripts(Name)
VALUES
	('Barazhad'),
	('Common'),
	('Davek'),
	('Iokharic'),
	('Rellanic'),
	('Supernal')
GO

INSERT INTO dbo.Skills(Name)
VALUES
	('Acrobatics'),
	('Arcana'),
	('Athletics'),
	('Bluff'),
	('Diplomacy'),
	('Dungeoneering'),
	('Endurance'),
	('Heal'),
	('History'),
	('Insight'),
	('Intimidate'),
	('Nature'),
	('Perception'),
	('Religion'),
	('Stealth'),
	('Streetwise'),
	('Thievery')
GO

INSERT INTO dbo.WeaponCategories(Name)
VALUES
	('Improvised'),
	('Military'),
	('Simple'),
	('Superior')
GO

INSERT INTO dbo.WeaponGroups(Name)
VALUES
	('None'),		-- 0
	('Axe'),		-- 1
	('Bow'),		-- 2
	('Crossbow'),	-- 3
	('Flail'),		-- 4
	('Hammer'),		-- 5
	('Heavy Blade'),-- 6
	('Light Blade'),-- 7
	('Mace'),		-- 8
	('Pick'),		-- 9
	('Polearm'),	-- 10
	('Sling'),		-- 11
	('Spear'),		-- 12
	('Staff'),		-- 13
	('Unarmed')		-- 14
GO

INSERT INTO dbo.WeaponProperties(Name)
VALUES
	('Heavy Thrown'),
	('High Crit'),
	('Light Thrown'),
	('Load'),
	('Off-Hand'),
	('Reach'),
	('Small'),
	('Versatile')
GO
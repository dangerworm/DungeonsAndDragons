INSERT INTO 
	dbo.Alignments(Name, AuthorityLevelId, CompassionLevelId)
VALUES
	('Lawful Good',1,1),
	('Good',2,1),
	('Chaotic Good',3,1),
	('Unaligned (Lawful)',1,2),
	('Unaligned',2,2),
	('Unaligned (Chaotic)',3,2),
	('Lawful Evil',1,3),
	('Evil',2,3),
	('Chaotic Evil',3,3)
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
	-- Book 1
	('Cleric',3,2,12,2,5,7,2),     -- 01
	('Fighter',2,3,15,2,6,9,2),	   -- 02
	('Paladin',2,2,15,2,6,10,2),   -- 03
	('Ranger',4,3,12,2,5,6,2),	   -- 04
	('Rogue',4,3,12,2,5,6,2),	   -- 05
	('Warlock',4,1,12,2,5,6,2),	   -- 06
	('Warlord',3,3,12,2,5,7,2),	   -- 07
	('Wizard',1,1,10,2,4,6,2),	   -- 08
	-- Book 2					   
	('Avenger',4,2,14,2,6,7,2),	   -- 09
	('Barbarian',4,4,15,2,6,8,2),  -- 10
	('Bard',3,1,12,2,5,7,2),	   -- 11
	('Druid',1,4,12,2,5,7,2),	   -- 12
	('Invoker',1,2,10,2,4,6,2),	   -- 13
	('Shaman',3,4,12,2,5,7,2),	   -- 14
	('Sorcerer',4,1,12,2,5,6,2),   -- 15
	('Warden',2,4,17,2,7,9,2)	   -- 16
GO

INSERT INTO
	dbo.Deities(Name, AlignmentId, FlavourText)
VALUES
	('None', 5,				NULL),
	('Avandra', 2,			'The god of change, Avandra delights in freedom, trade, travel, adventure, and the frontier. Her temples are few in civilized lands, but her wayside shrines appear throughout the world. Halflings, merchants, and all types of adventurers are drawn to her worship, and many people raise a glass in her honor, viewing her as the god of luck. Her commandments are few: ✦ Luck favors the bold. Take your fate into your own hands, and Avandra smiles upon you. ✦ Strike back against those who would rob you of your freedom and urge others to fight for their own liberty. ✦ Change is inevitable, but it takes the work of the faithful to ensure that change is for the better. '),
	('Bahamut', 1,			'Called the Platinum Dragon, Bahamut is the god of justice, protection, nobility, and honor. Lawful good paladins often revere him, and metallic dragons worship him as the first of their kind. Monarchs are crowned in his name. He commands his followers thus: ✦ Uphold the highest ideals of honor and justice. ✦ Be constantly vigilant against evil and oppose it on all fronts. ✦ Protect the weak, liberate the oppressed, and defend just order. '),
	('Corellon', 5,			'The god of spring, beauty, and the arts, Corellon is the patron of arcane magic and the fey. He seeded the world with arcane magic and planted the most ancient forests. Artists and musicians worship him, as do those who view their spellcasting as an art, and his shrines can be found throughout the Feywild. He despises Lolth and her priestesses for leading the drow astray. He urges his followers thus: ✦ Cultivate beauty in all that you do, whether you’re casting a spell, composing a saga, strumming a lute, or practicing the arts of war. ✦ Seek out lost magic items, forgotten rituals, and ancient works of art. Corellon might have inspired them in the world’s first days. ✦ Thwart the followers of Lolth at every opportunity.'),
	('Erathis', 5, 			'Erathis is the god of civilization. She is the muse of great invention, founder of cities, and author of laws. Rulers, judges, pioneers, and devoted citizens revere her, and her temples hold prominent places in most of the world’s major cities. Her laws are many, but their purpose is straightforward: ✦ Work with others to achieve your goals. Community and order are always stronger than the disjointed efforts of lone individuals. ✦ Tame the wilderness to make it fit for habitation, and defend the light of civilization against the encroaching darkness. ✦ Seek out new ideas, new inventions, new lands to inhabit, new wilderness to conquer. Build machines, build cities, build empires. '),
	('Ioun', 5,				'Ioun is the god of knowledge, skill, and prophecy. Sages, seers, and tacticians revere her, as do all who live by their knowledge and mental power. Corellon is the patron of arcane magic, but Ioun is the patron of its study. Libraries and wizard academies are built in her name. Her commands are also teachings: ✦ Seek the perfection of your mind by bringing reason, perception, and emotion into balance with one another. ✦ Accumulate, preserve, and distribute knowledge in all forms. Pursue education, build libraries, and seek out lost and ancient lore. ✦ Be watchful at all times for the followers of Vecna, who seek to control knowledge and keep secrets. Oppose their schemes, unmask their secrets, and blind them with the light of truth and reason.'),
	('Kord', 5,				'Kord is the storm god and the lord of battle. He revels in strength, battlefield prowess, and thunder. Fighters and athletes revere him. He is a mercurial god, unbridled and wild, who summons storms over land and sea; those who hope for better weather appease him with prayers and spirited toasts. He gives few commands: ✦ Be strong, but do not use your strength for wanton destruction. ✦ Be brave and scorn cowardice in any form. ✦ Prove your might in battle to win glory and renown. '),
	('Melora', 5,			'Melora is the god of the wilderness and the sea. She is both the wild beast and the peaceful forest, the raging whirlpool and the quiet desert. Rangers, hunters, and elves revere her, and sailors make offerings to her before beginning their voyages. Her strictures are these: ✦ Protect the wild places of the world from destruction and overuse. Oppose the rampant spread of cities and empires. ✦ Hunt aberrant monsters and other abominations of nature. ✦ Do not fear or condemn the savagery of nature. Live in harmony with the wild. '),
	('Moradin', 1,			'Moradin is the god of creation and patron of artisans, especially miners and smiths. He carved the mountains from primordial earth and is the guardian and protector of the hearth and the family. Dwarves from all walks of life follow him. He demands these behaviors of his followers: ✦ Meet adversity with stoicism and tenacity. ✦ Demonstrate loyalty to your family, your clan, your leaders, and your people. ✦ Strive to make a mark on the world, a lasting legacy. To make something that lasts is the highest good, whether you are a smith working at a forge or a ruler building a dynasty.'),
	('Pelor', 2,			'God of the sun and summer, Pelor is the keeper of time. He supports those in need and opposes all that is evil. As the lord of agriculture and the bountiful harvest, he is the deity most commonly worshiped by ordinary humans, and his priests are well received wherever they go. Paladins and rangers are found among his worshipers. He directs his followers thus: ✦ Alleviate suffering wherever you find it. ✦ Bring Pelor’s light into places of darkness, showing kindness, mercy, and compassion. ✦ Be watchful against evil. '),
	('The Raven Queen', 5,	'The name of the god of death is long forgotten, but she is called the Raven Queen. She is the spinner of fate and the patron of winter. She marks the end of each mortal life, and mourners call upon her during funeral rites, in the hope that she will guard the departed from the curse of undeath. She expects her followers to abide by these commandments: ✦ Hold no pity for those who suffer and die, for death is the natural end of life. ✦ Bring down the proud who try to cast off the chains of fate. As the instrument of the Raven Queen, you must punish hubris where you find it. ✦ Watch for the cults of Orcus and stamp them out whenever they arise. The Demon Prince of the Undead seeks to claim the Raven Queen’s throne. '),
	('Sehanine', 5,			'God of the moon and autumn, Sehanine is the patron of trickery and illusions. She has close ties to Corellon and Melora and is a favorite deity among elves and halflings. She is also the god of love, who sends shadows to cloak lovers’ trysts. Scouts and thieves ask for her blessing on their work. Her teachings are simple: ✦ Follow your goals and seek your own destiny. ✦ Keep to the shadows, avoiding the blazing light of zealous good and the utter darkness of evil. ✦ Seek new horizons and new experiences, and let nothing tie you down.'),
	('Primal Spirits', 5,	NULL)
GO

INSERT INTO 
	dbo.Languages(Name, ScriptId)
VALUES
	('Common',2),
	('Deep Speech',5),
	('Draconic',4),
	('Dwarven',3),
	('Elven',5),
	('Giant',3),
	('Goblin',2),
	('Primordial',1),
	('Supernal',6),
	('Abyssal',1)
GO

INSERT INTO 
	dbo.LightSources(Name, Radius, Brightness, Duration)
VALUES
	('Candle',2,'Dim',1),
	('Torch',5,'Bright',1),
	('Lantern',10,'Bright',8),
	('Campfire',10,'Bright',8),
	('Sunrod',20,'Bright',4)
GO

INSERT INTO 
	dbo.Sizes(Name, MinSpace, MinReach, MaxReach)
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
	-- Book 1
	('Dragonborn',3,6,1,1),         -- 01
	('Dwarf',3,5,2,1),			    -- 02
	('Eladrin',3,6,2,1),		    -- 03
	('Elf',3,7,2,1),			    -- 04
	('Half-Elf',3,6,2,1),		    -- 05
	('Halfling',2,6,1,1),		    -- 06
	('Human',3,6,1,1),			    -- 07
	('Tiefling',3,6,2,1),		    -- 08
	-- Book 2					    
	('Deva',3,6,1,1),			    -- 09
	('Gnome',2,5,2,1),			    -- 10
	('Goliath',3,6,1,1),		    -- 11
	('Half-Orc',3,6,2,1),		    -- 12
	('Longtooth Shifter',3,6,2,1),  -- 13
	('Razorclaw Shifter',3,6,2,1)   -- 14
GO									

INSERT INTO
	dbo.AbilityValues(RaceId, AbilityId, Modifier)
VALUES
	(1,1,2),
	(1,5,2),
	(2,2,2),
	(2,6,2),
	(3,3,2),
	(3,4,2),
	(4,3,2),
	(4,6,2),
	(5,1,2),
	(5,2,2),
	(6,1,2),
	(6,3,2),
	(8,1,2),
	(8,4,2),
	(9,4,2),
	(9,6,2),
	(10,1,2),
	(10,4,2),
	(11,2,2),
	(11,5,2),
	(12,3,2),
	(12,5,2),
	(13,5,2),
	(13,6,2),
	(13,3,2),
	(13,6,2)
GO

INSERT INTO 
	dbo.LanguageRacesBridge(RaceId, LanguageId)
VALUES
	(1,1),
	(1,3),
	(2,1),
	(2,4),
	(3,1),
	(3,5),
	(4,1),
	(4,5),
	(5,1),
	(5,5),
	(6,1),
	(7,1),
	(8,1),
	(9,1),
	(10,1),
	(10,5),
	(11,1),
	(12,1),
	(12,6),
	(13,1)
GO

INSERT INTO
	dbo.SkillModifiers(RaceId, SkillId, Modifier)
VALUES
	(1,9,2),
	(1,11,2),
	(2,6,2),
	(2,7,2),
	(3,2,2),
	(3,9,2),
	(4,12,2),
	(4,13,2),
	(5,5,2),
	(5,10,2),
	(6,1,2),
	(6,17,2),
	(8,4,2),
	(8,15,2),
	(9,10,2),
	(9,15,2),
	(10,2,2),
	(10,16,2),
	(11,3,2),
	(11,13,2),
	(12,8,2),
	(12,12,2),
	(13,3,2),
	(13,8,2),
	(13,1,2),
	(13,16,2)
GO

INSERT INTO
	dbo.Actors(ActorTypeId)
VALUES
	(1), 
	(1),
	(1),
	(1),
	(1),
	(1),
	(1)
GO

INSERT INTO
	dbo.PlayerCharacters(ActorId, Name, ClassId, ExperiencePoints, RaceId, 
		Age, GenderId, Height, WeightPounds, AlignmentId, DeityId)
VALUES
	(1,'Aeolius Legodir',	 3,750, 4,79,1,'5''8"',162, 2,  9),
	(2,'Glod Djürsbeck',	14,750, 2,46,1,'4''7"',130, 2, 12),
	(3,'Leucis Zaeloch',	 6,750, 8,25,1,'6''3"',242, 5,  0),
	(4,'Saskia Minyathr',	 4,750, 4,52,2,'5''2"',145, 5,  7),
	(5,'Squanto',			12,750,13,44,1,'5''9"',210, 5,  1),
	(6,'Yuo',				 9,750, 7,61,1,'6''1"',122, 5,  6)
GO

INSERT INTO	
	dbo.Games(Name)
VALUES
	('The First Great Outing')

INSERT INTO
	dbo.GameActorsBridge(GameId, ActorId)
VALUES
	(1,1),
	(1,2),
	(1,3),
	(1,4),
	(1,5),
	(1,6)

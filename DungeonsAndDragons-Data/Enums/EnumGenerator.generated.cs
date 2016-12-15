// This is a generated file. Do not attempt to modify it as your changes would be overwritten.
// Connection String Used: Data Source=FERMI;Initial Catalog=DungeonsAndDragons;Integrated Security=True
using System.CodeDom.Compiler;
using System.ComponentModel;

namespace DungeonsAndDragons_Data.Enums
{
	// Enums
    /// <summary>
    /// Abilities auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Abilities : int
    {
        /// <summary>
        /// Charisma (1)
        /// </summary>
		[Description("Charisma")]
        Charisma = 1,

        /// <summary>
        /// Constitution (2)
        /// </summary>
		[Description("Constitution")]
        Constitution = 2,

        /// <summary>
        /// Dexterity (3)
        /// </summary>
		[Description("Dexterity")]
        Dexterity = 3,

        /// <summary>
        /// Intelligence (4)
        /// </summary>
		[Description("Intelligence")]
        Intelligence = 4,

        /// <summary>
        /// Strength (5)
        /// </summary>
		[Description("Strength")]
        Strength = 5,

        /// <summary>
        /// Wisdom (6)
        /// </summary>
		[Description("Wisdom")]
        Wisdom = 6
	}

    /// <summary>
    /// ActionTypes auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum ActionTypes : int
    {
        /// <summary>
        /// Standard Action (1)
        /// </summary>
		[Description("Standard Action")]
        StandardAction = 1,

        /// <summary>
        /// Free Action (2)
        /// </summary>
		[Description("Free Action")]
        FreeAction = 2,

        /// <summary>
        /// Immediate Interrupt (3)
        /// </summary>
		[Description("Immediate Interrupt")]
        ImmediateInterrupt = 3,

        /// <summary>
        /// Immediate Reaction (4)
        /// </summary>
		[Description("Immediate Reaction")]
        ImmediateReaction = 4,

        /// <summary>
        /// Minor Action (5)
        /// </summary>
		[Description("Minor Action")]
        MinorAction = 5,

        /// <summary>
        /// Move Action (6)
        /// </summary>
		[Description("Move Action")]
        MoveAction = 6,

        /// <summary>
        /// No Action (7)
        /// </summary>
		[Description("No Action")]
        NoAction = 7
	}

    /// <summary>
    /// ActorTypes auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum ActorTypes : int
    {
        /// <summary>
        /// Player Character (1)
        /// </summary>
		[Description("Player Character")]
        PlayerCharacter = 1,

        /// <summary>
        /// Non-Player Character (2)
        /// </summary>
		[Description("Non-Player Character")]
        NonPlayerCharacter = 2,

        /// <summary>
        /// Trap (3)
        /// </summary>
		[Description("Trap")]
        Trap = 3
	}

    /// <summary>
    /// ArmourWeightClasses auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum ArmourWeightClasses : int
    {
        /// <summary>
        /// Light (1)
        /// </summary>
		[Description("Light")]
        Light = 1,

        /// <summary>
        /// Heavy (2)
        /// </summary>
		[Description("Heavy")]
        Heavy = 2
	}

    /// <summary>
    /// AttackTypes auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum AttackTypes : int
    {
        /// <summary>
        /// Area (1)
        /// </summary>
		[Description("Area")]
        Area = 1,

        /// <summary>
        /// Close (2)
        /// </summary>
		[Description("Close")]
        Close = 2,

        /// <summary>
        /// Melee (3)
        /// </summary>
		[Description("Melee")]
        Melee = 3,

        /// <summary>
        /// Ranged (4)
        /// </summary>
		[Description("Ranged")]
        Ranged = 4
	}

    /// <summary>
    /// AuthorityLevels auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum AuthorityLevels : int
    {
        /// <summary>
        /// Lawful (1)
        /// </summary>
		[Description("Lawful")]
        Lawful = 1,

        /// <summary>
        /// Neutral (2)
        /// </summary>
		[Description("Neutral")]
        Neutral = 2,

        /// <summary>
        /// Chaotic (3)
        /// </summary>
		[Description("Chaotic")]
        Chaotic = 3
	}

    /// <summary>
    /// CompassionLevels auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum CompassionLevels : int
    {
        /// <summary>
        /// Good (1)
        /// </summary>
		[Description("Good")]
        Good = 1,

        /// <summary>
        /// Neutral (2)
        /// </summary>
		[Description("Neutral")]
        Neutral = 2,

        /// <summary>
        /// Evil (3)
        /// </summary>
		[Description("Evil")]
        Evil = 3
	}

    /// <summary>
    /// DamageTypes auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum DamageTypes : int
    {
        /// <summary>
        /// Acid (1)
        /// </summary>
		[Description("Acid")]
        Acid = 1,

        /// <summary>
        /// Cold (2)
        /// </summary>
		[Description("Cold")]
        Cold = 2,

        /// <summary>
        /// Fire (3)
        /// </summary>
		[Description("Fire")]
        Fire = 3,

        /// <summary>
        /// Force (4)
        /// </summary>
		[Description("Force")]
        Force = 4,

        /// <summary>
        /// Lightning (5)
        /// </summary>
		[Description("Lightning")]
        Lightning = 5,

        /// <summary>
        /// Necrotic (6)
        /// </summary>
		[Description("Necrotic")]
        Necrotic = 6,

        /// <summary>
        /// Poison (7)
        /// </summary>
		[Description("Poison")]
        Poison = 7,

        /// <summary>
        /// Psychic (8)
        /// </summary>
		[Description("Psychic")]
        Psychic = 8,

        /// <summary>
        /// Radiant (9)
        /// </summary>
		[Description("Radiant")]
        Radiant = 9,

        /// <summary>
        /// Thunder (10)
        /// </summary>
		[Description("Thunder")]
        Thunder = 10
	}

    /// <summary>
    /// Defenses auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Defenses : int
    {
        /// <summary>
        /// Armour Class (1)
        /// </summary>
		[Description("Armour Class")]
        ArmourClass = 1,

        /// <summary>
        /// Fortitude (2)
        /// </summary>
		[Description("Fortitude")]
        Fortitude = 2,

        /// <summary>
        /// Reflex (3)
        /// </summary>
		[Description("Reflex")]
        Reflex = 3,

        /// <summary>
        /// Will (4)
        /// </summary>
		[Description("Will")]
        Will = 4
	}

    /// <summary>
    /// DurationUnits auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum DurationUnits : int
    {
        /// <summary>
        /// Action (1)
        /// </summary>
		[Description("Action")]
        Action = 1,

        /// <summary>
        /// Day (2)
        /// </summary>
		[Description("Day")]
        Day = 2,

        /// <summary>
        /// Encounter (3)
        /// </summary>
		[Description("Encounter")]
        Encounter = 3,

        /// <summary>
        /// Fortnight (4)
        /// </summary>
		[Description("Fortnight")]
        Fortnight = 4,

        /// <summary>
        /// Hour (5)
        /// </summary>
		[Description("Hour")]
        Hour = 5,

        /// <summary>
        /// Minute (6)
        /// </summary>
		[Description("Minute")]
        Minute = 6,

        /// <summary>
        /// Month (7)
        /// </summary>
		[Description("Month")]
        Month = 7,

        /// <summary>
        /// Round (8)
        /// </summary>
		[Description("Round")]
        Round = 8,

        /// <summary>
        /// Second (9)
        /// </summary>
		[Description("Second")]
        Second = 9,

        /// <summary>
        /// Turn (10)
        /// </summary>
		[Description("Turn")]
        Turn = 10,

        /// <summary>
        /// Week (11)
        /// </summary>
		[Description("Week")]
        Week = 11
	}

    /// <summary>
    /// EffectTypes auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum EffectTypes : int
    {
        /// <summary>
        /// Charm (1)
        /// </summary>
		[Description("Charm")]
        Charm = 1,

        /// <summary>
        /// Conjuration (2)
        /// </summary>
		[Description("Conjuration")]
        Conjuration = 2,

        /// <summary>
        /// Fear (3)
        /// </summary>
		[Description("Fear")]
        Fear = 3,

        /// <summary>
        /// Healing (4)
        /// </summary>
		[Description("Healing")]
        Healing = 4,

        /// <summary>
        /// Illusion (5)
        /// </summary>
		[Description("Illusion")]
        Illusion = 5,

        /// <summary>
        /// Poison (6)
        /// </summary>
		[Description("Poison")]
        Poison = 6,

        /// <summary>
        /// Polymorph (7)
        /// </summary>
		[Description("Polymorph")]
        Polymorph = 7,

        /// <summary>
        /// Reliable (8)
        /// </summary>
		[Description("Reliable")]
        Reliable = 8,

        /// <summary>
        /// Sleep (9)
        /// </summary>
		[Description("Sleep")]
        Sleep = 9,

        /// <summary>
        /// Stance (10)
        /// </summary>
		[Description("Stance")]
        Stance = 10,

        /// <summary>
        /// Teleportation (11)
        /// </summary>
		[Description("Teleportation")]
        Teleportation = 11,

        /// <summary>
        /// Zone (12)
        /// </summary>
		[Description("Zone")]
        Zone = 12
	}

    /// <summary>
    /// EpicDestinies auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum EpicDestinies : int
    {
        /// <summary>
        /// Archmage (1)
        /// </summary>
		[Description("Archmage")]
        Archmage = 1,

        /// <summary>
        /// Deadly Trickster (2)
        /// </summary>
		[Description("Deadly Trickster")]
        DeadlyTrickster = 2,

        /// <summary>
        /// Demigod (3)
        /// </summary>
		[Description("Demigod")]
        Demigod = 3,

        /// <summary>
        /// Eternal Seeker (4)
        /// </summary>
		[Description("Eternal Seeker")]
        EternalSeeker = 4
	}

    /// <summary>
    /// Genders auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Genders : int
    {
        /// <summary>
        /// Male (1)
        /// </summary>
		[Description("Male")]
        Male = 1,

        /// <summary>
        /// Female (2)
        /// </summary>
		[Description("Female")]
        Female = 2,

        /// <summary>
        /// Other (3)
        /// </summary>
		[Description("Other")]
        Other = 3
	}

    /// <summary>
    /// ImplementTypes auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum ImplementTypes : int
    {
        /// <summary>
        /// Orb (1)
        /// </summary>
		[Description("Orb")]
        Orb = 1,

        /// <summary>
        /// Rod (2)
        /// </summary>
		[Description("Rod")]
        Rod = 2,

        /// <summary>
        /// Staff (3)
        /// </summary>
		[Description("Staff")]
        Staff = 3,

        /// <summary>
        /// Wand (4)
        /// </summary>
		[Description("Wand")]
        Wand = 4
	}

    /// <summary>
    /// MapAreaTypes auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum MapAreaTypes : int
    {
	}

    /// <summary>
    /// PowerSources auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum PowerSources : int
    {
        /// <summary>
        /// Arcane (1)
        /// </summary>
		[Description("Arcane")]
        Arcane = 1,

        /// <summary>
        /// Divine (2)
        /// </summary>
		[Description("Divine")]
        Divine = 2,

        /// <summary>
        /// Martial (3)
        /// </summary>
		[Description("Martial")]
        Martial = 3,

        /// <summary>
        /// Primal (4)
        /// </summary>
		[Description("Primal")]
        Primal = 4
	}

    /// <summary>
    /// PowerUsages auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum PowerUsages : int
    {
        /// <summary>
        /// At-Will (1)
        /// </summary>
		[Description("At-Will")]
        AtWill = 1,

        /// <summary>
        /// Daily (2)
        /// </summary>
		[Description("Daily")]
        Daily = 2,

        /// <summary>
        /// Encounter (3)
        /// </summary>
		[Description("Encounter")]
        Encounter = 3,

        /// <summary>
        /// Utility (4)
        /// </summary>
		[Description("Utility")]
        Utility = 4
	}

    /// <summary>
    /// Roles auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Roles : int
    {
        /// <summary>
        /// Controller (1)
        /// </summary>
		[Description("Controller")]
        Controller = 1,

        /// <summary>
        /// Defender (2)
        /// </summary>
		[Description("Defender")]
        Defender = 2,

        /// <summary>
        /// Leader (3)
        /// </summary>
		[Description("Leader")]
        Leader = 3,

        /// <summary>
        /// Striker (4)
        /// </summary>
		[Description("Striker")]
        Striker = 4
	}

    /// <summary>
    /// Skills auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Skills : int
    {
        /// <summary>
        /// Acrobatics (1)
        /// </summary>
		[Description("Acrobatics")]
        Acrobatics = 1,

        /// <summary>
        /// Arcana (2)
        /// </summary>
		[Description("Arcana")]
        Arcana = 2,

        /// <summary>
        /// Athletics (3)
        /// </summary>
		[Description("Athletics")]
        Athletics = 3,

        /// <summary>
        /// Bluff (4)
        /// </summary>
		[Description("Bluff")]
        Bluff = 4,

        /// <summary>
        /// Diplomacy (5)
        /// </summary>
		[Description("Diplomacy")]
        Diplomacy = 5,

        /// <summary>
        /// Dungeoneering (6)
        /// </summary>
		[Description("Dungeoneering")]
        Dungeoneering = 6,

        /// <summary>
        /// Endurance (7)
        /// </summary>
		[Description("Endurance")]
        Endurance = 7,

        /// <summary>
        /// Heal (8)
        /// </summary>
		[Description("Heal")]
        Heal = 8,

        /// <summary>
        /// History (9)
        /// </summary>
		[Description("History")]
        History = 9,

        /// <summary>
        /// Insight (10)
        /// </summary>
		[Description("Insight")]
        Insight = 10,

        /// <summary>
        /// Intimidate (11)
        /// </summary>
		[Description("Intimidate")]
        Intimidate = 11,

        /// <summary>
        /// Nature (12)
        /// </summary>
		[Description("Nature")]
        Nature = 12,

        /// <summary>
        /// Perception (13)
        /// </summary>
		[Description("Perception")]
        Perception = 13,

        /// <summary>
        /// Religion (14)
        /// </summary>
		[Description("Religion")]
        Religion = 14,

        /// <summary>
        /// Stealth (15)
        /// </summary>
		[Description("Stealth")]
        Stealth = 15,

        /// <summary>
        /// Streetwise (16)
        /// </summary>
		[Description("Streetwise")]
        Streetwise = 16,

        /// <summary>
        /// Thievery (17)
        /// </summary>
		[Description("Thievery")]
        Thievery = 17
	}

    /// <summary>
    /// WeaponCategories auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum WeaponCategories : int
    {
        /// <summary>
        /// Improvised (1)
        /// </summary>
		[Description("Improvised")]
        Improvised = 1,

        /// <summary>
        /// Melee (2)
        /// </summary>
		[Description("Melee")]
        Melee = 2,

        /// <summary>
        /// Military (3)
        /// </summary>
		[Description("Military")]
        Military = 3,

        /// <summary>
        /// Ranged (4)
        /// </summary>
		[Description("Ranged")]
        Ranged = 4,

        /// <summary>
        /// Simple (5)
        /// </summary>
		[Description("Simple")]
        Simple = 5,

        /// <summary>
        /// Superior (6)
        /// </summary>
		[Description("Superior")]
        Superior = 6
	}

    /// <summary>
    /// WeaponGroups auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum WeaponGroups : int
    {
        /// <summary>
        /// Axe (1)
        /// </summary>
		[Description("Axe")]
        Axe = 1,

        /// <summary>
        /// Bow (2)
        /// </summary>
		[Description("Bow")]
        Bow = 2,

        /// <summary>
        /// Crossbow (3)
        /// </summary>
		[Description("Crossbow")]
        Crossbow = 3,

        /// <summary>
        /// Flail (4)
        /// </summary>
		[Description("Flail")]
        Flail = 4,

        /// <summary>
        /// Hammer (5)
        /// </summary>
		[Description("Hammer")]
        Hammer = 5,

        /// <summary>
        /// Heavy Blade (6)
        /// </summary>
		[Description("Heavy Blade")]
        HeavyBlade = 6,

        /// <summary>
        /// Light Blade (7)
        /// </summary>
		[Description("Light Blade")]
        LightBlade = 7,

        /// <summary>
        /// Mace (8)
        /// </summary>
		[Description("Mace")]
        Mace = 8,

        /// <summary>
        /// Pick (9)
        /// </summary>
		[Description("Pick")]
        Pick = 9,

        /// <summary>
        /// Polearm (10)
        /// </summary>
		[Description("Polearm")]
        Polearm = 10,

        /// <summary>
        /// Sling (11)
        /// </summary>
		[Description("Sling")]
        Sling = 11,

        /// <summary>
        /// Spear (12)
        /// </summary>
		[Description("Spear")]
        Spear = 12,

        /// <summary>
        /// Staff (13)
        /// </summary>
		[Description("Staff")]
        Staff = 13,

        /// <summary>
        /// Unarmed (14)
        /// </summary>
		[Description("Unarmed")]
        Unarmed = 14
	}

    /// <summary>
    /// WeaponProperties auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum WeaponProperties : int
    {
        /// <summary>
        /// Heavy Thrown (1)
        /// </summary>
		[Description("Heavy Thrown")]
        HeavyThrown = 1,

        /// <summary>
        /// High Crit (2)
        /// </summary>
		[Description("High Crit")]
        HighCrit = 2,

        /// <summary>
        /// Light Thrown (3)
        /// </summary>
		[Description("Light Thrown")]
        LightThrown = 3,

        /// <summary>
        /// Load (4)
        /// </summary>
		[Description("Load")]
        Load = 4,

        /// <summary>
        /// Off-Hand (5)
        /// </summary>
		[Description("Off-Hand")]
        OffHand = 5,

        /// <summary>
        /// Reach (6)
        /// </summary>
		[Description("Reach")]
        Reach = 6,

        /// <summary>
        /// Small (7)
        /// </summary>
		[Description("Small")]
        Small = 7,

        /// <summary>
        /// Versatile (8)
        /// </summary>
		[Description("Versatile")]
        Versatile = 8
	}


	// Tables
    /// <summary>
    /// ArmourClasses auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum ArmourClasses : int
    {
        /// <summary>
        /// Cloth Armour (1)
        /// </summary>
		[Description("Cloth Armour")]
        ClothArmour = 1,

        /// <summary>
        /// Leather Armour (2)
        /// </summary>
		[Description("Leather Armour")]
        LeatherArmour = 2,

        /// <summary>
        /// Hide Armour (3)
        /// </summary>
		[Description("Hide Armour")]
        HideArmour = 3,

        /// <summary>
        /// Chainmail (4)
        /// </summary>
		[Description("Chainmail")]
        Chainmail = 4,

        /// <summary>
        /// Scale Armour (5)
        /// </summary>
		[Description("Scale Armour")]
        ScaleArmour = 5,

        /// <summary>
        /// Plate Armour (6)
        /// </summary>
		[Description("Plate Armour")]
        PlateArmour = 6,

        /// <summary>
        /// Shield (7)
        /// </summary>
		[Description("Shield")]
        Shield = 7
	}

    /// <summary>
    /// ArmourTypes auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum ArmourTypes : int
    {
        /// <summary>
        /// Cloth armour (basic clothing) (1)
        /// </summary>
		[Description("Cloth armour (basic clothing)")]
        ClothArmourBasicClothing = 1,

        /// <summary>
        /// Feyweave armour (2)
        /// </summary>
		[Description("Feyweave armour")]
        FeyweaveArmour = 2,

        /// <summary>
        /// Starweave armour (3)
        /// </summary>
		[Description("Starweave armour")]
        StarweaveArmour = 3,

        /// <summary>
        /// Leather armour (4)
        /// </summary>
		[Description("Leather armour")]
        LeatherArmour = 4,

        /// <summary>
        /// Feyleather armour (5)
        /// </summary>
		[Description("Feyleather armour")]
        FeyleatherArmour = 5,

        /// <summary>
        /// Starleather armour (6)
        /// </summary>
		[Description("Starleather armour")]
        StarleatherArmour = 6,

        /// <summary>
        /// Hide armour (7)
        /// </summary>
		[Description("Hide armour")]
        HideArmour = 7,

        /// <summary>
        /// Darkhide armour (8)
        /// </summary>
		[Description("Darkhide armour")]
        DarkhideArmour = 8,

        /// <summary>
        /// Elderhide armour (9)
        /// </summary>
		[Description("Elderhide armour")]
        ElderhideArmour = 9,

        /// <summary>
        /// Chainmail (10)
        /// </summary>
		[Description("Chainmail")]
        Chainmail = 10,

        /// <summary>
        /// Forgemail (11)
        /// </summary>
		[Description("Forgemail")]
        Forgemail = 11,

        /// <summary>
        /// Spiritmail (12)
        /// </summary>
		[Description("Spiritmail")]
        Spiritmail = 12,

        /// <summary>
        /// Scale armour (13)
        /// </summary>
		[Description("Scale armour")]
        ScaleArmour = 13,

        /// <summary>
        /// Wyrmscale armour (14)
        /// </summary>
		[Description("Wyrmscale armour")]
        WyrmscaleArmour = 14,

        /// <summary>
        /// Elderscale armour (15)
        /// </summary>
		[Description("Elderscale armour")]
        ElderscaleArmour = 15,

        /// <summary>
        /// Plate armour (16)
        /// </summary>
		[Description("Plate armour")]
        PlateArmour = 16,

        /// <summary>
        /// Warplate armour (17)
        /// </summary>
		[Description("Warplate armour")]
        WarplateArmour = 17,

        /// <summary>
        /// Godplate armour (18)
        /// </summary>
		[Description("Godplate armour")]
        GodplateArmour = 18,

        /// <summary>
        /// Light shield (19)
        /// </summary>
		[Description("Light shield")]
        LightShield = 19,

        /// <summary>
        /// Heavy shield (20)
        /// </summary>
		[Description("Heavy shield")]
        HeavyShield = 20
	}

    /// <summary>
    /// Classes auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Classes : int
    {
        /// <summary>
        /// Cleric (1)
        /// </summary>
		[Description("Cleric")]
        Cleric = 1,

        /// <summary>
        /// Fighter (2)
        /// </summary>
		[Description("Fighter")]
        Fighter = 2,

        /// <summary>
        /// Paladin (3)
        /// </summary>
		[Description("Paladin")]
        Paladin = 3,

        /// <summary>
        /// Ranger (4)
        /// </summary>
		[Description("Ranger")]
        Ranger = 4,

        /// <summary>
        /// Rogue (5)
        /// </summary>
		[Description("Rogue")]
        Rogue = 5,

        /// <summary>
        /// Warlock (6)
        /// </summary>
		[Description("Warlock")]
        Warlock = 6,

        /// <summary>
        /// Warlord (7)
        /// </summary>
		[Description("Warlord")]
        Warlord = 7,

        /// <summary>
        /// Wizard (8)
        /// </summary>
		[Description("Wizard")]
        Wizard = 8,

        /// <summary>
        /// Avenger (9)
        /// </summary>
		[Description("Avenger")]
        Avenger = 9,

        /// <summary>
        /// Barbarian (10)
        /// </summary>
		[Description("Barbarian")]
        Barbarian = 10,

        /// <summary>
        /// Bard (11)
        /// </summary>
		[Description("Bard")]
        Bard = 11,

        /// <summary>
        /// Druid (12)
        /// </summary>
		[Description("Druid")]
        Druid = 12,

        /// <summary>
        /// Invoker (13)
        /// </summary>
		[Description("Invoker")]
        Invoker = 13,

        /// <summary>
        /// Shaman (14)
        /// </summary>
		[Description("Shaman")]
        Shaman = 14,

        /// <summary>
        /// Sorcerer (15)
        /// </summary>
		[Description("Sorcerer")]
        Sorcerer = 15,

        /// <summary>
        /// Warden (16)
        /// </summary>
		[Description("Warden")]
        Warden = 16
	}

    /// <summary>
    /// Deities auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Deities : int
    {
        /// <summary>
        /// Avandra (1)
        /// </summary>
		[Description("Avandra")]
        Avandra = 1,

        /// <summary>
        /// Bahamut (2)
        /// </summary>
		[Description("Bahamut")]
        Bahamut = 2,

        /// <summary>
        /// Corellon (3)
        /// </summary>
		[Description("Corellon")]
        Corellon = 3,

        /// <summary>
        /// Erathis (4)
        /// </summary>
		[Description("Erathis")]
        Erathis = 4,

        /// <summary>
        /// Ioun (5)
        /// </summary>
		[Description("Ioun")]
        Ioun = 5,

        /// <summary>
        /// Kord (6)
        /// </summary>
		[Description("Kord")]
        Kord = 6,

        /// <summary>
        /// Melora (7)
        /// </summary>
		[Description("Melora")]
        Melora = 7,

        /// <summary>
        /// Moradin (8)
        /// </summary>
		[Description("Moradin")]
        Moradin = 8,

        /// <summary>
        /// Pelor (9)
        /// </summary>
		[Description("Pelor")]
        Pelor = 9,

        /// <summary>
        /// The Raven Queen (10)
        /// </summary>
		[Description("The Raven Queen")]
        TheRavenQueen = 10,

        /// <summary>
        /// Sehanine (11)
        /// </summary>
		[Description("Sehanine")]
        Sehanine = 11,

        /// <summary>
        /// Primal Spirits (12)
        /// </summary>
		[Description("Primal Spirits")]
        PrimalSpirits = 12
	}

    /// <summary>
    /// Features auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Features : int
    {
	}

    /// <summary>
    /// Languages auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Languages : int
    {
        /// <summary>
        /// Common (1)
        /// </summary>
		[Description("Common")]
        Common = 1,

        /// <summary>
        /// Deep Speech (2)
        /// </summary>
		[Description("Deep Speech")]
        DeepSpeech = 2,

        /// <summary>
        /// Draconic (3)
        /// </summary>
		[Description("Draconic")]
        Draconic = 3,

        /// <summary>
        /// Dwarven (4)
        /// </summary>
		[Description("Dwarven")]
        Dwarven = 4,

        /// <summary>
        /// Elven (5)
        /// </summary>
		[Description("Elven")]
        Elven = 5,

        /// <summary>
        /// Giant (6)
        /// </summary>
		[Description("Giant")]
        Giant = 6,

        /// <summary>
        /// Goblin (7)
        /// </summary>
		[Description("Goblin")]
        Goblin = 7,

        /// <summary>
        /// Primordial (8)
        /// </summary>
		[Description("Primordial")]
        Primordial = 8,

        /// <summary>
        /// Supernal (9)
        /// </summary>
		[Description("Supernal")]
        Supernal = 9,

        /// <summary>
        /// Abyssal (10)
        /// </summary>
		[Description("Abyssal")]
        Abyssal = 10
	}

    /// <summary>
    /// Powers auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Powers : int
    {
	}

    /// <summary>
    /// Races auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Races : int
    {
        /// <summary>
        /// Dragonborn (1)
        /// </summary>
		[Description("Dragonborn")]
        Dragonborn = 1,

        /// <summary>
        /// Dwarf (2)
        /// </summary>
		[Description("Dwarf")]
        Dwarf = 2,

        /// <summary>
        /// Eladrin (3)
        /// </summary>
		[Description("Eladrin")]
        Eladrin = 3,

        /// <summary>
        /// Elf (4)
        /// </summary>
		[Description("Elf")]
        Elf = 4,

        /// <summary>
        /// Half-Elf (5)
        /// </summary>
		[Description("Half-Elf")]
        HalfElf = 5,

        /// <summary>
        /// Halfling (6)
        /// </summary>
		[Description("Halfling")]
        Halfling = 6,

        /// <summary>
        /// Human (7)
        /// </summary>
		[Description("Human")]
        Human = 7,

        /// <summary>
        /// Tiefling (8)
        /// </summary>
		[Description("Tiefling")]
        Tiefling = 8,

        /// <summary>
        /// Deva (9)
        /// </summary>
		[Description("Deva")]
        Deva = 9,

        /// <summary>
        /// Gnome (10)
        /// </summary>
		[Description("Gnome")]
        Gnome = 10,

        /// <summary>
        /// Goliath (11)
        /// </summary>
		[Description("Goliath")]
        Goliath = 11,

        /// <summary>
        /// Half-Orc (12)
        /// </summary>
		[Description("Half-Orc")]
        HalfOrc = 12,

        /// <summary>
        /// Longtooth Shifter (13)
        /// </summary>
		[Description("Longtooth Shifter")]
        LongtoothShifter = 13,

        /// <summary>
        /// Razorclaw Shifter (14)
        /// </summary>
		[Description("Razorclaw Shifter")]
        RazorclawShifter = 14
	}

    /// <summary>
    /// Scripts auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Scripts : int
    {
        /// <summary>
        /// Barazhad (1)
        /// </summary>
		[Description("Barazhad")]
        Barazhad = 1,

        /// <summary>
        /// Common (2)
        /// </summary>
		[Description("Common")]
        Common = 2,

        /// <summary>
        /// Davek (3)
        /// </summary>
		[Description("Davek")]
        Davek = 3,

        /// <summary>
        /// Iokharic (4)
        /// </summary>
		[Description("Iokharic")]
        Iokharic = 4,

        /// <summary>
        /// Rellanic (5)
        /// </summary>
		[Description("Rellanic")]
        Rellanic = 5,

        /// <summary>
        /// Supernal (6)
        /// </summary>
		[Description("Supernal")]
        Supernal = 6
	}

}

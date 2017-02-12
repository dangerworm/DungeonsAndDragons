// This is a generated file. Do not attempt to modify it as your changes would be overwritten.
// Connection String Used: Data Source=ANDY-PC;Initial Catalog=DungeonsAndDragons;Integrated Security=True
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DungeonsAndDragons_Data.Enums
{
    /// <summary>
    /// Abilities auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Abilities : byte
    {
        /// <summary>
        /// Charisma (1)
        /// </summary>
		[Display(Name = "Charisma")]
        Charisma = 1,

        /// <summary>
        /// Constitution (2)
        /// </summary>
		[Display(Name = "Constitution")]
        Constitution = 2,

        /// <summary>
        /// Dexterity (3)
        /// </summary>
		[Display(Name = "Dexterity")]
        Dexterity = 3,

        /// <summary>
        /// Intelligence (4)
        /// </summary>
		[Display(Name = "Intelligence")]
        Intelligence = 4,

        /// <summary>
        /// Strength (5)
        /// </summary>
		[Display(Name = "Strength")]
        Strength = 5,

        /// <summary>
        /// Wisdom (6)
        /// </summary>
		[Display(Name = "Wisdom")]
        Wisdom = 6
	}

    /// <summary>
    /// ActionTypes auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum ActionTypes : byte
    {
        /// <summary>
        /// Standard Action (1)
        /// </summary>
		[Display(Name = "Standard Action")]
        StandardAction = 1,

        /// <summary>
        /// Free Action (2)
        /// </summary>
		[Display(Name = "Free Action")]
        FreeAction = 2,

        /// <summary>
        /// Immediate Interrupt (3)
        /// </summary>
		[Display(Name = "Immediate Interrupt")]
        ImmediateInterrupt = 3,

        /// <summary>
        /// Immediate Reaction (4)
        /// </summary>
		[Display(Name = "Immediate Reaction")]
        ImmediateReaction = 4,

        /// <summary>
        /// Minor Action (5)
        /// </summary>
		[Display(Name = "Minor Action")]
        MinorAction = 5,

        /// <summary>
        /// Move Action (6)
        /// </summary>
		[Display(Name = "Move Action")]
        MoveAction = 6,

        /// <summary>
        /// No Action (7)
        /// </summary>
		[Display(Name = "No Action")]
        NoAction = 7
	}

    /// <summary>
    /// ActorTypes auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum ActorTypes : byte
    {
        /// <summary>
        /// Player Character (1)
        /// </summary>
		[Display(Name = "Player Character")]
        PlayerCharacter = 1,

        /// <summary>
        /// Non-Player Character (2)
        /// </summary>
		[Display(Name = "Non-Player Character")]
        NonPlayerCharacter = 2,

        /// <summary>
        /// Trap (3)
        /// </summary>
		[Display(Name = "Trap")]
        Trap = 3
	}

    /// <summary>
    /// Alignments auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Alignments : byte
    {
        /// <summary>
        /// Lawful Good (1)
        /// </summary>
		[Display(Name = "Lawful Good")]
        LawfulGood = 1,

        /// <summary>
        /// Good (2)
        /// </summary>
		[Display(Name = "Good")]
        Good = 2,

        /// <summary>
        /// Chaotic Good (3)
        /// </summary>
		[Display(Name = "Chaotic Good")]
        ChaoticGood = 3,

        /// <summary>
        /// Unaligned (Lawful) (4)
        /// </summary>
		[Display(Name = "Unaligned (Lawful)")]
        UnalignedLawful = 4,

        /// <summary>
        /// Unaligned (5)
        /// </summary>
		[Display(Name = "Unaligned")]
        Unaligned = 5,

        /// <summary>
        /// Unaligned (Chaotic) (6)
        /// </summary>
		[Display(Name = "Unaligned (Chaotic)")]
        UnalignedChaotic = 6,

        /// <summary>
        /// Lawful Evil (7)
        /// </summary>
		[Display(Name = "Lawful Evil")]
        LawfulEvil = 7,

        /// <summary>
        /// Evil (8)
        /// </summary>
		[Display(Name = "Evil")]
        Evil = 8,

        /// <summary>
        /// Chaotic Evil (9)
        /// </summary>
		[Display(Name = "Chaotic Evil")]
        ChaoticEvil = 9
	}

    /// <summary>
    /// ArmourWeightClasses auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum ArmourWeightClasses : byte
    {
        /// <summary>
        /// Light (1)
        /// </summary>
		[Display(Name = "Light")]
        Light = 1,

        /// <summary>
        /// Heavy (2)
        /// </summary>
		[Display(Name = "Heavy")]
        Heavy = 2
	}

    /// <summary>
    /// AttackTypes auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum AttackTypes : byte
    {
        /// <summary>
        /// Area (1)
        /// </summary>
		[Display(Name = "Area")]
        Area = 1,

        /// <summary>
        /// Close (2)
        /// </summary>
		[Display(Name = "Close")]
        Close = 2,

        /// <summary>
        /// Melee (3)
        /// </summary>
		[Display(Name = "Melee")]
        Melee = 3,

        /// <summary>
        /// Ranged (4)
        /// </summary>
		[Display(Name = "Ranged")]
        Ranged = 4
	}

    /// <summary>
    /// AuthorityLevels auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum AuthorityLevels : byte
    {
        /// <summary>
        /// Lawful (1)
        /// </summary>
		[Display(Name = "Lawful")]
        Lawful = 1,

        /// <summary>
        /// Neutral (2)
        /// </summary>
		[Display(Name = "Neutral")]
        Neutral = 2,

        /// <summary>
        /// Chaotic (3)
        /// </summary>
		[Display(Name = "Chaotic")]
        Chaotic = 3
	}

    /// <summary>
    /// CompassionLevels auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum CompassionLevels : byte
    {
        /// <summary>
        /// Good (1)
        /// </summary>
		[Display(Name = "Good")]
        Good = 1,

        /// <summary>
        /// Neutral (2)
        /// </summary>
		[Display(Name = "Neutral")]
        Neutral = 2,

        /// <summary>
        /// Evil (3)
        /// </summary>
		[Display(Name = "Evil")]
        Evil = 3
	}

    /// <summary>
    /// DamageTypes auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum DamageTypes : byte
    {
        /// <summary>
        /// Acid (1)
        /// </summary>
		[Display(Name = "Acid")]
        Acid = 1,

        /// <summary>
        /// Cold (2)
        /// </summary>
		[Display(Name = "Cold")]
        Cold = 2,

        /// <summary>
        /// Fire (3)
        /// </summary>
		[Display(Name = "Fire")]
        Fire = 3,

        /// <summary>
        /// Force (4)
        /// </summary>
		[Display(Name = "Force")]
        Force = 4,

        /// <summary>
        /// Lightning (5)
        /// </summary>
		[Display(Name = "Lightning")]
        Lightning = 5,

        /// <summary>
        /// Necrotic (6)
        /// </summary>
		[Display(Name = "Necrotic")]
        Necrotic = 6,

        /// <summary>
        /// Poison (7)
        /// </summary>
		[Display(Name = "Poison")]
        Poison = 7,

        /// <summary>
        /// Psychic (8)
        /// </summary>
		[Display(Name = "Psychic")]
        Psychic = 8,

        /// <summary>
        /// Radiant (9)
        /// </summary>
		[Display(Name = "Radiant")]
        Radiant = 9,

        /// <summary>
        /// Thunder (10)
        /// </summary>
		[Display(Name = "Thunder")]
        Thunder = 10
	}

    /// <summary>
    /// Defenses auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Defenses : byte
    {
        /// <summary>
        /// Armour Class (1)
        /// </summary>
		[Display(Name = "Armour Class")]
        ArmourClass = 1,

        /// <summary>
        /// Fortitude (2)
        /// </summary>
		[Display(Name = "Fortitude")]
        Fortitude = 2,

        /// <summary>
        /// Reflex (3)
        /// </summary>
		[Display(Name = "Reflex")]
        Reflex = 3,

        /// <summary>
        /// Will (4)
        /// </summary>
		[Display(Name = "Will")]
        Will = 4
	}

    /// <summary>
    /// DurationUnits auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum DurationUnits : byte
    {
        /// <summary>
        /// Action (1)
        /// </summary>
		[Display(Name = "Action")]
        Action = 1,

        /// <summary>
        /// Day (2)
        /// </summary>
		[Display(Name = "Day")]
        Day = 2,

        /// <summary>
        /// Encounter (3)
        /// </summary>
		[Display(Name = "Encounter")]
        Encounter = 3,

        /// <summary>
        /// Fortnight (4)
        /// </summary>
		[Display(Name = "Fortnight")]
        Fortnight = 4,

        /// <summary>
        /// Hour (5)
        /// </summary>
		[Display(Name = "Hour")]
        Hour = 5,

        /// <summary>
        /// Minute (6)
        /// </summary>
		[Display(Name = "Minute")]
        Minute = 6,

        /// <summary>
        /// Month (7)
        /// </summary>
		[Display(Name = "Month")]
        Month = 7,

        /// <summary>
        /// Round (8)
        /// </summary>
		[Display(Name = "Round")]
        Round = 8,

        /// <summary>
        /// Second (9)
        /// </summary>
		[Display(Name = "Second")]
        Second = 9,

        /// <summary>
        /// Turn (10)
        /// </summary>
		[Display(Name = "Turn")]
        Turn = 10,

        /// <summary>
        /// Week (11)
        /// </summary>
		[Display(Name = "Week")]
        Week = 11
	}

    /// <summary>
    /// EffectTypes auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum EffectTypes : byte
    {
        /// <summary>
        /// Charm (1)
        /// </summary>
		[Display(Name = "Charm")]
        Charm = 1,

        /// <summary>
        /// Conjuration (2)
        /// </summary>
		[Display(Name = "Conjuration")]
        Conjuration = 2,

        /// <summary>
        /// Fear (3)
        /// </summary>
		[Display(Name = "Fear")]
        Fear = 3,

        /// <summary>
        /// Healing (4)
        /// </summary>
		[Display(Name = "Healing")]
        Healing = 4,

        /// <summary>
        /// Illusion (5)
        /// </summary>
		[Display(Name = "Illusion")]
        Illusion = 5,

        /// <summary>
        /// Poison (6)
        /// </summary>
		[Display(Name = "Poison")]
        Poison = 6,

        /// <summary>
        /// Polymorph (7)
        /// </summary>
		[Display(Name = "Polymorph")]
        Polymorph = 7,

        /// <summary>
        /// Reliable (8)
        /// </summary>
		[Display(Name = "Reliable")]
        Reliable = 8,

        /// <summary>
        /// Sleep (9)
        /// </summary>
		[Display(Name = "Sleep")]
        Sleep = 9,

        /// <summary>
        /// Stance (10)
        /// </summary>
		[Display(Name = "Stance")]
        Stance = 10,

        /// <summary>
        /// Teleportation (11)
        /// </summary>
		[Display(Name = "Teleportation")]
        Teleportation = 11,

        /// <summary>
        /// Zone (12)
        /// </summary>
		[Display(Name = "Zone")]
        Zone = 12
	}

    /// <summary>
    /// EpicDestinies auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum EpicDestinies : byte
    {
        /// <summary>
        /// Archmage (1)
        /// </summary>
		[Display(Name = "Archmage")]
        Archmage = 1,

        /// <summary>
        /// Deadly Trickster (2)
        /// </summary>
		[Display(Name = "Deadly Trickster")]
        DeadlyTrickster = 2,

        /// <summary>
        /// Demigod (3)
        /// </summary>
		[Display(Name = "Demigod")]
        Demigod = 3,

        /// <summary>
        /// Eternal Seeker (4)
        /// </summary>
		[Display(Name = "Eternal Seeker")]
        EternalSeeker = 4
	}

    /// <summary>
    /// Genders auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Genders : byte
    {
        /// <summary>
        /// Male (1)
        /// </summary>
		[Display(Name = "Male")]
        Male = 1,

        /// <summary>
        /// Female (2)
        /// </summary>
		[Display(Name = "Female")]
        Female = 2,

        /// <summary>
        /// Other (3)
        /// </summary>
		[Display(Name = "Other")]
        Other = 3
	}

    /// <summary>
    /// ImplementTypes auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum ImplementTypes : byte
    {
        /// <summary>
        /// Orb (1)
        /// </summary>
		[Display(Name = "Orb")]
        Orb = 1,

        /// <summary>
        /// Rod (2)
        /// </summary>
		[Display(Name = "Rod")]
        Rod = 2,

        /// <summary>
        /// Staff (3)
        /// </summary>
		[Display(Name = "Staff")]
        Staff = 3,

        /// <summary>
        /// Wand (4)
        /// </summary>
		[Display(Name = "Wand")]
        Wand = 4
	}

    /// <summary>
    /// MapAreaTypes auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum MapAreaTypes : byte
    {
	}

    /// <summary>
    /// PowerSources auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum PowerSources : byte
    {
        /// <summary>
        /// Arcane (1)
        /// </summary>
		[Display(Name = "Arcane")]
        Arcane = 1,

        /// <summary>
        /// Divine (2)
        /// </summary>
		[Display(Name = "Divine")]
        Divine = 2,

        /// <summary>
        /// Martial (3)
        /// </summary>
		[Display(Name = "Martial")]
        Martial = 3,

        /// <summary>
        /// Primal (4)
        /// </summary>
		[Display(Name = "Primal")]
        Primal = 4
	}

    /// <summary>
    /// PowerUsages auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum PowerUsages : byte
    {
        /// <summary>
        /// At-Will (1)
        /// </summary>
		[Display(Name = "At-Will")]
        AtWill = 1,

        /// <summary>
        /// Daily (2)
        /// </summary>
		[Display(Name = "Daily")]
        Daily = 2,

        /// <summary>
        /// Encounter (3)
        /// </summary>
		[Display(Name = "Encounter")]
        Encounter = 3,

        /// <summary>
        /// Utility (4)
        /// </summary>
		[Display(Name = "Utility")]
        Utility = 4
	}

    /// <summary>
    /// Roles auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Roles : byte
    {
        /// <summary>
        /// Controller (1)
        /// </summary>
		[Display(Name = "Controller")]
        Controller = 1,

        /// <summary>
        /// Defender (2)
        /// </summary>
		[Display(Name = "Defender")]
        Defender = 2,

        /// <summary>
        /// Leader (3)
        /// </summary>
		[Display(Name = "Leader")]
        Leader = 3,

        /// <summary>
        /// Striker (4)
        /// </summary>
		[Display(Name = "Striker")]
        Striker = 4
	}

    /// <summary>
    /// Skills auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Skills : byte
    {
        /// <summary>
        /// Acrobatics (1)
        /// </summary>
		[Display(Name = "Acrobatics")]
        Acrobatics = 1,

        /// <summary>
        /// Arcana (2)
        /// </summary>
		[Display(Name = "Arcana")]
        Arcana = 2,

        /// <summary>
        /// Athletics (3)
        /// </summary>
		[Display(Name = "Athletics")]
        Athletics = 3,

        /// <summary>
        /// Bluff (4)
        /// </summary>
		[Display(Name = "Bluff")]
        Bluff = 4,

        /// <summary>
        /// Diplomacy (5)
        /// </summary>
		[Display(Name = "Diplomacy")]
        Diplomacy = 5,

        /// <summary>
        /// Dungeoneering (6)
        /// </summary>
		[Display(Name = "Dungeoneering")]
        Dungeoneering = 6,

        /// <summary>
        /// Endurance (7)
        /// </summary>
		[Display(Name = "Endurance")]
        Endurance = 7,

        /// <summary>
        /// Heal (8)
        /// </summary>
		[Display(Name = "Heal")]
        Heal = 8,

        /// <summary>
        /// History (9)
        /// </summary>
		[Display(Name = "History")]
        History = 9,

        /// <summary>
        /// Insight (10)
        /// </summary>
		[Display(Name = "Insight")]
        Insight = 10,

        /// <summary>
        /// Intimidate (11)
        /// </summary>
		[Display(Name = "Intimidate")]
        Intimidate = 11,

        /// <summary>
        /// Nature (12)
        /// </summary>
		[Display(Name = "Nature")]
        Nature = 12,

        /// <summary>
        /// Perception (13)
        /// </summary>
		[Display(Name = "Perception")]
        Perception = 13,

        /// <summary>
        /// Religion (14)
        /// </summary>
		[Display(Name = "Religion")]
        Religion = 14,

        /// <summary>
        /// Stealth (15)
        /// </summary>
		[Display(Name = "Stealth")]
        Stealth = 15,

        /// <summary>
        /// Streetwise (16)
        /// </summary>
		[Display(Name = "Streetwise")]
        Streetwise = 16,

        /// <summary>
        /// Thievery (17)
        /// </summary>
		[Display(Name = "Thievery")]
        Thievery = 17
	}

    /// <summary>
    /// WeaponCategories auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum WeaponCategories : byte
    {
        /// <summary>
        /// Improvised (1)
        /// </summary>
		[Display(Name = "Improvised")]
        Improvised = 1,

        /// <summary>
        /// Military (2)
        /// </summary>
		[Display(Name = "Military")]
        Military = 2,

        /// <summary>
        /// Simple (3)
        /// </summary>
		[Display(Name = "Simple")]
        Simple = 3,

        /// <summary>
        /// Superior (4)
        /// </summary>
		[Display(Name = "Superior")]
        Superior = 4
	}

    /// <summary>
    /// WeaponGroups auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum WeaponGroups : byte
    {
        /// <summary>
        /// None (0)
        /// </summary>
		[Display(Name = "None")]
        None = 0,

        /// <summary>
        /// Axe (1)
        /// </summary>
		[Display(Name = "Axe")]
        Axe = 1,

        /// <summary>
        /// Bow (2)
        /// </summary>
		[Display(Name = "Bow")]
        Bow = 2,

        /// <summary>
        /// Crossbow (3)
        /// </summary>
		[Display(Name = "Crossbow")]
        Crossbow = 3,

        /// <summary>
        /// Flail (4)
        /// </summary>
		[Display(Name = "Flail")]
        Flail = 4,

        /// <summary>
        /// Hammer (5)
        /// </summary>
		[Display(Name = "Hammer")]
        Hammer = 5,

        /// <summary>
        /// Heavy Blade (6)
        /// </summary>
		[Display(Name = "Heavy Blade")]
        HeavyBlade = 6,

        /// <summary>
        /// Light Blade (7)
        /// </summary>
		[Display(Name = "Light Blade")]
        LightBlade = 7,

        /// <summary>
        /// Mace (8)
        /// </summary>
		[Display(Name = "Mace")]
        Mace = 8,

        /// <summary>
        /// Pick (9)
        /// </summary>
		[Display(Name = "Pick")]
        Pick = 9,

        /// <summary>
        /// Polearm (10)
        /// </summary>
		[Display(Name = "Polearm")]
        Polearm = 10,

        /// <summary>
        /// Sling (11)
        /// </summary>
		[Display(Name = "Sling")]
        Sling = 11,

        /// <summary>
        /// Spear (12)
        /// </summary>
		[Display(Name = "Spear")]
        Spear = 12,

        /// <summary>
        /// Staff (13)
        /// </summary>
		[Display(Name = "Staff")]
        Staff = 13,

        /// <summary>
        /// Unarmed (14)
        /// </summary>
		[Display(Name = "Unarmed")]
        Unarmed = 14
	}

    /// <summary>
    /// WeaponProperties auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum WeaponProperties : byte
    {
        /// <summary>
        /// Heavy Thrown (1)
        /// </summary>
		[Display(Name = "Heavy Thrown")]
        HeavyThrown = 1,

        /// <summary>
        /// High Crit (2)
        /// </summary>
		[Display(Name = "High Crit")]
        HighCrit = 2,

        /// <summary>
        /// Light Thrown (3)
        /// </summary>
		[Display(Name = "Light Thrown")]
        LightThrown = 3,

        /// <summary>
        /// Load (4)
        /// </summary>
		[Display(Name = "Load")]
        Load = 4,

        /// <summary>
        /// Off-Hand (5)
        /// </summary>
		[Display(Name = "Off-Hand")]
        OffHand = 5,

        /// <summary>
        /// Reach (6)
        /// </summary>
		[Display(Name = "Reach")]
        Reach = 6,

        /// <summary>
        /// Small (7)
        /// </summary>
		[Display(Name = "Small")]
        Small = 7,

        /// <summary>
        /// Versatile (8)
        /// </summary>
		[Display(Name = "Versatile")]
        Versatile = 8
	}

    /// <summary>
    /// ArmourClasses auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum ArmourClasses : byte
    {
        /// <summary>
        /// Cloth Armour (1)
        /// </summary>
		[Display(Name = "Cloth Armour")]
        ClothArmour = 1,

        /// <summary>
        /// Leather Armour (2)
        /// </summary>
		[Display(Name = "Leather Armour")]
        LeatherArmour = 2,

        /// <summary>
        /// Hide Armour (3)
        /// </summary>
		[Display(Name = "Hide Armour")]
        HideArmour = 3,

        /// <summary>
        /// Chainmail Armour (4)
        /// </summary>
		[Display(Name = "Chainmail Armour")]
        ChainmailArmour = 4,

        /// <summary>
        /// Scale Armour (5)
        /// </summary>
		[Display(Name = "Scale Armour")]
        ScaleArmour = 5,

        /// <summary>
        /// Plate Armour (6)
        /// </summary>
		[Display(Name = "Plate Armour")]
        PlateArmour = 6,

        /// <summary>
        /// Shield (7)
        /// </summary>
		[Display(Name = "Shield")]
        Shield = 7
	}

    /// <summary>
    /// ArmourTypes auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum ArmourTypes : byte
    {
        /// <summary>
        /// Basic Clothing (1)
        /// </summary>
		[Display(Name = "Basic Clothing")]
        BasicClothing = 1,

        /// <summary>
        /// Feyweave (2)
        /// </summary>
		[Display(Name = "Feyweave")]
        Feyweave = 2,

        /// <summary>
        /// Starweave (3)
        /// </summary>
		[Display(Name = "Starweave")]
        Starweave = 3,

        /// <summary>
        /// Leather (4)
        /// </summary>
		[Display(Name = "Leather")]
        Leather = 4,

        /// <summary>
        /// Feyleather (5)
        /// </summary>
		[Display(Name = "Feyleather")]
        Feyleather = 5,

        /// <summary>
        /// Starleather (6)
        /// </summary>
		[Display(Name = "Starleather")]
        Starleather = 6,

        /// <summary>
        /// Hide (7)
        /// </summary>
		[Display(Name = "Hide")]
        Hide = 7,

        /// <summary>
        /// Darkhide (8)
        /// </summary>
		[Display(Name = "Darkhide")]
        Darkhide = 8,

        /// <summary>
        /// Elderhide (9)
        /// </summary>
		[Display(Name = "Elderhide")]
        Elderhide = 9,

        /// <summary>
        /// Chainmail (10)
        /// </summary>
		[Display(Name = "Chainmail")]
        Chainmail = 10,

        /// <summary>
        /// Forgemail (11)
        /// </summary>
		[Display(Name = "Forgemail")]
        Forgemail = 11,

        /// <summary>
        /// Spiritmail (12)
        /// </summary>
		[Display(Name = "Spiritmail")]
        Spiritmail = 12,

        /// <summary>
        /// Scale (13)
        /// </summary>
		[Display(Name = "Scale")]
        Scale = 13,

        /// <summary>
        /// Wyrmscale (14)
        /// </summary>
		[Display(Name = "Wyrmscale")]
        Wyrmscale = 14,

        /// <summary>
        /// Elderscale (15)
        /// </summary>
		[Display(Name = "Elderscale")]
        Elderscale = 15,

        /// <summary>
        /// Plate (16)
        /// </summary>
		[Display(Name = "Plate")]
        Plate = 16,

        /// <summary>
        /// Warplate (17)
        /// </summary>
		[Display(Name = "Warplate")]
        Warplate = 17,

        /// <summary>
        /// Godplate (18)
        /// </summary>
		[Display(Name = "Godplate")]
        Godplate = 18,

        /// <summary>
        /// Light (19)
        /// </summary>
		[Display(Name = "Light")]
        Light = 19,

        /// <summary>
        /// Heavy (20)
        /// </summary>
		[Display(Name = "Heavy")]
        Heavy = 20
	}

    /// <summary>
    /// Classes auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Classes : byte
    {
        /// <summary>
        /// Cleric (1)
        /// </summary>
		[Display(Name = "Cleric")]
        Cleric = 1,

        /// <summary>
        /// Fighter (2)
        /// </summary>
		[Display(Name = "Fighter")]
        Fighter = 2,

        /// <summary>
        /// Paladin (3)
        /// </summary>
		[Display(Name = "Paladin")]
        Paladin = 3,

        /// <summary>
        /// Ranger (4)
        /// </summary>
		[Display(Name = "Ranger")]
        Ranger = 4,

        /// <summary>
        /// Rogue (5)
        /// </summary>
		[Display(Name = "Rogue")]
        Rogue = 5,

        /// <summary>
        /// Warlock (6)
        /// </summary>
		[Display(Name = "Warlock")]
        Warlock = 6,

        /// <summary>
        /// Warlord (7)
        /// </summary>
		[Display(Name = "Warlord")]
        Warlord = 7,

        /// <summary>
        /// Wizard (8)
        /// </summary>
		[Display(Name = "Wizard")]
        Wizard = 8,

        /// <summary>
        /// Avenger (9)
        /// </summary>
		[Display(Name = "Avenger")]
        Avenger = 9,

        /// <summary>
        /// Barbarian (10)
        /// </summary>
		[Display(Name = "Barbarian")]
        Barbarian = 10,

        /// <summary>
        /// Bard (11)
        /// </summary>
		[Display(Name = "Bard")]
        Bard = 11,

        /// <summary>
        /// Druid (12)
        /// </summary>
		[Display(Name = "Druid")]
        Druid = 12,

        /// <summary>
        /// Invoker (13)
        /// </summary>
		[Display(Name = "Invoker")]
        Invoker = 13,

        /// <summary>
        /// Shaman (14)
        /// </summary>
		[Display(Name = "Shaman")]
        Shaman = 14,

        /// <summary>
        /// Sorcerer (15)
        /// </summary>
		[Display(Name = "Sorcerer")]
        Sorcerer = 15,

        /// <summary>
        /// Warden (16)
        /// </summary>
		[Display(Name = "Warden")]
        Warden = 16
	}

    /// <summary>
    /// Deities auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Deities : byte
    {
        /// <summary>
        /// None (0)
        /// </summary>
		[Display(Name = "None")]
        None = 0,

        /// <summary>
        /// Avandra (1)
        /// </summary>
		[Display(Name = "Avandra")]
        Avandra = 1,

        /// <summary>
        /// Bahamut (2)
        /// </summary>
		[Display(Name = "Bahamut")]
        Bahamut = 2,

        /// <summary>
        /// Corellon (3)
        /// </summary>
		[Display(Name = "Corellon")]
        Corellon = 3,

        /// <summary>
        /// Erathis (4)
        /// </summary>
		[Display(Name = "Erathis")]
        Erathis = 4,

        /// <summary>
        /// Ioun (5)
        /// </summary>
		[Display(Name = "Ioun")]
        Ioun = 5,

        /// <summary>
        /// Kord (6)
        /// </summary>
		[Display(Name = "Kord")]
        Kord = 6,

        /// <summary>
        /// Melora (7)
        /// </summary>
		[Display(Name = "Melora")]
        Melora = 7,

        /// <summary>
        /// Moradin (8)
        /// </summary>
		[Display(Name = "Moradin")]
        Moradin = 8,

        /// <summary>
        /// Pelor (9)
        /// </summary>
		[Display(Name = "Pelor")]
        Pelor = 9,

        /// <summary>
        /// The Raven Queen (10)
        /// </summary>
		[Display(Name = "The Raven Queen")]
        TheRavenQueen = 10,

        /// <summary>
        /// Sehanine (11)
        /// </summary>
		[Display(Name = "Sehanine")]
        Sehanine = 11,

        /// <summary>
        /// Primal Spirits (12)
        /// </summary>
		[Display(Name = "Primal Spirits")]
        PrimalSpirits = 12
	}

    /// <summary>
    /// Features auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Features : byte
    {
	}

    /// <summary>
    /// Languages auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Languages : byte
    {
        /// <summary>
        /// Common (1)
        /// </summary>
		[Display(Name = "Common")]
        Common = 1,

        /// <summary>
        /// Deep Speech (2)
        /// </summary>
		[Display(Name = "Deep Speech")]
        DeepSpeech = 2,

        /// <summary>
        /// Draconic (3)
        /// </summary>
		[Display(Name = "Draconic")]
        Draconic = 3,

        /// <summary>
        /// Dwarven (4)
        /// </summary>
		[Display(Name = "Dwarven")]
        Dwarven = 4,

        /// <summary>
        /// Elven (5)
        /// </summary>
		[Display(Name = "Elven")]
        Elven = 5,

        /// <summary>
        /// Giant (6)
        /// </summary>
		[Display(Name = "Giant")]
        Giant = 6,

        /// <summary>
        /// Goblin (7)
        /// </summary>
		[Display(Name = "Goblin")]
        Goblin = 7,

        /// <summary>
        /// Primordial (8)
        /// </summary>
		[Display(Name = "Primordial")]
        Primordial = 8,

        /// <summary>
        /// Supernal (9)
        /// </summary>
		[Display(Name = "Supernal")]
        Supernal = 9,

        /// <summary>
        /// Abyssal (10)
        /// </summary>
		[Display(Name = "Abyssal")]
        Abyssal = 10
	}

    /// <summary>
    /// Powers auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Powers : byte
    {
	}

    /// <summary>
    /// Races auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Races : byte
    {
        /// <summary>
        /// Dragonborn (1)
        /// </summary>
		[Display(Name = "Dragonborn")]
        Dragonborn = 1,

        /// <summary>
        /// Dwarf (2)
        /// </summary>
		[Display(Name = "Dwarf")]
        Dwarf = 2,

        /// <summary>
        /// Eladrin (3)
        /// </summary>
		[Display(Name = "Eladrin")]
        Eladrin = 3,

        /// <summary>
        /// Elf (4)
        /// </summary>
		[Display(Name = "Elf")]
        Elf = 4,

        /// <summary>
        /// Half-Elf (5)
        /// </summary>
		[Display(Name = "Half-Elf")]
        HalfElf = 5,

        /// <summary>
        /// Halfling (6)
        /// </summary>
		[Display(Name = "Halfling")]
        Halfling = 6,

        /// <summary>
        /// Human (7)
        /// </summary>
		[Display(Name = "Human")]
        Human = 7,

        /// <summary>
        /// Tiefling (8)
        /// </summary>
		[Display(Name = "Tiefling")]
        Tiefling = 8,

        /// <summary>
        /// Deva (9)
        /// </summary>
		[Display(Name = "Deva")]
        Deva = 9,

        /// <summary>
        /// Gnome (10)
        /// </summary>
		[Display(Name = "Gnome")]
        Gnome = 10,

        /// <summary>
        /// Goliath (11)
        /// </summary>
		[Display(Name = "Goliath")]
        Goliath = 11,

        /// <summary>
        /// Half-Orc (12)
        /// </summary>
		[Display(Name = "Half-Orc")]
        HalfOrc = 12,

        /// <summary>
        /// Shifter (13)
        /// </summary>
		[Display(Name = "Shifter")]
        Shifter = 13
	}

    /// <summary>
    /// Scripts auto generated enumeration
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
	[TypeConverter(typeof(EnumNameTypeConverter))]
    public enum Scripts : byte
    {
        /// <summary>
        /// Barazhad (1)
        /// </summary>
		[Display(Name = "Barazhad")]
        Barazhad = 1,

        /// <summary>
        /// Common (2)
        /// </summary>
		[Display(Name = "Common")]
        Common = 2,

        /// <summary>
        /// Davek (3)
        /// </summary>
		[Display(Name = "Davek")]
        Davek = 3,

        /// <summary>
        /// Iokharic (4)
        /// </summary>
		[Display(Name = "Iokharic")]
        Iokharic = 4,

        /// <summary>
        /// Rellanic (5)
        /// </summary>
		[Display(Name = "Rellanic")]
        Rellanic = 5,

        /// <summary>
        /// Supernal (6)
        /// </summary>
		[Display(Name = "Supernal")]
        Supernal = 6
	}

}

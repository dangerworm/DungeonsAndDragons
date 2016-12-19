﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DungeonsAndDragons
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DungeonsAndDragonsEntities : DbContext
    {
        public DungeonsAndDragonsEntities()
            : base("name=DungeonsAndDragonsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ability> Abilities { get; set; }
        public virtual DbSet<AbilityValue> AbilityValues { get; set; }
        public virtual DbSet<ActionType> ActionTypes { get; set; }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<ActorType> ActorTypes { get; set; }
        public virtual DbSet<Alignment> Alignments { get; set; }
        public virtual DbSet<ArmourClass> ArmourClasses { get; set; }
        public virtual DbSet<ArmourItem> ArmourItems { get; set; }
        public virtual DbSet<ArmourType> ArmourTypes { get; set; }
        public virtual DbSet<ArmourWeightClass> ArmourWeightClasses { get; set; }
        public virtual DbSet<AttackClass> AttackClasses { get; set; }
        public virtual DbSet<AttackType> AttackTypes { get; set; }
        public virtual DbSet<AuthorityLevel> AuthorityLevels { get; set; }
        public virtual DbSet<ClassArmourProficienciesBridge> ClassArmourProficienciesBridges { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<ClassFeaturesBridge> ClassFeaturesBridges { get; set; }
        public virtual DbSet<ClassImplementProficienciesBridge> ClassImplementProficienciesBridges { get; set; }
        public virtual DbSet<ClassPowersBridge> ClassPowersBridges { get; set; }
        public virtual DbSet<ClassTrainedSkillsBridge> ClassTrainedSkillsBridges { get; set; }
        public virtual DbSet<ClassWeaponProficienciesBridge> ClassWeaponProficienciesBridges { get; set; }
        public virtual DbSet<CompassionLevel> CompassionLevels { get; set; }
        public virtual DbSet<ConsumableItem> ConsumableItems { get; set; }
        public virtual DbSet<DamageType> DamageTypes { get; set; }
        public virtual DbSet<DefenseModifier> DefenseModifiers { get; set; }
        public virtual DbSet<Defens> Defenses { get; set; }
        public virtual DbSet<Deity> Deities { get; set; }
        public virtual DbSet<DurationUnit> DurationUnits { get; set; }
        public virtual DbSet<EffectType> EffectTypes { get; set; }
        public virtual DbSet<EpicDestiny> EpicDestinies { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<GameActorsBridge> GameActorsBridges { get; set; }
        public virtual DbSet<GameMapAreasBridge> GameMapAreasBridges { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GearItem> GearItems { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<ImplementType> ImplementTypes { get; set; }
        public virtual DbSet<LanguageRacesBridge> LanguageRacesBridges { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LightSource> LightSources { get; set; }
        public virtual DbSet<MapArea> MapAreas { get; set; }
        public virtual DbSet<MapAreaType> MapAreaTypes { get; set; }
        public virtual DbSet<NonPlayerCharacter> NonPlayerCharacters { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<ParagonPath> ParagonPaths { get; set; }
        public virtual DbSet<PlayerCharacterFeaturesBridge> PlayerCharacterFeaturesBridges { get; set; }
        public virtual DbSet<PlayerCharacterLanguagesBridge> PlayerCharacterLanguagesBridges { get; set; }
        public virtual DbSet<PlayerCharacter> PlayerCharacters { get; set; }
        public virtual DbSet<PowerEffectsBridge> PowerEffectsBridges { get; set; }
        public virtual DbSet<Power> Powers { get; set; }
        public virtual DbSet<PowerSource> PowerSources { get; set; }
        public virtual DbSet<PowerUsage> PowerUsages { get; set; }
        public virtual DbSet<Prerequisite> Prerequisites { get; set; }
        public virtual DbSet<Purse> Purses { get; set; }
        public virtual DbSet<RaceFeaturesBridge> RaceFeaturesBridges { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Script> Scripts { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<SkillModifier> SkillModifiers { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<TargetType> TargetTypes { get; set; }
        public virtual DbSet<TransportItem> TransportItems { get; set; }
        public virtual DbSet<VisionLevel> VisionLevels { get; set; }
        public virtual DbSet<WeaponCategory> WeaponCategories { get; set; }
        public virtual DbSet<WeaponGroup> WeaponGroups { get; set; }
        public virtual DbSet<WeaponProperty> WeaponProperties { get; set; }
        public virtual DbSet<WeaponPropertiesBridge> WeaponPropertiesBridges { get; set; }
        public virtual DbSet<Weapon> Weapons { get; set; }
    
        public virtual int USP_Games_Create(ObjectParameter gameId, string name, Nullable<System.DateTime> startDate)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_Games_Create", gameId, nameParameter, startDateParameter);
        }
    
        public virtual ObjectResult<USP_Games_GetAll_Result> USP_Games_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_Games_GetAll_Result>("USP_Games_GetAll");
        }
    
        public virtual ObjectResult<USP_Games_GetById_Result> USP_Games_GetById(Nullable<int> gameId)
        {
            var gameIdParameter = gameId.HasValue ?
                new ObjectParameter("GameId", gameId) :
                new ObjectParameter("GameId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_Games_GetById_Result>("USP_Games_GetById", gameIdParameter);
        }
    
        public virtual int USP_Games_Update(Nullable<int> gameId, string name, Nullable<System.DateTime> startDate)
        {
            var gameIdParameter = gameId.HasValue ?
                new ObjectParameter("GameId", gameId) :
                new ObjectParameter("GameId", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_Games_Update", gameIdParameter, nameParameter, startDateParameter);
        }
    
        public virtual int USP_MapAreas_Create(ObjectParameter mapAreaId, Nullable<int> mapAreaTypeId, string name, string flavourText, Nullable<int> shopId, byte[] mapImage, Nullable<int> parentMapAreaId, Nullable<decimal> parentMapAreaLocationN, Nullable<decimal> parentMapAreaLocationE)
        {
            var mapAreaTypeIdParameter = mapAreaTypeId.HasValue ?
                new ObjectParameter("MapAreaTypeId", mapAreaTypeId) :
                new ObjectParameter("MapAreaTypeId", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var flavourTextParameter = flavourText != null ?
                new ObjectParameter("FlavourText", flavourText) :
                new ObjectParameter("FlavourText", typeof(string));
    
            var shopIdParameter = shopId.HasValue ?
                new ObjectParameter("ShopId", shopId) :
                new ObjectParameter("ShopId", typeof(int));
    
            var mapImageParameter = mapImage != null ?
                new ObjectParameter("MapImage", mapImage) :
                new ObjectParameter("MapImage", typeof(byte[]));
    
            var parentMapAreaIdParameter = parentMapAreaId.HasValue ?
                new ObjectParameter("ParentMapAreaId", parentMapAreaId) :
                new ObjectParameter("ParentMapAreaId", typeof(int));
    
            var parentMapAreaLocationNParameter = parentMapAreaLocationN.HasValue ?
                new ObjectParameter("ParentMapAreaLocationN", parentMapAreaLocationN) :
                new ObjectParameter("ParentMapAreaLocationN", typeof(decimal));
    
            var parentMapAreaLocationEParameter = parentMapAreaLocationE.HasValue ?
                new ObjectParameter("ParentMapAreaLocationE", parentMapAreaLocationE) :
                new ObjectParameter("ParentMapAreaLocationE", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_MapAreas_Create", mapAreaId, mapAreaTypeIdParameter, nameParameter, flavourTextParameter, shopIdParameter, mapImageParameter, parentMapAreaIdParameter, parentMapAreaLocationNParameter, parentMapAreaLocationEParameter);
        }
    
        public virtual ObjectResult<USP_MapAreas_GetAll_Result> USP_MapAreas_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_MapAreas_GetAll_Result>("USP_MapAreas_GetAll");
        }
    
        public virtual ObjectResult<USP_MapAreas_GetByGameId_Result> USP_MapAreas_GetByGameId(Nullable<int> gameId)
        {
            var gameIdParameter = gameId.HasValue ?
                new ObjectParameter("GameId", gameId) :
                new ObjectParameter("GameId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_MapAreas_GetByGameId_Result>("USP_MapAreas_GetByGameId", gameIdParameter);
        }
    
        public virtual ObjectResult<USP_MapAreas_GetById_Result> USP_MapAreas_GetById(Nullable<int> mapAreaId)
        {
            var mapAreaIdParameter = mapAreaId.HasValue ?
                new ObjectParameter("MapAreaId", mapAreaId) :
                new ObjectParameter("MapAreaId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_MapAreas_GetById_Result>("USP_MapAreas_GetById", mapAreaIdParameter);
        }
    
        public virtual int USP_MapAreas_Update(Nullable<int> mapAreaId, Nullable<int> mapAreaTypeId, string name, string flavourText, Nullable<int> shopId, byte[] mapImage, Nullable<int> parentMapAreaId, Nullable<decimal> parentMapAreaLocationN, Nullable<decimal> parentMapAreaLocationE)
        {
            var mapAreaIdParameter = mapAreaId.HasValue ?
                new ObjectParameter("MapAreaId", mapAreaId) :
                new ObjectParameter("MapAreaId", typeof(int));
    
            var mapAreaTypeIdParameter = mapAreaTypeId.HasValue ?
                new ObjectParameter("MapAreaTypeId", mapAreaTypeId) :
                new ObjectParameter("MapAreaTypeId", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var flavourTextParameter = flavourText != null ?
                new ObjectParameter("FlavourText", flavourText) :
                new ObjectParameter("FlavourText", typeof(string));
    
            var shopIdParameter = shopId.HasValue ?
                new ObjectParameter("ShopId", shopId) :
                new ObjectParameter("ShopId", typeof(int));
    
            var mapImageParameter = mapImage != null ?
                new ObjectParameter("MapImage", mapImage) :
                new ObjectParameter("MapImage", typeof(byte[]));
    
            var parentMapAreaIdParameter = parentMapAreaId.HasValue ?
                new ObjectParameter("ParentMapAreaId", parentMapAreaId) :
                new ObjectParameter("ParentMapAreaId", typeof(int));
    
            var parentMapAreaLocationNParameter = parentMapAreaLocationN.HasValue ?
                new ObjectParameter("ParentMapAreaLocationN", parentMapAreaLocationN) :
                new ObjectParameter("ParentMapAreaLocationN", typeof(decimal));
    
            var parentMapAreaLocationEParameter = parentMapAreaLocationE.HasValue ?
                new ObjectParameter("ParentMapAreaLocationE", parentMapAreaLocationE) :
                new ObjectParameter("ParentMapAreaLocationE", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_MapAreas_Update", mapAreaIdParameter, mapAreaTypeIdParameter, nameParameter, flavourTextParameter, shopIdParameter, mapImageParameter, parentMapAreaIdParameter, parentMapAreaLocationNParameter, parentMapAreaLocationEParameter);
        }
    
        public virtual int USP_PlayerCharacters_Create(ObjectParameter playerCharacterId, Nullable<int> actorId, string name, Nullable<int> classId, Nullable<int> paragonPathId, Nullable<int> epicDestinyId, Nullable<int> experiencePoints, Nullable<int> raceId, Nullable<int> age, Nullable<int> genderId, Nullable<int> height, Nullable<int> weightPounds, Nullable<int> alignmentId, Nullable<int> deityId, byte[] picture)
        {
            var actorIdParameter = actorId.HasValue ?
                new ObjectParameter("ActorId", actorId) :
                new ObjectParameter("ActorId", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var classIdParameter = classId.HasValue ?
                new ObjectParameter("ClassId", classId) :
                new ObjectParameter("ClassId", typeof(int));
    
            var paragonPathIdParameter = paragonPathId.HasValue ?
                new ObjectParameter("ParagonPathId", paragonPathId) :
                new ObjectParameter("ParagonPathId", typeof(int));
    
            var epicDestinyIdParameter = epicDestinyId.HasValue ?
                new ObjectParameter("EpicDestinyId", epicDestinyId) :
                new ObjectParameter("EpicDestinyId", typeof(int));
    
            var experiencePointsParameter = experiencePoints.HasValue ?
                new ObjectParameter("ExperiencePoints", experiencePoints) :
                new ObjectParameter("ExperiencePoints", typeof(int));
    
            var raceIdParameter = raceId.HasValue ?
                new ObjectParameter("RaceId", raceId) :
                new ObjectParameter("RaceId", typeof(int));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(int));
    
            var genderIdParameter = genderId.HasValue ?
                new ObjectParameter("GenderId", genderId) :
                new ObjectParameter("GenderId", typeof(int));
    
            var heightParameter = height.HasValue ?
                new ObjectParameter("Height", height) :
                new ObjectParameter("Height", typeof(int));
    
            var weightPoundsParameter = weightPounds.HasValue ?
                new ObjectParameter("WeightPounds", weightPounds) :
                new ObjectParameter("WeightPounds", typeof(int));
    
            var alignmentIdParameter = alignmentId.HasValue ?
                new ObjectParameter("AlignmentId", alignmentId) :
                new ObjectParameter("AlignmentId", typeof(int));
    
            var deityIdParameter = deityId.HasValue ?
                new ObjectParameter("DeityId", deityId) :
                new ObjectParameter("DeityId", typeof(int));
    
            var pictureParameter = picture != null ?
                new ObjectParameter("Picture", picture) :
                new ObjectParameter("Picture", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_PlayerCharacters_Create", playerCharacterId, actorIdParameter, nameParameter, classIdParameter, paragonPathIdParameter, epicDestinyIdParameter, experiencePointsParameter, raceIdParameter, ageParameter, genderIdParameter, heightParameter, weightPoundsParameter, alignmentIdParameter, deityIdParameter, pictureParameter);
        }
    
        public virtual ObjectResult<USP_PlayerCharacters_GetAll_Result> USP_PlayerCharacters_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_PlayerCharacters_GetAll_Result>("USP_PlayerCharacters_GetAll");
        }
    
        public virtual ObjectResult<USP_PlayerCharacters_GetByGameId_Result> USP_PlayerCharacters_GetByGameId(Nullable<int> gameId)
        {
            var gameIdParameter = gameId.HasValue ?
                new ObjectParameter("GameId", gameId) :
                new ObjectParameter("GameId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_PlayerCharacters_GetByGameId_Result>("USP_PlayerCharacters_GetByGameId", gameIdParameter);
        }
    
        public virtual ObjectResult<USP_PlayerCharacters_GetById_Result> USP_PlayerCharacters_GetById(Nullable<int> playerCharacterId)
        {
            var playerCharacterIdParameter = playerCharacterId.HasValue ?
                new ObjectParameter("PlayerCharacterId", playerCharacterId) :
                new ObjectParameter("PlayerCharacterId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_PlayerCharacters_GetById_Result>("USP_PlayerCharacters_GetById", playerCharacterIdParameter);
        }
    
        public virtual int USP_PlayerCharacters_Update(Nullable<int> playerCharacterId, Nullable<int> actorId, string name, Nullable<int> classId, Nullable<int> paragonPathId, Nullable<int> epicDestinyId, Nullable<int> experiencePoints, Nullable<int> raceId, Nullable<int> age, Nullable<int> genderId, Nullable<int> height, Nullable<int> weightPounds, Nullable<int> alignmentId, Nullable<int> deityId, byte[] picture)
        {
            var playerCharacterIdParameter = playerCharacterId.HasValue ?
                new ObjectParameter("PlayerCharacterId", playerCharacterId) :
                new ObjectParameter("PlayerCharacterId", typeof(int));
    
            var actorIdParameter = actorId.HasValue ?
                new ObjectParameter("ActorId", actorId) :
                new ObjectParameter("ActorId", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var classIdParameter = classId.HasValue ?
                new ObjectParameter("ClassId", classId) :
                new ObjectParameter("ClassId", typeof(int));
    
            var paragonPathIdParameter = paragonPathId.HasValue ?
                new ObjectParameter("ParagonPathId", paragonPathId) :
                new ObjectParameter("ParagonPathId", typeof(int));
    
            var epicDestinyIdParameter = epicDestinyId.HasValue ?
                new ObjectParameter("EpicDestinyId", epicDestinyId) :
                new ObjectParameter("EpicDestinyId", typeof(int));
    
            var experiencePointsParameter = experiencePoints.HasValue ?
                new ObjectParameter("ExperiencePoints", experiencePoints) :
                new ObjectParameter("ExperiencePoints", typeof(int));
    
            var raceIdParameter = raceId.HasValue ?
                new ObjectParameter("RaceId", raceId) :
                new ObjectParameter("RaceId", typeof(int));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(int));
    
            var genderIdParameter = genderId.HasValue ?
                new ObjectParameter("GenderId", genderId) :
                new ObjectParameter("GenderId", typeof(int));
    
            var heightParameter = height.HasValue ?
                new ObjectParameter("Height", height) :
                new ObjectParameter("Height", typeof(int));
    
            var weightPoundsParameter = weightPounds.HasValue ?
                new ObjectParameter("WeightPounds", weightPounds) :
                new ObjectParameter("WeightPounds", typeof(int));
    
            var alignmentIdParameter = alignmentId.HasValue ?
                new ObjectParameter("AlignmentId", alignmentId) :
                new ObjectParameter("AlignmentId", typeof(int));
    
            var deityIdParameter = deityId.HasValue ?
                new ObjectParameter("DeityId", deityId) :
                new ObjectParameter("DeityId", typeof(int));
    
            var pictureParameter = picture != null ?
                new ObjectParameter("Picture", picture) :
                new ObjectParameter("Picture", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_PlayerCharacters_Update", playerCharacterIdParameter, actorIdParameter, nameParameter, classIdParameter, paragonPathIdParameter, epicDestinyIdParameter, experiencePointsParameter, raceIdParameter, ageParameter, genderIdParameter, heightParameter, weightPoundsParameter, alignmentIdParameter, deityIdParameter, pictureParameter);
        }
    }
}

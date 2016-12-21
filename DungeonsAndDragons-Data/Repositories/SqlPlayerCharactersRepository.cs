using System.Data;
using System.Linq;
using DungeonsAndDragons_Data.Helpers;
using DungeonsAndDragons_Data.Models.Domain;

namespace DungeonsAndDragons_Data.Repositories
{
    public class SqlPlayerCharactersRepository : Repository<DPlayerCharacter>
    {
        public SqlPlayerCharactersRepository(UnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        protected override DPlayerCharacter Map(IDataReader reader)
        {
            return PlayerCharacterHelper.ParseReader(reader);
        }

        public DPlayerCharacter[] GetAll()
        {
            var command = UnitOfWork.CreateStoredProcedure("dbo.USP_PlayerCharacters_GetAll");

            return GetList(command).ToArray();
        }

        public DPlayerCharacter[] GetByGameId(int gameId)
        {
            var command = UnitOfWork.CreateStoredProcedure("dbo.USP_PlayerCharacters_GetByGameId");
            command.AddWithValue("@GameId", gameId, DbType.Int32);

            return GetList(command).ToArray();
        }

        public DPlayerCharacter GetById(int gameId)
        {
            var command = UnitOfWork.CreateStoredProcedure("dbo.USP_PlayerCharacters_GetById");
            command.AddWithValue("@PlayerCharacterId", gameId, DbType.Int32);

            return Get(command);
        }

        public DataResult<DPlayerCharacter> Save(DPlayerCharacter value)
        {
            return !value.Id.HasValue ? Create(value) : Update(value);
        }

        public DataResult<DPlayerCharacter> Create(DPlayerCharacter value)
        {
            using (var command = UnitOfWork.CreateStoredProcedure("dbo.USP_PlayerCharacters_Create"))
            {
                var idParameter = command.AddOutput("@PlayerCharacterId", DbType.Int32);

                command
                    .AddWithValue("@ActorId", value.ActorId, DbType.Int32)
                    .AddWithValue("@Name", value.Name, DbType.String)
                    .AddWithValue("@ClassId", value.ClassId, DbType.Int32)
                    .AddWithValue("@ParagonPathId", value.ParagonPathId, DbType.Int32)
                    .AddWithValue("@EpicDestinyId", value.EpicDestinyId, DbType.Int32)
                    .AddWithValue("@ExperiencePoints", value.ExperiencePoints, DbType.Int32)
                    .AddWithValue("@RaceId", value.RaceId, DbType.Int32)
                    .AddWithValue("@Age", value.Age, DbType.Int32)
                    .AddWithValue("@GenderId", value.GenderId, DbType.Int32)
                    .AddWithValue("@Height", value.Height, DbType.String)
                    .AddWithValue("@WeightPounds", value.WeightPounds, DbType.Int32)
                    .AddWithValue("@AlignmentId", value.AlignmentId, DbType.Int32)
                    .AddWithValue("@DeityId", value.DeityId, DbType.Int32);

                var result = ExecuteNonQueryWithId(command, idParameter);

                value.Id = result.ValueId;

                return new DataResult<DPlayerCharacter>(value, result);
            }
        }

        public DataResult<DPlayerCharacter> Update(DPlayerCharacter value)
        {
            using (var command = UnitOfWork.CreateStoredProcedure("dbo.USP_PlayerCharacters_Update"))
            {
                command
                    .AddWithValue("@PlayerCharacterId", value.Id, DbType.Int32)
                    .AddWithValue("@ActorId", value.ActorId, DbType.Int32)
                    .AddWithValue("@Name", value.Name, DbType.String)
                    .AddWithValue("@ClassId", value.ClassId, DbType.Int32)
                    .AddWithValue("@ParagonPathId", value.ParagonPathId, DbType.Int32)
                    .AddWithValue("@EpicDestinyId", value.EpicDestinyId, DbType.Int32)
                    .AddWithValue("@ExperiencePoints", value.ExperiencePoints, DbType.Int32)
                    .AddWithValue("@RaceId", value.RaceId, DbType.Int32)
                    .AddWithValue("@Age", value.Age, DbType.Int32)
                    .AddWithValue("@GenderId", value.GenderId, DbType.Int32)
                    .AddWithValue("@Height", value.Height, DbType.String)
                    .AddWithValue("@WeightPounds", value.WeightPounds, DbType.Int32)
                    .AddWithValue("@AlignmentId", value.AlignmentId, DbType.Int32)
                    .AddWithValue("@DeityId", value.DeityId, DbType.Int32);

                var result = ExecuteNonQuery(command);

                return new DataResult<DPlayerCharacter>(value, result);
            }
        }
    }
}

using System.Data;
using System.Linq;
using DungeonsAndDragons_Data.Helpers;
using DungeonsAndDragons_Data.Models.Domain;

namespace DungeonsAndDragons_Data.Repositories
{
    public class SqlGamesRepository : Repository<DGame>
    {
        public SqlGamesRepository(UnitOfWork unitOfWork)
            :base (unitOfWork)
        {
        }

        protected override DGame Map(IDataReader reader)
        {
            return GameHelper.ParseReader(reader);
        }

        public DGame[] GetAll()
        {
            var command = UnitOfWork.CreateStoredProcedure("dbo.USP_Games_GetAll");

            return GetList(command).ToArray();
        }

        public DGame GetById(int gameId)
        {
            var command = UnitOfWork.CreateStoredProcedure("dbo.USP_Games_GetById");
            command.AddWithValue("@GameId", gameId, DbType.Int32);

            return Get(command);
        }

        public DataResult<DGame> Save(DGame value)
        {
            return !value.Id.HasValue ? Create(value) : Update(value);
        }

        public DataResult<DGame> Create(DGame value)
        {
            using (var command = UnitOfWork.CreateStoredProcedure("dbo.USP_Games_Create"))
            {
                var idParameter = command.AddOutput("@GameId", DbType.Int32);

                command
                .AddWithValue("@Name", value.Name, DbType.String)
                .AddWithValue("@StartDate", value.StartDate, DbType.DateTime2);

                var result = ExecuteNonQueryWithId(command, idParameter);

                value.Id = result.ValueId;

                return new DataResult<DGame>(value, result);
            }
        }

        public DataResult<DGame> Update(DGame value)
        {
            using (var command = UnitOfWork.CreateStoredProcedure("dbo.USP_Games_Update"))
            {
                command
                .AddWithValue("@GameId", value.Id, DbType.Int32)
                .AddWithValue("@Name", value.Name, DbType.String)
                .AddWithValue("@StartDate", value.StartDate, DbType.DateTime2);

                var result = ExecuteNonQuery(command);

                return new DataResult<DGame>(value, result);
            }
        }

        public DataResult CreateGameActorBridge(int gameId, int actorId)
        {
            using (var command = UnitOfWork.CreateStoredProcedure("dbo.USP_GameActorsBridge_Create"))
            {
                command
                    .AddWithValue("@GameId", gameId, DbType.Int32)
                    .AddWithValue("@ActorId", actorId, DbType.String);

                return ExecuteNonQuery(command);
            }
        }
    }
}

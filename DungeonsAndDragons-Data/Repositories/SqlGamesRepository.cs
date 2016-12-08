using System.Data;

namespace DungeonsAndDragons_Data
{
    public class SqlGameRepository : Repository<Game>
    {
        public SqlGameRepository(UnitOfWork unitOfWork)
        : base(unitOfWork, true)
        {
        }

        protected override Game Map(IDataReader reader)
        {
            return GameHelper.ParseReader(reader);
        }

        public Game Get(int gameId)
        {
            using (var command = UnitOfWork.CreateStoredProcedure("dbo.USP_Games_Get"))
            {
                command
                .AddWithValue("@GameId", gameId, DbType.Int32);

                return Get(command);
            }
        }

        public DataResult<Game> Save(Game value)
        {
            return !value.Id.HasValue ? Create(value) : Update(value);
        }

        public DataResult<Game> Create(Game value)
        {
            using (var command = UnitOfWork.CreateStoredProcedure("dbo.USP_Game_Create"))
            {
                var idParameter = command.AddOutput("@GameId", DbType.Int32);

                command
                .AddWithValue("@GameId", value.Id, DbType.Int32)
                .AddWithValue("@Name", value.Name, DbType.String)
                .AddWithValue("@StartDate", value.StartDate, DbType.DateTime2);

                var result = ExecuteNonQueryWithId(command, idParameter);

                value.Id = result.ValueId;

                return new DataResult<Game>(value, result);
            }
        }

        public DataResult<Game> Update(Game value)
        {
            using (var command = UnitOfWork.CreateStoredProcedure("dbo.USP_Game_Update"))
            {
                command
                .AddWithValue("@GameId", value.Id, DbType.Int32)
                .AddWithValue("@Name", value.Name, DbType.String)
                .AddWithValue("@StartDate", value.StartDate, DbType.DateTime2);

                var result = ExecuteNonQuery(command);

                return new DataResult<Game>(value, result);
            }
        }
    }
}

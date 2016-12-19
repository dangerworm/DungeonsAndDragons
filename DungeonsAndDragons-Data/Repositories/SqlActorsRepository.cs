using System.Data;
using DungeonsAndDragons_Data.Models.Domain;
using DungeonsAndDragons_Data.Helpers;

namespace DungeonsAndDragons_Data.Repositories
{
    public class SqlActorsRepository : Repository<DActor>
    {
        public SqlActorsRepository(UnitOfWork unitOfWork)
        : base(unitOfWork, true)
        {
        }

        protected override DActor Map(IDataReader reader)
        {
            return ActorHelper.ParseReader(reader);
        }

        public DActor Get(int actorsId)
        {
            using (var command = UnitOfWork.CreateStoredProcedure("dbo.USP_DActors_Get"))
            {
                command.AddWithValue("@ActorId", actorsId, DbType.Int32);

                return Get(command);
            }
        }

        public DataResult<DActor> Save(DActor value)
        {
            return !value.Id.HasValue ? Create(value) : Update(value);
        }

        public DataResult<DActor> Create(DActor value)
        {
            using (var command = UnitOfWork.CreateStoredProcedure("dbo.USP_Actors_Create"))
            {
                var idParameter = command.AddOutput("ActorId", DbType.Int32);

                command
                .AddWithValue("@ActorId", value.Id, DbType.Int32)
                .AddWithValue("@ActorTypeId", value.ActorTypeId, DbType.Int32)
                .AddWithValue("@MapAreaId", value.MapAreaId, DbType.Int32);

                var result = ExecuteNonQueryWithId(command, idParameter);

                value.Id = result.ValueId;

                return new DataResult<DActor>(value, result);
            }
        }

        public DataResult<DActor> Update(DActor value)
        {
            using (var command = UnitOfWork.CreateStoredProcedure("dbo.USP_DActors_Update"))
            {
                command
                .AddWithValue("@ActorId", value.Id, DbType.Int32)
                .AddWithValue("@ActorTypeId", value.ActorTypeId, DbType.Int32)
                .AddWithValue("@MapAreaId", value.MapAreaId, DbType.Int32);

                var result = ExecuteNonQuery(command);

                return new DataResult<DActor>(value, result);
            }
        }
    }
}

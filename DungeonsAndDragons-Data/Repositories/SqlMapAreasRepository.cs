using System.Data;
using System.Linq;
using DungeonsAndDragons_Data.Helpers;
using DungeonsAndDragons_Data.Models.Domain;

namespace DungeonsAndDragons_Data.Repositories
{
    public class SqlMapAreasRepository : Repository<DMapArea>
    {
        public SqlMapAreasRepository(UnitOfWork unitOfWork)
            :base (unitOfWork)
        {
        }

        protected override DMapArea Map(IDataReader reader)
        {
            return MapAreaHelper.ParseReader(reader);
        }

        public DMapArea[] GetAll()
        {
            var command = UnitOfWork.CreateStoredProcedure("dbo.USP_MapAreas_GetAll");

            return GetList(command).ToArray();
        }

        public DMapArea[] GetByGameId(int gameId)
        {
            var command = UnitOfWork.CreateStoredProcedure("dbo.USP_MapAreas_GetByGameId");
            command.AddWithValue("@GameId", gameId, DbType.Int32);

            return GetList(command).ToArray();
        }

        public DMapArea GetById(int gameId)
        {
            var command = UnitOfWork.CreateStoredProcedure("dbo.USP_MapAreas_GetById");
            command.AddWithValue("@GameId", gameId, DbType.Int32);

            return Get(command);
        }

        public DataResult<DMapArea> Save(DMapArea value)
        {
            return !value.Id.HasValue ? Create(value) : Update(value);
        }

        public DataResult<DMapArea> Create(DMapArea value)
        {
            using (var command = UnitOfWork.CreateStoredProcedure("dbo.USP_MapAreas_Create"))
            {
                var idParameter = command.AddOutput("@MapAreaId", DbType.Int32);

                command
                .AddWithValue("@MapAreaTypeId", value.TypeId, DbType.Int32)
                .AddWithValue("@Name", value.Name, DbType.String)
                .AddWithValue("@FlavourText", value.FlavourText, DbType.String)
                .AddWithValue("@ShopId", value.ShopId, DbType.Int32)
                .AddWithValue("@MapImage", value.Image, DbType.Binary)
                .AddWithValue("@ParentMapAreaId", value.ParentMapAreaId, DbType.Int32)
                .AddWithValue("@ParentMapAreaLocationN", value.ParentMapAreaLocationN, DbType.Decimal)
                .AddWithValue("@ParentMapAreaLocationE", value.ParentMapAreaLocationE, DbType.Decimal);

                var result = ExecuteNonQueryWithId(command, idParameter);

                value.Id = result.ValueId;

                return new DataResult<DMapArea>(value, result);
            }
        }

        public DataResult<DMapArea> Update(DMapArea value)
        {
            using (var command = UnitOfWork.CreateStoredProcedure("dbo.USP_MapAreas_Update"))
            {
                command
                .AddWithValue("@MapAreaId", value.Id, DbType.Int32)
                .AddWithValue("@MapAreaTypeId", value.TypeId, DbType.Int32)
                .AddWithValue("@Name", value.Name, DbType.String)
                .AddWithValue("@FlavourText", value.FlavourText, DbType.String)
                .AddWithValue("@ShopId", value.ShopId, DbType.Int32)
                .AddWithValue("@MapImage", value.Image, DbType.Binary)
                .AddWithValue("@ParentMapAreaId", value.ParentMapAreaId, DbType.Int32)
                .AddWithValue("@ParentMapAreaLocationN", value.ParentMapAreaLocationN, DbType.Decimal)
                .AddWithValue("@ParentMapAreaLocationE", value.ParentMapAreaLocationE, DbType.Decimal);

                var result = ExecuteNonQuery(command);

                return new DataResult<DMapArea>(value, result);
            }
        }
    }
}

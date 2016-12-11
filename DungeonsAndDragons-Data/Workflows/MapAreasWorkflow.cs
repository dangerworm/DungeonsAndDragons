using DungeonsAndDragons_Data.Mapping;
using DungeonsAndDragons_Data.Models.Domain;
using DungeonsAndDragons_Data.Models.Object;
using DungeonsAndDragons_Data.Repositories;

namespace DungeonsAndDragons_Data.Workflows
{

    public class MapAreasWorkflow
    {
        private readonly SqlMapAreasRepository _mapAreasRepository;

        public MapAreasWorkflow(UnitOfWork unitOfWork)
        {
            _mapAreasRepository = new SqlMapAreasRepository(unitOfWork);
        }

        public MapArea[] GetAll()
        {
            return _mapAreasRepository.GetAll().MapAll<DMapArea, MapArea>();
        }

        public MapArea[] GetByGameId(int gameId)
        {
            return _mapAreasRepository.GetByGameId(gameId).MapAll<DMapArea, MapArea>();
        }

        public MapArea GetById(int id)
        {
            return _mapAreasRepository.GetById(id).Map<DMapArea, MapArea>();
        }

        public DataResult<MapArea> Save(MapArea mapArea)
        {
            var dMapArea = mapArea.Map<DMapArea, MapArea>();
            var dResult = _mapAreasRepository.Save(dMapArea);

            return new DataResult<MapArea>(dResult.Value.Map<DMapArea, MapArea>(), dResult);
        }
    }
}

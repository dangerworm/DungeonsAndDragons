using System.Configuration;
using DungeonsAndDragons_Data.Models.Domain;

namespace DungeonsAndDragons_Data
{

    public class GamesWorkflow
    {
        private readonly SqlGamesRepository _gamesRepository;

        public GamesWorkflow(UnitOfWork unitOfWork)
        {
            _gamesRepository = new SqlGamesRepository(unitOfWork);
        }

        public DGame[] GetAll()
        {
            return _gamesRepository.GetAll();
        }

        public DGame GetById(int gameId)
        {
            return _gamesRepository.Get(gameId);
        }
    }
}

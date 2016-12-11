using DungeonsAndDragons_Data.Mapping;
using DungeonsAndDragons_Data.Models.Domain;
using DungeonsAndDragons_Data.Models.Object;
using DungeonsAndDragons_Data.Repositories;

namespace DungeonsAndDragons_Data.Workflows
{

    public class GamesWorkflow
    {
        private readonly SqlGamesRepository _gamesRepository;

        public GamesWorkflow(UnitOfWork unitOfWork)
        {
            _gamesRepository = new SqlGamesRepository(unitOfWork);
        }

        public Game[] GetAll()
        {
            return _gamesRepository.GetAll().MapAll<DGame, Game>();
        }

        public Game GetById(int gameId)
        {
            return _gamesRepository.GetById(gameId).Map<DGame, Game>();
        }

        public DataResult<Game> Save(Game game)
        {
            var dGame = game.Map<Game, DGame>();
            var dResult = _gamesRepository.Save(dGame);

            return new DataResult<Game>(dResult.Value.Map<DGame, Game>(), dResult);
        }
    }
}

using DungeonsAndDragons_Data.Mapping;
using DungeonsAndDragons_Data.Models.Domain;
using DungeonsAndDragons_Data.Models.Object;
using DungeonsAndDragons_Data.Workflows;

namespace DungeonsAndDragons_Data.Services
{
    public class GamesService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly GamesWorkflow _gamesWorkflow;
        private readonly MapAreasWorkflow _mapAreasWorkflow;
        private readonly PlayerCharactersWorkflow _playerCharactersWorkflow;

        public GamesService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _gamesWorkflow = new GamesWorkflow(unitOfWork);
            _mapAreasWorkflow = new MapAreasWorkflow(unitOfWork);
            _playerCharactersWorkflow = new PlayerCharactersWorkflow(unitOfWork);
        }

        public Game[] GetAll()
        {
            _unitOfWork.Begin();

            var games = _gamesWorkflow.GetAll();

            foreach (var game in games)
            {
                game.Players = _playerCharactersWorkflow.GetByGameId(game.Id ?? 0);
                game.MapAreas = _mapAreasWorkflow.GetByGameId(game.Id ?? 0);
            }

            _unitOfWork.End();

            return games;
        }

        public Game GetById(int gameId)
        {
            _unitOfWork.Begin();

            var game = _gamesWorkflow.GetById(gameId).Map<DGame, Game>();
            game.Players = _playerCharactersWorkflow.GetByGameId(gameId);
            game.MapAreas = _mapAreasWorkflow.GetByGameId(gameId);

            _unitOfWork.End();

            return game;
        }

        public DataResult<Game> Save(Game value)
        {
            _unitOfWork.Begin();

            var result = _gamesWorkflow.Save(value);

            _unitOfWork.End();

            return result;
        }
    }
}

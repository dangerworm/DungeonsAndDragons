using DungeonsAndDragons_Data.Enums;
using DungeonsAndDragons_Data.Models.Object;
using DungeonsAndDragons_Data.Workflows;

namespace DungeonsAndDragons_Data.Services
{
    public class PlayerCharactersService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly GamesWorkflow _gamesWorkflow;
        private readonly PlayerCharactersWorkflow _playerCharactersWorkflow;

        public PlayerCharactersService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _gamesWorkflow = new GamesWorkflow(unitOfWork);
            _playerCharactersWorkflow = new PlayerCharactersWorkflow(unitOfWork);
        }

        public PlayerCharacter[] GetAll()
        {
            _unitOfWork.Begin();

            var players = _playerCharactersWorkflow.GetAll();

            _unitOfWork.End();

            return players;
        }

        public PlayerCharacter GetById(int playerCharacterId)
        {
            _unitOfWork.Begin();

            var player = _playerCharactersWorkflow.GetById(playerCharacterId);

            _unitOfWork.End();

            return player;
        }

        public DataResult<PlayerCharacter> Save(PlayerCharacter value, int? gameId)
        {
            _unitOfWork.Begin();
            _unitOfWork.BeginTransaction();

            var pcResult = _playerCharactersWorkflow.Save(value);

            if (pcResult.Type != DataResultType.Success)
            {
                _unitOfWork.Rollback();
                return pcResult;
            }

            if (gameId.HasValue)
            {
                var gameResult = _gamesWorkflow.CreateGameActorBridge(gameId.Value, value.ActorId);

                if (gameResult.Type != DataResultType.Success)
                {
                    _unitOfWork.Rollback();
                    return new DataResult<PlayerCharacter>(pcResult.Value, DataResultType.UnableToCreateRecord, 
                        $"The player was created but could not be linked to the game: " + gameResult.FriendlyMessage);
                }
            }

            _unitOfWork.End();

            return pcResult;
        }
    }
}

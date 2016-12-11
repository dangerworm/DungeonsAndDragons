using DungeonsAndDragons_Data.Mapping;
using DungeonsAndDragons_Data.Models.Domain;
using DungeonsAndDragons_Data.Models.Object;
using DungeonsAndDragons_Data.Repositories;

namespace DungeonsAndDragons_Data.Workflows
{

    public class PlayerCharactersWorkflow
    {
        private readonly SqlPlayerCharactersRepository _playerCharactersRepository;

        public PlayerCharactersWorkflow(UnitOfWork unitOfWork)
        {
            _playerCharactersRepository= new SqlPlayerCharactersRepository(unitOfWork);
        }

        public PlayerCharacter[] GetAll()
        {
            return _playerCharactersRepository.GetAll().MapAll<DPlayerCharacter, PlayerCharacter>();
        }

        public PlayerCharacter[] GetByGameId(int gameId)
        {
            return _playerCharactersRepository.GetByGameId(gameId).MapAll<DPlayerCharacter, PlayerCharacter>();
        }

        public PlayerCharacter GetById(int id)
        {
            return _playerCharactersRepository.GetById(id).Map<DPlayerCharacter, PlayerCharacter>();
        }

        public DataResult<PlayerCharacter> Save(PlayerCharacter player)
        {
            var dPlayer = player.Map<PlayerCharacter, DPlayerCharacter>();
            var dResult = _playerCharactersRepository.Save(dPlayer);

            return new DataResult<PlayerCharacter>(dResult.Value.Map<DPlayerCharacter, PlayerCharacter>(), dResult);
        }
    }
}

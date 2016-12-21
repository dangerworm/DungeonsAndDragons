using System.Security.Cryptography;
using DungeonsAndDragons_Data.Enums;
using DungeonsAndDragons_Data.Mapping;
using DungeonsAndDragons_Data.Models.Domain;
using DungeonsAndDragons_Data.Models.Object;
using DungeonsAndDragons_Data.Repositories;

namespace DungeonsAndDragons_Data.Workflows
{

    public class PlayerCharactersWorkflow
    {
        private readonly SqlActorsRepository _actorsRepository;
        private readonly SqlPlayerCharactersRepository _playerCharactersRepository;

        public PlayerCharactersWorkflow(UnitOfWork unitOfWork)
        {
            _actorsRepository = new SqlActorsRepository(unitOfWork);
            _playerCharactersRepository = new SqlPlayerCharactersRepository(unitOfWork);
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
            var dActor = new DActor();
            if (player.Id.HasValue)
            {
                dActor = _actorsRepository.Get(player.ActorId);
            }
            else
            {
                dActor = new DActor(null, 1, null);
                dActor = _actorsRepository.Create(dActor);

                if (!dActor.Id.HasValue)
                {
                    return new DataResult<PlayerCharacter>(DataResultType.InvalidState, "Could not read ID of new Actor");
                }

                player.ActorId = dActor.Id.Value;
            }

            var dPlayer = player.Map<PlayerCharacter, DPlayerCharacter>();
            var dResult = _playerCharactersRepository.Save(dPlayer);

            return new DataResult<PlayerCharacter>(dResult.Value.Map<DPlayerCharacter, PlayerCharacter>(), dResult);
        }
    }
}

﻿using DungeonsAndDragons_Data.Enums;
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
            return _playerCharactersRepository.GetAll()?.MapAll<DPlayerCharacter, PlayerCharacter>();
        }

        public PlayerCharacter[] GetByGameId(int gameId)
        {
            return _playerCharactersRepository.GetByGameId(gameId)?.MapAll<DPlayerCharacter, PlayerCharacter>();
        }

        public PlayerCharacter GetById(int id)
        {
            return _playerCharactersRepository.GetById(id)?.Map<DPlayerCharacter, PlayerCharacter>();
        }

        public DataResult<PlayerCharacter> Save(PlayerCharacter player)
        {
            if (!player.Id.HasValue)
            {
                var dActor = new DActor(null, 1, null);
                var dActorResult = _actorsRepository.Create(dActor);

                if (dActorResult.Type != DataResultType.Success)
                {
                    return new DataResult<PlayerCharacter>(DataResultType.InvalidState, "Could not create new Actor");
                }

                dActor = dActorResult.Value;
                if (!dActor.Id.HasValue)
                {
                    return new DataResult<PlayerCharacter>(DataResultType.InvalidState, "Could not read ID of new Actor");
                }

                player.ActorId = dActor.Id.Value;
            }

            var dPlayer = player.Map<PlayerCharacter, DPlayerCharacter>();
            var dPlayerResult = _playerCharactersRepository.Save(dPlayer);

            return new DataResult<PlayerCharacter>(dPlayerResult.Value?.Map<DPlayerCharacter, PlayerCharacter>(), dPlayerResult);
        }
    }
}

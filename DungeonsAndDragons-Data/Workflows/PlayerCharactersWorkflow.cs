using System.Configuration;
using DungeonsAndDragons_Data.Mapping;
using DungeonsAndDragons_Data.Models.Domain;
using DungeonsAndDragons_Data.Models.Object;
using DungeonsAndDragons_Data.Repositories;

namespace DungeonsAndDragons_Data
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

        public PlayerCharacter[] GetAllByGameId(int gameId)
        {
            return _playerCharactersRepository.GetAllByGameId(gameId).MapAll<DPlayerCharacter, PlayerCharacter>();
        }

        public PlayerCharacter GetById(int id)
        {
            return _playerCharactersRepository.GetById(id).Map<DPlayerCharacter, PlayerCharacter>();
        }
    }
}

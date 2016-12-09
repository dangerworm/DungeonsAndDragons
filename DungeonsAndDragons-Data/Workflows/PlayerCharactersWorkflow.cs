using System.Configuration;
using DungeonsAndDragons_Data.Models.Domain;
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

        public DPlayerCharacter[] GetAll()
        {
            return _playerCharactersRepository.GetAll();
        }

        public DPlayerCharacter[] GetAllByGameId(int gameId)
        {
            return _playerCharactersRepository.GetAllByGameId(gameId);
        }

        public DPlayerCharacter GetById(int id)
        {
            return _playerCharactersRepository.GetById(id);
        }
    }
}

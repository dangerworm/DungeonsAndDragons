﻿using DungeonsAndDragons_Data.Mapping;
using DungeonsAndDragons_Data.Models.Domain;
using DungeonsAndDragons_Data.Models.Object;
using DungeonsAndDragons_Data.Workflows;

namespace DungeonsAndDragons_Data.Services
{
    public class PlayerCharactersService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly PlayerCharactersWorkflow _playerCharactersWorkflow;

        public PlayerCharactersService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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

        public DataResult<PlayerCharacter> Save(PlayerCharacter value)
        {
            _unitOfWork.Begin();

            var result = _playerCharactersWorkflow.Save(value);

            _unitOfWork.End();

            return result;
        }
    }
}

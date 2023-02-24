using APP.DTO;
using APP.Interfaces;
using DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace APP.Services
{
    public class CargoService : ICargoService
    {
        private ICargoRepository _cargoRepository;

        public void Add(CargoDto cargoDto)
        {
            throw new NotImplementedException();
        }

        public CargoDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<CargoDto> GetCargoDtos()
        {
            throw new NotImplementedException();
        }

        public void RemoveAll(CargoDto cargoDto)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(int cargoDto)
        {
            throw new NotImplementedException();
        }

        public void Update(CargoDto cargoDto)
        {
            throw new NotImplementedException();
        }
    }
}

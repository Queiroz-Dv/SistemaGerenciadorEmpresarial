using APP.DTO;
using System.Collections.Generic;

namespace APP.Interfaces
{
    public interface ICargoService
    {
        ICollection<CargoDto> GetCargoDtos();

        CargoDto GetById(int id);

        void Add(CargoDto cargoDto);

        void Update(CargoDto cargoDto);

        void RemoveById(int cargoDto);

        void RemoveAll(CargoDto cargoDto);
    }
}

using Domain.Entities;
using Domain.Interfaces.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.DAL.Repositories
{
    public class CargoRepository : ICargoRepository
    {
        public Task<Cargo> AtualizarCargo(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public Task<Cargo> CriarCargo(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Cargo>> ObterCargos()
        {
            throw new NotImplementedException();
        }

        public Task<Cargo> ObterPorId(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Cargo> RemoverCargo(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public Task<Cargo> RemoverTodos(Cargo cargo)
        {
            throw new NotImplementedException();
        }
    }
}

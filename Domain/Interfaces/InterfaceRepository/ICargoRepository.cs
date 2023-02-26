using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceRepository
{
    public interface ICargoRepository
    {
        Task<ICollection<Cargo>> ObterCargos();

        Task<Cargo> ObterPorId(int? id);

        Task<Cargo> CriarCargo(Cargo cargo);

        Task<Cargo> AtualizarCargo(Cargo cargo);

        Task<Cargo> RemoverCargo(Cargo cargo);

        Task<Cargo> RemoverTodos(Cargo cargo);
    }
}

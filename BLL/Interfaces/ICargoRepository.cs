using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface ICargoRepository
    {
        List<DAL.Models.Cargo> ObterCargos();

        DAL.Models.Cargo ObterCargoPorId(int id);

        void GravarCargo(DAL.Models.Cargo cargo);

        void AtualizarCargo(int id);

        void DeletarCargo(int id);

        void DeletarCargos(DAL.Models.Cargo cargos);
    }
}

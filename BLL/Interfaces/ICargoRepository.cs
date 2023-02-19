using DAL;
using DAL.DTO.Cargo;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface ICargoRepository
    {
        List<CargosDTO> ObterCargos();

        CargosDTO ObterCargoPorId(int id);

        void GravarCargo(CARGO cargo);

        void AtualizarCargo(int id);

        void DeletarCargo(int id);

        void DeletarCargos(CARGO cargos);
    }
}

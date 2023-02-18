using DAL;
using DAL.DTO.Cargo;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface ICargoRepository
    {
        List<CargosDTO> ObterCargos();

        CARGO GravarCargo(CARGO departamento);

        CARGO AtualizarCargo(int id);

        CARGO DeletarCargo(int id);

        CARGO DeletarCargos(CARGO departamentos);
    }
}

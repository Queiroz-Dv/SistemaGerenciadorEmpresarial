using Infra.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Application.Interfaces
{
    public interface IDepartamentoService
    {
        Task<ICollection<DepartamentoDto>> ObterDepartamentosService();

        Task<DepartamentoDto> ObterPorIdService(int? id);

        Task<DepartamentoDto> CriarDepartamentoService(DepartamentoDto departamento);

        Task<DepartamentoDto> AtualizarDepartamentoService(DepartamentoDto departamento);

        Task<DepartamentoDto> RemoverDepartamentoService(DepartamentoDto departamento);

        Task<DepartamentoDto> RemoverTodosService(DepartamentoDto departamento);
    }
}
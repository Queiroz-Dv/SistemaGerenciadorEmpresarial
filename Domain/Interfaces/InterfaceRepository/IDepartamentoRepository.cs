using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceRepository
{
    /// <summary>
    /// Interface para os repositórios de Data.DAL implementar
    /// </summary>
    public interface IDepartamentoRepository
    {
        Task<ICollection<Departamento>> ObterDepartamentos();

        Task<Departamento> ObterPorId(int? id);

        Task<Departamento> CriarDepartamento(Departamento departamento);

        Task<Departamento> AtualizarDepartamento(Departamento departamento);

        Task<Departamento> RemoverDepartamento(Departamento departamento);

        Task<Departamento> RemoverTodos(Departamento departamento);
    }
}

using DAL;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IDepartamentoRepository
    {
        IEnumerable<DEPARTAMENTO> ObterDepartamentos(DEPARTAMENTO departamento);

        DEPARTAMENTO GravarDepartamento(DEPARTAMENTO departamento);

        DEPARTAMENTO AtualizarDepartamento(DEPARTAMENTO departamento);

        DEPARTAMENTO DeletarDepartamento(DEPARTAMENTO departamento);
    }
}

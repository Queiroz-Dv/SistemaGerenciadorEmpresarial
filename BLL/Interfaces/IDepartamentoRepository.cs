using DAL;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IDepartamentoRepository
    {
        List<DEPARTAMENTO> ObterDepartamentos();

        DEPARTAMENTO GravarDepartamento(DEPARTAMENTO departamento);

        DEPARTAMENTO AtualizarDepartamento(int id);

        DEPARTAMENTO DeletarDepartamento(int id);

        DEPARTAMENTO DeletarDepartamentos(DEPARTAMENTO departamentos);
    }
}

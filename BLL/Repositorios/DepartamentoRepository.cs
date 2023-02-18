using BLL.Interfaces;
using DAL;
using DAL.DAO.Departamento;
using System;
using System.Collections.Generic;

namespace BLL.Repositorios
{
    /// <summary>
    /// Repositório do módulo de Departamento
    /// </summary>
    public class DepartamentoRepository : IDepartamentoRepository
    {
        public DEPARTAMENTO AtualizarDepartamento(int id)
        {
            throw new NotImplementedException();
        }

        public DEPARTAMENTO DeletarDepartamento(int id)
        {
            throw new NotImplementedException();
        }

        public DEPARTAMENTO DeletarDepartamentos(DEPARTAMENTO departamentos)
        {
            throw new NotImplementedException();
        }

        public DEPARTAMENTO GravarDepartamento(DEPARTAMENTO departamento)
        {
            if (departamento != null)
            {
                DepartamentosDAO.Gravar(departamento); // Repassa o objeto para a camada de persistência
                return departamento;
            }
            else
                return departamento;
        }

        public List<DEPARTAMENTO> ObterDepartamentos() => DepartamentosDAO.ObterTodos();
    }
}

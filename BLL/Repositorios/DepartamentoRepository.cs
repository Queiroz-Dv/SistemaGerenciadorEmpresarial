using BLL.Interfaces;
using DAL;
using DAL.DAO.Departamento;
using System;
using System.Collections.Generic;

namespace BLL.Repositorios
{
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
                DepartamentoDAO.Gravar(departamento); // Repassa o objeto para a camada de persistência
                return departamento;
            }
            else
                return departamento;
        }

        public List<DEPARTAMENTO> ObterDepartamentos() => DepartamentoDAO.ObterTodos();
    }
}

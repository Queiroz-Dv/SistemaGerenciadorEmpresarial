using DAL.Interfaces;
using DAL;
using DAL.DAO.Departamento;
using System;
using System.Collections.Generic;

namespace DAL.Repositorios
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        public void AtualizarDepartamento(int id)
        {
            throw new NotImplementedException();
        }

        public void DeletarDepartamento(int id)
        {
            throw new NotImplementedException();
        }

        public void DeletarDepartamentos(DEPARTAMENTO departamentos)
        {
            throw new NotImplementedException();
        }

        public void GravarDepartamento(DEPARTAMENTO departamento) => DepartamentosDAO.Gravar(departamento); // Repassa o objeto para a camada de persistência       

        public List<DEPARTAMENTO> ObterDepartamentos() => DepartamentosDAO.ObterTodos();
    }
}

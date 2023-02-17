using BLL.Interfaces;
using DAL;
using DAL.DAO.Departamento;
using System;
using System.Collections.Generic;

namespace BLL.Repositorios
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        public DEPARTAMENTO AtualizarDepartamento(DEPARTAMENTO departamento)
        {
            throw new NotImplementedException();
        }

        public DEPARTAMENTO DeletarDepartamento(DEPARTAMENTO departamento)
        {
            throw new NotImplementedException();
        }

        public DEPARTAMENTO GravarDepartamento(DEPARTAMENTO departamento)
        {
            DepartamentoDAO.Gravar(departamento); // Repassa o objeto para a camada de persistência
            return departamento;
        }

        public IEnumerable<DEPARTAMENTO> ObterDepartamentos(DEPARTAMENTO departamento)
        {
            throw new NotImplementedException();
        }
    }
}

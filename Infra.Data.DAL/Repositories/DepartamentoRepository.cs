using Domain.Entities;
using Domain.Interfaces.InterfaceRepository;
using Infra.Data.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Data.DAL.Repositories
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        private readonly Contexto _contexto;

        public DepartamentoRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public Task<Departamento> AtualizarDepartamento(Departamento departamento)
        {
            throw new NotImplementedException();
        }

        public async Task<Departamento> CriarDepartamento(Departamento departamento)
        {
            try
            {
                _contexto.Add(departamento);
                await _contexto.SaveChangesAsync();
                return departamento;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<ICollection<Departamento>> ObterDepartamentos()
        {
            throw new NotImplementedException();
        }

        public Task<Departamento> ObterPorId(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Departamento> RemoverDepartamento(Departamento departamento)
        {
            throw new NotImplementedException();
        }

        public Task<Departamento> RemoverTodos(Departamento departamento)
        {
            throw new NotImplementedException();
        }
    }
}

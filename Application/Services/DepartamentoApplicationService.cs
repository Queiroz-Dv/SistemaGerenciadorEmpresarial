using Domain.Entities;
using Domain.Interfaces.InterfaceRepository;
using Infra.Application.DTO;
using Infra.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Application.Services
{
    public class DepartamentoApplicationService : IDepartamentoService
    {
        private IDepartamentoRepository departamentoRepository;

        private Departamento departamento;

        public Task<DepartamentoDto> AtualizarDepartamentoService(DepartamentoDto departamento)
        {
            throw new NotImplementedException();
        }

        public async  Task<DepartamentoDto> CriarDepartamentoService(DepartamentoDto departamento)
        {
            if (departamento!=null)
            {
                var entity = new Departamento(departamento.Id, departamento.Nome);
                await departamentoRepository.CriarDepartamento(entity);
                return departamento;
            }
            return departamento;
        }

        public Task<ICollection<DepartamentoDto>> ObterDepartamentosService()
        {
            throw new NotImplementedException();
        }

        public Task<DepartamentoDto> ObterPorIdService(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<DepartamentoDto> RemoverDepartamentoService(DepartamentoDto departamento)
        {
            throw new NotImplementedException();
        }

        public Task<DepartamentoDto> RemoverTodosService(DepartamentoDto departamento)
        {
            throw new NotImplementedException();
        }
    }
}

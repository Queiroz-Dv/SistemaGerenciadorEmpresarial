using Domain.Commands;
using Domain.Entities;
using System;

namespace Domain.Services
{
    public class DepartamentoService : Service
    {
        private readonly Departamento _entity;

        public DepartamentoService(Guid id, string nome)
        {
            _entity = new Departamento(id, nome);
            NotificationEntity = _entity;
        }

        /// <summary>
        /// Método responsável por repassar os dados 
        /// para o SalvarDepartamentoCommand e ir ao Application
        /// </summary>
        /// <param name="id"> Id do Departamento</param>
        /// <param name="nome"> Nome do departamento</param>
        public void SalvarDepartamentoService(Guid id, string nome)
        {
            var cmd = new SalvarDepartamento(_entity);
            cmd.RunCommand();
        }
    }
}
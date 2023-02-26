using Domain.Commands;
using Domain.Entities;
using System;

namespace Domain.Services
{
    public class CargoService : Service
    {
        private readonly Cargo _entity;

        public CargoService(Guid id, string nome)
        {
            _entity = new Cargo(id, nome);
            NotificationEntity = _entity;
        }

        public void SalvarCargoService(Guid id, string nome)
        {
            var cmd = new SalvarCargo(_entity);
            cmd.Run();
        }
    }
}
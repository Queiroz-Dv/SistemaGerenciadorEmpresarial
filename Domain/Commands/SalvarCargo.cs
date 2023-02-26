using Domain.Entities;
using Domain.Interfaces.Erros;
using System;

namespace Domain.Commands
{
    public class SalvarCargo : Command
    {
        private readonly Cargo _cargo;

        public SalvarCargo(Cargo cargo) : base(cargo)
        {
            _cargo = cargo;
            var description = new ErrorDescription("Novo cargo criado em memória", new Warning());
            _cargo.Errors.Add(description);
        }

        public void Run()
        {
            if (!Errors.HasErrors)
            {
                SalvarCargoNoBackend();
            }
            else
            {
                var error = new ErrorDescription("Registro não foi salvo", new Critical());
                _cargo.Errors.Add(error);
            }
        }

        private void SalvarCargoNoBackend()
        {
            var message = new ErrorDescription("Registro salvo", new Information());
            _cargo.Errors.Add(message);
        }
    }
}

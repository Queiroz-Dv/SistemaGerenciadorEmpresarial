using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Cargo : Entity
    {
        protected Cargo() { }

        public Cargo(Guid cargoId, string cargoNome)
        {
            CargoId = cargoId;
            CargoNome = cargoNome;
            Validate();
        }

        public sealed override void Validate()
        {
            IsInvalidId(CargoId, InvalidId);
            IsInvalidName(CargoNome, InvalidName);
        }

        public Guid CargoId { get; set; }

        public string CargoNome { get; set; }

        public Guid DepartamentoID { get; set; }

        public virtual ICollection<Departamento> Departamentos { get; set; }
    }
}

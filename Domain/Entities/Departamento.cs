using System;

namespace Domain.Entities
{
    public class Departamento : Entity
    {
        protected Departamento() { }

        public Departamento(Guid departamentoGuid, string departamentoNome)
        {
            DepartamentoId = departamentoGuid;
            DepartamentoNome = departamentoNome;
            Validate();
        }

        public sealed override void Validate()
        {
            IsInvalidId(DepartamentoId, InvalidId);
            IsInvalidName(DepartamentoNome, InvalidName);
        }

        public Guid DepartamentoId { get; set; }

        public string DepartamentoNome { get; set; }

        public virtual Cargo Cargo { get; set; }
    }
}
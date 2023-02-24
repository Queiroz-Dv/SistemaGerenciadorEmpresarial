using System.Collections.Generic;

namespace Domain.Entities
{
    public class Cargo
    {
        protected Cargo()
        {

        }

        public Cargo(string cargoNome)
        {
            ValidateDomain
        }

        public Cargo(int cargoId, string cargoNome)
        {
            CargoId = cargoId;
            CargoNome = cargoNome;
        }

        public int CargoId { get; set; }

        public string CargoNome { get; set; }

        public int DepartamentoID { get; set; }

        public virtual ICollection<Departamento> Departamentos { get; set; }
    }
}

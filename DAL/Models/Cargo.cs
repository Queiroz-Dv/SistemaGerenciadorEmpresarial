using System.Collections.Generic;

namespace DAL.Models
{
    public class Cargo
    {
        public int CargoId { get; set; }

        public string CargoNome { get; set; }

        public int DepartamentoID { get; set; }

        public ICollection<Departamento> GetDepartamentos { get; set; }
    }
}

namespace DAL.Models
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }

        public string DepartamentoNome { get; set; }

        public virtual Cargo GetCargo { get; set; }
    }
}
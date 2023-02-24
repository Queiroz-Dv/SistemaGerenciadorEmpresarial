namespace Domain.Entities
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }

        public string DepartamentoNome { get; set; }

        public virtual Cargo Cargo { get; set; }
    }
}
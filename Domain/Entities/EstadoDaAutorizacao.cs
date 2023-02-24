namespace Domain.Entities
{
    public class EstadoDaAutorizacao
    {
        public int EstadoID { get; set; }

        public string EstadoNome { get; set; }

        public int AutorizacaoId { get; set; }

        public Autorizacao Autorizacao { get; set; }
    }
}
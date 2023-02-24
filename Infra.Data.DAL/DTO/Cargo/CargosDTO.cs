using DAL.DataCenter;

namespace DAL.Models.CargosDTO
{
    /// <summary>
    /// Classe responsável por obter o relacionamento dos objetos
    /// </summary>
    public class CargosDTO : Cargos
    {
        public string DepartamentoNome { get; set; }
    }
}

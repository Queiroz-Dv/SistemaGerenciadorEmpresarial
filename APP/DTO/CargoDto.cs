using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APP.DTO
{
    public class CargoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do cargo é necessário")]
        [MinLength(3)]
        [MaxLength(50)]
        public string Nome { get; set; }

        public ICollection<DepartamentoDto> DepartamentoDtos { get; set; }
    }
}
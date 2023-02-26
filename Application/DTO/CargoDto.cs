using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infra.Application.DTO
{
    public class CargoDto
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome do cargo é necessário")]
        [MinLength(3)]
        [MaxLength(50)]
        public string Nome { get; set; }

        public ICollection<DepartamentoDto> DepartamentoDtos { get; set; }
    }
}
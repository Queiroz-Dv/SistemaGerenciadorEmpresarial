using System;

namespace Infra.Application.DTO
{
    public class DepartamentoDto
    {
        public DepartamentoDto(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Guid Id { get; set; }

        public string Nome { get; set; }

        public CargoDto CargoDto { get; set; }
    }
}
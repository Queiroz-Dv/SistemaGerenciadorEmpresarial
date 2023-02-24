using System;

namespace DAL.Models
{
    public class Colaborador
    {
        public int ColaboradorId { get; set; }

        public int NumeroUsuario { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string CaminhoImagem { get; set; }

        public int DepartamentoId { get; set; }

        public int CargoId { get; set; }

        public int Salario { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string Endereco { get; set; }

        public string Senha { get; set; }

        public bool isAdmin { get; set; }

        public int AutorizacaoId { get; set; }

        public Autorizacao Autorizacao { get; set; }
    }
}
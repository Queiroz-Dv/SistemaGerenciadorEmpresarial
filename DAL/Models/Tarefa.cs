using System;

namespace DAL.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; }

        public int ColaboradorId { get; set; }

        public string Titulo { get; set; }

        public string Conteudo { get; set; }

        public DateTime DataInicial { get; set; }

        public DateTime DataDeEntrega { get; set; }

        public int TarefaEstado { get; set; }
    }
}
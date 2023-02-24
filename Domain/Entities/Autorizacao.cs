using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Autorizacao
    {
        public int AutorizacaoID { get; set; }

        public int AutorizacaoDia { get; set; }

        public DateTime DataInicial { get; set; }

        public DateTime DataFinal { get; set; }

        public string DescricaoDaAutorizacao { get; set; }

        #region Propriedades de Navegação
        public virtual List<EstadoDaAutorizacao> EstadosDaAutorizacao { get; set; }

        public virtual List<Colaborador> Colaboradores { get; set; }

        public virtual List<Departamento> Departamentos { get; set; }

        public virtual List<Cargo> Cargos { get; set; }
        #endregion
    }
}
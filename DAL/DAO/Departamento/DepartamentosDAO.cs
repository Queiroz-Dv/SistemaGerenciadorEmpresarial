using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DAO.Departamento
{
    /// <summary>
    /// Classe responsável pelas operações CRUD do módulo Departamento
    /// </summary>
    public class DepartamentosDAO : Contexto
    {
        public static void Gravar(DEPARTAMENTO departamento)
        {

            try
            {
                // Insere a entidade no banco
                dataContext.DEPARTAMENTO.InsertOnSubmit(departamento);

                // Gravar o que foi feito
                dataContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<DEPARTAMENTO> ObterTodos()
        {
            var departamentosBD = dataContext.DEPARTAMENTO.ToList();
            return departamentosBD;
        }
    }
}

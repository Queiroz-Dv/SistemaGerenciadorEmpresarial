using System;

namespace DAL.DAO.Departamento
{
    /// <summary>
    /// Classe responsável pelas operações CRUD do módulo Departamento
    /// </summary>
    public class DepartamentoDAO : Contexto
    {
        /// <summary>
        /// Método que gravar a entidade no banco de dados
        /// </summary>
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
    }
}

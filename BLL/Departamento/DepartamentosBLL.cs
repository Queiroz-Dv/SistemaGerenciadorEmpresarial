using DAL;
using DAL.DAO.Departamento;
using System;

namespace BLL.Departamento
{
    /// <summary>
    /// Classe responsável pelas regras do módulo Departamento
    /// </summary>
    public class DepartamentosBLL
    {
        /// <summary>
        /// Método que gravar um departamento
        /// </summary>
        public static void GravarDepartamento(DEPARTAMENTO departamento)
        {
            DepartamentoDAO.Gravar(departamento);
        }
    }
}

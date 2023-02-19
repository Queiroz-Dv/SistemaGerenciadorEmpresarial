using DAL.DTO.Cargo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DAO.Cargo
{
    /// <summary>
    /// Classe responsável pelo acesso ao banco de dados do módulo Cargos
    /// </summary>
    public class CargosDAO : Contexto
    {
        public static void Gravar(CARGO cargo)
        {
            try
            {
                dataContext.CARGO.InsertOnSubmit(cargo);
                dataContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<CargosDTO> ObterTodos()
        {
            try
            {
                // Obtem os registros do banco
                var cargosComDepartamentos = (from cargos in dataContext.CARGO
                                              join departamentos in dataContext.DEPARTAMENTO on cargos.CargoID equals departamentos.DepartamentoID
                                              select new
                                              {
                                                  cargos.CargoID,
                                                  cargos.CargoNome,
                                                  departamentos.DepartamentoID,
                                                  departamentos.DepartamentoNome
                                              }).OrderBy(order => order.CargoID).ToList();
                // Lista para preencher
                List<CargosDTO> cargosDTOsList = new List<CargosDTO>();
                foreach (var item in cargosComDepartamentos)
                {
                    // Preenchimento da lista
                    cargosDTOsList.Add(new CargosDTO
                    {
                        CargoID = item.CargoID,
                        CargoNome = item.CargoNome,
                        DepartamentoID = item.DepartamentoID,
                        DepartamentoNome = item.DepartamentoNome
                    });
                }
                return cargosDTOsList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

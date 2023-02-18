using System;

namespace DAL.DAO.Cargo
{
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
    }
}

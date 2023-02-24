using BLL.Interfaces;
using DAL.DAO.Cargo;
using System.Collections.Generic;

namespace BLL.Repositorios
{
    public class CargoRepository : ICargoRepository
    {
        private ICargoDAO
        public void AtualizarCargo(int id)
        {
            throw new System.NotImplementedException();
        }

        public void DeletarCargo(int id)
        {
            throw new System.NotImplementedException();
        }

        public void DeletarCargos(CARGO cargos)
        {
            throw new System.NotImplementedException();
        }

        public void GravarCargo(DAL.Models.Cargo cargo)
        {
            if (cargo != null)
            {
                CargosDAO.Gravar(cargo);
            }
        }

        public CargosDTO ObterCargoPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<CargosDTO> ObterCargos()
        {
            var cargosDAO = CargosDAO.ObterTodos();
            return cargosDAO;
        }
    }
}

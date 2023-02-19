using BLL.Interfaces;
using DAL;
using DAL.DAO.Cargo;
using DAL.DTO.Cargo;
using System.Collections.Generic;

namespace BLL.Repositorios
{
    public class CargoRepository : ICargoRepository
    {
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

        public void GravarCargo(CARGO cargo)
        {
            CargosDAO.Gravar(cargo);
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

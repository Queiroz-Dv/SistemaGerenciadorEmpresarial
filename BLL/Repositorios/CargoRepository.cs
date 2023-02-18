using BLL.Interfaces;
using DAL;
using DAL.DAO.Cargo;
using DAL.DTO.Cargo;
using System.Collections.Generic;

namespace BLL.Repositorios
{
    public class CargoRepository : ICargoRepository
    {
        public CARGO AtualizarCargo(int id)
        {
            throw new System.NotImplementedException();
        }

        public CARGO DeletarCargo(int id)
        {
            throw new System.NotImplementedException();
        }

        public CARGO DeletarCargos(CARGO cargos)
        {
            throw new System.NotImplementedException();
        }

        public CARGO GravarCargo(CARGO cargo)
        {
            CargosDAO.Gravar(cargo);
            return cargo;
        }

        public List<CargosDTO> ObterCargos()
        {
            var cargosDAO = CargosDAO.ObterTodos();
            return cargosDAO;
        }
    }
}

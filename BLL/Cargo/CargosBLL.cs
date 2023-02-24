using BLL.Interfaces;
using BLL.Repositorios;

namespace BLL.Cargo
{
    public class CargosBLL : ICargosBLL
    {
        public void Gravar(DAL.Models.Cargo cargo)
        {
            ValidarId(cargo);
            VerificarNomeValido(cargo.CargoNome);
            CargoRepository repository = new CargoRepository();
            repository.GravarCargo(cargo);
        }

        public bool ValidarId(DAL.Models.Cargo cargo)
        {
            bool idInvalido = false;

            if (cargo.CargoId != 0
                && cargo.DepartamentoID != 0)
            {
                return true;
            }
            else
            {
                return idInvalido;
            }
        }

        public bool VerificarNomeValido(string nome)
        {
            bool nomeInvalido = false;

            if (!string.IsNullOrEmpty(nome)
                || nome.Length < 3
                || nome.Length > 50)
            {
                return true;
            }
            else
            {
                return nomeInvalido;
            }
        }
    }
}

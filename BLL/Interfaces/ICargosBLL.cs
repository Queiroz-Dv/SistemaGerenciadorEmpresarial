namespace DAL.Interfaces
{
    public interface ICargosBLL
    {
        bool ValidarId(DAL.Models.Cargo cargo);

        bool VerificarNomeValido(string nome);

        void Gravar(DAL.Models.Cargo cargo);
    }
}
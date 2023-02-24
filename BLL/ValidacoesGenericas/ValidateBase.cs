namespace DAL.ValidacoesGenericas
{
    public class ValidateBase
    {
        public static bool Quando(bool temErro)
        {
            if (temErro)
                return true;
            else
                return false;
        }
    }
}

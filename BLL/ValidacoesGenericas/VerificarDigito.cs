using System.Windows.Forms;

namespace BLL.ValidacoesGenericas
{
    public class VerificarDigito
    {
        public static bool VerificaDigitoNumerico(KeyPressEventArgs e)
        {
            // Se a tecla pressionada não for uma letra deixa o usuário entrar
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                return true;
            else
                return false;
        }
    }
}

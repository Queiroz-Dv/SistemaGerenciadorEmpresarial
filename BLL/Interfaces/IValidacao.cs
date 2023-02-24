using System.Windows.Forms;

namespace DAL.Interfaces
{
    interface IValidacao
    {
        DialogResult InserirMensagem(string chave, string mensagemDeErro);
    }
}

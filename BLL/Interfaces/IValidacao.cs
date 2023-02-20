using System.Windows.Forms;

namespace BLL.Interfaces
{
    interface IValidacao
    {
        DialogResult InserirMensagem(string chave, string mensagemDeErro);

        bool E_Valido { get; }
    }
}

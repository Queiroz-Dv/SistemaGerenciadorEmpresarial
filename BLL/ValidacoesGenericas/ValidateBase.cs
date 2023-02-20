using BLL.Interfaces;
using System.Windows.Forms;

namespace BLL.ValidacoesGenericas
{
    public class ValidateBase : IValidacao
    {
        public bool Quando(bool temErro, object objeto)
        {
            if ()
            {
                var mensagens = InserirMensagem(objeto);
                return true;
            }
            else
                return false;
        }

        public DialogResult InserirMensagem(object objeto)
        {
            DialogResult resultado = MessageBox.Show("");
        }
    }
}

using BLL.Interfaces;
using System.Windows.Forms;

namespace BLL.ValidacoesGenericas
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

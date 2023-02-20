using System.Collections.Generic;
using System.Linq;

namespace BLL.Notificacoes
{
    public static class ExtensaoNotificacao
    {
        public static bool TemErros(this IList<MensagemNotificacao> mensagens)
        {
            var mensagensObtidas = mensagens.Count(m => m.Tipo == Enums.TipoNotificacao.Error) > 0;
            return mensagensObtidas;
        }

        public static void RemoverMensagensDuplicadas(this List<MensagemNotificacao> mensagens)
        {
            var novaListaDeErros = (from n in mensagens select n).Distinct(new MensagemNotificacaoComparador()).ToList();

            mensagens.Clear();
            mensagens.AddRange(novaListaDeErros);
        }
    }
}

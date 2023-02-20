using System.Collections.Generic;

namespace BLL.Notificacoes
{
    internal class MensagemNotificacaoComparador : IEqualityComparer<MensagemNotificacao>
    {
        public bool Equals(MensagemNotificacao x, MensagemNotificacao y)
        {
            var mensagensComparadas = x.Messagem.Equals(y.Messagem) &&
                                      x.Tipo.Equals(y.Tipo);

            return mensagensComparadas;
        }

        public int GetHashCode(MensagemNotificacao obj)
        {
            var hashCode = (obj.Messagem + obj.Tipo).GetHashCode();
            return hashCode;
        }
    }
}
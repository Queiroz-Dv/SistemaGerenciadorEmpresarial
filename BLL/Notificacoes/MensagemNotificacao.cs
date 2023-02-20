using BLL.Enums;
using BLL.Recursos;

namespace BLL.Notificacoes
{
    public class MensagemNotificacao
    {

        public MensagemNotificacao(string mensagem, TipoNotificacao tipo)
        {
            this.Messagem = mensagem;
            Tipo = tipo;
            LevelError = (int)tipo;
            IdentificarTipoMensagem(tipo);
        }

        private void IdentificarTipoMensagem(TipoNotificacao tipo)
        {
            switch (tipo)
            {
                case TipoNotificacao.Error:
                    TipoMensagem = MensagemNotificacaoResource.Error;
                    break;
                case TipoNotificacao.Aviso:
                    TipoMensagem = MensagemNotificacaoResource.Aviso;
                    break;
                case TipoNotificacao.Mensagem:
                    TipoMensagem = MensagemNotificacaoResource.Mensagem;
                    break;
                default:
                    break;
            }
        }

        public string Messagem { get; set; }

        public string Detalhe { get; set; }

        public TipoNotificacao Tipo { get; set; }

        public string TipoMensagem { get; set; }

        public int LevelError { get; set; }
    }
}

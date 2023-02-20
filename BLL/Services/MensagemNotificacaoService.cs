using BLL.Notificacoes;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class MensagemNotificacaoService
    {
        public List<MensagemNotificacao> Mensagens { get; set; }

        protected void InserirMensagemDeExcessao(Exception exception)
        {
            var exceptionMessage = ObterMensagemExcessao(exception);
            if (true)
            {

            }
        }

        private string ObterMensagemExcessao(Exception exception)
        {
            var mensagem = exception.Message;
            while (exception.InnerException != null)
            {
                mensagem = exception.InnerException.Message + Environment.NewLine + mensagem;
                exception = exception.InnerException;
            }

            return mensagem;
        }
    }
}

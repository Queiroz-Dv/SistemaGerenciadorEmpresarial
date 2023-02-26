namespace Domain.Interfaces.Notifications
{
    /// <summary>
    ///  Tem como objetivo ser usada como herança para a classe que
    ///  será a descrição da notificação em si.
    /// </summary>
    public abstract class Description : IDescription
    {
        public string Message { get; }

        public Description(string message, params string[] args)
        {
            Message = message;

            for (var i = 0; i < args.Length; i++)
            {
                Message = Message.Replace("{" + i + "}", args[i]);
            }
        }

        public override string ToString() => Message;
    }
}

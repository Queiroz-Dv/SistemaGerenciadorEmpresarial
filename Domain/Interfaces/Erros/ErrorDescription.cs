using Domain.Interfaces.Notifications;

namespace Domain.Interfaces.Erros
{
    public class ErrorDescription : Description
    {
        public ILevel Level { get; }

        public ErrorDescription(string message, ILevel level, params string[] args)
            : base(message, args) => Level = level;
    }
}

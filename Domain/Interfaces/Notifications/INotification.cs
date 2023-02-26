using System.Collections.Generic;

namespace Domain.Interfaces.Notifications
{
    /// <summary>
    /// Tem como objetivo definir um contrato para criação de notificações
    /// e facilita o uso de injeção de dependência
    /// </summary>
    public interface INotification
    {
        IList<object> List { get; }
        bool HasNotifications { get; }

        bool Includes(Description error);
        void Add(Description error);
    }
}
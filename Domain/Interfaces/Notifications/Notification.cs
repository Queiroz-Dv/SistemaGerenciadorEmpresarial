using System.Collections.Generic;
using System.Linq;

namespace Domain.Interfaces.Notifications
{
    /// <summary>
    /// É usada como Supertype para a classe de notificação
    /// </summary>
    public abstract class Notification : INotification
    {
        public IList<object> List { get; } = new List<object>();

        public bool HasNotifications => List.Any();

        public bool Includes(Description error) => List.Contains(error);

        public void Add(Description description) => List.Add(description);
    }
}

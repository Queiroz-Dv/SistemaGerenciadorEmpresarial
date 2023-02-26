using Domain.Entities;
using Domain.Interfaces.Erros;

namespace Domain.Commands
{
    public abstract class Command
    {
        protected Command(Entity entity) => Entity = entity;

        protected Entity Entity;

        protected Error Errors => Entity.Errors;
    }
}

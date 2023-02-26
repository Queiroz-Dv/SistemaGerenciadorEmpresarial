using Domain.Interfaces.Erros;
using System;

namespace Domain.Entities
{
    /// <summary>
    /// Classe que serve como base para validar
    /// e notificar outras classes
    /// </summary>
    public class Entity
    {
        public Error Errors { get; } = new Error();

        public virtual void Validate() { }

        protected void Fail(bool condition, ErrorDescription description)
        {
            if (condition)
                Errors.Add(description);
        }

        public bool IsValid() => !Errors.HasErrors;

        #region Validations

        protected void IsInvalidId(Guid Id, ErrorDescription error) => Fail(Id == Guid.Empty, error);

        protected void IsInvalidName(string s, ErrorDescription error) => Fail(string.IsNullOrWhiteSpace(s), error);

        #endregion

        #region Errors

        public static ErrorDescription InvalidId = new ErrorDescription("Invalid Id", new Critical());
        public static ErrorDescription InvalidName = new ErrorDescription("Invalid Name", new Critical());

        #endregion
    }
}

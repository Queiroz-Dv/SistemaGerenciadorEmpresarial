using Domain.Interfaces.Erros;
using System.Text.RegularExpressions;

namespace Domain.ValueObjects
{
    /// <summary>
    /// Classe que valida os VOs 
    /// para outras superclasses
    /// </summary>
    public class ValueObject
    {
        public Error Notification { get; } = new Error();

        public virtual void Validate() { }

        protected void Fail(bool condition, ErrorDescription error)
        {
            if (condition)
                Notification.Add(error);
        }

        public bool IsValid()
        {
            return !Notification.HasErrors;
        }

        #region Validations
        protected void IsInvalidEmail(string s, ErrorDescription error)
        {
            const string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            Fail(!Regex.IsMatch(s, pattern), error);
        }
        #endregion

        #region Erros
        public static ErrorDescription InvalidEmail = new ErrorDescription("Invalid E-mail address", new Critical());
        #endregion
    }
}

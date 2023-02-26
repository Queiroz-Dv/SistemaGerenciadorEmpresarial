namespace Domain.Interfaces.Notifications
{
    /// <summary>
    /// Define um contrato para uma descrição de uma
    /// notificação lançada.
    /// </summary>
    public interface IDescription
    {
        string Message { get; }
        string ToString();
    }
}

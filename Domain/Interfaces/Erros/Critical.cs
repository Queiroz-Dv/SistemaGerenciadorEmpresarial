namespace Domain.Interfaces.Erros
{
    public class Critical : ILevel
    {
        public Critical(string description = "Critical") => Description = description;

        public string Description { get; }

        public override string ToString() => Description;
    }
}
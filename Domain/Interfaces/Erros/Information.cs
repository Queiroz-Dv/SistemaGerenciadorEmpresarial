namespace Domain.Interfaces.Erros
{
    public class Information : ILevel
    {
        public Information(string description = "Information") => Description = description;

        public string Description { get; }

        public override string ToString() => Description;
    }
}
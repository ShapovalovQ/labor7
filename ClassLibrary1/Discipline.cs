namespace ClassLibrary1
{
    public class Discipline
    {
        public string Name { get; }
        public string Abbreviation { get; }

        public Discipline(string name, string abbreviation)
        {
            this.Name = name;
            this.Abbreviation = abbreviation;
        }
    }
}
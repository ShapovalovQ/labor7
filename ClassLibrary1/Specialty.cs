namespace ClassLibrary1
{
    public class Specialty //https://docs.google.com/document/d/1pDw7bbBJDmeqT8VVwp68BSOF_4yd9cNb9xpH_q2KW0E/edit?usp=share_link
    {
        public string Name { get; }
        public string Abbreviation { get; }
        public Specialty(string name, string abbreviation)
        {
            Name = name;
            Abbreviation = abbreviation;
        }
    }
}

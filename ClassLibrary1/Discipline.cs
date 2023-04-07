namespace ClassLibrary1
{
    public class Discipline //https://docs.google.com/document/d/1qCEMkbMRvvHP361IFDeWgSpHfVRUp6BV67nrsjl3fSw/edit?usp=share_link
    {
        public string Name { get; }
        public string Abbreviation { get; }

        public Discipline(string name, string abbreviation)
        {
            Name = name;
            Abbreviation = abbreviation;
        }
    }
}
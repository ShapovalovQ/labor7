namespace ClassLibrary1
{
    public class Discipline //https://drive.google.com/open?id=1qCEMkbMRvvHP361IFDeWgSpHfVRUp6BV67nrsjl3fSw&usp=drive_copy
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
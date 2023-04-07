namespace ClassLibrary1
{
    public class Corps //https://docs.google.com/document/d/13_TXjBoKn0TzKMcWP9A6jX2vyQEgcxBc4vY1CfJn9ps/edit?usp=share_link
    {
        public string Nom { get; }
        public string Adress { get; }
        public Worker Worker { get; }
        public Organization Organization { get; }
        public Corps(string nom, string adress, Worker worker, Organization organization)
        {
            Nom = nom;
            Adress = adress;
            Worker = worker;
            Organization = organization;
        }
    }
}
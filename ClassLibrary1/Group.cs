namespace ClassLibrary1
{
    public class Group //https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit?usp=sharing
    {
        public string Name { get; }
        public string Abbreviation { get; }
        public string Size { get; }
        public string Yearofadmission { get; }
        public Specialty Specialty { get; }
        public Worker ClassWorker { get; }

        public Group(string name, string abbreviation, string size, string yearofadmission, Specialty specialty, Worker classWorker)
        {
            this.Name = name;
            this.Abbreviation = abbreviation;
            this.Size = size;
            this.Yearofadmission = yearofadmission;
            this.Specialty = specialty;
            this.ClassWorker = classWorker;
        }
    }
}
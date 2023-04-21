namespace ClassLibrary1
{
    public class Group //https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit?usp=sharing
    {
        public string Name { get; }
        public string Abbreviation { get; }
        public byte Size { get; }
        public uint Year_of_admission { get; }
        public Specialty Specialty { get; }
        public Worker ClassTeacher { get; }

        public Group(string name, string abbreviation, byte size, uint yearofadmission, Specialty specialty, Worker classTeacher)
        {
            Name = name;
            Abbreviation = abbreviation;
            Size = size;
            Year_of_admission = yearofadmission;
            Specialty = specialty;
            ClassTeacher = classTeacher;
        }
    }
}
using System;

namespace ClassLibrary1
{
    public class Class1 //Занятие https://docs.google.com/document/d/1KZXfKJussGflgWnWylGbFrwmdcn3liYKIsgmtxB1mN0
    {
        public string Date { get; }
        public Discipline Discipline { get; }
        public Class9 Class9 { get; }
        public Class2 Class2 { get; }
        public Class4 Class4 { get; }
        public Class7 Class7 { get; }
        public Class14 Class14 { get; }

        public Class1(string date, Discipline discipline, Class9 class9, Class2 class2, Class4 class4, Class7 class7, Class14 class14)
        {
            Date = date;
            Discipline = discipline;
            Class9 = class9;
            Class2 = class2;
            Class4 = class4;
            Class7 = class7;
            Class14 = class14;
        }
    }
}
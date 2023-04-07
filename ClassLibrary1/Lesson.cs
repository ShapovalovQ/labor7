using System;

namespace ClassLibrary1
{
    public class Lesson //https://docs.google.com/document/d/1KZXfKJussGflgWnWylGbFrwmdcn3liYKIsgmtxB1mN0/edit?usp=share_link
    {
        public DateTime Date { get; }
        public Discipline Discipline { get; }
        public Worker Worker { get; }
        public Auditorium Auditorium { get; }
        public Group Group { get; }
        public Pair Pair { get; }
        public TypeOfLesson TypeOfLesson { get; }

        public Lesson(DateTime date, Discipline discipline, Worker worker, Auditorium auditorium, Group group, Pair pair, TypeOfLesson typeoflesson)
        {
            Date = date;
            Discipline = discipline;
            Worker = worker;
            Auditorium = auditorium;
            Group = group;
            Pair = pair;
            TypeOfLesson = typeoflesson;
        }
    }
}
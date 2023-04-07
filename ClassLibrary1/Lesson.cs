using System;

namespace ClassLibrary1
{
    public class Lesson //https://docs.google.com/document/d/1KZXfKJussGflgWnWylGbFrwmdcn3liYKIsgmtxB1mN0/edit?usp=share_link
    {
        public DateTime DateOfTheLesson { get; }
        public Discipline Discipline { get; }
        public Worker Worker { get; }
        public Auditorium Auditorium { get; }
        public Group Group { get; }
        public Pair Pair { get; }
        public TypeOfLesson TypeOfLesson { get; }

        public Lesson(DateTime dateofthelesson, Discipline discipline, Worker worker, Auditorium auditorium, Group group, Pair pair, TypeOfLesson typeoflesson)
        {
            DateOfTheLesson = dateofthelesson;
            Discipline = discipline;
            Worker = worker;
            Auditorium = auditorium;
            Group = group;
            Pair = pair;
            TypeOfLesson = typeoflesson;
        }
        public Lesson(Discipline discipline, Worker worker, Auditorium auditorium, Group group, Pair pair, TypeOfLesson typeoflesson)
            : this(DateTime.Now.Date, discipline, worker, auditorium, group, pair, typeoflesson)
        {

        }
    }
}
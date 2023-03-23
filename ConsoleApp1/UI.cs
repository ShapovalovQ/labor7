using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class UI
    {
        public static void Print(Lesson lesson)
        {
            Console.WriteLine($"Class1.Дата проведения = {lesson.Date}");
            Print(lesson.Discipline);
            Print(lesson.Worker);
            Print(lesson.Auditorium);
            Print(lesson.Group);
            Print(lesson.Pair);
            Print(lesson.TypeOfLesson);
        }

        public static void Print(Auditorium class2)
        {
            
        }

        public static void Print(Discipline discipline)
        {
            Console.WriteLine($"Discipline.Название = {discipline.Name}");
            Console.WriteLine($"Discipline.Сокращение = {discipline.Abbreviation}");
        }

        public static void Print(Group class4)
        {
        }

        public static void Print(Student student)
        {
            Console.WriteLine($"Student.Фамилия = {student.LastName}");
            Console.WriteLine($"Student.Имя = {student.FirstName}");
            Console.WriteLine($"Student.Отчество = {student.Patronymic}");
            Print(student.Group);
            Console.WriteLine($"Student.Дата рождения = {student.Birthday}");
        }

        public static void Print(Specialty class6)
        {

        }

        public static void Print(Pair class7)
        {

        }

        public static void Print(Shift class8)
        {

        }

        public static void Print(Worker class9)
        {

        }

        public static void Print(Post class10)
        {

        }

        public static void Print(Subdivision class11)
        {

        }

        public static void Print(Organization class12)
        {

        }
        public static void Print(Corps class13)
        {

        }

        public static void Print(TypeOfLesson class14)
        {

        }
    }
}
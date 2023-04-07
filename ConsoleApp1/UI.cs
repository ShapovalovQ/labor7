using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class UI
    {
        public static void Print(Lesson lesson)
        {
            Console.WriteLine($"Lesson.Дата проведения = {lesson.Date}");
            Print(lesson.Discipline);
            Print(lesson.Worker);
            Print(lesson.Auditorium);
            Print(lesson.Group);
            Print(lesson.Pair);
            Print(lesson.TypeOfLesson);
        }

        public static void Print(Auditorium auditorium)
        {
            Console.WriteLine($"Auditorium.Название = {auditorium.Name}");
            Print(auditorium.Worker);
            Console.WriteLine($"Auditorium.Количество посадочных мест = {auditorium.Places}");
            Console.WriteLine($"Auditorium.Количество окон = {auditorium.Window}");
            for (int i = 0; i < auditorium.Equipment.Count; i++)
            {
                Console.WriteLine($"{i+1} ");
                Print(auditorium.Equipment[i]);
            }
        }

        public static void Print(Discipline discipline)
        {
            Console.WriteLine($"Discipline.Название = {discipline.Name}");
            Console.WriteLine($"Discipline.Сокращение = {discipline.Abbreviation}");
        }

        public static void Print(Group group)
        {
            Console.WriteLine($"Group.Название = {group.Name}");
            Console.WriteLine($"Group.Сокращение = {group.Abbreviation}");
            Console.WriteLine($"Group.Численность = {group.Size}");
            Console.WriteLine($"Group.Год поступления = {group.Yearofadmission}");
            Print(group.Specialty);
            Print(group.ClassWorker);
        }

        public static void Print(Student student)
        {
            Console.WriteLine($"Student.Фамилия = {student.LastName}");
            Console.WriteLine($"Student.Имя = {student.FirstName}");
            Console.WriteLine($"Student.Отчество = {student.Patronymic}");
            Print(student.Group);
            Console.WriteLine($"Student.Дата рождения = {student.Birthday}");
        }

        public static void Print(Specialty specialty)
        {
            Console.WriteLine($"Specialty.Название = {specialty.Name}");
            Console.WriteLine($"Specialty.Сокращение = {specialty.Abbreviation}");
        }

        public static void Print(Pair class7)
        {

        }

        public static void Print(Shift class8)
        {

        }

        public static void Print(Worker worker)
        {
            Console.WriteLine($"Worker.Фамилия = {worker.LastName}");
            Console.WriteLine($"Worker.Имя = {worker.FirstName}");
            Console.WriteLine($"Worker.Отчество = {worker.Patronymic}");
            Print(worker.Post);
        }

        public static void Print(Post post)
        {
            Console.WriteLine($"Post.Название = {post.title}");
            Console.WriteLine($"Post.Оклад = {post.salary}");
            Print(post.Subdivision);
        }

        public static void Print(Subdivision class11)
        {

        }

        public static void Print(Organization class12)
        {

        }
        public static void Print(Corps corps)
        {
            Console.WriteLine($"Corps.Название = {corps.Nom}");
            Console.WriteLine($"Corps.Адрес = {corps.Adress}");
            Print(corps.Worker);
            Print(corps.Organization);
        }

        public static void Print(TypeOfLesson class14)
        {

        }

        public static void Print(Equipment equipment)
        {

        }
    }
}

using System;
using System.Globalization;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class ClassCreator
    {
        public static Lesson Lesson()
        {
            DateTime date = DateTime.Now; string input, d = "dd.MM.yyyy HH:mm:ss"; var ci = CultureInfo.InvariantCulture;
            while (true)
            {
                Console.Write("Введите дату проведения в формате \"число.месяц.год часы:минуты:секунды\": ");
                input = Console.ReadLine();
                if (!DateTime.TryParseExact(input, d, ci, DateTimeStyles.None, out _))
                {
                    if (input == "") break;
                    Console.WriteLine("Неверный формат");
                }
                else date = DateTime.ParseExact(input, d, ci); break;
            }
            return new Lesson(date, Discipline(), Worker(), Auditorium(), Group(), Pair(), TypeOfLesson());
        }

        public static Auditorium Auditorium()
        {
            return new Auditorium();
        }

        public static Discipline Discipline()
        {
            Console.Write("Введите название дисциплины: ");
            string name = Console.ReadLine();
            Console.Write("Введите сокращение: ");
            string abbreviation = Console.ReadLine();
            return new Discipline(name, abbreviation);
        }

        public static Group Group()
        {
            return new Group();
        }

        public static Student Student()
        {
            Console.Write("Введите фамилию: ");
            string lastName = Console.ReadLine();
            Console.Write("Введите имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string patronymic = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            string birthday = Console.ReadLine();
            return new Student(lastName, firstName, patronymic, Group(), birthday);
        }

        public static Specialty Specialty()
        {
            return new Specialty();
        }
        public static Pair Pair()
        {
            return new Pair();
        }

        public static Shift Shift()
        {
            return new Shift();
        }

        public static Worker Worker()
        {
            return new Worker();
        }

        public static Post Post()
        {
            return new Post();
        }

        public static Subdivision Subdivision()
        {
            return new Subdivision();
        }

        public static Organization Organization()
        {
            return new Organization();
        }

        public static Corps Corps()
        {
            return new Corps();
        }
        public static TypeOfLesson TypeOfLesson()
        {
            return new TypeOfLesson();
        }
    }
}
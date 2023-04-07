using System;
using System.Globalization;
using ClassLibrary1;
using System.Collections.Generic;

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
            Console.WriteLine("Аудитория");
            Console.Write("Введите название аудитории: ");
            string name = Console.ReadLine();
            byte places;
            byte window;
            while (true)
            {
                Console.Write("Введите количество посадочных мест: ");
                if (!byte.TryParse(Console.ReadLine(), out places)) Console.WriteLine("Неверный формат"); else break;
            }
            while(true)
            {
                Console.Write("Введите количество окон: ");
                if (!byte.TryParse(Console.ReadLine(), out window)) Console.WriteLine("Неверный формат"); else break;
            }
            List <Equipment> list = new List <Equipment>();
            int c = 1;
            Console.WriteLine("Список оборудования");
            bool f = true;
            string temp;
            while (f)
            {
                Console.Write($"Введите {c} ");
                list.Add(Equipment());
                Console.Write("Завершить создание списка? (да/нет): ");
                temp = Console.ReadLine();
                if (temp == "да") break;
                c++;
            }
            return new Auditorium(name, Worker(), places, window, list);
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
        public static Equipment Equipment()
        {
            Console.WriteLine("Оборудование");
            string test = "test";
            return new Equipment(test);
        }
    }
}
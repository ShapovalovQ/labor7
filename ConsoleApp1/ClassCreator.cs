using System;
using System.Collections.Generic;
using System.Globalization;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class ClassCreator
    {
        public static Lesson Lesson()
        {
            Console.WriteLine("Занятие");
            DateTime dateofthelesson;
            string input;
            while (true)
            {
                Console.Write("Введите дату проведения в формате \"число.месяц.год\": ");
                input = Console.ReadLine();
                if (!DateTime.TryParseExact(input, "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateofthelesson))
                {
                    if (string.IsNullOrEmpty(input)) return new Lesson(Discipline(), Worker(), Auditorium(), Group(), Pair(), TypeOfLesson());
                    Console.WriteLine("Неверный формат");
                }
                else break;    
            }
            return new Lesson(dateofthelesson, Discipline(), Worker(), Auditorium(), Group(), Pair(), TypeOfLesson());
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
            while (true)
            {
                Console.Write("Введите количество окон: ");
                if (!byte.TryParse(Console.ReadLine(), out window)) Console.WriteLine("Неверный формат"); else break;
            }
            List<Equipment> list = new List<Equipment>();
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
            Console.WriteLine("Дисциплина");
            Console.Write("Введите название дисциплины: ");
            string name = Console.ReadLine();
            Console.Write("Введите сокращение: ");
            string abbreviation = Console.ReadLine();
            return new Discipline(name, abbreviation);
        }

        public static Group Group()
        {
            Console.WriteLine("Группа");
            Console.Write("Введите название: ");
            string name = Console.ReadLine();
            Console.Write("Введите сокращение: ");
            string abbreviation = Console.ReadLine();
            Console.Write("Введите численность: ");
            string size = Console.ReadLine();
            Console.Write("Введите год поступления: ");
            string yearofadmission = Console.ReadLine();
            return new Group(name, abbreviation, size, yearofadmission, Specialty(), Worker());
        }

        public static Student Student()
        {
            Console.WriteLine("Студент");
            Console.Write("Введите фамилию: ");
            string lastName = Console.ReadLine();
            Console.Write("Введите имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string patronymic = Console.ReadLine();
            Console.WriteLine("Введите дату рождения в формате дд.мм.гггг (день.месяц.год): ");
            string birth = Console.ReadLine();
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthday))
            {
                return new Student(lastName, firstName, patronymic, Group(), birthday);
            }
            else
            {
                return new Student(lastName, firstName, patronymic, Group());
            }
        }

        public static Specialty Specialty()
        {
            Console.WriteLine("Специальность");
            Console.Write("Введите название специальности ");
            string name = Console.ReadLine();
            Console.Write("Введите сокращение ");
            string abbreviation = Console.ReadLine();
            return new Specialty(name, abbreviation);
        }
        public static Pair Pair()
        {
            return new Pair();
        }

        public static Shift Shift()
        {
            Console.WriteLine("Смена");
            Console.Write("Введите название: ");
            string name = Console.ReadLine();
            return new Shift(name);
        }


        public static Worker Worker()
        {
            Console.WriteLine("Сотрудник");
            Console.Write("Введите фамилию: ");
            string lastName = Console.ReadLine();
            Console.Write("Введите имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string patronymic = Console.ReadLine();
            return new Worker(lastName, firstName, patronymic, Post());
        }

        public static Post Post()
        {
            Console.WriteLine("Должность");
            Console.Write("Введите название: ");
            string title = Console.ReadLine();
            Console.Write("Укажите размер оклада: ");
            string salary = Console.ReadLine();
            return new Post(title, salary, Subdivision());
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
            Console.Write("Корпус\nВведите название: ");
            string nom = Console.ReadLine();
            Console.Write("Введите адрес: ");
            string adress = Console.ReadLine();
            Console.WriteLine("Комендант:");
            return new Corps(nom,adress,Worker(),Organization());
        }
        public static TypeOfLesson TypeOfLesson()
        {
            return new TypeOfLesson();
        }

        public static Equipment Equipment()
        {
            return new Equipment();
        }
    }
}
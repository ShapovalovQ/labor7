using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите название класса: ");
                switch (Console.ReadLine())
                {
                    case "занятие": UI.Print(ClassCreator.Lesson()); break;
                    case "аудитория": UI.Print(ClassCreator.Auditorium()); break;
                    case "дисциплина": UI.Print(ClassCreator.Discipline()); break;
                    case "группа": UI.Print(ClassCreator.Group()); break;
                    case "студент": UI.Print(ClassCreator.Student()); break;
                    case "специальность": UI.Print(ClassCreator.Specialty()); break;
                    case "пара": UI.Print(ClassCreator.Pair()); break;
                    case "смена": UI.Print(ClassCreator.Shift()); break;
                    case "сотрудник": UI.Print(ClassCreator.Worker()); break;
                    case "должность": UI.Print(ClassCreator.Post()); break;
                    case "подразделение": UI.Print(ClassCreator.Subdivision()); break;
                    case "организация": UI.Print(ClassCreator.Organization()); break;
                    case "корпус": UI.Print(ClassCreator.Corps()); break;
                    case "вид занятия": UI.Print(ClassCreator.TypeOfLesson()); break;
                    case "выход": break; ;
                    default: Console.WriteLine("Класс не реализован"); break;
                }
            }
        }
    }
}
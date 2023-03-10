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
                    case "Class1": UI.Print(ClassCreator.Class1()); break;
                    case "Class2": UI.Print(ClassCreator.Class2()); break;
                    default: Console.WriteLine("Класс не реализован"); break;
                }
            }
        }
    }
}
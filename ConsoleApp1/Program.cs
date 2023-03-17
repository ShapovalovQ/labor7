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
                    case "Discipline": UI.Print(ClassCreator.Discipline()); break;
                    case "Class4": UI.Print(ClassCreator.Class4()); break;
                    case "Class5": UI.Print(ClassCreator.Class5()); break;
                    case "Class6": UI.Print(ClassCreator.Class6()); break;
                    case "Class7": UI.Print(ClassCreator.Class7()); break;
                    case "Class8": UI.Print(ClassCreator.Class8()); break;
                    case "Class9": UI.Print(ClassCreator.Class9()); break;
                    case "Class10": UI.Print(ClassCreator.Class10()); break;
                    case "Class11": UI.Print(ClassCreator.Class11()); break;
                    case "Class12": UI.Print(ClassCreator.Class12()); break;
                    case "Class13": UI.Print(ClassCreator.Class13()); break;
                    case "Class14": UI.Print(ClassCreator.Class14()); break;
                    default: Console.WriteLine("Класс не реализован"); break;
                }
            }
        }
    }
}
using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class UI
    {
        public static void Print(Class1 class1)
        {
            Console.WriteLine($"Class1.Date = {class1.Date}");
            Print(class1.Discipline);
            Print(class1.Class9);
            Print(class1.Class2);
            Print(class1.Class4);
            Print(class1.Class7);
            Print(class1.Class14);
        }

        public static void Print(Class2 class2)
        {
            //Print(class2.Class1);
            //Print(class2.Discipline);
        }

        public static void Print(Discipline discipline)
        {
            Console.WriteLine($"Discipline.Название = {discipline.Name}");
            Console.WriteLine($"Discipline.Сокращение = {discipline.Abbreviation}");
        }

        public static void Print(Class4 class4)
        {
        }

        public static void Print(Class5 class5)
        {

        }

        public static void Print(Class6 class6)
        {

        }

        public static void Print(Class7 class7)
        {

        }

        public static void Print(Class8 class8)
        {

        }

        public static void Print(Class9 class9)
        {

        }

        public static void Print(Class10 class10)
        {

        }

        public static void Print(Class11 class11)
        {

        }

        public static void Print(Class12 class12)
        {

        }
        public static void Print(Class13 class13)
        {

        }

        public static void Print(Class14 class14)
        {

        }
    }
}
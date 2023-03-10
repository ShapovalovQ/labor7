using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class UI
    {
        public static void Print(Class1 class1)
        {
            Console.WriteLine($"Class1.Name={class1.Name}");
            Console.WriteLine($"Class1.LastName={class1.LastName}");
        }

        public static void Print(Class2 class2)
        {
            Print(class2.Class1);
            Print(class2.Class3);
        }

        public static void Print(Class3 class3)
        {

        }
    }
}
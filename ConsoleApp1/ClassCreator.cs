using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class ClassCreator
    {
        public static Class1 Class1()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string lastName = Console.ReadLine();
            return new Class1(name, lastName);
        }

        public static Class2 Class2()
        {

            return new Class2(Class1(), Class3());
        }

        public static Class3 Class3()
        {
            return new Class3();
        }
    }
}
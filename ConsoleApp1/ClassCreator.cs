using System;
using System.Globalization;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class ClassCreator
    {
        public static string DateThe()//Дата проведения
        {
            DateTime date; string input,d = "dd.MM.yyyy HH:mm:ss"; bool f = true;
            while(f)
            {
                Console.Write("Введите дату в формате \"число.месяц.год часы:минуты:секунды\": ");
                input = Console.ReadLine();
                if (DateTime.TryParseExact(input, d, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    return date.ToString(d);
                }
                else
                {
                    if (input == "") break;
                    Console.WriteLine("Неверный формат");
                }
            }
            return DateTime.Now.ToString(d);
        }
        public static Class1 Class1()
        {
            var date = DateThe();

            if(date == null)
            {
                date = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            }
            return new Class1(date, Class3(), Class9(), Class2(), Class4(), Class7(), Class14());
        }

        public static Class2 Class2()
        {
            return new Class2();
        }

        public static Class3 Class3()
        {
            return new Class3();
        }

        public static Class4 Class4()
        {
            return new Class4();
        }

        public static Class5 Class5()
        {
            return new Class5();
        }

        public static Class6 Class6()
        {
            return new Class6();
        }
        public static Class7 Class7()
        {
            return new Class7();
        }

        public static Class8 Class8()
        {
            return new Class8();
        }

        public static Class9 Class9()
        {
            return new Class9();
        }

        public static Class10 Class10()
        {
            return new Class10();
        }

        public static Class11 Class11()
        {
            return new Class11();
        }

        public static Class12 Class12()
        {
            return new Class12();
        }

        public static Class13 Class13()
        {
            return new Class13();
        }
        public static Class14 Class14()
        {
            return new Class14();
        }
    }
}
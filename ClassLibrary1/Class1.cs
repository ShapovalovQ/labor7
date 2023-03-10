using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public string Name { get; }
        public string LastName { get; }

        public Class1(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
    }
}
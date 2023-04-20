using System;

namespace ClassLibrary1
{
    public class Student //https://docs.google.com/document/d/1FrtPd2tz85cDVhZCYXqL0wrByPjNbd6kUbjXzOzfLPc/edit?usp=share_link
    {
        public string LastName { get; }
        public string FirstName { get; }
        public string Patronymic { get; }
        public Group Group { get; }
        public DateTime Birthday { get; }
        public Student(string lastName, string firstName, string patronymic, Group group, DateTime birthday)
        {
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            Group = group;
            Birthday = birthday;
        }
        public Student(string lastName, string firstName, string patronymic, Group group)
            :this (lastName, firstName, patronymic, group, DateTime.Today)
        {
            
        }
    }
}
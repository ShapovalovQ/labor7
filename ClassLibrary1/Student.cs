namespace ClassLibrary1
{
    public class Student //https://docs.google.com/document/d/1FrtPd2tz85cDVhZCYXqL0wrByPjNbd6kUbjXzOzfLPc/edit?usp=share_link
    {
        public string LastName { get; }
        public string FirstName { get; }
        public string Patronymic { get; }
        public Group Group { get; }
        public string Birthday { get; }
        public Student(string lastName, string firstName, string patronymic, Group group, string birthday)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Patronymic = patronymic;
            this.Group = group;
            this.Birthday = birthday;
        }
    }

    /*Создать класс Студент с
● закрытыми полями:
○ фамилия
○ имя
○ отчество
○ ссылка на группу
○ дата рождения
● конструктором принимающим следующие аргументы (все аргументы должны быть
записаны в поля, если дата не задана, то берется текущая дата):
○ фамилия
○ имя
○ отчество
○ ссылка на группу
○ дата рождения*/
}
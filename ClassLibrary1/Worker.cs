using System;

namespace ClassLibrary1
{
    public class Worker //https://docs.google.com/document/d/1dhWsZqo-d1x4uk0y45lDVnu4H91wRvpRWKJ0lfCizxY/edit?usp=share_link
    {
        public string LastName { get; }
        public string FirstName { get; }
        public string Patronymic { get; }
        public Post Post { get; }

        public Worker(string lastName, string firstName, string patronymic, Post post)
        {
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            Post = post;
        }
    }
}
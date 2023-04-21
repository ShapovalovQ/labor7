namespace ClassLibrary1
{
    public class Post //https://docs.google.com/document/d/1yBWzXRuxmOQiPQs9TyNx8tNgq6nWF42Sjn-mgT_-5nY/edit?usp=share_link
    {
        public string Title { get; }
        public string Salary { get; }
        public Subdivision Subdivision { get; }


        public Post(string title, string salary, Subdivision subdivision)
        {
            Title = title;
            Salary = salary;
            Subdivision = subdivision;
        }
    }
}
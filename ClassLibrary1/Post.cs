namespace ClassLibrary1
{
    public class Post //https://docs.google.com/document/d/1yBWzXRuxmOQiPQs9TyNx8tNgq6nWF42Sjn-mgT_-5nY/edit?usp=share_link
    {
        public string title { get; }
        public string salary { get; }
        public Subdivision Subdivision { get; }


        public Post(string title, string salary, Subdivision subdivision)
        {
            this.title = title;
            this.salary = salary;
            this.Subdivision = subdivision;
        }
    }
}
namespace libraryApiRest.Models
{ 
    public class Book
    {
        private string _author;
        private string _title;
        private int _id;

        public string Author { get { return _author; } set { _author = value; } }
        public string Title { get { return _title; } set { _title = value; } }

        public int Id { get { return _id; } set { _id = value; } }


        public Book()
        {

        }
        public Book(string autore, string title, int id)
        {
            Author = autore;
            Title = title;
            Id = id;
        }
    }
}

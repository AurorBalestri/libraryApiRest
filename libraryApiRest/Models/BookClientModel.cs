namespace libraryApiRest.Models
{
    public class BookClientModel
    {
        private string _author;
        private string _title;

        public string Author { get { return _author; } set { _author = value; } }
        public string Title { get { return _title; } set { _title = value; } }



        public BookClientModel()
        {

        }
        public BookClientModel(string autore, string title)
        {
            Author = autore;
            Title = title;
        }
    }
}

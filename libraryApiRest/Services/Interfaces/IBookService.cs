using libraryApiRest.Models;

namespace libraryApiRest.Services.Interfaces
{
    public interface IBookService
    {
        public Book Add(BookClientModel clientBook);
        public List<Book> GetAll();
        public Book GetById(int id);
        public Book Update(int id);
        public Book Delete(int id);
    }
}

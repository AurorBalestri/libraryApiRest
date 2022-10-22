using libraryApiRest.FileHelper;
using libraryApiRest.Models;
using libraryApiRest.Services.Interfaces;

namespace libraryApiRest.Services
{
    public class BookService : IBookService
    {
        public static readonly string _bookPath = "Book.txt";
        private readonly IList<Book> _books;

        private LibraryFileHelper _fileHelper = new LibraryFileHelper(); 

        public BookService(IList<Book> books)
        {
            _books = books;
        }
        public Book Add(BookClientModel clientBook)
        {
            var bookToAdd = MappingWithId(clientBook);
            var books = _fileHelper.ReadAndDeserialize<Book>(_bookPath);
            books.Add(bookToAdd);
            _fileHelper.WriteAndSerialize<Book>(_bookPath, books);
            return bookToAdd;
        }

        public Book MappingWithId(BookClientModel clientBook)
        {
            var bookWithId = new Book();
            bookWithId.Id = GetId();
            bookWithId.Author = clientBook.Author;
            bookWithId.Title = clientBook.Title;

            return bookWithId;
        }

        private int GetId()
        {
            var booksOnFile = _fileHelper.ReadAndDeserialize<Book>(_bookPath);
            if (booksOnFile.Count == 0)
                return 1;

            return booksOnFile.Max(book => book.Id) + 1;
        }

        public Book Delete(int id)
        {
            var books = _fileHelper.ReadAndDeserialize<Book>(_bookPath);
            var bookOnId = books.FirstOrDefault(book => book.Id == id);
            if(bookOnId != null)
            {
                books.Remove(bookOnId);
                _fileHelper.WriteAndSerialize(_bookPath, books);
                return bookOnId;
            } else
            {
                return null;
            }
        }

        public List<Book> GetAll()
        {
            var books = _fileHelper.ReadAndDeserialize<Book>(_bookPath);
            return books;
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Book Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using libraryApiRest.FileHelper;
using libraryApiRest.Models;
using libraryApiRest.Services.Interfaces;

namespace libraryApiRest.Services
{
    public class BorrowService : IBorrowService
    {
        public static readonly string _borrowPath = "Borrow.txt";
        private readonly IList<Borrow> _borrows;

        private LibraryFileHelper _fileHelper = new LibraryFileHelper();

        public BorrowService(IList<Borrow> borrows)
        {
            _borrows = borrows;
        }
        public Borrow Add()
        {
            throw new NotImplementedException();
        }

        public Borrow Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Borrow> GetAll()
        {
            throw new NotImplementedException();
        }

        public Borrow GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Borrow Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}

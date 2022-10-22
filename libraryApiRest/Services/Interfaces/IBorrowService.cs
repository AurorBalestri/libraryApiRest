using libraryApiRest.Models;

namespace libraryApiRest.Services.Interfaces
{
    public interface IBorrowService
    {
        public Borrow Add();
        public List<Borrow> GetAll();
        public Borrow GetById(int id);
        public Borrow Update(int id);
        public Borrow Delete(int id);
    }
}

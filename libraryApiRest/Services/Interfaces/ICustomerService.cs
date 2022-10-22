using libraryApiRest.Models;

namespace libraryApiRest.Services.Interfaces
{
    public interface ICustomerService
    {
        public Customer Add();
        public List<Customer> GetAll();
        public Customer GetById(int id);
        public Customer Update(int id);
        public Customer Delete(int id);
    }
}

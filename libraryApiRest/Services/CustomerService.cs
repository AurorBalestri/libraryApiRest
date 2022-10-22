using libraryApiRest.FileHelper;
using libraryApiRest.Models;
using libraryApiRest.Services.Interfaces;

namespace libraryApiRest.Services
{
    public class CustomerService : ICustomerService
    {
        public static readonly string _customerPath = "Customer.txt";
        private readonly IList<Customer> _customers;

        private LibraryFileHelper _fileHelper = new LibraryFileHelper();

        public CustomerService(IList<Customer> customers)
        {
            _customers = customers;
        }
        public Customer Add()
        {
            throw new NotImplementedException();
        }

        public Customer Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}

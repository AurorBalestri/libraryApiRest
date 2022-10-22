namespace libraryApiRest.Models
{
    public class CustomerClientModel
    {
        private int _customerId { get; set; }
        private string _fullName { get; set; }
        private string _address { get; set; }
        private int _phoneNumber { get; set; }

        public CustomerClientModel()
        {

        }
        public CustomerClientModel(int customerid, string fullname, string address, int phonenumber)
        {
            _customerId = customerid;
            _fullName = fullname;
            _address = address;
            _phoneNumber = phonenumber;
        }
    }
}

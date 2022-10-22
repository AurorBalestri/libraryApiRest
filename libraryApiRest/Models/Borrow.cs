namespace libraryApiRest.Models
{
    public class Borrow
    {
        private DateTime _startDate { get; set; }
        private DateTime _endDate { get; set; }
        private int _customerId { get; set; }
        private int _bookId { get; set; }

        public Borrow()
        {

        }

        public Borrow(DateTime startdate, DateTime enddate, int customerid, int bookid)
        {
            _startDate = startdate;
            _endDate = enddate;
            _customerId = customerid;
            _bookId = bookid;
        }
    }
}

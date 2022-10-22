namespace libraryApiRest.Models
{
    public class BorrowClientModel
    {
        private DateTime _startDate { get; set; }
        private DateTime _endDate { get; set; }

        public BorrowClientModel()
        {

        }

        public BorrowClientModel(DateTime startdate, DateTime enddate)
        {
            _startDate = startdate;
            _endDate = enddate;
        }
    }
}

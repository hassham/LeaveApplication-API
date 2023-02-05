namespace LeaveApplication.API.Model
{
    public class LeaveApplicationRequest
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public int ManagerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int NumberOfDays { get; set; }
        public string GeneralComments { get; set; }
    }
}

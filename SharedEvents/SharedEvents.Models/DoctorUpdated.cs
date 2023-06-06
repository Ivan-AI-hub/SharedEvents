namespace SharedEvents.Models
{
    public class DoctorUpdated
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Guid OfficeId { get; set; }
        public string Specialization { get; set; }
        public int CareerStartYear { get; set; }
        public DateTime BirthDay { get; set; }

        public DoctorUpdated(Guid id, string firstName, string middleName, string lastName, Guid officeId, string specialization, int careerStartYear, DateTime birthDay)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            OfficeId = officeId;
            Specialization = specialization;
            CareerStartYear = careerStartYear;
            BirthDay = birthDay;
        }
    }
}

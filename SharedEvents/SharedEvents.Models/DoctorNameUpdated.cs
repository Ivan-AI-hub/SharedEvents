namespace SharedEvents.Models
{
    public class DoctorNameUpdated
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public DoctorNameUpdated(Guid id, string firstName, string middleName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
    }
}

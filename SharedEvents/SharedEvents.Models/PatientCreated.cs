namespace SharedEvents.Models
{
    public class PatientCreated
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }

        public PatientCreated(Guid id, string email, string firstName, string middleName, string lastName, string phoneNumber, DateTime birthDay)
        {
            Id = id;
            Email = email;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            BirthDay = birthDay;
        }
    }
}

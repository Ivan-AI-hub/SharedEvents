namespace SharedEvents.Models
{
    public class PatientDeleted
    {
        public Guid Id { get; set; }

        public PatientDeleted(Guid id)
        {
            Id = id;
        }
    }
}

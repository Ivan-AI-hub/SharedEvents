namespace SharedEvents.Models
{
    public class DoctorDeleted
    {
        public Guid Id { get; set; }

        public DoctorDeleted(Guid id)
        {
            Id = id;
        }
    }
}

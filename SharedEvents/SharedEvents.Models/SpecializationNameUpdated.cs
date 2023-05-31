namespace SharedEvents.Models
{
    public class SpecializationNameUpdated
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public SpecializationNameUpdated(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

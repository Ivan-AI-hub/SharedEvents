namespace SharedEvents.Models
{
    public class ServiceNameUpdated
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ServiceNameUpdated(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

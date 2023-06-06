namespace SharedEvents.Models
{
    public class ServiceCreated
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public ServiceCreated(Guid id, string name, string price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}

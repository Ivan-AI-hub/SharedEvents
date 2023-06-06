namespace SharedEvents.Models
{
    public class UserCreated
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string ConfirmEmailUrl { get; set; }

        public UserCreated(Guid id, string userEmail, string confirmEmailUrl)
        {
            Id = id;
            Email = userEmail;
            ConfirmEmailUrl = confirmEmailUrl;
        }
    }
}

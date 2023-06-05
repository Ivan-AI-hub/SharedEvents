namespace SharedEvents.Models
{
    public class UserCreated
    {
        public Guid Id { get; set; }
        public string UserEmail { get; set; }
        public string ConfirmEmailUrl { get; set; }

        public UserCreated(Guid id, string userEmail, string confirmEmailUrl)
        {
            Id = id;
            UserEmail = userEmail;
            ConfirmEmailUrl = confirmEmailUrl;
        }
    }
}

namespace SharedEvents.Models
{
    public class UserRoleUpdated
    {
        public string Email { get; set; }
        public string Role { get; set; }
        public UserRoleUpdated(string email, string role)
        {
            Email = email;
            Role = role;
        }
    }
}

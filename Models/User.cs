namespace RostrosFelices.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        ICollection<User> Users { get; set; }

    }
}

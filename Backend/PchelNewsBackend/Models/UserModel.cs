namespace PchelNewsBackend.Models
{
    public class UserModel
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string username { get; set; }
        public string password { get; set; }
        public bool isAdmin { get; }

    }
}
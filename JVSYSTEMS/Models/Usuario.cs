namespace SistemaPonto.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? User { get; set; }
        public string? PasswordHash { get; set; }

        public Usuario(string user, string passwordHash)
        {
            User = user;
            PasswordHash = passwordHash;
        }
    }
}

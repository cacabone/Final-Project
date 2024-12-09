using FinalProject.Data.Enum;
namespace FinalProject.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public UsersRole Role { get; set; }
    }
}

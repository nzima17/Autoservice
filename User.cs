using System.ComponentModel.DataAnnotations;

namespace Autoservice
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string? Login { get; set; }

        public string? Password { get; set; }
    }
}
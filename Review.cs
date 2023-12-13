using System.ComponentModel.DataAnnotations;

namespace Autoservice
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        public string? Description { get; set; }
    }
}
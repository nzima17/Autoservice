using System.ComponentModel.DataAnnotations;

namespace Autoservice
{
    public class Catalog
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Price { get; set; }
    }
}
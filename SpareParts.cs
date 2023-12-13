using System;
using System.ComponentModel.DataAnnotations;

namespace Autoservice
{
    public class SpareParts
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Category { get; set; }

        public string? Price { get; set; }

        public string? Compatibility { get; set; }

        public string? Description { get; set; }

        public string? InStock { get; set; }

        public DateTime? AddedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string? ModifiedBy { get; set; }
    }
}
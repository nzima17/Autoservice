using System;
using System.ComponentModel.DataAnnotations;

namespace Autoservice
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Description { get; set; }

        public string? Image { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? FinishDate { get; set; }

        public string? OrderStatus { get; set; }

        public string? TotalPrice { get; set; }

        public string? Username { get; set; }

    }
}
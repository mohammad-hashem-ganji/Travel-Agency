
using System.ComponentModel.DataAnnotations;

namespace OnlineShope_5030.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
    }
}

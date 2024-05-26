using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShope_5030_practice.Models
{
    public class Products
    {

        [Key]
        public int Id { get; set; }
        
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public byte[] Image { get; set; } // sql equivalnce : varbinary(Max)
    }
}

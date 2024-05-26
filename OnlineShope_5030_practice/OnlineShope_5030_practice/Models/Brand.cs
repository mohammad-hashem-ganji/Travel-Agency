using System.ComponentModel.DataAnnotations;

namespace OnlineShope_5030_practice.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string RegCode { get; set; }
        public ICollection<Products> products { get; set; }
    }
}

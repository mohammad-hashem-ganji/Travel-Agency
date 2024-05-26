using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Airports> Airports { get; set; }
    }
}

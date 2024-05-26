using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models
{
    public class Cargo
    {
        [Key]
        public int Id { get; set; }
        public int CargoCount { get; set; }
        public int CargoWeight { get; set; }
        public string CargoTag { get; set; }
    }
}

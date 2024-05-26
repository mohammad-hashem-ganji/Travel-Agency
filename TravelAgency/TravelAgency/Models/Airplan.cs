using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.Models
{
    public class Airplan
    {
        [Key]
        public int Id { get; set; }
        public string ACType { get; set; }
        public int AirlineId { get; set; }
        [ForeignKey("AirlineId")]
        public Airlines Airlines { get; set; }
        public ICollection<Flights> Flights { get; set; }
    }
}

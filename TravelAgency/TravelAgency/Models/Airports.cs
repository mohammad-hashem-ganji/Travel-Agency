using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.Models
{
    public class Airports
    {
        [Key]
        public int Id { get; set; }
        public string AirportName { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
        public ICollection<Flights> OriginFlights { get; set; }
        public ICollection<Flights> DestinationFlights { get; set; }
    }
}

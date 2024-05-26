using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.Models
{
    public class Flights
    {
        [Key]
        public int Id { get; set; }
        public string SitNumber { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
//        public DateTime FlightDate { get; set; }
        public int AirpalanId { get; set; }
        [ForeignKey("AirpalanId")]
        public Airplan Airplan { get; set; }
        public int OriginAirportId { get; set; }
        [ForeignKey("OriginAirportId")]
        public Airports OriginAirport { get; set; } = null!;
        public int DestinationAirportId { get; set; }
        [ForeignKey("DestinationAirportId")]
        public Airports DestinationAirport { get; set; }
        public ICollection<Tickets> Tickets { get; set; }
        // ### transit ###
    }
}

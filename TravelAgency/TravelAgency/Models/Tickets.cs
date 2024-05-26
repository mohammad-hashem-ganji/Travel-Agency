using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.Models
{
    public class Tickets
    {
        [Key]
        public int Id { get; set; }
        public int FlightId { get; set; }
        [ForeignKey("FlightId")]
        public Flights Flights { get; set; }
        public int PassangerId { get; set; }
        [ForeignKey("PassangerId")]
        public Passanger Passanger { get; set; }
        public int PaymentTypeId { get; set; }
        [ForeignKey("PaymentTypeId")]
        public PaymentType PaymentType { get; set; }
        public int OrderTypesId { get; set; }
        [ForeignKey("OrderTypeId")]
        public OrderTypes OrderTypes { get; set; }
        public string Gender { get; set; }
        public string Sit { get; set; }
        public ICollection<CheckIn> CheckIns { get; set; }
    }
}

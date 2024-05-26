using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.Models
{
    public class CheckIn
    {
        [Key]
        public int Id { get; set; }
        public int TicketId { get; set; }
        [ForeignKey("TicketId")]
        public Tickets Tickets  { get; set; }
        public int CargoId { get; set; }
        public bool IsVIP { get; set; }
        public bool WCHC { get; set; }
        public bool WCHR { get; set; }
        public bool WCHS { get; set; }
    }
}

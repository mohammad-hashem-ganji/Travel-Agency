using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models
{
    public class PaymentType
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Tickets> Tickets { get; set; }
    }
}

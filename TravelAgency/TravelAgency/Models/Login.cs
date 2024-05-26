using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelAgency.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public Passanger Passanger { get; set; }
        public Employee Employee { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models
{
    public class Passanger
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string NCode { get; set; }
        public string Tell { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Login> Logins { get; set; }
    }
}

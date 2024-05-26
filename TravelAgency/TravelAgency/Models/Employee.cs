using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string PersoneCode { get; set; }
        public string Tell { get; set; }
        public ICollection<Login> Logins { get; set; }
    }
}

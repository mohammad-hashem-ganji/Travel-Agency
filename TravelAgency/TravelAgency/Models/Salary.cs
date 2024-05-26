using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models
{
    public class Salary
    {
        [Key]
        public int Id { get; set; }
        public int TotalPay { get; set; }
        public int Tax { get; set; }
        public int Insurance { get; set; }
        public int EmployeeId { get; set; }
    }
}

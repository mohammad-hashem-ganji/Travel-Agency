using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models
{
    public class Contract
    {
        [Key]
        public int Id { get; set; }
        public int EmpId { get; set; }
        public int RoleId { get; set; }
        public int SecId { get; set; }
        public int Duration { get; set; }
        public DateTime ContractDate { get; set; }
        public bool IsActive { get; set; }
    }
}


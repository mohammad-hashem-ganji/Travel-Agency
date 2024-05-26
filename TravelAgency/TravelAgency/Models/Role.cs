using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}

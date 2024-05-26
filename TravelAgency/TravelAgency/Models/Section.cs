using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models
{
    public class Section
    {
        [Key]
        public int Id { get; set; }
        public string SecTitle { get; set; }
    }
}

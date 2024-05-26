using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models
{
    public class Airlines
    {
        [Key]
        public int Id { get; set; }
        public string AirlineName { get; set; }
        public ICollection<Airplan> Airplans { get; set; }
    }
}

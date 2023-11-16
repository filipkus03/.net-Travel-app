using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Travel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }
        public decimal Price { get; set; }
    }
}

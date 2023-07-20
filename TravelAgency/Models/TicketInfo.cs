using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models
{
    public class TicketInfo
    {
        [Key]
        public int TicketID { get; set; }
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public string SeatNo { get; set; }
        public string TravelDate { get; set; }
        public string Airline { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Arrival { get; set; }
        public string Departure { get; set; }
    }
}

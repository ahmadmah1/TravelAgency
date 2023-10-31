using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models
{
    // Data Annotations
    public class TicketInfo
    {
        [Key]

        [Required]
        public int TicketID { get; set; }

        [Required]
        [Range(1, 99999, ErrorMessage = "Customer ID is not valid")]
        public int CustomerID { get; set; }

        [Required]
        [Range(1, 99999, ErrorMessage = "Order ID is not valid")]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Please enter the seat number")]
        // This function tell you that you must put a value in the field
        [DisplayName("Seat number")]
        // This function determines what the label for the field is
        [DataType(DataType.Text)]
        // The 'DataType' annotation that specifies which type of data it is (e.g. Text)

        [RegularExpression("^[a-zA-Z0-9_.-]*$", ErrorMessage = "Please enter the seat number")]
        // Regular expressions specify what can and can't be put in a field. This one for example only allows number and letters to be inputted
        public string SeatNo { get; set; }

        [Required(ErrorMessage = "Please enter a last name")]
        [DisplayName("First Name")]
        [DataType(DataType.Date)]
        public string TravelDate { get; set; }

        [Required(ErrorMessage = "Please enter a last name")]
        [DisplayName("Last Name")]
        [DataType(DataType.Text)]
        public string Airline { get; set; }

        [Required(ErrorMessage = "Please enter the destination country")]
        [DisplayName("Country")]
        [DataType(DataType.Text)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter the destination city")]
        [DisplayName("City")]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter the airline")]
        [DisplayName("Airline")]
        [RegularExpression("^[\\w'\\-,.][^0-9_!¡?÷?¿/\\\\+=@#$%ˆ&*(){}|~<>;:[\\]]{2,}$", ErrorMessage = "Please enter a valid airline")]
        [DataType(DataType.Text)]
        public string Arrival { get; set; }

        [Required(ErrorMessage = "Please enter the airport destination")]
        [DisplayName("Airport")]
        [RegularExpression("^[\\w'\\-,.][^0-9_!¡?÷?¿/\\\\+=@#$%ˆ&*(){}|~<>;:[\\]]{2,}$", ErrorMessage = "Please enter a valid airport name")]
        [DataType(DataType.Text)]
        public string Departure { get; set; }
    }
}





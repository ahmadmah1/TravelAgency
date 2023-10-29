using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models
{
    // Data Annotations
    public class Customer
    {
        [Required]
        public int CustomerID { get; set; }



        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        // This function tell you that you must put a value in the field

        [DisplayName("First Name")]
        // This function determines what the label for the field is

        [DataType(DataType.Text)]
        // The 'DataType' annotation that specifies which type of data it is (e.g. Text)

        [RegularExpression("^[\\w'\\-,.][^0-9_!¡?÷?¿/\\\\+=@#$%ˆ&*(){}|~<>;:[\\]]{2,}$", ErrorMessage = "Please enter your first name")]
        // Regular expressions specify what can and can't be put in a field. This one for example prevents special characters such as '!','@', and numbers from being inputted into the field.
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name"), MaxLength(30)]
        [DisplayName("Last Name")]
        [DataType(DataType.Text)]
        [RegularExpression("^[\\w'\\-,.][^0-9_!¡?÷?¿/\\\\+=@#$%ˆ&*(){}|~<>;:[\\]]{2,}$", ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your date of birth")]
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public string DOB { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        [DisplayName("Address")]
        [DataType(DataType.Text)]
       
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter the suburb you live in")]
        [DisplayName("Suburb")]
        [DataType(DataType.Text)]
        public string Suburb { get; set; }

        [Required(ErrorMessage = "Please enter the city you live in")]
        [DisplayName("City")]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your ZIP code")]
        [DisplayName("Zip")]
        [DataType(DataType.PostalCode)]
        [Range(1, 99999, ErrorMessage = "number is not valid")]
        // Specifies the range that the number must be in (1+ - 99999), therefore not allowing negative numbers
        [RegularExpression("^(\\d{4})$", ErrorMessage = "Please enter a valid ZIP code")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("\t\r\n^\\w+@[a-zA-Z_]+?\\.[a-zA-Z]{2,3}$", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Range(1, 99999, ErrorMessage = "number is not valid")]
        [RegularExpression("^(((\\+?64\\s*[-\\.\\ ]?[3-9]|\\(?0[3-9]\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{4})|((\\+?64\\s*[-\\.\\(\\ ]?2\\d{1,2}[-\\.\\)\\ ]?|\\(?02\\d{1}\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{3,5})|((\\+?64\\s*[-\\.\\ ]?[-\\.\\(\\ ]?800[-\\.\\)\\ ]?|[-\\.\\(\\ ]?0800[-\\.\\)\\ ]?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?(\\d{2}|\\d{5})))|^$$", ErrorMessage ="Please enter a valid Phone Number")]
        public string Phone { get; set; }

        public ICollection<Order> Order { get; set; }
    }
}

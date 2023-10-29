using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TravelAgency.Models
{
    // Data Annotations
    public class Staff
    {

        [Required]
        public int StaffId { get; set; }

        [Required]
        public int StoreID { get; set; }

        [Required(ErrorMessage = "Please enter a first name"), MaxLength(30)]
        // This function tell you that you must put a value in the field

        [DisplayName("first Name")]
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

        [Required(ErrorMessage = "Please enter your email address")]
        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^\\w+@[a-zA-Z_]+?\\.[a-zA-Z]{2,3}$", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^(((\\+?64\\s*[-\\.\\ ]?[3-9]|\\(?0[3-9]\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{4})|((\\+?64\\s*[-\\.\\(\\ ]?2\\d{1,2}[-\\.\\)\\ ]?|\\(?02\\d{1}\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{3,5})|((\\+?64\\s*[-\\.\\ ]?[-\\.\\(\\ ]?800[-\\.\\)\\ ]?|[-\\.\\(\\ ]?0800[-\\.\\)\\ ]?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?(\\d{2}|\\d{5})))|^$$", ErrorMessage = "Please enter a valid Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        [DisplayName("Address")]
        [DataType(DataType.Text)]
        public string Address { get; set; }


        public Store Store { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}

namespace TravelAgency.Models
{
    public class Customer
    {
        [Required]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Please enter a first name")]
        // This function tell you that you must put a value in the field
        
        [DisplayName("First Name")]
        // This function tell you what to put in the field
        
        [DataType(DataType.Text)]
        // The 'DataType' annotation that specifies which type of data it is (e.g. Text, r)
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name")]
        [DisplayName("Last Name")]
        [DataType(DataType.Text)]
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

        [Required(ErrorMessage = "Please enter your ZIP")]
        [DisplayName("Zip")]
        [DataType(DataType.PostalCode)]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^(((\\+?64\\s*[-\\.\\ ]?[3-9]|\\(?0[3-9]\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{4})|((\\+?64\\s*[-\\.\\(\\ ]?2\\d{1,2}[-\\.\\)\\ ]?|\\(?02\\d{1}\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{3,5})|((\\+?64\\s*[-\\.\\ ]?[-\\.\\(\\ ]?800[-\\.\\)\\ ]?|[-\\.\\(\\ ]?0800[-\\.\\)\\ ]?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?(\\d{2}|\\d{5})))|^$$", ErrorMessage ="Please enter a valid Phone Number")]
        public string Phone { get; set; }

        public ICollection<Order> Order { get; set; }
    }
}

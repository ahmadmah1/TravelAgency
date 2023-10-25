namespace TravelAgency.Models
{
    public class Customer
    {
        [Required]
        public int CustomerID { get; set; }

        [Required]
        [DisplayName("First Name")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required]
        // This function tell you that you must put a value in the field
        [DisplayName("Last Name")]
        // This function tell you what to put in the field
        [DataType(DataType.Text)]
        // The 'DataType' annotation that specifies which type of data it is (e.g. Text, r)
        public string LastName { get; set; }

        [Required]
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public string DOB { get; set; }

        [Required]
        [DisplayName("Address")]
        [DataType(DataType.Text)]
        public string Address { get; set; }

        [Required]
        [DisplayName("Suburb")]
        [DataType(DataType.Text)]
        public string Suburb { get; set; }

        [Required]
        [DisplayName("City")]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [Required]
        [DisplayName("Zip")]
        [DataType(DataType.PostalCode)]
        public string Zip { get; set; }

        [Required]
        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^(((\\+?64\\s*[-\\.\\ ]?[3-9]|\\(?0[3-9]\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{4})|((\\+?64\\s*[-\\.\\(\\ ]?2\\d{1,2}[-\\.\\)\\ ]?|\\(?02\\d{1}\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{3,5})|((\\+?64\\s*[-\\.\\ ]?[-\\.\\(\\ ]?800[-\\.\\)\\ ]?|[-\\.\\(\\ ]?0800[-\\.\\)\\ ]?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?(\\d{2}|\\d{5})))|^$$", ErrorMessage ="Please enter a valid Phone Number")]
        public string Phone { get; set; }

        public ICollection<Order> Order { get; set; }
    }
}

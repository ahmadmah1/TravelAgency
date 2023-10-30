using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models
{
    // Data Annotations
    public class Order
    {
        [Required]
        public int OrderID { get; set; }
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public int StaffID { get; set; }



        [Required(ErrorMessage = "Please enter date")]
        // This function tell you that you must put a value in the field
        [DisplayName("Date ordered for")]
        // This function determines what the label for the field is
        [DataType(DataType.Date)]
        // The 'DataType' annotation that specifies which type of data it is (e.g. Text)
        public string DateOrdered { get; set; }

        [Required(ErrorMessage = "Please enter the price")]
        [Display(Name = "Price")]

        [Range(1, 99999, ErrorMessage = "number is not valid")]

        // Specifies the range that the number must be in (1+ - 99999), therefore not allowing negative numbers

        [RegularExpression(@"^(((\d{1})*))$", ErrorMessage = "Please input a valid price")]
        // Regular expressions specify what can and can't be put in a field. This one for example prevents negative numbers from being inputted into the field.
        public int Price { get; set; }

        [Required(ErrorMessage = "Please specify if paid")]
        [Display(Name = "Paid")]
        [RegularExpression("^(?:Yes|No|y|n|Y|N|yes|no)$", ErrorMessage = "Yes/No")]
        public string Paid { get; set; }

        public Customer Customer { get; set; }
        public Staff Staff { get; set; }
   
    }
}





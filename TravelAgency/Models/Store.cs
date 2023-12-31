﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models
{
    // Data Annotations
    public class Store
    {
        [Required]
        public int StoreID { get; set; }

        [Required]
        [DisplayName("Store name")]
        [DataType(DataType.Text)]
        [RegularExpression("^[\\w'\\-,.][^0-9_!¡?÷?¿/\\\\+=@#$%ˆ&*(){}|~<>;:[\\]]{2,}$", ErrorMessage = "Please enter the branch name")]
        public string StoreName { get; set; }
        


        [Required(ErrorMessage = "Please enter your phone number")]
        // This function tell you that you must put a value in the field

        [DisplayName("Phone Number")]
        // This function determines what the label for the field is

        [DataType(DataType.PhoneNumber)]
        // The 'DataType' annotation that specifies which type of data it is (e.g. Text)

        [RegularExpression("^(((\\+?64\\s*[-\\.\\ ]?[3-9]|\\(?0[3-9]\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{4})|((\\+?64\\s*[-\\.\\(\\ ]?2\\d{1,2}[-\\.\\)\\ ]?|\\(?02\\d{1}\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{3,5})|((\\+?64\\s*[-\\.\\ ]?[-\\.\\(\\ ]?800[-\\.\\)\\ ]?|[-\\.\\(\\ ]?0800[-\\.\\)\\ ]?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?(\\d{2}|\\d{5})))|^$$", ErrorMessage = "Please enter a valid Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        [DisplayName("Address")]
        [DataType(DataType.Text)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter the suburb the store is in")]
        [DisplayName("Suburb")]
        [DataType(DataType.Text)]
        public string Suburb { get; set; }

        [Required(ErrorMessage = "Please enter the city the store is in")]
        [DisplayName("City")]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter the ZIP code")]
        [DisplayName("Zip")]
        [Range(1, 99999, ErrorMessage = "number is not valid")]
        [DataType(DataType.PostalCode)]
        [RegularExpression("^(\\d{4})$", ErrorMessage = "Please enter a valid ZIP code")]
        public int Zip { get; set; }
        public ICollection<Staff> Staff { get; set; }

    }
}




namespace TravelAgency.Models
{
    public class Store
    {
        public int StoreID { get; set; }
        public string StoreName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public ICollection<Staff> Staff { get; set; }

    }
}

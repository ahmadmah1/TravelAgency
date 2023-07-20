namespace TravelAgency.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        public int StoreID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Store Store { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}

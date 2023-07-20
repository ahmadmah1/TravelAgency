namespace TravelAgency.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int StaffID { get; set; }
        public string DateOrdered { get; set; }
        public string Price { get; set; }
        public string Paid { get; set; }

        public Customer Customer { get; set; }
        public Staff Staff { get; set; }

    }
}

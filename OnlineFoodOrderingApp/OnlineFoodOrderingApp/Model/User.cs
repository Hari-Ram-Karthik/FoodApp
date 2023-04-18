namespace OnlineFoodOrderingApp.Model
{
    public class User
    {
        //public int OrderID { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public Hotel Hotel { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
    }
}

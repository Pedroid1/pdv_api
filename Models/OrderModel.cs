namespace PDV_API.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public string? Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

    }
}

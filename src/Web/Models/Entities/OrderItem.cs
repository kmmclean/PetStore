namespace PetStore.Web.Models.Entities
{
    public class OrderItem
    {
        public long Id { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Order Order { get; set; }
    }
}
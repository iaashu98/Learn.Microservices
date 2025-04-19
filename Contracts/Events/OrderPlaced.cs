namespace Contracts.Events {
    public class OrderPlaced {
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime PlacedAt { get; set; }
    }
}
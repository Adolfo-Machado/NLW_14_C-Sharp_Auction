namespace RocketseatAuction.API.Entities
{
    public class Offer
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal Price { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}

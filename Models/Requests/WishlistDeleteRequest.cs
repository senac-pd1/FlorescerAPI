namespace FlorescerAPI.Models.Requests
{
    public class WishlistDeleteRequest
    {
        public Guid UserId { get; set; }
        public Guid PlantaId { get; set; }
    }
}



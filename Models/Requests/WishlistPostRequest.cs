namespace FlorescerAPI.Models.Requests
{
    public class WishlistPostRequest
    {
        public Guid UserId { get; set; }
        public Guid PlantaId { get; set; }
    }
}

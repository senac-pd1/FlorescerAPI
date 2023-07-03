namespace FlorescerAPI.Models.Requests
{
    public class MeuJardimPostRequest
    {
        public Guid UserId { get; set; }
        public Guid PlantaId { get; set; }
        public bool Notifica { get; set; }
    }
}

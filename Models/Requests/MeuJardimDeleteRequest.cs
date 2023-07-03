namespace FlorescerAPI.Models.Requests
{
    public class MeuJardimDeleteRequest
    {
        public Guid UserId { get; set; }
        public Guid PlantaId { get; set; }
        public bool Notifica { get; set; }

    }
}



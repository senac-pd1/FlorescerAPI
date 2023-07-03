using System;
namespace FlorescerAPI.Models
{
	public class MeuJardim
	{
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid PlantaId { get; set; }

        public bool Notifica { get; set; }

        public MeuJardim()
        {
            Id = Guid.NewGuid();
        }
    }
}


using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.ComponentModel.DataAnnotations;

namespace FlorescerAPI.Models
{
    public class Wishlist
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid PlantaId { get; set; }

        public Wishlist()
        {
            Id = Guid.NewGuid();
        }
        
    }
}

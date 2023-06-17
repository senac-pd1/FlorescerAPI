using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.ComponentModel.DataAnnotations;

namespace FlorescerAPI.Models
{
    public class Planta
    {
        public string Name { get; set; }
        public string Img { get; set; }
        public string Luminosity { get; set; }
        public Guid Id { get; set; }
        public string Growth { get; set; }
        public string Family { get; set; }
        public string Irrigation { get; set; }
        public string Climate { get; set; }
        public string ScientificName { get; set; }

    }

}

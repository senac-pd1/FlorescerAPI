using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace FlorescerAPI.Models
{
    public class Planta
    {
        public Guid Id { get; set; }
        public string? Categorie { get; set; }
        public string? Desease { get; set; }
        public string? Img { get; set; }
        public ICollection<String> Use { get; set; }
        public string? LatinName { get; set; }
        public ICollection<String> Insect { get; set; }
        public string? Avaibility { get; set; }
        public string? Style { get; set; }
        public string? Bearing { get; set; }
        public string? LightTolered { get; set; }
        public Dictionary<string, double> HeightAtPurchase { get; set; }
        public string? LightIdeal { get; set; }
        public Dictionary<string, double> WidthAtPurchase { get; set; }
        public string? Appeal { get; set; }
        public string? Perfume { get; set; }
        public string? Growth { get; set; }
        public Dictionary<string, double> WidthPotential { get; set; }
        public string? Name { get; set; }
        public string? Pruning { get; set; }
        public string? Family { get; set; }
        public Dictionary<string, double> HeightPotential { get; set; }
        public ICollection<String>? Origin { get; set; }
        public string? Description { get; set; }
        public Dictionary<string, double> TemperatureMax { get; set; }
        public string? BloomingSeason { get; set; }
        public string? Url { get; set; }
        public ICollection<String> ColorOfLeaf { get; set; }
        public string? Watering { get; set; }
        public string? ColorOfBloom { get; set; }
        public ICollection<String> Zone { get; set; }
        public string? AvaibleSizesPot { get; set; }
        public string? OtherName { get; set; }
        public Dictionary<string, double> TemperatureMin { get; set; }
        public Dictionary<string, double> PotDiameter { get; set; }
        public string? Climat { get; set; }




    }

}

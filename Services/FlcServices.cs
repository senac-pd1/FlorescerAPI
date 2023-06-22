using FlorescerAPI.Data;
using FlorescerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FlorescerAPI.Services
{
    public static class FlcServices
    {
        public static async Task<IEnumerable<Planta>> GetPlantasByLuminosity(string luminosity, MinimalContextDb _context)
        {
            var plantas = await _context.Plantas.Where(x => x.Luminosity.Contains(luminosity)).ToListAsync();
            return plantas;
        }
    }
}

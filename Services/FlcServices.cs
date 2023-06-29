using FlorescerAPI.Data;
using FlorescerAPI.Models;
using FlorescerAPI.Models.Requests;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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

        public static async Task<IResult> PostWishlistAsync(WishlistPostRequest wishlist, MinimalContextDb _context)
        {
            if (wishlist == null)
            {
                return Results.BadRequest("Requisição inválida");
            }

            try
            {

                var existsWishlist = await _context.Wishlists.AnyAsync(x => x.PlantaId == wishlist.PlantaId &&
                                                                    x.UserId == wishlist.UserId);

                if (!existsWishlist)
                {
                    var wishlistToPost = new Wishlist
                    {
                        PlantaId = wishlist.PlantaId,
                        UserId = wishlist.UserId
                    };
                    await _context.Wishlists.AddAsync(wishlistToPost);
                    await _context.SaveChangesAsync();

                    return Results.Ok(wishlistToPost);
                }
                else
                {
                    return Results.BadRequest($"Planta : {wishlist.PlantaId} já consta na lista de desejo.");
                }
            }
            catch (Exception ex)
            {
                return Results.BadRequest($"Erro ao tentar adicionar na lista de desejo {ex.Message}");
            }
        }

        public static async Task<IResult> DeleteWishlistAsync(WishlistDeleteRequest wishlist, MinimalContextDb _context)
        {
            if (wishlist == null)
            {
                return Results.BadRequest("Requisição inválida");
            }
            try
            {
                var existsWishlist = await _context.Wishlists.Where(x => x.PlantaId == wishlist.PlantaId &&
                                                                         x.UserId == wishlist.UserId).ToListAsync();
                if (existsWishlist.Any())
                {

                    foreach (var item in existsWishlist)
                    {
                        _context.Wishlists.Remove(item);
                        await _context.SaveChangesAsync();
                    }

                    return Results.Ok($"Item removido da lista de desejos.");
                }
                else
                {
                    return Results.BadRequest($"Planta : {wishlist.PlantaId} não consta na lista de desejo.");
                }
            }
            catch (Exception ex)
            {
                return Results.BadRequest($"Erro ao tentar remover a planta {wishlist.PlantaId} da lista de desejo {ex.Message}");
            }
        }

        public static async Task<List<Planta>> GetWishlistByUserId(Guid userId, MinimalContextDb _context)
        {
            var wishlist = await _context.Wishlists.Where(x => x.UserId == userId).ToListAsync();
            var plantas = new List<Planta>();

            if (wishlist.Any())
            {
                
                foreach (var item in wishlist)
                {
                    var planta = await _context.Plantas.Where(x => x.Id == item.PlantaId).FirstOrDefaultAsync();
                    plantas.Add(planta);
                }
                
            }
            return plantas;
        }
    }
}

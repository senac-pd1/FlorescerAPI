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

        
        // Controller do wishlist
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


        // Controller do Meu Jardim
        public static async Task<IResult> PostMeuJardimAsync(MeuJardimPostRequest meuJardim, MinimalContextDb _context)
        {
            if (meuJardim == null)
            {
                return Results.BadRequest("Requisição inválida");
            }

            try
            {
                var existsMeuJardim = await _context.MeusJardins.AnyAsync(x => x.PlantaId == meuJardim.PlantaId &&
                                                                    x.UserId == meuJardim.UserId && x.Notifica == meuJardim.Notifica);

                if (!existsMeuJardim)
                {
                    var meuJardimToPost = new MeuJardim
                    {
                        PlantaId = meuJardim.PlantaId,
                        UserId = meuJardim.UserId,
                        Notifica = meuJardim.Notifica
                    };
                    await _context.MeusJardins.AddAsync(meuJardimToPost);
                    await _context.SaveChangesAsync();

                    return Results.Ok(meuJardimToPost);
                }
                else
                {
                    return Results.BadRequest($"Planta : {meuJardim.PlantaId} já consta no seu jardim.");
                }
            }
            catch (Exception ex)
            {
                return Results.BadRequest($"Erro ao tentar adicionar no seu jardim {ex.Message}");
            }
        }


        public static async Task<IResult> PutMeuJardimAsync(MeuJardim meuJardim, MinimalContextDb _context)
        {
            if (meuJardim == null)
            {
                return Results.BadRequest("Requisição inválida");
            }

            try
            {
                var existsMeuJardim = await _context.MeusJardins.FirstAsync(x => x.PlantaId == meuJardim.PlantaId &&
                                                                    x.UserId == meuJardim.UserId);

                if (existsMeuJardim != null)
                {
                    existsMeuJardim.Notifica = meuJardim.Notifica;
                        
                    _context.MeusJardins.Update(existsMeuJardim);
                    var results = await _context.SaveChangesAsync();

                    return Results.Ok(results);
                }
                else
                {
                    return Results.BadRequest($"Planta : {meuJardim.PlantaId} não consta no seu jardim.");
                }
            }
            catch (Exception ex)
            {
                return Results.BadRequest($"Erro ao tentar atualizar a planta no seu jardim {ex.Message}");
            }
        }

        public static async Task<IResult> DeleteMeuJardimAsync(MeuJardimDeleteRequest meuJardim, MinimalContextDb _context)
        {
            if (meuJardim == null)
            {
                return Results.BadRequest("Requisição inválida");
            }
            try
            {
                var existsMeuJardim = await _context.MeusJardins.Where(x => x.PlantaId == meuJardim.PlantaId &&
                                                                         x.UserId == meuJardim.UserId ).ToListAsync();
                if (existsMeuJardim.Any())
                {

                    foreach (var item in existsMeuJardim)
                    {
                        _context.MeusJardins.Remove(item);
                        await _context.SaveChangesAsync();
                    }

                    return Results.Ok($"Item removido do seu jardim.");
                }
                else
                {
                    return Results.BadRequest($"Planta : {meuJardim.PlantaId} não consta no seu jardim.");
                }
            }
            catch (Exception ex)
            {
                return Results.BadRequest($"Erro ao tentar remover a planta {meuJardim.PlantaId} do seu jardim {ex.Message}");
            }
        }

        public static async Task<List<Planta>> GetMeuJardimByUserId(Guid userId, MinimalContextDb _context)
        {
            var meuJardim = await _context.MeusJardins.Where(x => x.UserId == userId).ToListAsync();
            var plantas = new List<Planta>();

            if (meuJardim.Any())
            {

                foreach (var item in meuJardim)
                {
                    var planta = await _context.Plantas.Where(x => x.Id == item.PlantaId).FirstOrDefaultAsync();
                    plantas.Add(planta);
                }

            }
            return plantas;
        }

    }
}

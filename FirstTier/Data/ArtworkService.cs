using System.Collections.Generic;
using System.Threading.Tasks;
using FirstTier.Models;

namespace FirstTier.Data
{
    public interface ArtworkService
    {
        Task<Artwork> AddArtwork(Artwork artwork);
        Task<IList<Artwork>> GetArtworksAsync();
        Task DeleteArtworkAsync(int id);
        Task<Artwork> EditArtwork(Artwork artwork);
        Task<Artwork> GetArtworkAsync(int Id);
    }
}
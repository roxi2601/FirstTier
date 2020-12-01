﻿using System.Threading.Tasks;
using FirstTier.Models;

namespace FirstTier.Data
{
    public interface ArtworkService
    {
        Task<Artwork> AddArtwork(Artwork artwork);
    }
}
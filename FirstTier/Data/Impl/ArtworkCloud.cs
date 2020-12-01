using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FirstTier.Models;

namespace FirstTier.Data.Impl
{
    public class ArtworkCloud : ArtworkService
    {
        HttpClient client = new HttpClient();
        
        public async Task<Artwork> AddArtwork(Artwork artwork)
        {
            string artworkSerialized = JsonSerializer.Serialize(artwork);
            StringContent content = new StringContent(artworkSerialized, Encoding.UTF8, "application/json");
            HttpResponseMessage response =
                await client.PostAsync("http://localhost:8080/addArtwork",content);
            
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Artwork result = JsonSerializer.Deserialize<Artwork>(response.Content.ReadAsStringAsync().Result);
                return result;
            }
            throw new Exception(response.Content.ReadAsStringAsync().Result);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
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
        private readonly DapperService dapper;
        
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
        public async Task<Artwork> EditArtwork(Artwork artwork)
        {
            string artworkSerialized = JsonSerializer.Serialize(artwork);
            StringContent content = new StringContent(artworkSerialized, Encoding.UTF8, "application/json");
            HttpResponseMessage response =
                await client.PutAsync("http://localhost:8080/editArtwork",content);
            
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Artwork result = JsonSerializer.Deserialize<Artwork>(response.Content.ReadAsStringAsync().Result);
                return result;
            }
            throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public async Task<IList<Artwork>> GetArtworksAsync()
        {
            string message = await client.GetStringAsync("http://localhost:8080/artworks");
            
            List<Artwork> result = JsonSerializer.Deserialize<List<Artwork>>(message);
            
            return result;
        }

        public async Task<Artwork> GetArtworkAsync(int id)
        {
           HttpResponseMessage response = await client.GetAsync("http://localhost:8080/artworks/"+id);
           
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Artwork result = JsonSerializer.Deserialize<Artwork>(response.Content.ReadAsStringAsync().Result);
                return result;
            }
            throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public async Task DeleteArtworkAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("http://localhost:8080/artworks/"+id);
            if (response.IsSuccessStatusCode)
            {
                //do nothing
            }
            throw new Exception(response.Content.ReadAsStringAsync().Result);
        }
        /* searching
        public async Task<int> CountAsync(string search)
        {
            var totalArtwork = await Task.FromResult(dapper.Get<int>($"select COUNT(*) from [Artwork] WHERE title like '%{search}%'", null,
                commandType: CommandType.Text));
            return totalArtwork;
        }

        public async Task<List<Artwork>> ListAllAsync(int skip, int take, string orderBy, string direction,
            string search)
        {
            var artworks = await Task.FromResult(dapper.GetAll<Artwork>
                ($"SELECT * FROM [Artwork] WHERE title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return artworks;
        }*/
    }
}
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FirstTier.Models
{
    public class Artwork
    {
        [JsonPropertyName("pictureBytes")]
        public byte[] pictureBytes { get; set; }
        
        [NotNull]
        [JsonPropertyName("title")]
        public string title { get; set; }
        
        [JsonPropertyName("description")]
        public string description { get; set; }
        
        
        [JsonPropertyName("author")]
        public string author { get; set; }
        
        [NotNull, Range(0,100000000000000)]
        [JsonPropertyName("price")]
        public int price { get; set; }
        
        
        [JsonPropertyName("userId")]
        public int userId { get; set; }
        
        [JsonPropertyName("id")]
        public int id { get; set;}
        
        [JsonPropertyName("category")]
        public string category { get; set; }
        
        public override string ToString() {
            return JsonSerializer.Serialize(this);
        }
    }
}
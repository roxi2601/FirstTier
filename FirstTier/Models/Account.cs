using System.Text.Json;
using System.Text.Json.Serialization;

namespace FirstTier.Models
{
    public class Account
    {
        [JsonPropertyName("username")]
        public string username { get; set; }
        [JsonPropertyName("firstName")] 
        public string FirstName { get; set; }
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }
        [JsonPropertyName("description")] 
        public string Description { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
       
        [JsonPropertyName("accountId")]
        public int ID { get; set; }
        
        [JsonPropertyName("securityLevel")]
        public int SecurityLevel { get; set; }
        
        [JsonPropertyName("pictureBytes")] 
        public byte[] Img { get; set; }
        
        public override string ToString() {
            return JsonSerializer.Serialize(this);
        }
    }
}
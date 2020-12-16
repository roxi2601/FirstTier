using System.Text.Json;
using System.Text.Json.Serialization;

namespace FirstTier.Models
{
    public class Message
    {
        [JsonPropertyName("username")]
        public string username { get; set; }
        
        [JsonPropertyName("messageBody")]
        public string messageBody { get; set; }
        
        [JsonPropertyName("mine")]
        public bool mine { get; set; }
        
        [JsonPropertyName("isNotice")]
        public bool IsNotice => messageBody.StartsWith("[Notice]");
        
        [JsonPropertyName("CSS")]
        public string CSS => mine ? "sent" : "received";
        
        public override string ToString() {
            return JsonSerializer.Serialize(this);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FirstTier.Models;

namespace FirstTier.Data.Impl
{
    public class ChatCloud : ChatService
    {
        HttpClient client = new HttpClient();
        
        public async Task<Message> AddMessageAsync(Message message)
        {
            string messageSerialized = JsonSerializer.Serialize(message);
            StringContent content = new StringContent(messageSerialized, Encoding.UTF8, "application/json");
            HttpResponseMessage response =
                await client.PostAsync("http://localhost:8080/sendMessage",content);
            
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Message result = JsonSerializer.Deserialize<Message>(response.Content.ReadAsStringAsync().Result);
                return result;
            }
            throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public async Task<IList<Message>> GetMessagesAsync()
        {
            string message = await client.GetStringAsync("http://localhost:8080/chats");
            
            List<Message> result = JsonSerializer.Deserialize<List<Message>>(message);
            
            return result;
        }
        
        public async Task<Message> EditMessageAsync(Message message)
        {
            string messageSerialized = JsonSerializer.Serialize(message);
            StringContent content = new StringContent(messageSerialized, Encoding.UTF8, "application/json");
            HttpResponseMessage response =
                await client.PutAsync("http://localhost:8080/updateChat",content);
            
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Message result = JsonSerializer.Deserialize<Message>(response.Content.ReadAsStringAsync().Result);
                return result;
            }
            throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public async Task DeleteMessageAsync(string message)
        {
            HttpResponseMessage response = await client.DeleteAsync("http://localhost:8080/chats/"+message);
            if (response.IsSuccessStatusCode)
            {
                //do nothing
            }
            throw new Exception(response.Content.ReadAsStringAsync().Result);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FirstTier.Models;

namespace FirstTier.Data.Impl
{
    public class UserCloud : UserService
    {
        HttpClient client = new HttpClient();

        public async Task<User> ValidateUserAsync(string username, string password)
        {
            User user =new User();
            user.Password = password;
            user.UserName = username;
            string personSerialized = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(personSerialized, Encoding.UTF8, "application/json");
            HttpResponseMessage response =
                await client.PostAsync("http://localhost:8080/login",content);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                User result = JsonSerializer.Deserialize<User>(response.Content.ReadAsStringAsync().Result);
                return result;
            }

            Console.WriteLine("user received on client side " + response.Content.ReadAsStringAsync().Result);
           
            throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public async Task<IList<User>> GetUsersAsync()
        {
            string message = await client.GetStringAsync("https://localhost:5001/users");
            List<User> result = JsonSerializer.Deserialize<List<User>>(message);
            return result;
        }

        public async Task AddUserAsync(User user)
        {
            string personSerialized = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(personSerialized,Encoding.UTF8,"application/json");
            HttpResponseMessage response = await client.PostAsync("https://localhost:5001/users",content);
            Console.WriteLine(response.ToString());
            if (response.StatusCode != HttpStatusCode.Created)
            {
                throw new Exception(response.Content.ReadAsStringAsync().Result);
            }
        }

        public async Task UpdateUserAsync(User user)
        {
            string userSerialized = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(userSerialized,Encoding.UTF8,"application/json");
            HttpResponseMessage response = await client.PutAsync( "https://localhost:5001/users",content);
            Console.WriteLine(response.ToString()); 
        }

        public async Task RemoveUserAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("https://localhost:5001/users?Id="+id);
            Console.WriteLine(response);
        }
    }
}
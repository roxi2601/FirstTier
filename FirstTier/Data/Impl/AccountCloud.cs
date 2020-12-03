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
    public class AccountCloud: AccountService
    {
        HttpClient client = new HttpClient();

        public async Task<IList<Account>> GetAccountsAsync()
        {
            string message = await client.GetStringAsync("http://localhost:8080/accounts");
            Console.WriteLine("cloud message"+message);
            List<Account> result = JsonSerializer.Deserialize<List<Account>>(message);
            return result;
        }
        public async Task<Account> GetAccountAsync(int userId)
        {
            string message = await client.GetStringAsync("http://localhost:8080/account/"+userId);
            Console.WriteLine("cloud message"+message);
            Account result = JsonSerializer.Deserialize<Account>(message);
            
            return result;
        }

        public async Task<Account> AddAccountAsync(Account account)
        {
            string personSerialized = JsonSerializer.Serialize(account);
            StringContent content = new StringContent(personSerialized,Encoding.UTF8,"application/json");
            
            HttpResponseMessage response = 
                await client.PostAsync("http://localhost:8080/signUp",content);
            
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Account result = JsonSerializer.Deserialize<Account>(response.Content.ReadAsStringAsync().Result);
                return result;
            } 
            throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public async Task UpdateAccountAsync(Account account)
        {
            string accountSerialized = JsonSerializer.Serialize(account);
            StringContent content = new StringContent(accountSerialized,Encoding.UTF8,"application/json");
            HttpResponseMessage response = await client.PutAsync( "https://localhost:8080/accounts",content);
            Console.WriteLine(response.ToString()); 
        }

        public async Task RemoveAccountAsync(string username)
        {
            HttpResponseMessage response = await client.DeleteAsync("https://localhost:8080/accounts/"+username);
            Console.WriteLine(response);
        }
    }
}
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
            string message = await client.GetStringAsync("http://localhost:5001/accounts");
            Console.WriteLine("cloud message"+message);
            List<Account> result = JsonSerializer.Deserialize<List<Account>>(message);
            return result;
        }

        public async Task AddAccountAsync(Account account)
        {
            string personSerialized = JsonSerializer.Serialize(account);
            StringContent content = new StringContent(personSerialized,Encoding.UTF8,"application/json");
            HttpResponseMessage response = await client.PostAsync("http://localhost:5001/signUp",content);
            Console.WriteLine(response.ToString());
            if (response.StatusCode != HttpStatusCode.Created)
            {
                Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
                throw new Exception(response.Content.ReadAsStringAsync().Result);
            }
        }

        public async Task UpdateAccountAsync(Account account)
        {
            string accountSerialized = JsonSerializer.Serialize(account);
            StringContent content = new StringContent(accountSerialized,Encoding.UTF8,"application/json");
            HttpResponseMessage response = await client.PutAsync( "https://localhost:5001/accounts",content);
            Console.WriteLine(response.ToString()); 
        }

        public async Task RemoveAccountAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("https://localhost:5001/accounts?Id="+id);
            Console.WriteLine(response);
        }
    }
}
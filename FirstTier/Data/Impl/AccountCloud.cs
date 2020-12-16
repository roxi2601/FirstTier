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
    public class AccountCloud: AccountService
    {
        HttpClient client = new HttpClient();
        private readonly DapperService dapper;

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

        public async Task<Account> UpdateAccountAsync(Account account)
        {
            Console.WriteLine(account);
            string accountSerialized = JsonSerializer.Serialize(account);
            StringContent content = new StringContent(accountSerialized, Encoding.UTF8, "application/json");
            HttpResponseMessage response =
                await client.PutAsync("http://localhost:8080/editAccount",content);
            
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Account result = JsonSerializer.Deserialize<Account>(response.Content.ReadAsStringAsync().Result);
                return result;
            }
            throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public async Task RemoveAccountAsync(int userId)
        {
            HttpResponseMessage response = await client.DeleteAsync("http://localhost:8080/accounts/"+userId);
            Console.WriteLine(response);
        }
        
        /* searching
        public async Task<int> CountAsync(string search)
        {
            var totalAccount = await Task.FromResult(dapper.Get<int>($"select COUNT(*) from [Account] WHERE username like '%{search}%'", null,
                commandType: CommandType.Text));
            return totalAccount;
        }

        public async Task<List<Account>> ListAllAsync(int skip, int take, string orderBy, string direction,
            string search)
        {
            var accounts = await Task.FromResult(dapper.GetAll<Account>
                ($"SELECT * FROM [Account] WHERE username like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return accounts;
        }*/
    }
}
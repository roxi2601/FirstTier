using System.Collections.Generic;
using System.Threading.Tasks;
using FirstTier.Models;

namespace FirstTier.Data
{
    public interface AccountService
    {
        Task<IList<Account>> GetAccountsAsync();
        Task<Account> GetAccountAsync(string username);
        Task<Account> AddAccountAsync(Account account);
        Task UpdateAccountAsync(Account account);
        Task RemoveAccountAsync(string username);
    }
}
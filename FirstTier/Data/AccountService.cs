using System.Collections.Generic;
using System.Threading.Tasks;
using FirstTier.Models;

namespace FirstTier.Data
{
    public interface AccountService
    {
        Task<IList<Account>> GetAccountsAsync();
        Task<Account> AddAccountAsync(Account account);
        Task<Account> UpdateAccountAsync(Account account);
        Task RemoveAccountAsync(int userId);
        Task<Account> GetAccountAsync(int userId);
    }
}
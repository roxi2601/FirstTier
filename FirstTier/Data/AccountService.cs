using System.Collections.Generic;
using System.Threading.Tasks;
using FirstTier.Models;

namespace FirstTier.Data
{
    public interface AccountService
    {
        Task<IList<Account>> GetAccountsAsync();
        Task<Account> GetAccountAsync(int userId);
        Task<Account> AddAccountAsync(Account account);
        Task UpdateAccountAsync(Account account, int userId);
        Task RemoveAccountAsync(int userId);
    }
}
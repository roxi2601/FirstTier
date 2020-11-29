using System.Collections.Generic;
using System.Threading.Tasks;
using FirstTier.Models;

namespace FirstTier.Data
{
    public interface AccountService
    {
        Task<IList<Account>> GetAccountsAsync();
        Task AddAccountAsync(Account account);
        Task UpdateAccountAsync(Account account);
        Task RemoveAccountAsync(int id);
    }
}
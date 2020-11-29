using System.Collections.Generic;
using System.Threading.Tasks;
using FirstTier.Models;

namespace FirstTier.Data
{
    public interface UserService
    {
        Task<User> ValidateUserAsync(string username, string password);
        Task<IList<User>> GetUsersAsync();
    }
}
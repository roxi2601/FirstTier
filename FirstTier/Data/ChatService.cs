using System.Collections.Generic;
using System.Threading.Tasks;
using FirstTier.Models;

namespace FirstTier.Data
{
    public interface ChatService
    {
        Task<Message> AddMessageAsync(Message message);
        Task DeleteMessageAsync(string message);
        Task<Message> EditMessageAsync(Message message);
        Task<IList<Message>> GetMessagesAsync();
    }
}
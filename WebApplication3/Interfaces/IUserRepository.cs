using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmailAsync(string email);
        Task<User> CreateUserAsync(User user);
    }
}

using Microsoft.EntityFrameworkCore;
using WebApplication3.Contexts;
using WebApplication3.Interfaces;
using WebApplication3.Models;

namespace WebApplication3.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AuthenticationContext _context;

        public UserRepository(AuthenticationContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _context.users.FirstOrDefaultAsync(user => user.email == email);
        }

        public async Task<User> CreateUserAsync(User user)
        {
            _context.users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}

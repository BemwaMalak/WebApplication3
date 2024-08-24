using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Contexts
{
    public class AuthenticationContext : DbContext
    {
        public AuthenticationContext(DbContextOptions<AuthenticationContext> options) : base(options) { }


        public DbSet<User> users { get; set; }
    }
}

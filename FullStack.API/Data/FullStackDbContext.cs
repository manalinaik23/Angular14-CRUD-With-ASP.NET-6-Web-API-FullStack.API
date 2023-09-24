using FullStack.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FullStack.API.Data
{
    public class FullStackDbContext : IdentityDbContext
    {
        public FullStackDbContext(DbContextOptions<FullStackDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}

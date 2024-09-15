using Microsoft.EntityFrameworkCore;
using aspnet_api.Models;

namespace aspnet_api.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        { 
        }

        public DbSet<Person> Persons { get; set; }
    }
}

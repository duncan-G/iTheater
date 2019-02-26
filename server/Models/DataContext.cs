using Microsoft.EntityFrameworkCore;

namespace Server.Models
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Movies> Movies {get; set; }
    }
}
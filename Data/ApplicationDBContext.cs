using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) //ctor = constructor
        : base(dbContextOptions) //Passes data to actual DbContext
        {
            
        }

        public DbSet<Stock> Stocks { get; set; } //Grabs something off the database and do something with it
        public DbSet<Comment> Comments { get; set; }
    }
}

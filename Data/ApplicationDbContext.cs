using Microsoft.EntityFrameworkCore;
using MyWebApp3.Models;

namespace MyWebApp3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        
        public DbSet<Book> Books {get; set;}
    }
}
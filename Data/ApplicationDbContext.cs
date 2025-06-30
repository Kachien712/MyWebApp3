using Microsoft.EntityFrameworkCore;
using MyWebApp3.Models;

namespace MyWebApp3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Đắc Nhân Tâm", Author = "Dale Carnegie", YearPublished = 1936 },
                new Book { Id = 2, Title = "Nhà Giả Kim", Author = "Paulo Coelho", YearPublished = 1988 },
                new Book { Id = 3, Title = "Cha Giàu Cha Nghèo", Author = "Robert Kiyosaki", YearPublished = 1997 }
            );
        }
    }
    
}

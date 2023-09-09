using Microsoft.EntityFrameworkCore;
namespace EF_BookCurd.Models

{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }

    }
}

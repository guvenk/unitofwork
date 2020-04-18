using Microsoft.EntityFrameworkCore;

namespace UnitOfWork
{
    public partial class AppDbContext : DbContext
    {
        public DbSet<Library> Libraries { get; set; }

        public DbSet<Book> Books { get; set; }
    }
}
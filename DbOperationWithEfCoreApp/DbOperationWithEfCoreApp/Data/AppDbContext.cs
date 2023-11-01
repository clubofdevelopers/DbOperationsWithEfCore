using Microsoft.EntityFrameworkCore;

namespace DbOperationWithEfCoreApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
                new Currency { Id = 1, Title = "INR", Description = "Indian INR" },
                new Currency { Id = 2, Title = "Doller", Description = "Doller" },
                new Currency { Id = 3, Title = "Euro", Description = "Euro" },
                new Currency { Id = 4, Title = "Dinar", Description = "Dinar" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language { Id = 1, Title = "INR", Description = "Indian INR" },
                new Language { Id = 2, Title = "Doller", Description = "Doller" },
                new Language { Id = 3, Title = "Euro", Description = "Euro" },
                new Language { Id = 4, Title = "Dinar", Description = "Dinar" }
                );
        }
        public DbSet<Book> books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
        public DbSet<Currency> Currencies { get; set; }
    }
}

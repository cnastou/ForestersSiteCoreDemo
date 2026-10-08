using Microsoft.EntityFrameworkCore;
using ForestersSiteCoreDemo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace ForestersSiteCoreDemo.Data
{
    public class ApplicationDbContext : IdentityDbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }
        // Define a DbSet for the InsuranceProduct model, 
        // allowing CRUD operations on the InsuranceProducts table in the database.
        public DbSet<InsuranceProduct> InsuranceProducts { get; set; }
        // Define a DbSet for the ContentPage model, 
        // allowing CRUD operations on the ContentPages table in the database.
        public DbSet<ContentPage> ContentPages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the ContentPage entity to have a unique index on the PageKey property.
            modelBuilder.Entity<ContentPage>()
                .HasIndex(p => p.PageKey)
                .IsUnique();
        }
    }   
}

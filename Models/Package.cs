using Microsoft.EntityFrameworkCore;

namespace APP1.Models
{
    public class Package
    {
        public Guid Id { get; set; }
        public string? Number { get; set; }
        public int? RegNumber { get; set; }
        public int? Status { get; set; }
        //public DateTime CreateDate { get; set; }
        public DateTime TransferDate { get; set; }
        public DateTime RegDate { get; set; }
        public int? RegistrationNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    public class ApplicationContext : DbContext
    {
        public DbSet<Package> Packages { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Package>().ToTable("Package");
        }
        
    }

    
}
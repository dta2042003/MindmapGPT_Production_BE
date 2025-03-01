using Microsoft.EntityFrameworkCore;

namespace mindmapGPT_server.Entity
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<UserEntity>()
            //    .HasIndex(u => u.Email)
            //    .IsUnique();
        }
    }
}

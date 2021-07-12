using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public partial class SignLanguageContext : DbContext
    {
        public SignLanguageContext(DbContextOptions<SignLanguageContext> options) : base(options) { }
        public DbSet<SignLanguage> SignLanguages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SignLanguage>().HasData(
                new SignLanguage { Id = 1, Word = "abandon", WordVideoUrl = "http://dlmg.ro/wp-content/uploads/2017/08/abandon-2.mp4" });
            modelBuilder.Entity<SignLanguage>().HasData(
                new SignLanguage { Id = 2, Word = "accepta", WordVideoUrl = "http://dlmg.ro/wp-content/uploads/2017/06/accepta.mp4" });
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace MyBGList.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configure the composite primary key for join entities 
            modelBuilder.Entity<BoardGames_Domains>()
                .HasKey(i => new { i.BoardGameId, i.DomainId });
            modelBuilder.Entity<BoardGames_Domains>()
                .HasOne(x => x.BoardGame)
                .WithMany(y => y.BoardGames_Domains)
                .HasForeignKey(f => f.BoardGameId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<BoardGames_Mechanic>()
                .HasKey(i => new { i.BoardGameId, i.MechanicId });

        }
    }
}

namespace ProgramsService.Data
{
    using Microsoft.EntityFrameworkCore;
    using ProgramsService.Data.Configurations;
    using ProgramsService.Domain.Models;

    public class ProgramsContext : DbContext
    {
        public DbSet<Programs> Programs { get; set; }

        public ProgramsContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProgramsConfiguration());
        }
    }
}

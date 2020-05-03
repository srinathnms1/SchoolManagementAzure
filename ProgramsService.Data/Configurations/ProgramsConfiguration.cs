namespace ProgramsService.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ProgramsService.Domain.Models;

    public class ProgramsConfiguration : IEntityTypeConfiguration<Programs>
    {
        public void Configure(EntityTypeBuilder<Programs> builder)
        {
            builder.HasKey(s => new { s.Id });
        }
    }
}

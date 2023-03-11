using ControleCaldeiras.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleCaldeiras.Data.Map
{
    public class CaldeiraMap : IEntityTypeConfiguration<CaldeiraModel>
    {
        public void Configure(EntityTypeBuilder<CaldeiraModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(255);
            builder.Property(x => x.Status).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Pressao).HasMaxLength(255);
            builder.Property(x => x.Temperatura).HasMaxLength(255);
            builder.Property(x => x.Operador).HasMaxLength(255);
        }
    }
}

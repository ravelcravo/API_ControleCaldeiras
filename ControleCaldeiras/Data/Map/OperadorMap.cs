using ControleCaldeiras.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleCaldeiras.Data.Map
{
    public class OperadorMap : IEntityTypeConfiguration<OperadorModel>
    {
        public void Configure(EntityTypeBuilder<OperadorModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
        }
    }
}

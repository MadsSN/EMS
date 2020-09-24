using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Template1.API.Context.EntityConfigurations
{
    class Template1EntityTypeConfiguration
        : IEntityTypeConfiguration<Model.Template1>
    {
        public void Configure(EntityTypeBuilder<Model.Template1> builder)
        {
            builder.ToTable("Template1");

            builder.HasKey(ci => ci.Id);

            builder.Property(ci => ci.Id)
                .IsRequired();

            builder.Property(ci => ci.Name)
                .IsRequired();
        }
    }
}
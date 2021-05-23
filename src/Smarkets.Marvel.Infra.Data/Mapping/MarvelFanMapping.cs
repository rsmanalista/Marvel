using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smarkets.Marvel.Domain.Entities;

namespace Smarkets.Marvel.Infra.Data.Mapping
{
	public class MarvelFanMapping : IEntityTypeConfiguration<MarvelFan>
    {
        public void Configure(EntityTypeBuilder<MarvelFan> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder
                .Property(x => x.Name)
                .IsRequired();

            builder
                .Property(x => x.Cpf)                
                .HasMaxLength(11)
                .IsRequired();

            builder
                .Property(x => x.DtNasc)                
                .IsRequired();
        }
    }
}
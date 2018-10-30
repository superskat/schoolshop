using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Models;

namespace Shop.Data.Mappings
{
    public class ProcentSaleMap : IEntityTypeConfiguration<ProcentSale>
    {
        public void Configure(EntityTypeBuilder<ProcentSale> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}

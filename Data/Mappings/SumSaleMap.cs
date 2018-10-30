using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Models;

namespace Shop.Data.Mappings
{
    public class SumSaleMap : IEntityTypeConfiguration<SumSale>
    {
        public void Configure(EntityTypeBuilder<SumSale> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}

using eShopSolution.Data.Entities.Shop;
using eShopSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Caterogy>
    {
        public void Configure(EntityTypeBuilder<Caterogy> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}

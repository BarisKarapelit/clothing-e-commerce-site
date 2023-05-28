using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Base.Model;

namespace WebApplication.Data.Domain;

public class Price : BaseModel
{
    public double NetPrice { get; set; }
    public double Discount { get; set; }
    public bool IsValid { get; set; }
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }
}
public class PriceConfiguration : IEntityTypeConfiguration<Price>
{
    public void Configure(EntityTypeBuilder<Price> builder)
    {
        builder.Property(x => x.Id).IsRequired(true).UseIdentityColumn();
        builder.Property(x => x.CreatedAt).IsRequired(false);
        builder.Property(x => x.CreatedBy).IsRequired(false).HasMaxLength(30);
        builder.Property(x => x.UpdatedAt).IsRequired(false);
        builder.Property(x => x.UpdatedBy).IsRequired(false).HasMaxLength(30);
        builder.Property(x => x.NetPrice).IsRequired(true);
        builder.Property(x => x.Discount).IsRequired(false);
        builder.Property(x => x.IsValid).IsRequired(true).HasDefaultValue(true);
              
    }
}

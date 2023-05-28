using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Base.Model;

namespace WebApplication.Data.Domain;

public class Basket : BaseModel
{

    public string UserId { get; set; }
    public double Total { get; set; }
    public bool IsValid { get; set; }
    public virtual User User { get; set; }
    public virtual List<Order> Orders { get; set; }

}
public class BasketConfiguration : IEntityTypeConfiguration<Basket>
{
    public void Configure(EntityTypeBuilder<Basket> builder)
    {
        builder.Property(x => x.Id).IsRequired(true).UseIdentityColumn();
        builder.Property(x => x.CreatedAt).IsRequired(false);
        builder.Property(x => x.CreatedBy).IsRequired(false).HasMaxLength(30);
        builder.Property(x => x.UpdatedAt).IsRequired(false);
        builder.Property(x => x.UpdatedBy).IsRequired(false).HasMaxLength(30);
        builder.Property(x => x.Total).IsRequired(true);
        builder.Property(x => x.IsValid).IsRequired(true).HasDefaultValue(true);
        builder.HasMany(c => c.Orders)
                  .WithOne(p => p.Basket)
                  .HasForeignKey(p => p.BasketId)
                  .OnDelete(DeleteBehavior.Cascade);
    }
}
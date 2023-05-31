using WebApplication.Base.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication.Base;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication.Base.Model;
using WebApplication.Data.Domain;

namespace WebApplication.Data.Domain;

public class Order : BaseModel
{
    public int BasketId { get; set; }
    public int UserID { get; set; }
    public int ProductId { get; set; }
    public int Amount { get; set; }
    public bool IsValid { get; set; }

    public virtual Basket Basket { get; set; }
    public virtual User User { get; set; }
    public virtual Product Product { get; set; }


}
public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.Property(x => x.Id).IsRequired(true).UseIdentityColumn();
        builder.Property(x => x.CreatedAt).IsRequired(false);
        builder.Property(x => x.CreatedBy).IsRequired(false).HasMaxLength(30);
        builder.Property(x => x.UpdatedAt).IsRequired(false);
        builder.Property(x => x.UpdatedBy).IsRequired(false).HasMaxLength(30);
        builder.Property(x => x.IsValid).IsRequired(true).HasDefaultValue(true);

    }
}


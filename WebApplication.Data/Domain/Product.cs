using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication.Base;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication.Base.Model;
using WebApplication.Data.Domain;

namespace WebApplication.Data;


[Table("Product", Schema = "dbo")]
public class Product : BaseModel
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public int PriceId { get; set; }
    public bool IsValid { get; set; }
    public string Description { get; set; }
    public int ProductStock { get; set; }

    public virtual Price Price { get; set; }
    public virtual Category Category { get; set; }

}

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(x => x.Id).IsRequired(true).UseIdentityColumn();
        builder.Property(x => x.CreatedAt).IsRequired(false);
        builder.Property(x => x.CreatedBy).IsRequired(false).HasMaxLength(30);
        builder.Property(x => x.UpdatedAt).IsRequired(false);
        builder.Property(x => x.UpdatedBy).IsRequired(false).HasMaxLength(30);
        builder.Property(x => x.Description).IsRequired(false).HasMaxLength(200);
        builder.Property(x => x.ProductStock).IsRequired(true);
        builder.Property(x => x.Price).IsRequired(true);

        builder.Property(x => x.Name).IsRequired(true).HasMaxLength(50);
        builder.Property(x => x.CategoryId).IsRequired(true);
        builder.Property(x => x.IsValid).IsRequired(true).HasDefaultValue(true);

        builder.HasOne(p => p.Category) // Her bir Product'ın bir Category'si olmasını sağlar.
            .WithMany(c => c.Products) // Her bir Category'nin birden çok Product'a sahip olmasını sağlar.
            .HasForeignKey(p => p.CategoryId) // Product sınıfındaki CategoryId alanını foreign key olarak belirler.
            .OnDelete(DeleteBehavior.Cascade); // Eğer bir Category silinirse, ilgili Product'lar da silinir.

    }
}
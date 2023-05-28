using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using WebApplication.Base.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication.Base;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication.Data.Domain;


namespace WebApplication.Data.Domain;

public class Category:BaseModel
{
    public string Name { get; set; }
    public bool IsValid { get; set; }
    public virtual List<Product> Products { get; set; }


}
public class CategoryConfiguration : IEntityTypeConfiguration<Category> 
{
   public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(x=>x.Id).IsRequired(true).UseIdentityColumn();
        builder.Property(x => x.CreatedAt).IsRequired(false);
        builder.Property(x => x.CreatedBy).IsRequired(false).HasMaxLength(30);
        builder.Property(x => x.UpdatedAt).IsRequired(false);
        builder.Property(x => x.UpdatedBy).IsRequired(false).HasMaxLength(30);

        builder.Property(x => x.Name).IsRequired(true).HasMaxLength(30);
        builder.Property(x => x.IsValid).IsRequired(true).HasDefaultValue(true);


        builder.HasIndex(x => x.Name).IsUnique(true);

        builder.HasMany(c => c.Products) 
                  .WithOne(p => p.Category) 
                  .HasForeignKey(p => p.CategoryId) 
                  .OnDelete(DeleteBehavior.Cascade); 
    }
}
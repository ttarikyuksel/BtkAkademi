using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasKey(p => p.Id);
            builder.Property(P => P.ProductName).IsRequired();
            builder.Property(P => P.Price).IsRequired();

            builder.HasData(
                new Product() { Id = 1, CategoryId = 2, ProductName = "Computer", Price = 17_000 },
                new Product() { Id = 2, CategoryId = 2, ProductName = "Keyboard", Price = 1_000 },
                new Product() { Id = 3, CategoryId = 2, ProductName = "Mouse", Price = 500 },
                new Product() { Id = 4, CategoryId = 2, ProductName = "Monitor", Price = 7_000 },
                new Product() { Id = 5, CategoryId = 2, ProductName = "Deck", Price = 1_500 },
                new Product() { Id = 6, CategoryId = 1, ProductName = "History", Price = 25 },
                new Product() { Id = 7, CategoryId = 1, ProductName = "Hamlet", Price = 45 }
                );
        }
    }
}

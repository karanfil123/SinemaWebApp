using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sinemam.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemam.Repository.Configurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.Property(x => x.Name).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(500);

            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Aksiyon",
                    Description = "Aksiyon kategorisi deneme açıklaması",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsActive = true,
                    IsDelete = false
                },
                new Category
                {
                    Id = 2,
                    Name = "Macera",
                    Description = "Macera kategorisi deneme açıklaması",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsActive = true,
                    IsDelete = false
                },
                new Category
                {
                    Id = 3,
                    Name = "Gerilim",
                    Description = "Aksiyon kategorisi deneme açıklaması",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsActive = true,
                    IsDelete = false
                },
                new Category
                {
                    Id = 4,
                    Name = "Yerli Dizi",
                    Description = "Yerli Dizi kategorisi deneme açıklaması",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsActive = true,
                    IsDelete = false
                },
                new Category
                {
                    Id = 5,
                    Name = "Yabancı Dizi",
                    Description = "Yabancı Dizi kategorisi deneme açıklaması",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsActive = true,
                    IsDelete = false
                });
        }
    }
}

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
    public class ShowConfig : IEntityTypeConfiguration<Show>
    {
        public void Configure(EntityTypeBuilder<Show> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);            
            builder.Property(x => x.Name).HasMaxLength(300).IsRequired();
            builder.Property(x => x.Director).HasMaxLength(100).IsRequired();
            builder.Property(x => x.ImageUrl).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Country).HasMaxLength(100).IsRequired();
            builder.HasOne(x => x.Category).WithMany(x => x.Shows).HasForeignKey(x => x.CategoryId);

            builder.HasData(new Show
            {
                Id = 1,
                CategoryId=1,
                Name="John Wick",
                Director= "Chad Stahelski",
                Description= "John Wick, emekliye ayrılmış bir tetikçidir. Emekliliğinin tadını çıkarırken karısının yakalandığı amansız hastalıkla hayatı altüst olur. Karısından kendisine kalan en değerli varlığı ve can yoldaşı köpeğidir. Ancak evine dalan üç gangster onu da öldürür.",
                ImageUrl= "https://tr.web.img2.acsta.net/pictures/14/10/14/15/30/266211.jpg",
                Imdb=8.5,
                MinuteSize= 90,
                Year= 2014,
                Country="ABD",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                IsActive = true,
                IsDelete = false

            });

        }
    }
}

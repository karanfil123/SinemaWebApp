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
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.Property(x => x.Subject).HasMaxLength(350).IsRequired();
            builder.Property(x => x.Content).HasMaxLength(2500).IsRequired();
            builder.HasOne(x => x.Show).WithMany(x => x.Comments).HasForeignKey(x => x.ShowId);
            builder.HasOne(x => x.User).WithMany(x => x.Comments).HasForeignKey(x => x.UserId);

            builder.HasData(new Comment
            {
                Id = 1,
                Subject = "John Wick Filmi Hakkında",
                Content = "John Wick Filmi Hakkında test yorumu",
                UserId = 1,
                ShowId = 1
            });

        }
    }
}

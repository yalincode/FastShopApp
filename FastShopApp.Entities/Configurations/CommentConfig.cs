using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShopApp.Entities.Configurations
{
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CommentTitle).IsRequired().HasMaxLength(100);
            builder.Property(x => x.CommentContent).IsRequired().HasMaxLength(350);
            builder.Property(x => x.CommentUserName).IsRequired().HasMaxLength(150);
            builder.Property(x => x.UserId).IsRequired();
        }
    }
}

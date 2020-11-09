using InfinityMeshTest.Dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshTest.Dal.Configuration
{
    public class BlogConfiguration : BaseEntityConfiguration<Blog>
    {
        public override void Configure(EntityTypeBuilder<Blog> builder)
        {
            base.Configure(builder);

            builder.HasData(new Blog[]
            {
                new Blog
                {
                    Id =1,
                    UserId=1,
                    Title = "This is title",
                    Content = "This is content",
                    Summary = "This is summary",
                    CreatedAt = new DateTime(2020, 11, 09, 11, 36, 00, DateTimeKind.Utc),
                    PublishedDateTime = new DateTime(2020, 11, 09, 11, 37, 00, DateTimeKind.Utc),
                }
            });


        }
    }
}

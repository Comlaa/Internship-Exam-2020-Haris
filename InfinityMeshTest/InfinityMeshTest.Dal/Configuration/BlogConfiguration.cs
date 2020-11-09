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

            
        }
    }
}

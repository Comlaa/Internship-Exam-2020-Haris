using InfinityMeshTest.Dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshTest.Dal.Configuration
{
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.HasMany(p => p.Blogs)
                   .WithOne(p => p.User)
                   .HasForeignKey(p => p.UserId);

            builder.HasData(new User[]
            {

                new User
                {
                    Id = 1,
                    Name="Haris Mlaco",
                    Birthdate = new DateTime(1999, 10, 27),
                    Age = 21,
                    CreatedAt = new DateTime(2020, 11, 9, 10, 42, 00, DateTimeKind.Utc),
                    Email = "haris.mlaco@edu.fit.ba",
                    ViewProfile = "https://localhost:44357/api/user/getUserById?userId=1",
                },

                new User
                {
                    Id = 2,
                    Name="Admir Mujkic",
                    Birthdate = new DateTime(1989, 10, 27),
                    Age = 31,
                    CreatedAt = new DateTime(2020, 11, 9, 10, 42, 00, DateTimeKind.Utc),
                    Email = "admirmujkic@infinitymesh.com",
                    ViewProfile = "https://localhost:44357/api/user/getUserById?userId=2",
                },
                new User
                {
                    Id = 3,
                    Name="John Doe",
                    Birthdate = new DateTime(1999, 08, 22),
                    Age = 21,
                    CreatedAt = new DateTime(2020, 11, 9, 10, 43, 00, DateTimeKind.Utc),
                    Email = "johndoe@doeCompany.com",
                    ViewProfile = "https://localhost:44357/api/user/getUserById?userId=3",
                }
            });


        }
    }
}

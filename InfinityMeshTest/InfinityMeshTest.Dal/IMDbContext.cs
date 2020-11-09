using InfinityMeshTest.Dal.Configuration;
using InfinityMeshTest.Dal.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace InfinityMeshTest.Dal
{
    public class IMDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public IMDbContext(DbContextOptions<IMDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
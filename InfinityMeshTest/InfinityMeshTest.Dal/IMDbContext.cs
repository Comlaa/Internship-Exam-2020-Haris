using InfinityMeshTest.Dal.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace InfinityMeshTest.Dal
{
    public class IMDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public IMDbContext(DbContextOptions<IMDbContext> options) : base(options) { }

    }
}
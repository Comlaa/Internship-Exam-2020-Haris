using InfinityMeshTest.Dal.Domain;
using InfinityMeshTest.Dal.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InfinityMeshTest.Dal.Repository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly IMDbContext Context;
        public BlogRepository(IMDbContext context)
        {
            Context = context;
        }
        public async Task<BlogDto> AddBlog(Blog blog, CancellationToken cancellationToken = default)
        {
            Context.Blogs.Add(blog);
            await Context.SaveChangesAsync(cancellationToken);

            return new BlogDto(blog);
        }

        public Blog GetBlogById(int blogId)
        {
            return Context.Blogs.Find(blogId);
        }

        public async Task<List<Blog>> GetTopTen(CancellationToken cancellationToken = default)
        {
            int Number = 10;

            return await Context.Blogs.Take(Number).OrderBy(x => x.PublishedDateTime).ToListAsync(cancellationToken);
        }

        public async Task<List<Blog>> GetUserBlogs(int userId, CancellationToken cancellationToken = default)
        {
            int Number = 10;

            return await Context.Blogs.Take(Number).Where(x => x.UserId == userId).OrderBy(x => x.PublishedDateTime).ToListAsync(cancellationToken);
        }
    }
}

using InfinityMeshTest.Dal.Domain;
using InfinityMeshTest.Dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InfinityMeshTest.Dal.Repository
{
    public interface IBlogRepository
    {
        Task<BlogDto> AddBlog(Blog blog, CancellationToken cancellationToken = default);
        Task<List<Blog>> GetTopTen(CancellationToken cancellationToken = default);
        Blog GetBlogById(int blogId);
    }
}

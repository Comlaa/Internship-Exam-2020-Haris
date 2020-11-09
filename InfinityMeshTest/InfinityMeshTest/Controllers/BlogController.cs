using InfinityMeshTest.Dal.Domain;
using InfinityMeshTest.Dal.Repository;
using InfinityMeshTest.Dal.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityMeshTest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BlogController : Controller
    {
        private IBlogRepository _BlogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _BlogRepository = blogRepository;
        }

        [HttpGet]
        public async Task<List<BlogDto>> GetBlogs()
        {
            var Collection = await _BlogRepository.GetTopTen();

            return new List<BlogDto>(Collection.Select(blog => new BlogDto(blog)));
        }

        [HttpGet]
        public async Task<List<UserBlogDto>> GetUserBlogs(int userId)
        {
            var Collection = await _BlogRepository.GetUserBlogs(userId);

            return new List<UserBlogDto>(Collection.Select(blog => new UserBlogDto(blog)));
        }

        [HttpGet]
        public BlogDto GetBlogById(int blogId)
        {
            return new BlogDto(_BlogRepository.GetBlogById(blogId));
        }

        [HttpPost]
        public async Task<BlogDto> AddBlog([FromBody] AddBlogDto blog)
        {
            if (!ModelState.IsValid)
            {
                Debug.WriteLine("Validation exception!");
            }

            var BlogDomain = new Blog
            {
                Title = blog.Title,
                Content = blog.Content,
                Summary = blog.Summary,
                PublishedDateTime = DateTime.Parse(blog.PublishedDateTime.ToString()),
                UserId = blog.UserId,
            };

            await _BlogRepository.AddBlog(BlogDomain);

            return new BlogDto(BlogDomain);
        }
    }
}

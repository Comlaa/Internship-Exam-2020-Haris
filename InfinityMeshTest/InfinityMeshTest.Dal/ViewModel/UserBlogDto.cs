using InfinityMeshTest.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshTest.Dal.ViewModel
{
    public class UserBlogDto
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string PublishedDateTime { get; set; }

        public UserBlogDto()
        {

        }
        public UserBlogDto(Blog blog)
        {
            Title = blog.Title;
            Summary = blog.Summary;
            PublishedDateTime = blog.PublishedDateTime.ToString("hh: mm, dd MMM yyyy");
        }
    }
}

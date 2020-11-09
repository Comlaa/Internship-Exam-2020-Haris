using InfinityMeshTest.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshTest.Dal.ViewModel
{
    public class BlogDto
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public string PublishedDateTime { get; set; }

        public BlogDto()
        {

        }
        public BlogDto(Blog blog)
        {
            Title = blog.Title;
            Summary = blog.Summary;
            Content = blog.Content;
            PublishedDateTime = blog.PublishedDateTime.ToString("hh: mm, dd MMM yyyy");
            UserId = blog.UserId;
        }
    }
}

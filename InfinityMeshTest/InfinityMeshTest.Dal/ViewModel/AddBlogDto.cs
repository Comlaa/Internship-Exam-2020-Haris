using InfinityMeshTest.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshTest.Dal.ViewModel
{
    public class AddBlogDto
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public DateTime PublishedDateTime { get; set; }

        public AddBlogDto()
        {

        }
        public AddBlogDto(Blog blog)
        {
            Title = blog.Title;
            Summary = blog.Summary;
            Content = blog.Content;
            PublishedDateTime = blog.PublishedDateTime;
            UserId = blog.UserId;
        }
    }
}

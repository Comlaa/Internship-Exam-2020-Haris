using FluentValidation;
using InfinityMeshTest.Dal.Domain;
using InfinityMeshTest.Dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshTest.Dal.Validation
{
    public class BlogValidation : AbstractValidator<AddBlogDto>
    {
        public BlogValidation()
        {
            RuleFor(blog => blog.Title).Length(1, 64).NotEmpty().WithMessage("Title is required and its maximum length is 64 characters");
            RuleFor(blog => blog.Summary).Length(1, 350).NotEmpty().WithMessage("Summary is required and its maximum length is 350 characters");
            RuleFor(blog => blog.Content).Length(1, 3500).NotEmpty().WithMessage("Content is required and its maximum length is 3500 characters");
            //RuleFor(blog => blog.PublishedDateTime).NotEmpty().GreaterThan(DateTime.Now).WithMessage("Date is required and can't be in the past!");
        }
    }
}

using InfinityMeshTest.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshTest.Dal.ViewModel
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Blog> Blogs { get; set; }
        public User ViewProfile { get; set; }

        public UserDto() { }

        public UserDto(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Age = user.Age;
            Blogs = user.Blogs;
            ViewProfile = user.ViewProfile;
        }
    }
}

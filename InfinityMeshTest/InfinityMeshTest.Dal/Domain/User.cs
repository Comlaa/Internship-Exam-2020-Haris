using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshTest.Dal.Domain
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public List<Blog> Blogs { get; set; }
        public string ViewProfile { get; set; }

        public User()
        {

        }
        public User(User user)
        {
            Name = user.Name;
            Birthdate = user.Birthdate;
            Age = (int.Parse(DateTime.UtcNow.ToString("yyyyMMdd")) - int.Parse(user.Birthdate.ToString("yyyyMMdd"))) / 10000;
            ViewProfile = "https://localhost:44357/api/user/getUserById?userId="+user.Id;
        }
    }
}

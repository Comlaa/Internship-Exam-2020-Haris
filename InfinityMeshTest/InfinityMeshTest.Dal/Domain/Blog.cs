using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshTest.Dal.Domain
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public DateTime PublishedDateTime { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

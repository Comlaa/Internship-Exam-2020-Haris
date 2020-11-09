using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshTest.Dal.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        protected BaseEntity()
        {
            CreatedAt = DateTime.Now;
        }
    }
}

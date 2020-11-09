﻿using InfinityMeshTest.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshTest.Dal.ViewModel
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public UserDto() { }

        public UserDto(User user)
        {
            Id = user.Id;
            Name = user.Name;
        }
    }
}

using FluentValidation;
using InfinityMeshTest.Dal.Domain;
using InfinityMeshTest.Dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshTest.Dal.Validation
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
        {
            RuleFor(user => user.Name).Length(3, 50);
        }
    }
}

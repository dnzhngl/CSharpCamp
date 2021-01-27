using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Services.Abstract
{
    interface IUserValidationService
    {
        bool Validate(User user);
    }
}

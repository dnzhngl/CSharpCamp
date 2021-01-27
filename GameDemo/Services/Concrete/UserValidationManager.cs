using GameDemo.Entities;
using GameDemo.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Services.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.FirstName == "Salih" && user.LastName == "Sağsalim" && user.IdentityNo == "11111111111" && user.DOB == new DateTime(01 / 01 / 199))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.Date=="1990"&& user.FirstName == "Deniz")
            {
                return true;
            }
            return false;
        }
    }
}

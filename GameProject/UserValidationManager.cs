using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validation(User user)
        {
            if (user.DateOfBrith==1999&&user.FisrtName=="HÜSEYİN"&&user.LastName=="PALAMAR"&&user.Id==1)
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

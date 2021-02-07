using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class AdminValidationManager : IAdminValidationServices
    {
        public bool AdminValidation(User user)
        {
            if (user.DateOfBrith == 1999 && user.FisrtName == "HÜSEYİN" && user.LastName == "PALAMAR" && user.Id == 1&& user.IdentificationNumber==123456)
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

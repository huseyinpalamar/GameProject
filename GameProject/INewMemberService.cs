using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface INewMemberService
    {
        void NewRegistration(User user);
        void ProfilUpdate(User user);
        void ProfilDelete(User user);
    }
}

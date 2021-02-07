using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface INewAdminServices
    {
        void NewRegistration(User user);
        void ProfilUpdate(User user);
        void ProfilDelete(User user);
        void AddMember(User user);
        void DeleteMember(User user);


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class AdminManager : INewAdminServices
    {
        IAdminValidationServices _adminValidationServices;

        public AdminManager(IAdminValidationServices adminValidationServices)
        {
            _adminValidationServices = adminValidationServices;
        }

        public void AddMember(User user)
        {
            Console.WriteLine("Üye Eklendi"+user.FisrtName);
        }

        public void DeleteMember(User user)
        {
            Console.WriteLine("Üye Silindi");

        }

        public void NewRegistration(User user)
        {
            if (_adminValidationServices.AdminValidation(user) == true)
            {
                Console.WriteLine("ADmin Kaydı olundu"+":"+user.FisrtName);
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız Kayıt yapılamadı");
            }

        }

        public void ProfilDelete(User user)
        {
            Console.WriteLine("Profil Güncellendi");

        }

        public void ProfilUpdate(User user)
        {
            Console.WriteLine("Prifil Silindi");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : INewMemberService
    {
        IUserValidationService _validationService;

        public GamerManager(IUserValidationService validationService)
        {
            _validationService = validationService;
        }

        public void NewRegistration(User user)
        {
            if (_validationService.Validation(user)==true)
            {
                Console.WriteLine("Kayıt olundu"+":"+user.FisrtName);
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız Kayıt yapılamadı");
            }
        }

        public void ProfilDelete(User user)
        {
            Console.WriteLine("profil güncellendi  ");
        }

        public void ProfilUpdate(User   user)
        {
            Console.WriteLine("Profil Silindi");
        }
    }
}

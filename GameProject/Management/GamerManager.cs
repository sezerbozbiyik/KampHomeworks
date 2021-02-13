using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager()
        {
        }

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("silindi.");
        }

        public void Insert(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Doğrulama Başarılı kayıt olundu.");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız kayıt gerçekleşmedi!!");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("güncellendi.");
        }
    }
}

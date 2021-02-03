using GameBase.Abstract;
using GameBase.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBase.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserControlService _userControlService;

        public GamerManager(IUserControlService userControlService)
        {
            _userControlService = userControlService;

        }
        public void Add(Gamer gamer)
        {
            if (_userControlService.Control(gamer)==true)
            {
                Console.WriteLine("Merhaba"+ gamer.FirstName+ " " + gamer.LastName+ ", Seni Görmek Harika İyi Eğlenceler ");

            }
            else
            {
                Console.WriteLine("Bilgilerinizde hata olduğu için kayıt başarısız oldu. ");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Sayın "+ gamer.FirstName+ " "+ gamer.LastName+ " "+ "Kaydınız Silinmiştir." );
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Sayın " + gamer.FirstName + " " + gamer.LastName + " " + "Kaydınız başarıyla Güncellenmiştir.");
        }
    }
}

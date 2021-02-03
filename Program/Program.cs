using GameBase.Concrete;
using GameBase.Entities;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            GamerManager gamerManager = new GamerManager(new UserControlManager());


            gamerManager.Add(new Gamer
            {
                GamerId = 1,
                FirstName = "Çağrı",
                LastName = "Kibar",
                IdentityNumber = "123456789"
            }) ;
            gamerManager.Update(new Gamer
            {
                GamerId = 1,
                FirstName = "Çağrı",
                LastName = "Kibar",
                IdentityNumber = "123456789"
            });
            gamerManager.Delete(new Gamer
            {
                GamerId = 1,
                FirstName = "Çağrı",
                LastName = "Kibar",
                IdentityNumber = "123456789"
            });

            gameManager.GameBuy(new Gamer
            {

                GamerId = 1,
                FirstName = "Çağrı",
                LastName = "Kibar",
                IdentityNumber = "123456789"


            }, new Game
            {
                GameId = 1,
                GameName = "Battlefield 4",
                GamePrice = 150
            }, new Campaign
            {
                CampaignId = 1,
                CampaignName = "%50 İndirim",
                Description="Promo kodu sayesinde indirim kazanırsınız"}) ;
           




        }
    }
}

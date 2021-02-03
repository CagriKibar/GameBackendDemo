using GameBase.Abstract;
using GameBase.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBase.Concrete
{
    public class GameManager : IGameService
    {
        public void GameBuy(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("Sayın"+ gamer.FirstName + " "+ gamer.LastName + " "+ game.GameName+
                " Adlı Oyun Alınmıştır"+ " Fiyat Bilgileri: " +game.GamePrice);
        }

        public void GameBuy(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Sayın" + gamer.FirstName + " " + gamer.LastName + " " + game.GameName +
                " Adlı Oyun Alınmıştır" + " Fiyat Bilgileri: " + game.GamePrice);
        }
    }
}

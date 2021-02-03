using GameBase.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBase.Abstract
{
  public  interface IGameService
    {
         void GameBuy(Game game, Gamer gamer, Campaign campaign );

    }
}

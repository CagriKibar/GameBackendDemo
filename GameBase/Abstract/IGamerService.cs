using GameBase.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBase.Abstract
{
  public  interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);

    }
}

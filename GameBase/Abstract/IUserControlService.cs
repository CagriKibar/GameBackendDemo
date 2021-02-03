using GameBase.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBase.Abstract
{
     public interface IUserControlService
    {
        bool Control(Gamer gamer);
    }
}

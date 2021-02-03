using GameBase.Abstract;
using GameBase.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBase.Concrete
{
    public class UserControlManager : IUserControlService
    {
        public bool Control(Gamer gamer)
        {
            if (gamer.BirthYear==1998 && gamer.FirstName=="Çağrı"&& gamer.LastName=="Kibar"&&
                gamer.IdentityNumber=="123456789")
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
